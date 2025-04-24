using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policy.networking.k8s.io;
/// <summary>Port selects a port on a pod(s) based on number.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressPortsPortNumber
{
    /// <summary>Number defines a network port value.   Support: Core</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Protocol is the network protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.   Support: Core</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary>PortRange selects a port range on a pod(s) based on provided start and end values.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressPortsPortRange
{
    /// <summary>End defines a network port that is the end of a port range, the End value must be greater than Start.   Support: Core</summary>
    [JsonPropertyName("end")]
    public int End { get; set; }

    /// <summary>Protocol is the network protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.   Support: Core</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Start defines a network port that is the start of a port range, the Start value must be less than End.   Support: Core</summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }
}

/// <summary>AdminNetworkPolicyPort describes how to select network ports on pod(s). Exactly one field must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressPorts
{
    /// <summary>NamedPort selects a port on a pod(s) based on name.   Support: Extended   &lt;network-policy-api:experimental&gt;</summary>
    [JsonPropertyName("namedPort")]
    public string? NamedPort { get; set; }

    /// <summary>Port selects a port on a pod(s) based on number.   Support: Core</summary>
    [JsonPropertyName("portNumber")]
    public V1alpha1AdminNetworkPolicySpecEgressPortsPortNumber? PortNumber { get; set; }

    /// <summary>PortRange selects a port range on a pod(s) based on provided start and end values.   Support: Core</summary>
    [JsonPropertyName("portRange")]
    public V1alpha1AdminNetworkPolicySpecEgressPortsPortRange? PortRange { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToNamespacesMatchExpressions
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

/// <summary>Namespaces defines a way to select all pods within a set of Namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressToNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToNodesMatchExpressions
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

/// <summary>Nodes defines a way to select a set of nodes in the cluster. This field follows standard label selector semantics; if present but empty, it selects all Nodes.   Support: Extended   &lt;network-policy-api:experimental&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToNodes
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressToNodesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToPodsNamespaceSelectorMatchExpressions
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

/// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressToPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToPodsPodSelectorMatchExpressions
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

/// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressToPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Pods defines a way to select a set of pods in a set of namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressToPods
{
    /// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AdminNetworkPolicySpecEgressToPodsNamespaceSelector NamespaceSelector { get; set; }

    /// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
    [JsonPropertyName("podSelector")]
    public V1alpha1AdminNetworkPolicySpecEgressToPodsPodSelector PodSelector { get; set; }
}

/// <summary>AdminNetworkPolicyEgressPeer defines a peer to allow traffic to. Exactly one of the selector pointers must be set for a given peer. If a consumer observes none of its fields are set, they must assume an unknown option has been specified and fail closed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgressTo
{
    /// <summary>Namespaces defines a way to select all pods within a set of Namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
    [JsonPropertyName("namespaces")]
    public V1alpha1AdminNetworkPolicySpecEgressToNamespaces? Namespaces { get; set; }

    /// <summary>Networks defines a way to select peers via CIDR blocks. This is intended for representing entities that live outside the cluster, which can't be selected by pods, namespaces and nodes peers, but note that cluster-internal traffic will be checked against the rule as well. So if you Allow or Deny traffic to `"0.0.0.0/0"`, that will allow or deny all IPv4 pod-to-pod traffic as well. If you don't want that, add a rule that Passes all pod traffic before the Networks rule.   Each item in Networks should be provided in the CIDR format and should be IPv4 or IPv6, for example "10.0.0.0/8" or "fd00::/8".   Networks can have upto 25 CIDRs specified.   Support: Extended   &lt;network-policy-api:experimental&gt;</summary>
    [JsonPropertyName("networks")]
    public IList<string>? Networks { get; set; }

    /// <summary>Nodes defines a way to select a set of nodes in the cluster. This field follows standard label selector semantics; if present but empty, it selects all Nodes.   Support: Extended   &lt;network-policy-api:experimental&gt;</summary>
    [JsonPropertyName("nodes")]
    public V1alpha1AdminNetworkPolicySpecEgressToNodes? Nodes { get; set; }

    /// <summary>Pods defines a way to select a set of pods in a set of namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
    [JsonPropertyName("pods")]
    public V1alpha1AdminNetworkPolicySpecEgressToPods? Pods { get; set; }
}

/// <summary>AdminNetworkPolicyEgressRule describes an action to take on a particular set of traffic originating from pods selected by a AdminNetworkPolicy's Subject field. &lt;network-policy-api:experimental:validation&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecEgress
{
    /// <summary>Action specifies the effect this rule will have on matching traffic. Currently the following actions are supported: Allow: allows the selected traffic (even if it would otherwise have been denied by NetworkPolicy) Deny: denies the selected traffic Pass: instructs the selected traffic to skip any remaining ANP rules, and then pass execution to any NetworkPolicies that select the pod. If the pod is not selected by any NetworkPolicies then execution is passed to any BaselineAdminNetworkPolicies that select the pod.   Support: Core</summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>Name is an identifier for this rule, that may be no more than 100 characters in length. This field should be used by the implementation to help improve observability, readability and error-reporting for any applied AdminNetworkPolicies.   Support: Core</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Ports allows for matching traffic based on port and protocols. This field is a list of destination ports for the outgoing egress traffic. If Ports is not set then the rule does not filter traffic via port.   Support: Core</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressPorts>? Ports { get; set; }

    /// <summary>To is the List of destinations whose traffic this rule applies to. If any AdminNetworkPolicyEgressPeer matches the destination of outgoing traffic then the specified action is applied. This field must be defined and contain at least one item.   Support: Core</summary>
    [JsonPropertyName("to")]
    public IList<V1alpha1AdminNetworkPolicySpecEgressTo> To { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromNamespacesMatchExpressions
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

/// <summary>Namespaces defines a way to select all pods within a set of Namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecIngressFromNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromPodsNamespaceSelectorMatchExpressions
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

/// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecIngressFromPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromPodsPodSelectorMatchExpressions
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

/// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecIngressFromPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Pods defines a way to select a set of pods in a set of namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFromPods
{
    /// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AdminNetworkPolicySpecIngressFromPodsNamespaceSelector NamespaceSelector { get; set; }

    /// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
    [JsonPropertyName("podSelector")]
    public V1alpha1AdminNetworkPolicySpecIngressFromPodsPodSelector PodSelector { get; set; }
}

/// <summary>AdminNetworkPolicyIngressPeer defines an in-cluster peer to allow traffic from. Exactly one of the selector pointers must be set for a given peer. If a consumer observes none of its fields are set, they must assume an unknown option has been specified and fail closed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressFrom
{
    /// <summary>Namespaces defines a way to select all pods within a set of Namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
    [JsonPropertyName("namespaces")]
    public V1alpha1AdminNetworkPolicySpecIngressFromNamespaces? Namespaces { get; set; }

    /// <summary>Pods defines a way to select a set of pods in a set of namespaces. Note that host-networked pods are not included in this type of peer.   Support: Core</summary>
    [JsonPropertyName("pods")]
    public V1alpha1AdminNetworkPolicySpecIngressFromPods? Pods { get; set; }
}

/// <summary>Port selects a port on a pod(s) based on number.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressPortsPortNumber
{
    /// <summary>Number defines a network port value.   Support: Core</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Protocol is the network protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.   Support: Core</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary>PortRange selects a port range on a pod(s) based on provided start and end values.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressPortsPortRange
{
    /// <summary>End defines a network port that is the end of a port range, the End value must be greater than Start.   Support: Core</summary>
    [JsonPropertyName("end")]
    public int End { get; set; }

    /// <summary>Protocol is the network protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.   Support: Core</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Start defines a network port that is the start of a port range, the Start value must be less than End.   Support: Core</summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }
}

/// <summary>AdminNetworkPolicyPort describes how to select network ports on pod(s). Exactly one field must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngressPorts
{
    /// <summary>NamedPort selects a port on a pod(s) based on name.   Support: Extended   &lt;network-policy-api:experimental&gt;</summary>
    [JsonPropertyName("namedPort")]
    public string? NamedPort { get; set; }

    /// <summary>Port selects a port on a pod(s) based on number.   Support: Core</summary>
    [JsonPropertyName("portNumber")]
    public V1alpha1AdminNetworkPolicySpecIngressPortsPortNumber? PortNumber { get; set; }

    /// <summary>PortRange selects a port range on a pod(s) based on provided start and end values.   Support: Core</summary>
    [JsonPropertyName("portRange")]
    public V1alpha1AdminNetworkPolicySpecIngressPortsPortRange? PortRange { get; set; }
}

/// <summary>AdminNetworkPolicyIngressRule describes an action to take on a particular set of traffic destined for pods selected by an AdminNetworkPolicy's Subject field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecIngress
{
    /// <summary>Action specifies the effect this rule will have on matching traffic. Currently the following actions are supported: Allow: allows the selected traffic (even if it would otherwise have been denied by NetworkPolicy) Deny: denies the selected traffic Pass: instructs the selected traffic to skip any remaining ANP rules, and then pass execution to any NetworkPolicies that select the pod. If the pod is not selected by any NetworkPolicies then execution is passed to any BaselineAdminNetworkPolicies that select the pod.   Support: Core</summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>From is the list of sources whose traffic this rule applies to. If any AdminNetworkPolicyIngressPeer matches the source of incoming traffic then the specified action is applied. This field must be defined and contain at least one item.   Support: Core</summary>
    [JsonPropertyName("from")]
    public IList<V1alpha1AdminNetworkPolicySpecIngressFrom> From { get; set; }

    /// <summary>Name is an identifier for this rule, that may be no more than 100 characters in length. This field should be used by the implementation to help improve observability, readability and error-reporting for any applied AdminNetworkPolicies.   Support: Core</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Ports allows for matching traffic based on port and protocols. This field is a list of ports which should be matched on the pods selected for this policy i.e the subject of the policy. So it matches on the destination port for the ingress traffic. If Ports is not set then the rule does not filter traffic via port.   Support: Core</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AdminNetworkPolicySpecIngressPorts>? Ports { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectNamespacesMatchExpressions
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

/// <summary>Namespaces is used to select pods via namespace selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecSubjectNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectPodsNamespaceSelectorMatchExpressions
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

/// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecSubjectPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectPodsPodSelectorMatchExpressions
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

/// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AdminNetworkPolicySpecSubjectPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Pods is used to select pods via namespace AND pod selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubjectPods
{
    /// <summary>NamespaceSelector follows standard label selector semantics; if empty, it selects all Namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AdminNetworkPolicySpecSubjectPodsNamespaceSelector NamespaceSelector { get; set; }

    /// <summary>PodSelector is used to explicitly select pods within a namespace; if empty, it selects all Pods.</summary>
    [JsonPropertyName("podSelector")]
    public V1alpha1AdminNetworkPolicySpecSubjectPodsPodSelector PodSelector { get; set; }
}

/// <summary>Subject defines the pods to which this AdminNetworkPolicy applies. Note that host-networked pods are not included in subject selection.   Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpecSubject
{
    /// <summary>Namespaces is used to select pods via namespace selectors.</summary>
    [JsonPropertyName("namespaces")]
    public V1alpha1AdminNetworkPolicySpecSubjectNamespaces? Namespaces { get; set; }

    /// <summary>Pods is used to select pods via namespace AND pod selectors.</summary>
    [JsonPropertyName("pods")]
    public V1alpha1AdminNetworkPolicySpecSubjectPods? Pods { get; set; }
}

/// <summary>Specification of the desired behavior of AdminNetworkPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicySpec
{
    /// <summary>Egress is the list of Egress rules to be applied to the selected pods. A total of 100 rules will be allowed in each ANP instance. The relative precedence of egress rules within a single ANP object (all of which share the priority) will be determined by the order in which the rule is written. Thus, a rule that appears at the top of the egress rules would take the highest precedence. ANPs with no egress rules do not affect egress traffic.   Support: Core</summary>
    [JsonPropertyName("egress")]
    public IList<V1alpha1AdminNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary>Ingress is the list of Ingress rules to be applied to the selected pods. A total of 100 rules will be allowed in each ANP instance. The relative precedence of ingress rules within a single ANP object (all of which share the priority) will be determined by the order in which the rule is written. Thus, a rule that appears at the top of the ingress rules would take the highest precedence. ANPs with no ingress rules do not affect ingress traffic.   Support: Core</summary>
    [JsonPropertyName("ingress")]
    public IList<V1alpha1AdminNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary>Priority is a value from 0 to 1000. Rules with lower priority values have higher precedence, and are checked before rules with higher priority values. All AdminNetworkPolicy rules have higher precedence than NetworkPolicy or BaselineAdminNetworkPolicy rules The behavior is undefined if two ANP objects have same priority.   Support: Core</summary>
    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    /// <summary>Subject defines the pods to which this AdminNetworkPolicy applies. Note that host-networked pods are not included in subject selection.   Support: Core</summary>
    [JsonPropertyName("subject")]
    public V1alpha1AdminNetworkPolicySpecSubject Subject { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicyStatusConditions
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

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status is the status to be reported by the implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AdminNetworkPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AdminNetworkPolicyStatusConditions> Conditions { get; set; }
}

/// <summary>AdminNetworkPolicy is  a cluster level resource that is part of the AdminNetworkPolicy API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AdminNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AdminNetworkPolicySpec>, IStatus<V1alpha1AdminNetworkPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AdminNetworkPolicy";
    public const string KubeGroup = "policy.networking.k8s.io";
    public const string KubePluralName = "adminnetworkpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of AdminNetworkPolicy.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AdminNetworkPolicySpec Spec { get; set; }

    /// <summary>Status is the status to be reported by the implementation.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AdminNetworkPolicyStatus? Status { get; set; }
}

/// <summary>AdminNetworkPolicy is  a cluster level resource that is part of the AdminNetworkPolicy API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AdminNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AdminNetworkPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AdminNetworkPolicyList";
    public const string KubeGroup = "policy.networking.k8s.io";
    public const string KubePluralName = "adminnetworkpolicies";
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
    public IList<V1alpha1AdminNetworkPolicy> Items { get; set; }
}