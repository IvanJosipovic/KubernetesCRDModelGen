using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestinationServiceAccounts
{
    /// <summary>Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account whose name is in the list.</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>Selector is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account that matches the given label selector. If both Names and Selector are specified then they are AND'ed.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestinationServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace of the given Service. If left empty, the rule will match within this policy's namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Destination contains the match criteria that apply to destination entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestination
{
    /// <summary>NamespaceSelector is an optional field that contains a selector expression. Only traffic that originates from (or terminates at) endpoints within the selected namespaces will be matched. When both NamespaceSelector and another selector are defined on the same rule, then only workload endpoints that are matched by both selectors will be selected by the rule.   For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting only workload endpoints in the same namespace as the NetworkPolicy.   For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting only GlobalNetworkSet or HostEndpoint.   For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload endpoints across all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>Nets is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) IP addresses in any of the given subnets.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>NotPorts is the negated version of the Ports field. Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary>NotSelector is the negated version of the Selector field.  See Selector field for subtleties with negated selectors.</summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>Ports is an optional field that restricts the rule to only apply to traffic that has a source (destination) port that matches one of these ranges/values. This value is a list of integers or strings that represent ranges of ports.   Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary>Selector is an optional field that contains a selector expression (see Policy for sample syntax).  Only traffic that originates from (terminates at) endpoints matching the selector will be matched.   Note that: in addition to the negated version of the Selector (see NotSelector below), the selector expression syntax itself supports negation.  The two types of negation are subtly different. One negates the set of matched endpoints, the other negates the whole match:   	Selector = "!has(my_label)" matches packets that are from other Calico-controlled 	endpoints that do not have the label "my_label".   	NotSelector = "has(my_label)" matches packets that are not from Calico-controlled 	endpoints that do have the label "my_label".   The effect is that the latter will accept packets from non-Calico sources whereas the former is limited to packets from Calico-controlled endpoints.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

/// <summary>HTTPPath specifies an HTTP path to match. It may be either of the form: exact: &lt;path&gt;: which matches the path exactly or prefix: &lt;path-prefix&gt;: which matches the path prefix</summary>
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

/// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressHttp
{
    /// <summary>Methods is an optional field that restricts the rule to apply only to HTTP requests that use one of the listed HTTP Methods (e.g. GET, PUT, etc.) Multiple methods are OR'd together.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Paths is an optional field that restricts the rule to apply to HTTP requests that use one of the listed HTTP Paths. Multiple paths are OR'd together. e.g: - exact: /foo - prefix: /bar NOTE: Each entry may ONLY specify either a `exact` or a `prefix` match. The validator will check for it.</summary>
    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

/// <summary>ICMP is an optional field that restricts the rule to apply to a specific type and code of ICMP traffic.  This should only be specified if the Protocol field is set to "ICMP" or "ICMPv6".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressIcmp
{
    /// <summary>Match on a specific ICMP code.  If specified, the Type value must also be specified. This is a technical limitation imposed by the kernel's iptables firewall, which Calico uses to enforce the rule.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request (i.e. pings).</summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>Metadata contains additional information for this rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressMetadata
{
    /// <summary>Annotations is a set of key value pairs that give extra information about the rule</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>NotICMP is the negated version of the ICMP field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressNotICMP
{
    /// <summary>Match on a specific ICMP code.  If specified, the Type value must also be specified. This is a technical limitation imposed by the kernel's iptables firewall, which Calico uses to enforce the rule.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request (i.e. pings).</summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSourceServiceAccounts
{
    /// <summary>Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account whose name is in the list.</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>Selector is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account that matches the given label selector. If both Names and Selector are specified then they are AND'ed.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSourceServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace of the given Service. If left empty, the rule will match within this policy's namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Source contains the match criteria that apply to source entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSource
{
    /// <summary>NamespaceSelector is an optional field that contains a selector expression. Only traffic that originates from (or terminates at) endpoints within the selected namespaces will be matched. When both NamespaceSelector and another selector are defined on the same rule, then only workload endpoints that are matched by both selectors will be selected by the rule.   For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting only workload endpoints in the same namespace as the NetworkPolicy.   For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting only GlobalNetworkSet or HostEndpoint.   For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload endpoints across all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>Nets is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) IP addresses in any of the given subnets.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>NotPorts is the negated version of the Ports field. Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary>NotSelector is the negated version of the Selector field.  See Selector field for subtleties with negated selectors.</summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>Ports is an optional field that restricts the rule to only apply to traffic that has a source (destination) port that matches one of these ranges/values. This value is a list of integers or strings that represent ranges of ports.   Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary>Selector is an optional field that contains a selector expression (see Policy for sample syntax).  Only traffic that originates from (terminates at) endpoints matching the selector will be matched.   Note that: in addition to the negated version of the Selector (see NotSelector below), the selector expression syntax itself supports negation.  The two types of negation are subtly different. One negates the set of matched endpoints, the other negates the whole match:   	Selector = "!has(my_label)" matches packets that are from other Calico-controlled 	endpoints that do not have the label "my_label".   	NotSelector = "has(my_label)" matches packets that are not from Calico-controlled 	endpoints that do have the label "my_label".   The effect is that the latter will accept packets from non-Calico sources whereas the former is limited to packets from Calico-controlled endpoints.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressSourceServices? Services { get; set; }
}

/// <summary>A Rule encapsulates a set of match criteria and an action.  Both selector-based security Policy and security Profiles reference rules - separated out as a list of rules for both ingress and egress packet matching.   Each positive match criteria has a negated version, prefixed with "Not". All the match criteria within a rule must be satisfied for a packet to match. A single rule can contain the positive and negative version of a match and both must be satisfied for the rule to match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>Destination contains the match criteria that apply to destination entity.</summary>
    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
    [JsonPropertyName("http")]
    public V1NetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary>ICMP is an optional field that restricts the rule to apply to a specific type and code of ICMP traffic.  This should only be specified if the Protocol field is set to "ICMP" or "ICMPv6".</summary>
    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary>IPVersion is an optional field that restricts the rule to only match a specific IP version.</summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary>Metadata contains additional information for this rule</summary>
    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary>NotICMP is the negated version of the ICMP field.</summary>
    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary>NotProtocol is the negated version of the Protocol field.</summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary>Protocol is an optional field that restricts the rule to only apply to traffic of a specific IP protocol. Required if any of the EntityRules contain Ports (because ports only apply to certain protocols).   Must be one of these string values: "TCP", "UDP", "ICMP", "ICMPv6", "SCTP", "UDPLite" or an integer in the range 1-255.</summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary>Source contains the match criteria that apply to source entity.</summary>
    [JsonPropertyName("source")]
    public V1NetworkPolicySpecEgressSource? Source { get; set; }
}

/// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestinationServiceAccounts
{
    /// <summary>Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account whose name is in the list.</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>Selector is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account that matches the given label selector. If both Names and Selector are specified then they are AND'ed.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestinationServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace of the given Service. If left empty, the rule will match within this policy's namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Destination contains the match criteria that apply to destination entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestination
{
    /// <summary>NamespaceSelector is an optional field that contains a selector expression. Only traffic that originates from (or terminates at) endpoints within the selected namespaces will be matched. When both NamespaceSelector and another selector are defined on the same rule, then only workload endpoints that are matched by both selectors will be selected by the rule.   For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting only workload endpoints in the same namespace as the NetworkPolicy.   For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting only GlobalNetworkSet or HostEndpoint.   For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload endpoints across all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>Nets is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) IP addresses in any of the given subnets.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>NotPorts is the negated version of the Ports field. Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary>NotSelector is the negated version of the Selector field.  See Selector field for subtleties with negated selectors.</summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>Ports is an optional field that restricts the rule to only apply to traffic that has a source (destination) port that matches one of these ranges/values. This value is a list of integers or strings that represent ranges of ports.   Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary>Selector is an optional field that contains a selector expression (see Policy for sample syntax).  Only traffic that originates from (terminates at) endpoints matching the selector will be matched.   Note that: in addition to the negated version of the Selector (see NotSelector below), the selector expression syntax itself supports negation.  The two types of negation are subtly different. One negates the set of matched endpoints, the other negates the whole match:   	Selector = "!has(my_label)" matches packets that are from other Calico-controlled 	endpoints that do not have the label "my_label".   	NotSelector = "has(my_label)" matches packets that are not from Calico-controlled 	endpoints that do have the label "my_label".   The effect is that the latter will accept packets from non-Calico sources whereas the former is limited to packets from Calico-controlled endpoints.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

/// <summary>HTTPPath specifies an HTTP path to match. It may be either of the form: exact: &lt;path&gt;: which matches the path exactly or prefix: &lt;path-prefix&gt;: which matches the path prefix</summary>
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

/// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressHttp
{
    /// <summary>Methods is an optional field that restricts the rule to apply only to HTTP requests that use one of the listed HTTP Methods (e.g. GET, PUT, etc.) Multiple methods are OR'd together.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Paths is an optional field that restricts the rule to apply to HTTP requests that use one of the listed HTTP Paths. Multiple paths are OR'd together. e.g: - exact: /foo - prefix: /bar NOTE: Each entry may ONLY specify either a `exact` or a `prefix` match. The validator will check for it.</summary>
    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

/// <summary>ICMP is an optional field that restricts the rule to apply to a specific type and code of ICMP traffic.  This should only be specified if the Protocol field is set to "ICMP" or "ICMPv6".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressIcmp
{
    /// <summary>Match on a specific ICMP code.  If specified, the Type value must also be specified. This is a technical limitation imposed by the kernel's iptables firewall, which Calico uses to enforce the rule.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request (i.e. pings).</summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>Metadata contains additional information for this rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressMetadata
{
    /// <summary>Annotations is a set of key value pairs that give extra information about the rule</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>NotICMP is the negated version of the ICMP field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressNotICMP
{
    /// <summary>Match on a specific ICMP code.  If specified, the Type value must also be specified. This is a technical limitation imposed by the kernel's iptables firewall, which Calico uses to enforce the rule.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request (i.e. pings).</summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSourceServiceAccounts
{
    /// <summary>Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account whose name is in the list.</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>Selector is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a service account that matches the given label selector. If both Names and Selector are specified then they are AND'ed.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSourceServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace of the given Service. If left empty, the rule will match within this policy's namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Source contains the match criteria that apply to source entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSource
{
    /// <summary>NamespaceSelector is an optional field that contains a selector expression. Only traffic that originates from (or terminates at) endpoints within the selected namespaces will be matched. When both NamespaceSelector and another selector are defined on the same rule, then only workload endpoints that are matched by both selectors will be selected by the rule.   For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting only workload endpoints in the same namespace as the NetworkPolicy.   For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting only GlobalNetworkSet or HostEndpoint.   For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload endpoints across all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>Nets is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) IP addresses in any of the given subnets.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>NotPorts is the negated version of the Ports field. Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary>NotSelector is the negated version of the Selector field.  See Selector field for subtleties with negated selectors.</summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>Ports is an optional field that restricts the rule to only apply to traffic that has a source (destination) port that matches one of these ranges/values. This value is a list of integers or strings that represent ranges of ports.   Since only some protocols have ports, if any ports are specified it requires the Protocol match in the Rule to be set to "TCP" or "UDP".</summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary>Selector is an optional field that contains a selector expression (see Policy for sample syntax).  Only traffic that originates from (terminates at) endpoints matching the selector will be matched.   Note that: in addition to the negated version of the Selector (see NotSelector below), the selector expression syntax itself supports negation.  The two types of negation are subtly different. One negates the set of matched endpoints, the other negates the whole match:   	Selector = "!has(my_label)" matches packets that are from other Calico-controlled 	endpoints that do not have the label "my_label".   	NotSelector = "has(my_label)" matches packets that are not from Calico-controlled 	endpoints that do have the label "my_label".   The effect is that the latter will accept packets from non-Calico sources whereas the former is limited to packets from Calico-controlled endpoints.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or terminates at) a pod running as a matching service account.</summary>
    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>Services is an optional field that contains options for matching Kubernetes Services. If specified, only traffic that originates from or terminates at endpoints within the selected service(s) will be matched, and only to/from each endpoint's port.   Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets, NotNets or ServiceAccounts.   Ports and NotPorts can only be specified with Services on ingress rules.</summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressSourceServices? Services { get; set; }
}

/// <summary>A Rule encapsulates a set of match criteria and an action.  Both selector-based security Policy and security Profiles reference rules - separated out as a list of rules for both ingress and egress packet matching.   Each positive match criteria has a negated version, prefixed with "Not". All the match criteria within a rule must be satisfied for a packet to match. A single rule can contain the positive and negative version of a match and both must be satisfied for the rule to match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>Destination contains the match criteria that apply to destination entity.</summary>
    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
    [JsonPropertyName("http")]
    public V1NetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary>ICMP is an optional field that restricts the rule to apply to a specific type and code of ICMP traffic.  This should only be specified if the Protocol field is set to "ICMP" or "ICMPv6".</summary>
    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary>IPVersion is an optional field that restricts the rule to only match a specific IP version.</summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary>Metadata contains additional information for this rule</summary>
    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary>NotICMP is the negated version of the ICMP field.</summary>
    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary>NotProtocol is the negated version of the Protocol field.</summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary>Protocol is an optional field that restricts the rule to only apply to traffic of a specific IP protocol. Required if any of the EntityRules contain Ports (because ports only apply to certain protocols).   Must be one of these string values: "TCP", "UDP", "ICMP", "ICMPv6", "SCTP", "UDPLite" or an integer in the range 1-255.</summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary>Source contains the match criteria that apply to source entity.</summary>
    [JsonPropertyName("source")]
    public V1NetworkPolicySpecIngressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpec
{
    /// <summary>The ordered set of egress rules.  Each rule contains a set of packet match criteria and a corresponding action to apply.</summary>
    [JsonPropertyName("egress")]
    public IList<V1NetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary>The ordered set of ingress rules.  Each rule contains a set of packet match criteria and a corresponding action to apply.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1NetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary>Order is an optional field that specifies the order in which the policy is applied. Policies with higher "order" are applied after those with lower order within the same tier.  If the order is omitted, it may be considered to be "infinite" - i.e. the policy will be applied last.  Policies with identical order will be applied in alphanumerical order based on the Policy "Name" within the tier.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>PerformanceHints contains a list of hints to Calico's policy engine to help process the policy more efficiently.  Hints never change the enforcement behaviour of the policy.   Currently, the only available hint is "AssumeNeededOnEveryNode".  When that hint is set on a policy, Felix will act as if the policy matches a local endpoint even if it does not. This is useful for "preloading" any large static policies that are known to be used on every node. If the policy is _not_ used on a particular node then the work done to preload the policy (and to maintain it) is wasted.</summary>
    [JsonPropertyName("performanceHints")]
    public IList<string>? PerformanceHints { get; set; }

    /// <summary>The selector is an expression used to pick out the endpoints that the policy should be applied to.   Selector expressions follow this syntax:   	label == "string_literal"  -&gt;  comparison, e.g. my_label == "foo bar" 	label != "string_literal"   -&gt;  not equal; also matches if label is not present 	label in { "a", "b", "c", ... }  -&gt;  true if the value of label X is one of "a", "b", "c" 	label not in { "a", "b", "c", ... }  -&gt;  true if the value of label X is not one of "a", "b", "c" 	has(label_name)  -&gt; True if that label is present 	! expr -&gt; negation of expr 	expr &amp;&amp; expr  -&gt; Short-circuit and 	expr || expr  -&gt; Short-circuit or 	( expr ) -&gt; parens for grouping 	all() or the empty selector -&gt; matches all endpoints.   Label names are allowed to contain alphanumerics, -, _ and /. String literals are more permissive but they do not support escape characters.   Examples (with made-up labels):   	type == "webserver" &amp;&amp; deployment == "prod" 	type in {"frontend", "backend"} 	deployment != "dev" 	! has(label_name)</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccountSelector is an optional field for an expression used to select a pod based on service accounts.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    /// <summary>The name of the tier that this policy belongs to.  If this is omitted, the default tier (name is "default") is assumed.  The specified tier must exist in order to create security policies within the tier, the "default" tier is created automatically if it does not exist, this means for deployments requiring only a single Tier, the tier name may be omitted on all policy management requests.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Types indicates whether this policy applies to ingress, or to egress, or to both.  When not explicitly specified (and so the value on creation is empty or nil), Calico defaults Types according to what Ingress and Egress are present in the policy.  The default is:   - [ PolicyTypeIngress ], if there are no Egress rules (including the case where there are   also no Ingress rules)   - [ PolicyTypeEgress ], if there are Egress rules but no Ingress rules   - [ PolicyTypeIngress, PolicyTypeEgress ], if there are both Ingress and Egress rules.   When the policy is read back again, Types will always be one of these values, never empty or nil.</summary>
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