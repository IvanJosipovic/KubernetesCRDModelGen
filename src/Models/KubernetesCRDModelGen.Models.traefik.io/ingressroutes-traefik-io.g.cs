using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>IngressRoute is the CRD implementation of a Traefik HTTP Router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IngressRouteList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IngressRoute>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IngressRouteList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "ingressroutes";
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
    public IList<V1alpha1IngressRoute> Items { get; set; }
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Observability defines the observability configuration for a router. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#observability</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesObservability
{
    /// <summary>AccessLogs enables access logs for this router.</summary>
    [JsonPropertyName("accessLogs")]
    public bool? AccessLogs { get; set; }

    /// <summary>Metrics enables metrics for this router.</summary>
    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    /// <summary>TraceVerbosity defines the verbosity level of the tracing for this router.</summary>
    [JsonPropertyName("traceVerbosity")]
    public string? TraceVerbosity { get; set; }

    /// <summary>Tracing enables tracing for this router.</summary>
    [JsonPropertyName("tracing")]
    public bool? Tracing { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesServicesHealthCheck
{
    /// <summary>FollowRedirects defines whether redirects should be followed during the health check calls. Default: true</summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Interval defines the frequency of the health check calls for healthy targets. Default: 30s</summary>
    [JsonPropertyName("interval")]
    public IntstrIntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Mode defines the health check mode. If defined to grpc, will use the gRPC health check protocol to probe the server. Default: http</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy. Default: 5s</summary>
    [JsonPropertyName("timeout")]
    public IntstrIntOrString? Timeout { get; set; }

    /// <summary>UnhealthyInterval defines the frequency of the health check calls for unhealthy targets. When UnhealthyInterval is not defined, it defaults to the Interval value. Default: 30s</summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntstrIntOrString? UnhealthyInterval { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesServicesResponseForwarding
{
    /// <summary>FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body. A negative value means to flush immediately after each write to the client. This configuration is ignored when ReverseProxy recognizes a response as a streaming response; for such responses, writes are flushed to the client immediately. Default: 100ms</summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesServicesStickyCookie
{
    /// <summary>Domain defines the host to which the cookie will be sent. More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>MaxAge defines the number of seconds until the cookie expires. When set to a negative number, the cookie expires immediately. When set to zero, the cookie never expires.</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path defines the path that must exist in the requested URL for the browser to send the Cookie header. When not provided the cookie will be sent on every request to the domain. More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>SameSite defines the same site policy. More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite</summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/services/#sticky-sessions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesServicesSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1IngressRouteSpecRoutesServicesStickyCookie? Cookie { get; set; }
}

/// <summary>Service defines an upstream HTTP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutesServices
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1IngressRouteSpecRoutesServicesHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name defines the name of the referenced Kubernetes Service or TraefikService. The differentiation between the two is specified in the Kind field.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>NativeLB controls, when creating the load-balancer, whether the LB's children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP. The Kubernetes Service itself does load-balance to the pods. By default, NativeLB is false.</summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>NodePortLB controls, when creating the load-balancer, whether the LB's children are directly the nodes internal IPs using the nodePort when the service type is NodePort. It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes. By default, NodePortLB is false.</summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service. By default, passHostHeader is true.</summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>Port defines the port of a Kubernetes Service. This can be a reference to a named port.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1IngressRouteSpecRoutesServicesResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>Scheme defines the scheme to use for the request to the upstream Kubernetes Service. It defaults to https when Kubernetes Service port is 443, http otherwise.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransport resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/services/#sticky-sessions</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1IngressRouteSpecRoutesServicesSticky? Sticky { get; set; }

    /// <summary>Strategy defines the load balancing strategy between the servers. Supported values are: wrr (Weighed round-robin) and p2c (Power of two choices). RoundRobin value is deprecated and supported for backward compatibility.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Weight defines the weight and should only be specified when Name references a TraefikService object (and to be precise, one that embeds a Weighted Round Robin).</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Route holds the HTTP route configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecRoutes
{
    /// <summary>Kind defines the kind of the route. Rule is the only supported kind. If not defined, defaults to Rule.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Match defines the router's rule. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#rule</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources. More info: https://doc.traefik.io/traefik/v3.5/routing/providers/kubernetes-crd/#kind-middleware</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1IngressRouteSpecRoutesMiddlewares>? Middlewares { get; set; }

    /// <summary>Observability defines the observability configuration for a router. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#observability</summary>
    [JsonPropertyName("observability")]
    public V1alpha1IngressRouteSpecRoutesObservability? Observability { get; set; }

    /// <summary>Priority defines the router's priority. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#priority</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Services defines the list of Service. It can contain any combination of TraefikService and/or reference to a Kubernetes Service.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1IngressRouteSpecRoutesServices>? Services { get; set; }

    /// <summary>Syntax defines the router's rule syntax. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#rulesyntax Deprecated: Please do not use this field and rewrite the router rules to use the v3 syntax.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }
}

/// <summary>Domain holds a domain name with SANs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecTlsDomains
{
    /// <summary>Main defines the main domain name.</summary>
    [JsonPropertyName("main")]
    public string? Main { get; set; }

    /// <summary>SANs defines the subject alternative domain names.</summary>
    [JsonPropertyName("sans")]
    public IList<string>? Sans { get; set; }
}

/// <summary>Options defines the reference to a TLSOption, that specifies the parameters of the TLS connection. If not defined, the `default` TLSOption is used. More info: https://doc.traefik.io/traefik/v3.5/https/tls/#tls-options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecTlsOptions
{
    /// <summary>Name defines the name of the referenced TLSOption. More info: https://doc.traefik.io/traefik/v3.5/routing/providers/kubernetes-crd/#kind-tlsoption</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced TLSOption. More info: https://doc.traefik.io/traefik/v3.5/routing/providers/kubernetes-crd/#kind-tlsoption</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Store defines the reference to the TLSStore, that will be used to store certificates. Please note that only `default` TLSStore can be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecTlsStore
{
    /// <summary>Name defines the name of the referenced TLSStore. More info: https://doc.traefik.io/traefik/v3.5/routing/providers/kubernetes-crd/#kind-tlsstore</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced TLSStore. More info: https://doc.traefik.io/traefik/v3.5/routing/providers/kubernetes-crd/#kind-tlsstore</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>TLS defines the TLS configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#tls</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpecTls
{
    /// <summary>CertResolver defines the name of the certificate resolver to use. Cert resolvers have to be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.5/https/acme/#certificate-resolvers</summary>
    [JsonPropertyName("certResolver")]
    public string? CertResolver { get; set; }

    /// <summary>Domains defines the list of domains that will be used to issue certificates. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#domains</summary>
    [JsonPropertyName("domains")]
    public IList<V1alpha1IngressRouteSpecTlsDomains>? Domains { get; set; }

    /// <summary>Options defines the reference to a TLSOption, that specifies the parameters of the TLS connection. If not defined, the `default` TLSOption is used. More info: https://doc.traefik.io/traefik/v3.5/https/tls/#tls-options</summary>
    [JsonPropertyName("options")]
    public V1alpha1IngressRouteSpecTlsOptions? Options { get; set; }

    /// <summary>SecretName is the name of the referenced Kubernetes Secret to specify the certificate details.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Store defines the reference to the TLSStore, that will be used to store certificates. Please note that only `default` TLSStore can be used.</summary>
    [JsonPropertyName("store")]
    public V1alpha1IngressRouteSpecTlsStore? Store { get; set; }
}

/// <summary>IngressRouteSpec defines the desired state of IngressRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteSpec
{
    /// <summary>EntryPoints defines the list of entry point names to bind to. Entry points have to be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/entrypoints/ Default: all.</summary>
    [JsonPropertyName("entryPoints")]
    public IList<string>? EntryPoints { get; set; }

    /// <summary>Routes defines the list of routes.</summary>
    [JsonPropertyName("routes")]
    public IList<V1alpha1IngressRouteSpecRoutes> Routes { get; set; }

    /// <summary>TLS defines the TLS configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/routers/#tls</summary>
    [JsonPropertyName("tls")]
    public V1alpha1IngressRouteSpecTls? Tls { get; set; }
}

/// <summary>IngressRoute is the CRD implementation of a Traefik HTTP Router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IngressRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IngressRouteSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IngressRoute";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "ingressroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IngressRouteSpec defines the desired state of IngressRoute.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1IngressRouteSpec Spec { get; set; }
}