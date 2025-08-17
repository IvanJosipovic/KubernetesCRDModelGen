using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VirtualServiceList : IKubernetesObject<V1ListMeta>, IItems<V1VirtualService>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VirtualServiceList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "virtualservices";
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
    public IList<V1VirtualService> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpCorsPolicyAllowOrigins
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cross-Origin Resource Sharing policy (CORS).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpCorsPolicy
{
    /// <summary>Indicates whether the caller is allowed to send the actual request (not the preflight) using credentials.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>List of HTTP headers that can be used when requesting the resource.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>List of HTTP methods allowed to access the resource.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowOrigin")]
    public IList<string>? AllowOrigin { get; set; }

    /// <summary>String patterns that match allowed origins.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<V1VirtualServiceSpecHttpCorsPolicyAllowOrigins>? AllowOrigins { get; set; }

    /// <summary>A list of HTTP headers that the browsers are allowed to access.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached.</summary>
    [JsonPropertyName("maxAge")]
    public string? MaxAge { get; set; }

    /// <summary>Indicates whether preflight requests not matching the configured allowed origin shouldn't be forwarded to the upstream.  Valid Options: FORWARD, IGNORE</summary>
    [JsonPropertyName("unmatchedPreflights")]
    public string? UnmatchedPreflights { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Delegate is used to specify the particular VirtualService which can be used to define delegate HTTPRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpDelegate
{
    /// <summary>Name specifies the name of the delegate VirtualService.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace where the delegate VirtualService resides.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the content of the response body.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpDirectResponseBody
{
    /// <summary>response body as base64 encoded bytes.</summary>
    [JsonPropertyName("bytes")]
    public string? Bytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpDirectResponse
{
    /// <summary>Specifies the content of the response body.</summary>
    [JsonPropertyName("body")]
    public V1VirtualServiceSpecHttpDirectResponseBody? Body { get; set; }

    /// <summary>Specifies the HTTP response status to be returned.</summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Percentage of requests to be aborted with the error code provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpFaultAbortPercentage
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Abort Http request attempts and return error codes back to downstream service, giving the impression that the upstream service is faulty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpFaultAbort
{
    /// <summary>GRPC status code to use to abort the request.</summary>
    [JsonPropertyName("grpcStatus")]
    public string? GrpcStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http2Error")]
    public string? Http2Error { get; set; }

    /// <summary>HTTP status code to use to abort the Http request.</summary>
    [JsonPropertyName("httpStatus")]
    public int? HttpStatus { get; set; }

    /// <summary>Percentage of requests to be aborted with the error code provided.</summary>
    [JsonPropertyName("percentage")]
    public V1VirtualServiceSpecHttpFaultAbortPercentage? Percentage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Percentage of requests on which the delay will be injected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpFaultDelayPercentage
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Delay requests before forwarding, emulating various failures such as network issues, overloaded upstream service, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpFaultDelay
{
    /// <summary></summary>
    [JsonPropertyName("exponentialDelay")]
    public string? ExponentialDelay { get; set; }

    /// <summary>Add a fixed delay before forwarding the request.</summary>
    [JsonPropertyName("fixedDelay")]
    public string? FixedDelay { get; set; }

    /// <summary>Percentage of requests on which the delay will be injected (0-100).</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Percentage of requests on which the delay will be injected.</summary>
    [JsonPropertyName("percentage")]
    public V1VirtualServiceSpecHttpFaultDelayPercentage? Percentage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fault injection policy to apply on HTTP traffic at the client side.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpFault
{
    /// <summary>Abort Http request attempts and return error codes back to downstream service, giving the impression that the upstream service is faulty.</summary>
    [JsonPropertyName("abort")]
    public V1VirtualServiceSpecHttpFaultAbort? Abort { get; set; }

    /// <summary>Delay requests before forwarding, emulating various failures such as network issues, overloaded upstream service, etc.</summary>
    [JsonPropertyName("delay")]
    public V1VirtualServiceSpecHttpFaultDelay? Delay { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpHeadersRequest
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary></summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpHeadersResponse
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary></summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("request")]
    public V1VirtualServiceSpecHttpHeadersRequest? Request { get; set; }

    /// <summary></summary>
    [JsonPropertyName("response")]
    public V1VirtualServiceSpecHttpHeadersResponse? Response { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP Authority values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchAuthority
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchHeaders
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP Method values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchMethod
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchQueryParams
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>URI Scheme values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchScheme
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>URI to match values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchUri
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatchWithoutHeaders
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMatch
{
    /// <summary>HTTP Authority values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("authority")]
    public V1VirtualServiceSpecHttpMatchAuthority? Authority { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>The header keys must be lowercase and use hyphen as the separator, e.g.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, V1VirtualServiceSpecHttpMatchHeaders>? Headers { get; set; }

    /// <summary>Flag to specify whether the URI matching should be case-insensitive.</summary>
    [JsonPropertyName("ignoreUriCase")]
    public bool? IgnoreUriCase { get; set; }

    /// <summary>HTTP Method values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("method")]
    public V1VirtualServiceSpecHttpMatchMethod? Method { get; set; }

    /// <summary>The name assigned to a match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the ports on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Query parameters for matching.</summary>
    [JsonPropertyName("queryParams")]
    public IDictionary<string, V1VirtualServiceSpecHttpMatchQueryParams>? QueryParams { get; set; }

    /// <summary>URI Scheme values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("scheme")]
    public V1VirtualServiceSpecHttpMatchScheme? Scheme { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to source (client) workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }

    /// <summary>The human readable prefix to use when emitting statistics for this route.</summary>
    [JsonPropertyName("statPrefix")]
    public string? StatPrefix { get; set; }

    /// <summary>URI to match values are case-sensitive and formatted as follows: - `exact: "value"` for exact string match - `prefix: "value"` for prefix-based match - `regex: "value"` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("uri")]
    public V1VirtualServiceSpecHttpMatchUri? Uri { get; set; }

    /// <summary>withoutHeader has the same syntax with the header, but has opposite meaning.</summary>
    [JsonPropertyName("withoutHeaders")]
    public IDictionary<string, V1VirtualServiceSpecHttpMatchWithoutHeaders>? WithoutHeaders { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrorPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Mirror HTTP traffic to a another destination in addition to forwarding the requests to the intended destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirror
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1VirtualServiceSpecHttpMirrorPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Percentage of the traffic to be mirrored by the `mirror` field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrorPercentage
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrorsDestinationPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Destination specifies the target of the mirror operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrorsDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1VirtualServiceSpecHttpMirrorsDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Percentage of the traffic to be mirrored by the `destination` field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrorsPercentage
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpMirrors
{
    /// <summary>Destination specifies the target of the mirror operation.</summary>
    [JsonPropertyName("destination")]
    public V1VirtualServiceSpecHttpMirrorsDestination Destination { get; set; }

    /// <summary>Percentage of the traffic to be mirrored by the `destination` field.</summary>
    [JsonPropertyName("percentage")]
    public V1VirtualServiceSpecHttpMirrorsPercentage? Percentage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRedirect
{
    /// <summary>On a redirect, overwrite the Authority/Host portion of the URL with this value.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>On a redirect, dynamically set the port: * FROM_PROTOCOL_DEFAULT: automatically set to 80 for HTTP and 443 for HTTPS.  Valid Options: FROM_PROTOCOL_DEFAULT, FROM_REQUEST_PORT</summary>
    [JsonPropertyName("derivePort")]
    public string? DerivePort { get; set; }

    /// <summary>On a redirect, overwrite the port portion of the URL with this value.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>On a redirect, Specifies the HTTP status code to use in the redirect response.</summary>
    [JsonPropertyName("redirectCode")]
    public int? RedirectCode { get; set; }

    /// <summary>On a redirect, overwrite the scheme portion of the URL with this value.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>On a redirect, overwrite the Path portion of the URL with this value.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy for HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRetries
{
    /// <summary>Number of retries to be allowed for a given request.</summary>
    [JsonPropertyName("attempts")]
    public int? Attempts { get; set; }

    /// <summary>Specifies the minimum duration between retry attempts.</summary>
    [JsonPropertyName("backoff")]
    public string? Backoff { get; set; }

    /// <summary>Timeout per attempt for a given request, including the initial call and any retries.</summary>
    [JsonPropertyName("perTryTimeout")]
    public string? PerTryTimeout { get; set; }

    /// <summary>Flag to specify whether the retries should ignore previously tried hosts during retry.</summary>
    [JsonPropertyName("retryIgnorePreviousHosts")]
    public bool? RetryIgnorePreviousHosts { get; set; }

    /// <summary>Specifies the conditions under which retry takes place.</summary>
    [JsonPropertyName("retryOn")]
    public string? RetryOn { get; set; }

    /// <summary>Flag to specify whether the retries should retry to other localities.</summary>
    [JsonPropertyName("retryRemoteLocalities")]
    public bool? RetryRemoteLocalities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>rewrite the path portion of the URI with the specified regex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRewriteUriRegexRewrite
{
    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>The string that should replace into matching portions of original URI.</summary>
    [JsonPropertyName("rewrite")]
    public string? Rewrite { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Rewrite HTTP URIs and Authority headers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRewrite
{
    /// <summary>rewrite the Authority/Host header with this value.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>rewrite the path (or the prefix) portion of the URI with this value.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>rewrite the path portion of the URI with the specified regex.</summary>
    [JsonPropertyName("uriRegexRewrite")]
    public V1VirtualServiceSpecHttpRewriteUriRegexRewrite? UriRegexRewrite { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRouteDestinationPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1VirtualServiceSpecHttpRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRouteHeadersRequest
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary></summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRouteHeadersResponse
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary></summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRouteHeaders
{
    /// <summary></summary>
    [JsonPropertyName("request")]
    public V1VirtualServiceSpecHttpRouteHeadersRequest? Request { get; set; }

    /// <summary></summary>
    [JsonPropertyName("response")]
    public V1VirtualServiceSpecHttpRouteHeadersResponse? Response { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttpRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public V1VirtualServiceSpecHttpRouteDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public V1VirtualServiceSpecHttpRouteHeaders? Headers { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecHttp
{
    /// <summary>Cross-Origin Resource Sharing policy (CORS).</summary>
    [JsonPropertyName("corsPolicy")]
    public V1VirtualServiceSpecHttpCorsPolicy? CorsPolicy { get; set; }

    /// <summary>Delegate is used to specify the particular VirtualService which can be used to define delegate HTTPRoute.</summary>
    [JsonPropertyName("delegate")]
    public V1VirtualServiceSpecHttpDelegate? Delegate { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("directResponse")]
    public V1VirtualServiceSpecHttpDirectResponse? DirectResponse { get; set; }

    /// <summary>Fault injection policy to apply on HTTP traffic at the client side.</summary>
    [JsonPropertyName("fault")]
    public V1VirtualServiceSpecHttpFault? Fault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public V1VirtualServiceSpecHttpHeaders? Headers { get; set; }

    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public IList<V1VirtualServiceSpecHttpMatch>? Match { get; set; }

    /// <summary>Mirror HTTP traffic to a another destination in addition to forwarding the requests to the intended destination.</summary>
    [JsonPropertyName("mirror")]
    public V1VirtualServiceSpecHttpMirror? Mirror { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mirror_percent")]
    public int? MirrorPercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mirrorPercent1")]
    public int? MirrorPercent1 { get; set; }

    /// <summary>Percentage of the traffic to be mirrored by the `mirror` field.</summary>
    [JsonPropertyName("mirrorPercentage")]
    public V1VirtualServiceSpecHttpMirrorPercentage? MirrorPercentage { get; set; }

    /// <summary>Specifies the destinations to mirror HTTP traffic in addition to the original destination.</summary>
    [JsonPropertyName("mirrors")]
    public IList<V1VirtualServiceSpecHttpMirrors>? Mirrors { get; set; }

    /// <summary>The name assigned to the route for debugging purposes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("redirect")]
    public V1VirtualServiceSpecHttpRedirect? Redirect { get; set; }

    /// <summary>Retry policy for HTTP requests.</summary>
    [JsonPropertyName("retries")]
    public V1VirtualServiceSpecHttpRetries? Retries { get; set; }

    /// <summary>Rewrite HTTP URIs and Authority headers.</summary>
    [JsonPropertyName("rewrite")]
    public V1VirtualServiceSpecHttpRewrite? Rewrite { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("route")]
    public IList<V1VirtualServiceSpecHttpRoute>? Route { get; set; }

    /// <summary>Timeout for HTTP requests, default is disabled.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTcpMatch
{
    /// <summary>IPv4 or IPv6 ip addresses of destination with optional subnet.</summary>
    [JsonPropertyName("destinationSubnets")]
    public IList<string>? DestinationSubnets { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceSubnet")]
    public string? SourceSubnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTcpRouteDestinationPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTcpRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1VirtualServiceSpecTcpRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTcpRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public V1VirtualServiceSpecTcpRouteDestination Destination { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTcp
{
    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public IList<V1VirtualServiceSpecTcpMatch>? Match { get; set; }

    /// <summary>The destination to which the connection should be forwarded to.</summary>
    [JsonPropertyName("route")]
    public IList<V1VirtualServiceSpecTcpRoute>? Route { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTlsMatch
{
    /// <summary>IPv4 or IPv6 ip addresses of destination with optional subnet.</summary>
    [JsonPropertyName("destinationSubnets")]
    public IList<string>? DestinationSubnets { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SNI (server name indicator) to match on.</summary>
    [JsonPropertyName("sniHosts")]
    public IList<string> SniHosts { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTlsRouteDestinationPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTlsRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1VirtualServiceSpecTlsRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTlsRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public V1VirtualServiceSpecTlsRouteDestination Destination { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpecTls
{
    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public IList<V1VirtualServiceSpecTlsMatch> Match { get; set; }

    /// <summary>The destination to which the connection should be forwarded to.</summary>
    [JsonPropertyName("route")]
    public IList<V1VirtualServiceSpecTlsRoute>? Route { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration affecting label/content routing, sni routing, etc. See more details at: https://istio.io/docs/reference/config/networking/virtual-service.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VirtualServiceSpec
{
    /// <summary>A list of namespaces to which this virtual service is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The names of gateways and sidecars that should apply these routes.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>The destination hosts to which traffic is being sent.</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>An ordered list of route rules for HTTP traffic.</summary>
    [JsonPropertyName("http")]
    public IList<V1VirtualServiceSpecHttp>? Http { get; set; }

    /// <summary>An ordered list of route rules for opaque TCP traffic.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1VirtualServiceSpecTcp>? Tcp { get; set; }

    /// <summary>An ordered list of route rule for non-terminated TLS &amp; HTTPS traffic.</summary>
    [JsonPropertyName("tls")]
    public IList<V1VirtualServiceSpecTls>? Tls { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VirtualService : IKubernetesObject<V1ObjectMeta>, ISpec<V1VirtualServiceSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VirtualService";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "virtualservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting label/content routing, sni routing, etc. See more details at: https://istio.io/docs/reference/config/networking/virtual-service.html</summary>
    [JsonPropertyName("spec")]
    public V1VirtualServiceSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}
#nullable disable
