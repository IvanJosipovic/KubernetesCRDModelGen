using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>Middleware is the CRD implementation of a Traefik Middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/overview/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MiddlewareList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Middleware>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MiddlewareList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewares";
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
    public IList<V1alpha1Middleware> Items { get; set; }
}

/// <summary>AddPrefix holds the add prefix middleware configuration. This middleware updates the path of a request before forwarding it. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/addprefix/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecAddPrefix
{
    /// <summary>Prefix is the string to add before the current path in the requested URL. It should include a leading slash (/).</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>BasicAuth holds the basic auth middleware configuration. This middleware restricts access to your services to known users. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/basicauth/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecBasicAuth
{
    /// <summary>HeaderField defines a header field to store the authenticated user. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/basicauth/#headerfield</summary>
    [JsonPropertyName("headerField")]
    public string? HeaderField { get; set; }

    /// <summary>Realm allows the protected resources on a server to be partitioned into a set of protection spaces, each with its own authentication scheme. Default: traefik.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>RemoveHeader sets the removeHeader option to true to remove the authorization header before forwarding the request to your service. Default: false.</summary>
    [JsonPropertyName("removeHeader")]
    public bool? RemoveHeader { get; set; }

    /// <summary>Secret is the name of the referenced Kubernetes Secret containing user credentials.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

/// <summary>Buffering holds the buffering middleware configuration. This middleware retries or limits the size of requests that can be forwarded to backends. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/buffering/#maxrequestbodybytes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecBuffering
{
    /// <summary>MaxRequestBodyBytes defines the maximum allowed body size for the request (in bytes). If the request exceeds the allowed size, it is not forwarded to the service, and the client gets a 413 (Request Entity Too Large) response. Default: 0 (no maximum).</summary>
    [JsonPropertyName("maxRequestBodyBytes")]
    public long? MaxRequestBodyBytes { get; set; }

    /// <summary>MaxResponseBodyBytes defines the maximum allowed response size from the service (in bytes). If the response exceeds the allowed size, it is not forwarded to the client. The client gets a 500 (Internal Server Error) response instead. Default: 0 (no maximum).</summary>
    [JsonPropertyName("maxResponseBodyBytes")]
    public long? MaxResponseBodyBytes { get; set; }

    /// <summary>MemRequestBodyBytes defines the threshold (in bytes) from which the request will be buffered on disk instead of in memory. Default: 1048576 (1Mi).</summary>
    [JsonPropertyName("memRequestBodyBytes")]
    public long? MemRequestBodyBytes { get; set; }

    /// <summary>MemResponseBodyBytes defines the threshold (in bytes) from which the response will be buffered on disk instead of in memory. Default: 1048576 (1Mi).</summary>
    [JsonPropertyName("memResponseBodyBytes")]
    public long? MemResponseBodyBytes { get; set; }

    /// <summary>RetryExpression defines the retry conditions. It is a logical combination of functions with operators AND (&amp;&amp;) and OR (||). More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/buffering/#retryexpression</summary>
    [JsonPropertyName("retryExpression")]
    public string? RetryExpression { get; set; }
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecChainMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Chain holds the configuration of the chain middleware. This middleware enables to define reusable combinations of other pieces of middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/chain/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecChain
{
    /// <summary>Middlewares is the list of MiddlewareRef which composes the chain.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1MiddlewareSpecChainMiddlewares>? Middlewares { get; set; }
}

/// <summary>CircuitBreaker holds the circuit breaker configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecCircuitBreaker
{
    /// <summary>CheckPeriod is the interval between successive checks of the circuit breaker condition (when in standby state).</summary>
    [JsonPropertyName("checkPeriod")]
    public IntstrIntOrString? CheckPeriod { get; set; }

    /// <summary>Expression is the condition that triggers the tripped state.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>FallbackDuration is the duration for which the circuit breaker will wait before trying to recover (from a tripped state).</summary>
    [JsonPropertyName("fallbackDuration")]
    public IntstrIntOrString? FallbackDuration { get; set; }

    /// <summary>RecoveryDuration is the duration for which the circuit breaker will try to recover (as soon as it is in recovering state).</summary>
    [JsonPropertyName("recoveryDuration")]
    public IntstrIntOrString? RecoveryDuration { get; set; }

    /// <summary>ResponseCode is the status code that the circuit breaker will return while it is in the open state.</summary>
    [JsonPropertyName("responseCode")]
    public int? ResponseCode { get; set; }
}

/// <summary>Compress holds the compress middleware configuration. This middleware compresses responses before sending them to the client, using gzip, brotli, or zstd compression. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/compress/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecCompress
{
    /// <summary>DefaultEncoding specifies the default encoding if the `Accept-Encoding` header is not in the request or contains a wildcard (`*`).</summary>
    [JsonPropertyName("defaultEncoding")]
    public string? DefaultEncoding { get; set; }

    /// <summary>Encodings defines the list of supported compression algorithms.</summary>
    [JsonPropertyName("encodings")]
    public IList<string>? Encodings { get; set; }

    /// <summary>ExcludedContentTypes defines the list of content types to compare the Content-Type header of the incoming requests and responses before compressing. `application/grpc` is always excluded.</summary>
    [JsonPropertyName("excludedContentTypes")]
    public IList<string>? ExcludedContentTypes { get; set; }

    /// <summary>IncludedContentTypes defines the list of content types to compare the Content-Type header of the responses before compressing.</summary>
    [JsonPropertyName("includedContentTypes")]
    public IList<string>? IncludedContentTypes { get; set; }

    /// <summary>MinResponseBodyBytes defines the minimum amount of bytes a response body must have to be compressed. Default: 1024.</summary>
    [JsonPropertyName("minResponseBodyBytes")]
    public int? MinResponseBodyBytes { get; set; }
}

/// <summary>ContentType holds the content-type middleware configuration. This middleware exists to enable the correct behavior until at least the default one can be changed in a future version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecContentType
{
    /// <summary>AutoDetect specifies whether to let the `Content-Type` header, if it has not been set by the backend, be automatically set to a value derived from the contents of the response. Deprecated: AutoDetect option is deprecated, Content-Type middleware is only meant to be used to enable the content-type detection, please remove any usage of this option.</summary>
    [JsonPropertyName("autoDetect")]
    public bool? AutoDetect { get; set; }
}

/// <summary>DigestAuth holds the digest auth middleware configuration. This middleware restricts access to your services to known users. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/digestauth/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecDigestAuth
{
    /// <summary>HeaderField defines a header field to store the authenticated user. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/basicauth/#headerfield</summary>
    [JsonPropertyName("headerField")]
    public string? HeaderField { get; set; }

    /// <summary>Realm allows the protected resources on a server to be partitioned into a set of protection spaces, each with its own authentication scheme. Default: traefik.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>RemoveHeader defines whether to remove the authorization header before forwarding the request to the backend.</summary>
    [JsonPropertyName("removeHeader")]
    public bool? RemoveHeader { get; set; }

    /// <summary>Secret is the name of the referenced Kubernetes Secret containing user credentials.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecErrorsServiceHealthCheck
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
public partial class V1alpha1MiddlewareSpecErrorsServiceResponseForwarding
{
    /// <summary>FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body. A negative value means to flush immediately after each write to the client. This configuration is ignored when ReverseProxy recognizes a response as a streaming response; for such responses, writes are flushed to the client immediately. Default: 100ms</summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecErrorsServiceStickyCookie
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
public partial class V1alpha1MiddlewareSpecErrorsServiceSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1MiddlewareSpecErrorsServiceStickyCookie? Cookie { get; set; }
}

/// <summary>Service defines the reference to a Kubernetes Service that will serve the error page. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/errorpages/#service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecErrorsService
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1MiddlewareSpecErrorsServiceHealthCheck? HealthCheck { get; set; }

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
    public V1alpha1MiddlewareSpecErrorsServiceResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>Scheme defines the scheme to use for the request to the upstream Kubernetes Service. It defaults to https when Kubernetes Service port is 443, http otherwise.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransport resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>Sticky defines the sticky sessions configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/services/#sticky-sessions</summary>
    [JsonPropertyName("sticky")]
    public V1alpha1MiddlewareSpecErrorsServiceSticky? Sticky { get; set; }

    /// <summary>Strategy defines the load balancing strategy between the servers. Supported values are: wrr (Weighed round-robin) and p2c (Power of two choices). RoundRobin value is deprecated and supported for backward compatibility.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Weight defines the weight and should only be specified when Name references a TraefikService object (and to be precise, one that embeds a Weighted Round Robin).</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>ErrorPage holds the custom error middleware configuration. This middleware returns a custom page in lieu of the default, according to configured ranges of HTTP Status codes. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/errorpages/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecErrors
{
    /// <summary>Query defines the URL for the error page (hosted by service). The {status} variable can be used in order to insert the status code in the URL. The {originalStatus} variable can be used in order to insert the upstream status code in the URL. The {url} variable can be used in order to insert the escaped request URL.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Service defines the reference to a Kubernetes Service that will serve the error page. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/errorpages/#service</summary>
    [JsonPropertyName("service")]
    public V1alpha1MiddlewareSpecErrorsService? Service { get; set; }

    /// <summary>Status defines which status or range of statuses should result in an error page. It can be either a status code as a number (500), as multiple comma-separated numbers (500,502), as ranges by separating two codes with a dash (500-599), or a combination of the two (404,418,500-599).</summary>
    [JsonPropertyName("status")]
    public IList<string>? Status { get; set; }

    /// <summary>StatusRewrites defines a mapping of status codes that should be returned instead of the original error status codes. For example: "418": 404 or "410-418": 404</summary>
    [JsonPropertyName("statusRewrites")]
    public IDictionary<string, int>? StatusRewrites { get; set; }
}

/// <summary>TLS defines the configuration used to secure the connection to the authentication server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecForwardAuthTls
{
    /// <summary>Deprecated: TLS client authentication is a server side option (see https://github.com/golang/go/blob/740a490f71d026bb7d2d13cb8fa2d6d6e0572b70/src/crypto/tls/common.go#L634).</summary>
    [JsonPropertyName("caOptional")]
    public bool? CaOptional { get; set; }

    /// <summary>CASecret is the name of the referenced Kubernetes Secret containing the CA to validate the server certificate. The CA certificate is extracted from key `tls.ca` or `ca.crt`.</summary>
    [JsonPropertyName("caSecret")]
    public string? CaSecret { get; set; }

    /// <summary>CertSecret is the name of the referenced Kubernetes Secret containing the client certificate. The client certificate is extracted from the keys `tls.crt` and `tls.key`.</summary>
    [JsonPropertyName("certSecret")]
    public string? CertSecret { get; set; }

    /// <summary>InsecureSkipVerify defines whether the server certificates should be validated.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>ForwardAuth holds the forward auth middleware configuration. This middleware delegates the request authentication to a Service. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/forwardauth/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecForwardAuth
{
    /// <summary>AddAuthCookiesToResponse defines the list of cookies to copy from the authentication server response to the response.</summary>
    [JsonPropertyName("addAuthCookiesToResponse")]
    public IList<string>? AddAuthCookiesToResponse { get; set; }

    /// <summary>Address defines the authentication server address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AuthRequestHeaders defines the list of the headers to copy from the request to the authentication server. If not set or empty then all request headers are passed.</summary>
    [JsonPropertyName("authRequestHeaders")]
    public IList<string>? AuthRequestHeaders { get; set; }

    /// <summary>AuthResponseHeaders defines the list of headers to copy from the authentication server response and set on forwarded request, replacing any existing conflicting headers.</summary>
    [JsonPropertyName("authResponseHeaders")]
    public IList<string>? AuthResponseHeaders { get; set; }

    /// <summary>AuthResponseHeadersRegex defines the regex to match headers to copy from the authentication server response and set on forwarded request, after stripping all headers that match the regex. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/forwardauth/#authresponseheadersregex</summary>
    [JsonPropertyName("authResponseHeadersRegex")]
    public string? AuthResponseHeadersRegex { get; set; }

    /// <summary>ForwardBody defines whether to send the request body to the authentication server.</summary>
    [JsonPropertyName("forwardBody")]
    public bool? ForwardBody { get; set; }

    /// <summary>HeaderField defines a header field to store the authenticated user. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/forwardauth/#headerfield</summary>
    [JsonPropertyName("headerField")]
    public string? HeaderField { get; set; }

    /// <summary>MaxBodySize defines the maximum body size in bytes allowed to be forwarded to the authentication server.</summary>
    [JsonPropertyName("maxBodySize")]
    public long? MaxBodySize { get; set; }

    /// <summary>PreserveLocationHeader defines whether to forward the Location header to the client as is or prefix it with the domain name of the authentication server.</summary>
    [JsonPropertyName("preserveLocationHeader")]
    public bool? PreserveLocationHeader { get; set; }

    /// <summary>PreserveRequestMethod defines whether to preserve the original request method while forwarding the request to the authentication server.</summary>
    [JsonPropertyName("preserveRequestMethod")]
    public bool? PreserveRequestMethod { get; set; }

    /// <summary>TLS defines the configuration used to secure the connection to the authentication server.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1MiddlewareSpecForwardAuthTls? Tls { get; set; }

    /// <summary>TrustForwardHeader defines whether to trust (ie: forward) all X-Forwarded-* headers.</summary>
    [JsonPropertyName("trustForwardHeader")]
    public bool? TrustForwardHeader { get; set; }
}

/// <summary>GrpcWeb holds the gRPC web middleware configuration. This middleware converts a gRPC web request to an HTTP/2 gRPC request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecGrpcWeb
{
    /// <summary>AllowOrigins is a list of allowable origins. Can also be a wildcard origin "*".</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }
}

/// <summary>Headers holds the headers middleware configuration. This middleware manages the requests and responses headers. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/headers/#customrequestheaders</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecHeaders
{
    /// <summary>AccessControlAllowCredentials defines whether the request can include user credentials.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>AccessControlAllowHeaders defines the Access-Control-Request-Headers values sent in preflight response.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public IList<string>? AccessControlAllowHeaders { get; set; }

    /// <summary>AccessControlAllowMethods defines the Access-Control-Request-Method values sent in preflight response.</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public IList<string>? AccessControlAllowMethods { get; set; }

    /// <summary>AccessControlAllowOriginList is a list of allowable origins. Can also be a wildcard origin "*".</summary>
    [JsonPropertyName("accessControlAllowOriginList")]
    public IList<string>? AccessControlAllowOriginList { get; set; }

    /// <summary>AccessControlAllowOriginListRegex is a list of allowable origins written following the Regular Expression syntax (https://golang.org/pkg/regexp/).</summary>
    [JsonPropertyName("accessControlAllowOriginListRegex")]
    public IList<string>? AccessControlAllowOriginListRegex { get; set; }

    /// <summary>AccessControlExposeHeaders defines the Access-Control-Expose-Headers values sent in preflight response.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public IList<string>? AccessControlExposeHeaders { get; set; }

    /// <summary>AccessControlMaxAge defines the time that a preflight request may be cached.</summary>
    [JsonPropertyName("accessControlMaxAge")]
    public long? AccessControlMaxAge { get; set; }

    /// <summary>AddVaryHeader defines whether the Vary header is automatically added/updated when the AccessControlAllowOriginList is set.</summary>
    [JsonPropertyName("addVaryHeader")]
    public bool? AddVaryHeader { get; set; }

    /// <summary>AllowedHosts defines the fully qualified list of allowed domain names.</summary>
    [JsonPropertyName("allowedHosts")]
    public IList<string>? AllowedHosts { get; set; }

    /// <summary>BrowserXSSFilter defines whether to add the X-XSS-Protection header with the value 1; mode=block.</summary>
    [JsonPropertyName("browserXssFilter")]
    public bool? BrowserXssFilter { get; set; }

    /// <summary>ContentSecurityPolicy defines the Content-Security-Policy header value.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>ContentSecurityPolicyReportOnly defines the Content-Security-Policy-Report-Only header value.</summary>
    [JsonPropertyName("contentSecurityPolicyReportOnly")]
    public string? ContentSecurityPolicyReportOnly { get; set; }

    /// <summary>ContentTypeNosniff defines whether to add the X-Content-Type-Options header with the nosniff value.</summary>
    [JsonPropertyName("contentTypeNosniff")]
    public bool? ContentTypeNosniff { get; set; }

    /// <summary>CustomBrowserXSSValue defines the X-XSS-Protection header value. This overrides the BrowserXssFilter option.</summary>
    [JsonPropertyName("customBrowserXSSValue")]
    public string? CustomBrowserXSSValue { get; set; }

    /// <summary>CustomFrameOptionsValue defines the X-Frame-Options header value. This overrides the FrameDeny option.</summary>
    [JsonPropertyName("customFrameOptionsValue")]
    public string? CustomFrameOptionsValue { get; set; }

    /// <summary>CustomRequestHeaders defines the header names and values to apply to the request.</summary>
    [JsonPropertyName("customRequestHeaders")]
    public IDictionary<string, string>? CustomRequestHeaders { get; set; }

    /// <summary>CustomResponseHeaders defines the header names and values to apply to the response.</summary>
    [JsonPropertyName("customResponseHeaders")]
    public IDictionary<string, string>? CustomResponseHeaders { get; set; }

    /// <summary>Deprecated: FeaturePolicy option is deprecated, please use PermissionsPolicy instead.</summary>
    [JsonPropertyName("featurePolicy")]
    public string? FeaturePolicy { get; set; }

    /// <summary>ForceSTSHeader defines whether to add the STS header even when the connection is HTTP.</summary>
    [JsonPropertyName("forceSTSHeader")]
    public bool? ForceSTSHeader { get; set; }

    /// <summary>FrameDeny defines whether to add the X-Frame-Options header with the DENY value.</summary>
    [JsonPropertyName("frameDeny")]
    public bool? FrameDeny { get; set; }

    /// <summary>HostsProxyHeaders defines the header keys that may hold a proxied hostname value for the request.</summary>
    [JsonPropertyName("hostsProxyHeaders")]
    public IList<string>? HostsProxyHeaders { get; set; }

    /// <summary>IsDevelopment defines whether to mitigate the unwanted effects of the AllowedHosts, SSL, and STS options when developing. Usually testing takes place using HTTP, not HTTPS, and on localhost, not your production domain. If you would like your development environment to mimic production with complete Host blocking, SSL redirects, and STS headers, leave this as false.</summary>
    [JsonPropertyName("isDevelopment")]
    public bool? IsDevelopment { get; set; }

    /// <summary>PermissionsPolicy defines the Permissions-Policy header value. This allows sites to control browser features.</summary>
    [JsonPropertyName("permissionsPolicy")]
    public string? PermissionsPolicy { get; set; }

    /// <summary>PublicKey is the public key that implements HPKP to prevent MITM attacks with forged certificates.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>ReferrerPolicy defines the Referrer-Policy header value. This allows sites to control whether browsers forward the Referer header to other sites.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }

    /// <summary>Deprecated: SSLForceHost option is deprecated, please use RedirectRegex instead.</summary>
    [JsonPropertyName("sslForceHost")]
    public bool? SslForceHost { get; set; }

    /// <summary>Deprecated: SSLHost option is deprecated, please use RedirectRegex instead.</summary>
    [JsonPropertyName("sslHost")]
    public string? SslHost { get; set; }

    /// <summary>SSLProxyHeaders defines the header keys with associated values that would indicate a valid HTTPS request. It can be useful when using other proxies (example: "X-Forwarded-Proto": "https").</summary>
    [JsonPropertyName("sslProxyHeaders")]
    public IDictionary<string, string>? SslProxyHeaders { get; set; }

    /// <summary>Deprecated: SSLRedirect option is deprecated, please use EntryPoint redirection or RedirectScheme instead.</summary>
    [JsonPropertyName("sslRedirect")]
    public bool? SslRedirect { get; set; }

    /// <summary>Deprecated: SSLTemporaryRedirect option is deprecated, please use EntryPoint redirection or RedirectScheme instead.</summary>
    [JsonPropertyName("sslTemporaryRedirect")]
    public bool? SslTemporaryRedirect { get; set; }

    /// <summary>STSIncludeSubdomains defines whether the includeSubDomains directive is appended to the Strict-Transport-Security header.</summary>
    [JsonPropertyName("stsIncludeSubdomains")]
    public bool? StsIncludeSubdomains { get; set; }

    /// <summary>STSPreload defines whether the preload flag is appended to the Strict-Transport-Security header.</summary>
    [JsonPropertyName("stsPreload")]
    public bool? StsPreload { get; set; }

    /// <summary>STSSeconds defines the max-age of the Strict-Transport-Security header. If set to 0, the header is not set.</summary>
    [JsonPropertyName("stsSeconds")]
    public long? StsSeconds { get; set; }
}

/// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecInFlightReqSourceCriterionIpStrategy
{
    /// <summary>Depth tells Traefik to use the X-Forwarded-For header and take the IP located at the depth position (starting from the right).</summary>
    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    /// <summary>ExcludedIPs configures Traefik to scan the X-Forwarded-For header and select the first IP not in the list.</summary>
    [JsonPropertyName("excludedIPs")]
    public IList<string>? ExcludedIPs { get; set; }

    /// <summary>IPv6Subnet configures Traefik to consider all IPv6 addresses from the defined subnet as originating from the same IP. Applies to RemoteAddrStrategy and DepthStrategy.</summary>
    [JsonPropertyName("ipv6Subnet")]
    public int? Ipv6Subnet { get; set; }
}

/// <summary>SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the requestHost. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/inflightreq/#sourcecriterion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecInFlightReqSourceCriterion
{
    /// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
    [JsonPropertyName("ipStrategy")]
    public V1alpha1MiddlewareSpecInFlightReqSourceCriterionIpStrategy? IpStrategy { get; set; }

    /// <summary>RequestHeaderName defines the name of the header used to group incoming requests.</summary>
    [JsonPropertyName("requestHeaderName")]
    public string? RequestHeaderName { get; set; }

    /// <summary>RequestHost defines whether to consider the request Host as the source.</summary>
    [JsonPropertyName("requestHost")]
    public bool? RequestHost { get; set; }
}

/// <summary>InFlightReq holds the in-flight request middleware configuration. This middleware limits the number of requests being processed and served concurrently. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/inflightreq/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecInFlightReq
{
    /// <summary>Amount defines the maximum amount of allowed simultaneous in-flight request. The middleware responds with HTTP 429 Too Many Requests if there are already amount requests in progress (based on the same sourceCriterion strategy).</summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; set; }

    /// <summary>SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the requestHost. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/inflightreq/#sourcecriterion</summary>
    [JsonPropertyName("sourceCriterion")]
    public V1alpha1MiddlewareSpecInFlightReqSourceCriterion? SourceCriterion { get; set; }
}

/// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecIpAllowListIpStrategy
{
    /// <summary>Depth tells Traefik to use the X-Forwarded-For header and take the IP located at the depth position (starting from the right).</summary>
    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    /// <summary>ExcludedIPs configures Traefik to scan the X-Forwarded-For header and select the first IP not in the list.</summary>
    [JsonPropertyName("excludedIPs")]
    public IList<string>? ExcludedIPs { get; set; }

    /// <summary>IPv6Subnet configures Traefik to consider all IPv6 addresses from the defined subnet as originating from the same IP. Applies to RemoteAddrStrategy and DepthStrategy.</summary>
    [JsonPropertyName("ipv6Subnet")]
    public int? Ipv6Subnet { get; set; }
}

/// <summary>IPAllowList holds the IP allowlist middleware configuration. This middleware limits allowed requests based on the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecIpAllowList
{
    /// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
    [JsonPropertyName("ipStrategy")]
    public V1alpha1MiddlewareSpecIpAllowListIpStrategy? IpStrategy { get; set; }

    /// <summary>RejectStatusCode defines the HTTP status code used for refused requests. If not set, the default is 403 (Forbidden).</summary>
    [JsonPropertyName("rejectStatusCode")]
    public int? RejectStatusCode { get; set; }

    /// <summary>SourceRange defines the set of allowed IPs (or ranges of allowed IPs by using CIDR notation).</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecIpWhiteListIpStrategy
{
    /// <summary>Depth tells Traefik to use the X-Forwarded-For header and take the IP located at the depth position (starting from the right).</summary>
    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    /// <summary>ExcludedIPs configures Traefik to scan the X-Forwarded-For header and select the first IP not in the list.</summary>
    [JsonPropertyName("excludedIPs")]
    public IList<string>? ExcludedIPs { get; set; }

    /// <summary>IPv6Subnet configures Traefik to consider all IPv6 addresses from the defined subnet as originating from the same IP. Applies to RemoteAddrStrategy and DepthStrategy.</summary>
    [JsonPropertyName("ipv6Subnet")]
    public int? Ipv6Subnet { get; set; }
}

/// <summary>Deprecated: please use IPAllowList instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecIpWhiteList
{
    /// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
    [JsonPropertyName("ipStrategy")]
    public V1alpha1MiddlewareSpecIpWhiteListIpStrategy? IpStrategy { get; set; }

    /// <summary>SourceRange defines the set of allowed IPs (or ranges of allowed IPs by using CIDR notation). Required.</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>Issuer defines the client certificate issuer details to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecPassTLSClientCertInfoIssuer
{
    /// <summary>CommonName defines whether to add the organizationalUnit information into the issuer.</summary>
    [JsonPropertyName("commonName")]
    public bool? CommonName { get; set; }

    /// <summary>Country defines whether to add the country information into the issuer.</summary>
    [JsonPropertyName("country")]
    public bool? Country { get; set; }

    /// <summary>DomainComponent defines whether to add the domainComponent information into the issuer.</summary>
    [JsonPropertyName("domainComponent")]
    public bool? DomainComponent { get; set; }

    /// <summary>Locality defines whether to add the locality information into the issuer.</summary>
    [JsonPropertyName("locality")]
    public bool? Locality { get; set; }

    /// <summary>Organization defines whether to add the organization information into the issuer.</summary>
    [JsonPropertyName("organization")]
    public bool? Organization { get; set; }

    /// <summary>Province defines whether to add the province information into the issuer.</summary>
    [JsonPropertyName("province")]
    public bool? Province { get; set; }

    /// <summary>SerialNumber defines whether to add the serialNumber information into the issuer.</summary>
    [JsonPropertyName("serialNumber")]
    public bool? SerialNumber { get; set; }
}

/// <summary>Subject defines the client certificate subject details to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecPassTLSClientCertInfoSubject
{
    /// <summary>CommonName defines whether to add the organizationalUnit information into the subject.</summary>
    [JsonPropertyName("commonName")]
    public bool? CommonName { get; set; }

    /// <summary>Country defines whether to add the country information into the subject.</summary>
    [JsonPropertyName("country")]
    public bool? Country { get; set; }

    /// <summary>DomainComponent defines whether to add the domainComponent information into the subject.</summary>
    [JsonPropertyName("domainComponent")]
    public bool? DomainComponent { get; set; }

    /// <summary>Locality defines whether to add the locality information into the subject.</summary>
    [JsonPropertyName("locality")]
    public bool? Locality { get; set; }

    /// <summary>Organization defines whether to add the organization information into the subject.</summary>
    [JsonPropertyName("organization")]
    public bool? Organization { get; set; }

    /// <summary>OrganizationalUnit defines whether to add the organizationalUnit information into the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public bool? OrganizationalUnit { get; set; }

    /// <summary>Province defines whether to add the province information into the subject.</summary>
    [JsonPropertyName("province")]
    public bool? Province { get; set; }

    /// <summary>SerialNumber defines whether to add the serialNumber information into the subject.</summary>
    [JsonPropertyName("serialNumber")]
    public bool? SerialNumber { get; set; }
}

/// <summary>Info selects the specific client certificate details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecPassTLSClientCertInfo
{
    /// <summary>Issuer defines the client certificate issuer details to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
    [JsonPropertyName("issuer")]
    public V1alpha1MiddlewareSpecPassTLSClientCertInfoIssuer? Issuer { get; set; }

    /// <summary>NotAfter defines whether to add the Not After information from the Validity part.</summary>
    [JsonPropertyName("notAfter")]
    public bool? NotAfter { get; set; }

    /// <summary>NotBefore defines whether to add the Not Before information from the Validity part.</summary>
    [JsonPropertyName("notBefore")]
    public bool? NotBefore { get; set; }

    /// <summary>Sans defines whether to add the Subject Alternative Name information from the Subject Alternative Name part.</summary>
    [JsonPropertyName("sans")]
    public bool? Sans { get; set; }

    /// <summary>SerialNumber defines whether to add the client serialNumber information.</summary>
    [JsonPropertyName("serialNumber")]
    public bool? SerialNumber { get; set; }

    /// <summary>Subject defines the client certificate subject details to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
    [JsonPropertyName("subject")]
    public V1alpha1MiddlewareSpecPassTLSClientCertInfoSubject? Subject { get; set; }
}

/// <summary>PassTLSClientCert holds the pass TLS client cert middleware configuration. This middleware adds the selected data from the passed client TLS certificate to a header. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/passtlsclientcert/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecPassTLSClientCert
{
    /// <summary>Info selects the specific client certificate details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.</summary>
    [JsonPropertyName("info")]
    public V1alpha1MiddlewareSpecPassTLSClientCertInfo? Info { get; set; }

    /// <summary>PEM sets the X-Forwarded-Tls-Client-Cert header with the certificate.</summary>
    [JsonPropertyName("pem")]
    public bool? Pem { get; set; }
}

/// <summary>TLS defines TLS-specific configurations, including the CA, certificate, and key, which can be provided as a file path or file content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRateLimitRedisTls
{
    /// <summary>CASecret is the name of the referenced Kubernetes Secret containing the CA to validate the server certificate. The CA certificate is extracted from key `tls.ca` or `ca.crt`.</summary>
    [JsonPropertyName("caSecret")]
    public string? CaSecret { get; set; }

    /// <summary>CertSecret is the name of the referenced Kubernetes Secret containing the client certificate. The client certificate is extracted from the keys `tls.crt` and `tls.key`.</summary>
    [JsonPropertyName("certSecret")]
    public string? CertSecret { get; set; }

    /// <summary>InsecureSkipVerify defines whether the server certificates should be validated.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>Redis hold the configs of Redis as bucket in rate limiter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRateLimitRedis
{
    /// <summary>DB defines the Redis database that will be selected after connecting to the server.</summary>
    [JsonPropertyName("db")]
    public int? Db { get; set; }

    /// <summary>DialTimeout sets the timeout for establishing new connections. Default value is 5 seconds.</summary>
    [JsonPropertyName("dialTimeout")]
    public IntstrIntOrString? DialTimeout { get; set; }

    /// <summary>Endpoints contains either a single address or a seed list of host:port addresses. Default value is ["localhost:6379"].</summary>
    [JsonPropertyName("endpoints")]
    public IList<string>? Endpoints { get; set; }

    /// <summary>MaxActiveConns defines the maximum number of connections allocated by the pool at a given time. Default value is 0, meaning there is no limit.</summary>
    [JsonPropertyName("maxActiveConns")]
    public int? MaxActiveConns { get; set; }

    /// <summary>MinIdleConns defines the minimum number of idle connections. Default value is 0, and idle connections are not closed by default.</summary>
    [JsonPropertyName("minIdleConns")]
    public int? MinIdleConns { get; set; }

    /// <summary>PoolSize defines the initial number of socket connections. If the pool runs out of available connections, additional ones will be created beyond PoolSize. This can be limited using MaxActiveConns. // Default value is 0, meaning 10 connections per every available CPU as reported by runtime.GOMAXPROCS.</summary>
    [JsonPropertyName("poolSize")]
    public int? PoolSize { get; set; }

    /// <summary>ReadTimeout defines the timeout for socket read operations. Default value is 3 seconds.</summary>
    [JsonPropertyName("readTimeout")]
    public IntstrIntOrString? ReadTimeout { get; set; }

    /// <summary>Secret defines the name of the referenced Kubernetes Secret containing Redis credentials.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>TLS defines TLS-specific configurations, including the CA, certificate, and key, which can be provided as a file path or file content.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1MiddlewareSpecRateLimitRedisTls? Tls { get; set; }

    /// <summary>WriteTimeout defines the timeout for socket write operations. Default value is 3 seconds.</summary>
    [JsonPropertyName("writeTimeout")]
    public IntstrIntOrString? WriteTimeout { get; set; }
}

/// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRateLimitSourceCriterionIpStrategy
{
    /// <summary>Depth tells Traefik to use the X-Forwarded-For header and take the IP located at the depth position (starting from the right).</summary>
    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    /// <summary>ExcludedIPs configures Traefik to scan the X-Forwarded-For header and select the first IP not in the list.</summary>
    [JsonPropertyName("excludedIPs")]
    public IList<string>? ExcludedIPs { get; set; }

    /// <summary>IPv6Subnet configures Traefik to consider all IPv6 addresses from the defined subnet as originating from the same IP. Applies to RemoteAddrStrategy and DepthStrategy.</summary>
    [JsonPropertyName("ipv6Subnet")]
    public int? Ipv6Subnet { get; set; }
}

/// <summary>SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the request's remote address field (as an ipStrategy).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRateLimitSourceCriterion
{
    /// <summary>IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/#ipstrategy</summary>
    [JsonPropertyName("ipStrategy")]
    public V1alpha1MiddlewareSpecRateLimitSourceCriterionIpStrategy? IpStrategy { get; set; }

    /// <summary>RequestHeaderName defines the name of the header used to group incoming requests.</summary>
    [JsonPropertyName("requestHeaderName")]
    public string? RequestHeaderName { get; set; }

    /// <summary>RequestHost defines whether to consider the request Host as the source.</summary>
    [JsonPropertyName("requestHost")]
    public bool? RequestHost { get; set; }
}

/// <summary>RateLimit holds the rate limit configuration. This middleware ensures that services will receive a fair amount of requests, and allows one to define what fair is. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ratelimit/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRateLimit
{
    /// <summary>Average is the maximum rate, by default in requests/s, allowed for the given source. It defaults to 0, which means no rate limiting. The rate is actually defined by dividing Average by Period. So for a rate below 1req/s, one needs to define a Period larger than a second.</summary>
    [JsonPropertyName("average")]
    public long? Average { get; set; }

    /// <summary>Burst is the maximum number of requests allowed to arrive in the same arbitrarily small period of time. It defaults to 1.</summary>
    [JsonPropertyName("burst")]
    public long? Burst { get; set; }

    /// <summary>Period, in combination with Average, defines the actual maximum rate, such as: r = Average / Period. It defaults to a second.</summary>
    [JsonPropertyName("period")]
    public IntstrIntOrString? Period { get; set; }

    /// <summary>Redis hold the configs of Redis as bucket in rate limiter.</summary>
    [JsonPropertyName("redis")]
    public V1alpha1MiddlewareSpecRateLimitRedis? Redis { get; set; }

    /// <summary>SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the request's remote address field (as an ipStrategy).</summary>
    [JsonPropertyName("sourceCriterion")]
    public V1alpha1MiddlewareSpecRateLimitSourceCriterion? SourceCriterion { get; set; }
}

/// <summary>RedirectRegex holds the redirect regex middleware configuration. This middleware redirects a request using regex matching and replacement. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/redirectregex/#regex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRedirectRegex
{
    /// <summary>Permanent defines whether the redirection is permanent (308).</summary>
    [JsonPropertyName("permanent")]
    public bool? Permanent { get; set; }

    /// <summary>Regex defines the regex used to match and capture elements from the request URL.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement defines how to modify the URL to have the new target URL.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }
}

/// <summary>RedirectScheme holds the redirect scheme middleware configuration. This middleware redirects requests from a scheme/port to another. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/redirectscheme/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRedirectScheme
{
    /// <summary>Permanent defines whether the redirection is permanent (308).</summary>
    [JsonPropertyName("permanent")]
    public bool? Permanent { get; set; }

    /// <summary>Port defines the port of the new URL.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Scheme defines the scheme of the new URL.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>ReplacePath holds the replace path middleware configuration. This middleware replaces the path of the request URL and store the original path in an X-Replaced-Path header. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/replacepath/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecReplacePath
{
    /// <summary>Path defines the path to use as replacement in the request URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>ReplacePathRegex holds the replace path regex middleware configuration. This middleware replaces the path of a URL using regex matching and replacement. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/replacepathregex/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecReplacePathRegex
{
    /// <summary>Regex defines the regular expression used to match and capture the path from the request URL.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement defines the replacement path format, which can include captured variables.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }
}

/// <summary>Retry holds the retry middleware configuration. This middleware reissues requests a given number of times to a backend server if that server does not reply. As soon as the server answers, the middleware stops retrying, regardless of the response status. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/retry/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecRetry
{
    /// <summary>Attempts defines how many times the request should be retried.</summary>
    [JsonPropertyName("attempts")]
    public int? Attempts { get; set; }

    /// <summary>InitialInterval defines the first wait time in the exponential backoff series. The maximum interval is calculated as twice the initialInterval. If unspecified, requests will be retried immediately. The value of initialInterval should be provided in seconds or as a valid duration format, see https://pkg.go.dev/time#ParseDuration.</summary>
    [JsonPropertyName("initialInterval")]
    public IntstrIntOrString? InitialInterval { get; set; }
}

/// <summary>StripPrefix holds the strip prefix middleware configuration. This middleware removes the specified prefixes from the URL path. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/stripprefix/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecStripPrefix
{
    /// <summary>Deprecated: ForceSlash option is deprecated, please remove any usage of this option. ForceSlash ensures that the resulting stripped path is not the empty string, by replacing it with / when necessary. Default: true.</summary>
    [JsonPropertyName("forceSlash")]
    public bool? ForceSlash { get; set; }

    /// <summary>Prefixes defines the prefixes to strip from the request URL.</summary>
    [JsonPropertyName("prefixes")]
    public IList<string>? Prefixes { get; set; }
}

/// <summary>StripPrefixRegex holds the strip prefix regex middleware configuration. This middleware removes the matching prefixes from the URL path. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/stripprefixregex/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpecStripPrefixRegex
{
    /// <summary>Regex defines the regular expression to match the path prefix from the request URL.</summary>
    [JsonPropertyName("regex")]
    public IList<string>? Regex { get; set; }
}

/// <summary>MiddlewareSpec defines the desired state of a Middleware.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareSpec
{
    /// <summary>AddPrefix holds the add prefix middleware configuration. This middleware updates the path of a request before forwarding it. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/addprefix/</summary>
    [JsonPropertyName("addPrefix")]
    public V1alpha1MiddlewareSpecAddPrefix? AddPrefix { get; set; }

    /// <summary>BasicAuth holds the basic auth middleware configuration. This middleware restricts access to your services to known users. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/basicauth/</summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1MiddlewareSpecBasicAuth? BasicAuth { get; set; }

    /// <summary>Buffering holds the buffering middleware configuration. This middleware retries or limits the size of requests that can be forwarded to backends. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/buffering/#maxrequestbodybytes</summary>
    [JsonPropertyName("buffering")]
    public V1alpha1MiddlewareSpecBuffering? Buffering { get; set; }

    /// <summary>Chain holds the configuration of the chain middleware. This middleware enables to define reusable combinations of other pieces of middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/chain/</summary>
    [JsonPropertyName("chain")]
    public V1alpha1MiddlewareSpecChain? Chain { get; set; }

    /// <summary>CircuitBreaker holds the circuit breaker configuration.</summary>
    [JsonPropertyName("circuitBreaker")]
    public V1alpha1MiddlewareSpecCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>Compress holds the compress middleware configuration. This middleware compresses responses before sending them to the client, using gzip, brotli, or zstd compression. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/compress/</summary>
    [JsonPropertyName("compress")]
    public V1alpha1MiddlewareSpecCompress? Compress { get; set; }

    /// <summary>ContentType holds the content-type middleware configuration. This middleware exists to enable the correct behavior until at least the default one can be changed in a future version.</summary>
    [JsonPropertyName("contentType")]
    public V1alpha1MiddlewareSpecContentType? ContentType { get; set; }

    /// <summary>DigestAuth holds the digest auth middleware configuration. This middleware restricts access to your services to known users. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/digestauth/</summary>
    [JsonPropertyName("digestAuth")]
    public V1alpha1MiddlewareSpecDigestAuth? DigestAuth { get; set; }

    /// <summary>ErrorPage holds the custom error middleware configuration. This middleware returns a custom page in lieu of the default, according to configured ranges of HTTP Status codes. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/errorpages/</summary>
    [JsonPropertyName("errors")]
    public V1alpha1MiddlewareSpecErrors? Errors { get; set; }

    /// <summary>ForwardAuth holds the forward auth middleware configuration. This middleware delegates the request authentication to a Service. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/forwardauth/</summary>
    [JsonPropertyName("forwardAuth")]
    public V1alpha1MiddlewareSpecForwardAuth? ForwardAuth { get; set; }

    /// <summary>GrpcWeb holds the gRPC web middleware configuration. This middleware converts a gRPC web request to an HTTP/2 gRPC request.</summary>
    [JsonPropertyName("grpcWeb")]
    public V1alpha1MiddlewareSpecGrpcWeb? GrpcWeb { get; set; }

    /// <summary>Headers holds the headers middleware configuration. This middleware manages the requests and responses headers. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/headers/#customrequestheaders</summary>
    [JsonPropertyName("headers")]
    public V1alpha1MiddlewareSpecHeaders? Headers { get; set; }

    /// <summary>InFlightReq holds the in-flight request middleware configuration. This middleware limits the number of requests being processed and served concurrently. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/inflightreq/</summary>
    [JsonPropertyName("inFlightReq")]
    public V1alpha1MiddlewareSpecInFlightReq? InFlightReq { get; set; }

    /// <summary>IPAllowList holds the IP allowlist middleware configuration. This middleware limits allowed requests based on the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ipallowlist/</summary>
    [JsonPropertyName("ipAllowList")]
    public V1alpha1MiddlewareSpecIpAllowList? IpAllowList { get; set; }

    /// <summary>Deprecated: please use IPAllowList instead.</summary>
    [JsonPropertyName("ipWhiteList")]
    public V1alpha1MiddlewareSpecIpWhiteList? IpWhiteList { get; set; }

    /// <summary>PassTLSClientCert holds the pass TLS client cert middleware configuration. This middleware adds the selected data from the passed client TLS certificate to a header. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/passtlsclientcert/</summary>
    [JsonPropertyName("passTLSClientCert")]
    public V1alpha1MiddlewareSpecPassTLSClientCert? PassTLSClientCert { get; set; }

    /// <summary>Plugin defines the middleware plugin configuration. More info: https://doc.traefik.io/traefik/plugins/</summary>
    [JsonPropertyName("plugin")]
    public IDictionary<string, JsonNode>? Plugin { get; set; }

    /// <summary>RateLimit holds the rate limit configuration. This middleware ensures that services will receive a fair amount of requests, and allows one to define what fair is. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/ratelimit/</summary>
    [JsonPropertyName("rateLimit")]
    public V1alpha1MiddlewareSpecRateLimit? RateLimit { get; set; }

    /// <summary>RedirectRegex holds the redirect regex middleware configuration. This middleware redirects a request using regex matching and replacement. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/redirectregex/#regex</summary>
    [JsonPropertyName("redirectRegex")]
    public V1alpha1MiddlewareSpecRedirectRegex? RedirectRegex { get; set; }

    /// <summary>RedirectScheme holds the redirect scheme middleware configuration. This middleware redirects requests from a scheme/port to another. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/redirectscheme/</summary>
    [JsonPropertyName("redirectScheme")]
    public V1alpha1MiddlewareSpecRedirectScheme? RedirectScheme { get; set; }

    /// <summary>ReplacePath holds the replace path middleware configuration. This middleware replaces the path of the request URL and store the original path in an X-Replaced-Path header. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/replacepath/</summary>
    [JsonPropertyName("replacePath")]
    public V1alpha1MiddlewareSpecReplacePath? ReplacePath { get; set; }

    /// <summary>ReplacePathRegex holds the replace path regex middleware configuration. This middleware replaces the path of a URL using regex matching and replacement. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/replacepathregex/</summary>
    [JsonPropertyName("replacePathRegex")]
    public V1alpha1MiddlewareSpecReplacePathRegex? ReplacePathRegex { get; set; }

    /// <summary>Retry holds the retry middleware configuration. This middleware reissues requests a given number of times to a backend server if that server does not reply. As soon as the server answers, the middleware stops retrying, regardless of the response status. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/retry/</summary>
    [JsonPropertyName("retry")]
    public V1alpha1MiddlewareSpecRetry? Retry { get; set; }

    /// <summary>StripPrefix holds the strip prefix middleware configuration. This middleware removes the specified prefixes from the URL path. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/stripprefix/</summary>
    [JsonPropertyName("stripPrefix")]
    public V1alpha1MiddlewareSpecStripPrefix? StripPrefix { get; set; }

    /// <summary>StripPrefixRegex holds the strip prefix regex middleware configuration. This middleware removes the matching prefixes from the URL path. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/stripprefixregex/</summary>
    [JsonPropertyName("stripPrefixRegex")]
    public V1alpha1MiddlewareSpecStripPrefixRegex? StripPrefixRegex { get; set; }
}

/// <summary>Middleware is the CRD implementation of a Traefik Middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/http/overview/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Middleware : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MiddlewareSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Middleware";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewares";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MiddlewareSpec defines the desired state of a Middleware.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MiddlewareSpec Spec { get; set; }
}