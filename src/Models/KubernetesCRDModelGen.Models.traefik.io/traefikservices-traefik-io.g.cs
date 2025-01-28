using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringHealthCheck
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

    /// <summary>Interval defines the frequency of the health check calls. Default: 30s</summary>
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
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsHealthCheck
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

    /// <summary>Interval defines the frequency of the health check calls. Default: 30s</summary>
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
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsResponseForwarding
{
    /// <summary>FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body. A negative value means to flush immediately after each write to the client. This configuration is ignored when ReverseProxy recognizes a response as a streaming response; for such responses, writes are flushed to the client immediately. Default: 100ms</summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookie
{
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

/// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookie? Cookie { get; set; }
}

/// <summary>MirrorService holds the mirror configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrors
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsHealthCheck? HealthCheck { get; set; }

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

    /// <summary>Percent defines the part of the traffic to mirror. Supported values: 0 to 100.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Port defines the port of a Kubernetes Service. This can be a reference to a named port.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>Scheme defines the scheme to use for the request to the upstream Kubernetes Service. It defaults to https when Kubernetes Service port is 443, http otherwise.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransport resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsSticky? Sticky { get; set; }

    /// <summary>Strategy defines the load balancing strategy between the servers. RoundRobin is the only supported value at the moment.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Weight defines the weight and should only be specified when Name references a TraefikService object (and to be precise, one that embeds a Weighted Round Robin).</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringResponseForwarding
{
    /// <summary>FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body. A negative value means to flush immediately after each write to the client. This configuration is ignored when ReverseProxy recognizes a response as a streaming response; for such responses, writes are flushed to the client immediately. Default: 100ms</summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringStickyCookie
{
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

/// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecMirroringStickyCookie? Cookie { get; set; }
}

/// <summary>Mirroring defines the Mirroring service configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroring
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecMirroringHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>MaxBodySize defines the maximum size allowed for the body of the request. If the body is larger, the request is not mirrored. Default value is -1, which means unlimited size.</summary>
    [JsonPropertyName("maxBodySize")]
    public long? MaxBodySize { get; set; }

    /// <summary>MirrorBody defines whether the body of the request should be mirrored. Default value is true.</summary>
    [JsonPropertyName("mirrorBody")]
    public bool? MirrorBody { get; set; }

    /// <summary>Mirrors defines the list of mirrors where Traefik will duplicate the traffic.</summary>
    [JsonPropertyName("mirrors")]
    public IList<V1alpha1TraefikServiceSpecMirroringMirrors>? Mirrors { get; set; }

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
    public V1alpha1TraefikServiceSpecMirroringResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>Scheme defines the scheme to use for the request to the upstream Kubernetes Service. It defaults to https when Kubernetes Service port is 443, http otherwise.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransport resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecMirroringSticky? Sticky { get; set; }

    /// <summary>Strategy defines the load balancing strategy between the servers. RoundRobin is the only supported value at the moment.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Weight defines the weight and should only be specified when Name references a TraefikService object (and to be precise, one that embeds a Weighted Round Robin).</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesHealthCheck
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

    /// <summary>Interval defines the frequency of the health check calls. Default: 30s</summary>
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
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesResponseForwarding
{
    /// <summary>FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body. A negative value means to flush immediately after each write to the client. This configuration is ignored when ReverseProxy recognizes a response as a streaming response; for such responses, writes are flushed to the client immediately. Default: 100ms</summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesStickyCookie
{
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

/// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecWeightedServicesStickyCookie? Cookie { get; set; }
}

/// <summary>Service defines an upstream HTTP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServices
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecWeightedServicesHealthCheck? HealthCheck { get; set; }

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
    public V1alpha1TraefikServiceSpecWeightedServicesResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>Scheme defines the scheme to use for the request to the upstream Kubernetes Service. It defaults to https when Kubernetes Service port is 443, http otherwise.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransport resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.3/routing/services/#sticky-sessions</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecWeightedServicesSticky? Sticky { get; set; }

    /// <summary>Strategy defines the load balancing strategy between the servers. RoundRobin is the only supported value at the moment.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Weight defines the weight and should only be specified when Name references a TraefikService object (and to be precise, one that embeds a Weighted Round Robin).</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedStickyCookie
{
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

/// <summary>Sticky defines whether sticky sessions are enabled. More info: https://doc.traefik.io/traefik/v3.3/routing/providers/kubernetes-crd/#stickiness-and-load-balancing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecWeightedStickyCookie? Cookie { get; set; }
}

/// <summary>Weighted defines the Weighted Round Robin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeighted
{
    /// <summary>Services defines the list of Kubernetes Service and/or TraefikService to load-balance, with weight.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1TraefikServiceSpecWeightedServices>? Services { get; set; }

    /// <summary>Sticky defines whether sticky sessions are enabled. More info: https://doc.traefik.io/traefik/v3.3/routing/providers/kubernetes-crd/#stickiness-and-load-balancing</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecWeightedSticky? Sticky { get; set; }
}

/// <summary>TraefikServiceSpec defines the desired state of a TraefikService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpec
{
    /// <summary>Mirroring defines the Mirroring service configuration.</summary>
    [JsonPropertyName("mirroring")]
    public V1alpha1TraefikServiceSpecMirroring? Mirroring { get; set; }

    /// <summary>Weighted defines the Weighted Round Robin configuration.</summary>
    [JsonPropertyName("weighted")]
    public V1alpha1TraefikServiceSpecWeighted? Weighted { get; set; }
}

/// <summary>TraefikService is the CRD implementation of a Traefik Service. TraefikService object allows to: - Apply weight to Services on load-balancing - Mirror traffic on services More info: https://doc.traefik.io/traefik/v3.3/routing/providers/kubernetes-crd/#kind-traefikservice</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TraefikService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TraefikServiceSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TraefikService";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "traefikservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TraefikServiceSpec defines the desired state of a TraefikService.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TraefikServiceSpec Spec { get; set; }
}