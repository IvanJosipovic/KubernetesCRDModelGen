using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.@internal.knative.dev;
/// <summary>HeaderMatch represents a matching value of Headers in HTTPIngressPath. Currently, only the exact matching is supported.</summary>
public partial class V1alpha1IngressSpecRulesHttpPathsHeaders
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string Exact { get; set; }
}

/// <summary>IngressBackendSplit describes all endpoints for a given service and port.</summary>
public partial class V1alpha1IngressSpecRulesHttpPathsSplits
{
    /// <summary>AppendHeaders allow specifying additional HTTP headers to add before forwarding a request to the destination service.   NOTE: This differs from K8s Ingress which doesn't allow header appending.</summary>
    [JsonPropertyName("appendHeaders")]
    public IDictionary<string, string>? AppendHeaders { get; set; }

    /// <summary>Specifies the split percentage, a number between 0 and 100.  If only one split is specified, we default to 100.   NOTE: This differs from K8s Ingress to allow percentage split.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Specifies the name of the referenced service.</summary>
    [JsonPropertyName("serviceName")]
    public string ServiceName { get; set; }

    /// <summary>Specifies the namespace of the referenced service.   NOTE: This differs from K8s Ingress to allow routing to different namespaces.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string ServiceNamespace { get; set; }

    /// <summary>Specifies the port of the referenced service.</summary>
    [JsonPropertyName("servicePort")]
    public IntstrIntOrString ServicePort { get; set; }
}

/// <summary>HTTPIngressPath associates a path regex with a backend. Incoming URLs matching the path are forwarded to the backend.</summary>
public partial class V1alpha1IngressSpecRulesHttpPaths
{
    /// <summary>AppendHeaders allow specifying additional HTTP headers to add before forwarding a request to the destination service.   NOTE: This differs from K8s Ingress which doesn't allow header appending.</summary>
    [JsonPropertyName("appendHeaders")]
    public IDictionary<string, string>? AppendHeaders { get; set; }

    /// <summary>Headers defines header matching rules which is a map from a header name to HeaderMatch which specify a matching condition. When a request matched with all the header matching rules, the request is routed by the corresponding ingress rule. If it is empty, the headers are not used for matching</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, V1alpha1IngressSpecRulesHttpPathsHeaders>? Headers { get; set; }

    /// <summary>Path represents a literal prefix to which this rule should apply. Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/'. If unspecified, the path defaults to a catch all sending traffic to the backend.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>RewriteHost rewrites the incoming request's host header.   This field is currently experimental and not supported by all Ingress implementations.</summary>
    [JsonPropertyName("rewriteHost")]
    public string? RewriteHost { get; set; }

    /// <summary>Splits defines the referenced service endpoints to which the traffic will be forwarded to.</summary>
    [JsonPropertyName("splits")]
    public IList<V1alpha1IngressSpecRulesHttpPathsSplits> Splits { get; set; }
}

/// <summary>HTTP represents a rule to apply against incoming requests. If the rule is satisfied, the request is routed to the specified backend.</summary>
public partial class V1alpha1IngressSpecRulesHttp
{
    /// <summary>A collection of paths that map requests to backends.   If they are multiple matching paths, the first match takes precedence.</summary>
    [JsonPropertyName("paths")]
    public IList<V1alpha1IngressSpecRulesHttpPaths> Paths { get; set; }
}

/// <summary>IngressRule represents the rules mapping the paths under a specified host to the related backend services. Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.</summary>
public partial class V1alpha1IngressSpecRules
{
    /// <summary>Host is the fully qualified domain name of a network host, as defined by RFC 3986. Note the following deviations from the "host" part of the URI as defined in the RFC: 1. IPs are not allowed. Currently a rule value can only apply to the 	  IP in the Spec of the parent . 2. The `:` delimiter is not respected because ports are not allowed. 	  Currently the port of an Ingress is implicitly :80 for http and 	  :443 for https. Both these may change in the future. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue. If multiple matching Hosts were provided, the first rule will take precedent.</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>HTTP represents a rule to apply against incoming requests. If the rule is satisfied, the request is routed to the specified backend.</summary>
    [JsonPropertyName("http")]
    public V1alpha1IngressSpecRulesHttp? Http { get; set; }

    /// <summary>Visibility signifies whether this rule should `ClusterLocal`. If it's not specified then it defaults to `ExternalIP`.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>IngressTLS describes the transport layer security associated with an Ingress.</summary>
public partial class V1alpha1IngressSpecTls
{
    /// <summary>Hosts is a list of hosts included in the TLS certificate. The values in this list must match the name/s used in the tlsSecret. Defaults to the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>SecretName is the name of the secret used to terminate SSL traffic.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>SecretNamespace is the namespace of the secret used to terminate SSL traffic. If not set the namespace should be assumed to be the same as the Ingress. If set the secret should have the same namespace as the Ingress otherwise the behaviour is undefined and not supported.</summary>
    [JsonPropertyName("secretNamespace")]
    public string? SecretNamespace { get; set; }
}

/// <summary>Spec is the desired state of the Ingress. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1alpha1IngressSpec
{
    /// <summary>HTTPOption is the option of HTTP. It has the following two values: `HTTPOptionEnabled`, `HTTPOptionRedirected`</summary>
    [JsonPropertyName("httpOption")]
    public string? HttpOption { get; set; }

    /// <summary>A list of host rules used to configure the Ingress.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1IngressSpecRules>? Rules { get; set; }

    /// <summary>TLS configuration. Currently Ingress only supports a single TLS port: 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.</summary>
    [JsonPropertyName("tls")]
    public IList<V1alpha1IngressSpecTls>? Tls { get; set; }
}

/// <summary>Condition defines a readiness condition for a Knative resource. See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties</summary>
public partial class V1alpha1IngressStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>LoadBalancerIngressStatus represents the status of a load-balancer ingress point: traffic intended for the service should be sent to an ingress point.</summary>
public partial class V1alpha1IngressStatusPrivateLoadBalancerIngress
{
    /// <summary>Domain is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>DomainInternal is set if there is a cluster-local DNS name to access the Ingress.   NOTE: This differs from K8s Ingress, since we also desire to have a cluster-local       DNS name to allow routing in case of not having a mesh.</summary>
    [JsonPropertyName("domainInternal")]
    public string? DomainInternal { get; set; }

    /// <summary>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>MeshOnly is set if the Ingress is only load-balanced through a Service mesh.</summary>
    [JsonPropertyName("meshOnly")]
    public bool? MeshOnly { get; set; }
}

/// <summary>PrivateLoadBalancer contains the current status of the load-balancer.</summary>
public partial class V1alpha1IngressStatusPrivateLoadBalancer
{
    /// <summary>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1alpha1IngressStatusPrivateLoadBalancerIngress>? Ingress { get; set; }
}

/// <summary>LoadBalancerIngressStatus represents the status of a load-balancer ingress point: traffic intended for the service should be sent to an ingress point.</summary>
public partial class V1alpha1IngressStatusPublicLoadBalancerIngress
{
    /// <summary>Domain is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>DomainInternal is set if there is a cluster-local DNS name to access the Ingress.   NOTE: This differs from K8s Ingress, since we also desire to have a cluster-local       DNS name to allow routing in case of not having a mesh.</summary>
    [JsonPropertyName("domainInternal")]
    public string? DomainInternal { get; set; }

    /// <summary>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>MeshOnly is set if the Ingress is only load-balanced through a Service mesh.</summary>
    [JsonPropertyName("meshOnly")]
    public bool? MeshOnly { get; set; }
}

/// <summary>PublicLoadBalancer contains the current status of the load-balancer.</summary>
public partial class V1alpha1IngressStatusPublicLoadBalancer
{
    /// <summary>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1alpha1IngressStatusPublicLoadBalancerIngress>? Ingress { get; set; }
}

/// <summary>Status is the current state of the Ingress. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1alpha1IngressStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IngressStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>PrivateLoadBalancer contains the current status of the load-balancer.</summary>
    [JsonPropertyName("privateLoadBalancer")]
    public V1alpha1IngressStatusPrivateLoadBalancer? PrivateLoadBalancer { get; set; }

    /// <summary>PublicLoadBalancer contains the current status of the load-balancer.</summary>
    [JsonPropertyName("publicLoadBalancer")]
    public V1alpha1IngressStatusPublicLoadBalancer? PublicLoadBalancer { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Ingress is a collection of rules that allow inbound connections to reach the endpoints defined by a backend. An Ingress can be configured to give services externally-reachable URLs, load balance traffic, offer name based virtual hosting, etc.   This is heavily based on K8s Ingress https://godoc.org/k8s.io/api/networking/v1beta1#Ingress which some highlighted modifications.</summary>
public partial class V1alpha1Ingress : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IngressSpec>, IStatus<V1alpha1IngressStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Ingress";
    public const string KubeGroup = "networking.internal.knative.dev";
    public const string KubePluralName = "ingresses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec is the desired state of the Ingress. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1alpha1IngressSpec? Spec { get; set; }

    /// <summary>Status is the current state of the Ingress. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1alpha1IngressStatus? Status { get; set; }
}