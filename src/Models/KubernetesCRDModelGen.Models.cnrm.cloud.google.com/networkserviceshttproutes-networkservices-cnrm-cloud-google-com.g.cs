using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecGateways
{
    /// <summary>Allowed value: The `selfLink` field of a `NetworkServicesGateway` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecMeshes
{
    /// <summary>Allowed value: The `selfLink` field of a `NetworkServicesMesh` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The specification for allowing client side cross-origin requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionCorsPolicy
{
    /// <summary>In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This translates to the Access-Control-Allow-Credentials header. Default value is false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Specifies the regular expression patterns that match allowed origins. For regular expression grammar, please see https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches either an item in allow_origins or an item in allow_origin_regexes.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long result of a preflight request can be cached in seconds. This translates to the Access-Control-Max-Age header.</summary>
    [JsonPropertyName("maxAge")]
    public string? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionDestinationsServiceRef
{
    /// <summary>The URL of a BackendService to route traffic to.  Allowed value: The Google Cloud resource name of a `ComputeBackendService` resource (format: `projects/{{project}}/global/backendServices/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionDestinations
{
    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public NetworkServicesHTTPRouteSpecRulesActionDestinationsServiceRef? ServiceRef { get; set; }

    /// <summary>Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports. If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend. If weights are specified for any one service name, they need to be specified for all of them. If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.</summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>The specification for aborting to client requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public long? HttpStatus { get; set; }

    /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
    [JsonPropertyName("percentage")]
    public long? Percentage { get; set; }
}

/// <summary>The specification for injecting delay to client requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicyDelay
{
    /// <summary>Specify a fixed delay before forwarding the request.</summary>
    [JsonPropertyName("fixedDelay")]
    public string? FixedDelay { get; set; }

    /// <summary>The percentage of traffic on which delay will be injected. The value must be between [0, 100]</summary>
    [JsonPropertyName("percentage")]
    public long? Percentage { get; set; }
}

/// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicy
{
    /// <summary>The specification for aborting to client requests.</summary>
    [JsonPropertyName("abort")]
    public NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for injecting delay to client requests.</summary>
    [JsonPropertyName("delay")]
    public NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>If set, the request is directed as configured by this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request. The default is set to false.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>The path that will be used in the redirect response instead of the one that was supplied in the request. path_redirect can not be supplied together with prefix_redirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.</summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>The port that will be used in the redirected request instead of the one that was supplied in the request.</summary>
    [JsonPropertyName("portRedirect")]
    public long? PortRedirect { get; set; }

    /// <summary>Indicates that during redirection, the matched prefix (or path) should be swapped with this value. This option allows URLs be dynamically created based on the request.</summary>
    [JsonPropertyName("prefixRewrite")]
    public string? PrefixRewrite { get; set; }

    /// <summary>The HTTP Status code to use for the redirect. Possible values: MOVED_PERMANENTLY_DEFAULT, FOUND, SEE_OTHER, TEMPORARY_REDIRECT, PERMANENT_REDIRECT</summary>
    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; set; }

    /// <summary>if set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default is set to false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary>The specification for modifying the headers of a matching request prior to delivery of the request to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRequestHeaderModifier
{
    /// <summary>Add the headers with given map where key is the name of the header, value is the value of the header.</summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary>Remove headers (matching by header names) specified in the list.</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Completely overwrite/replace the headers with given map where key is the name of the header, value is the value of the header.</summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicyDestinationServiceRef
{
    /// <summary>The URL of a BackendService to route traffic to.  Allowed value: The Google Cloud resource name of a `ComputeBackendService` resource (format: `projects/{{project}}/global/backendServices/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The destination the requests will be mirrored to. The weight of the destination will be ignored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicyDestination
{
    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicyDestinationServiceRef? ServiceRef { get; set; }

    /// <summary>Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports. If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend. If weights are specified for any one service name, they need to be specified for all of them. If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.</summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>Specifies the policy on how requests intended for the routes destination are shadowed to a separate mirrored destination. Proxy will not wait for the shadow destination to respond before returning the response. Prior to sending traffic to the shadow service, the host/authority header is suffixed with -shadow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicy
{
    /// <summary>The destination the requests will be mirrored to. The weight of the destination will be ignored.</summary>
    [JsonPropertyName("destination")]
    public NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicyDestination? Destination { get; set; }
}

/// <summary>The specification for modifying the headers of a response prior to sending the response back to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionResponseHeaderModifier
{
    /// <summary>Add the headers with given map where key is the name of the header, value is the value of the header.</summary>
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    /// <summary>Remove headers (matching by header names) specified in the list.</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Completely overwrite/replace the headers with given map where key is the name of the header, value is the value of the header.</summary>
    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

/// <summary>Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionRetryPolicy
{
    /// <summary>Specifies the allowed number of retries. This number must be &gt; 0. If not specified, default to 1.</summary>
    [JsonPropertyName("numRetries")]
    public long? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt.</summary>
    [JsonPropertyName("perTryTimeout")]
    public string? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry policy applies. Valid values are: 5xx: Proxy will attempt a retry if the destination service responds with any 5xx response code, of if the destination service does not respond at all, example: disconnect, reset, read timeout, connection failure and refused streams. gateway-error: Similar to 5xx, but only applies to response codes 502, 503, 504. reset: Proxy will attempt a retry if the destination service does not respond at all (disconnect/reset/read timeout) connect-failure: Proxy will retry on failures connecting to destination for example due to connection timeouts. retriable-4xx: Proxy will retry fro retriable 4xx response codes. Currently the only retriable error supported is 409. refused-stream: Proxy will retry if the destination resets the stream with a REFUSED_STREAM error code. This reset type indicates that it is safe to retry.</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>The specification for rewrite URL before forwarding requests to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected destination, the requests host header is replaced by this value.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected destination, the matching portion of the requests path is replaced by this value.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>The detailed rule defining how to route matched traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesAction
{
    /// <summary>The specification for allowing client side cross-origin requests.</summary>
    [JsonPropertyName("corsPolicy")]
    public NetworkServicesHTTPRouteSpecRulesActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The destination to which traffic should be forwarded.</summary>
    [JsonPropertyName("destinations")]
    public IList<NetworkServicesHTTPRouteSpecRulesActionDestinations>? Destinations { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public NetworkServicesHTTPRouteSpecRulesActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>If set, the request is directed as configured by this field.</summary>
    [JsonPropertyName("redirect")]
    public NetworkServicesHTTPRouteSpecRulesActionRedirect? Redirect { get; set; }

    /// <summary>The specification for modifying the headers of a matching request prior to delivery of the request to the destination.</summary>
    [JsonPropertyName("requestHeaderModifier")]
    public NetworkServicesHTTPRouteSpecRulesActionRequestHeaderModifier? RequestHeaderModifier { get; set; }

    /// <summary>Specifies the policy on how requests intended for the routes destination are shadowed to a separate mirrored destination. Proxy will not wait for the shadow destination to respond before returning the response. Prior to sending traffic to the shadow service, the host/authority header is suffixed with -shadow.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public NetworkServicesHTTPRouteSpecRulesActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>The specification for modifying the headers of a response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeaderModifier")]
    public NetworkServicesHTTPRouteSpecRulesActionResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public NetworkServicesHTTPRouteSpecRulesActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for selected route. Timeout is computed from the time the request has been fully processed (i.e. end of stream) up until the response has been completely processed. Timeout includes all retries.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>The specification for rewrite URL before forwarding requests to the destination.</summary>
    [JsonPropertyName("urlRewrite")]
    public NetworkServicesHTTPRouteSpecRulesActionUrlRewrite? UrlRewrite { get; set; }
}

/// <summary>If specified, the rule will match if the request header value is within the range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesMatchesHeadersRangeMatch
{
    /// <summary>End of the range (exclusive)</summary>
    [JsonPropertyName("end")]
    public long? End { get; set; }

    /// <summary>Start of the range (inclusive)</summary>
    [JsonPropertyName("start")]
    public long? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesMatchesHeaders
{
    /// <summary>The value of the header should match exactly the content of exact_match.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the HTTP header to match against.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>If specified, the match result will be inverted before checking. Default value is set to false.</summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>The value of the header must start with the contents of prefix_match.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>A header with header_name must exist. The match takes place whether or not the header has a value.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>If specified, the rule will match if the request header value is within the range.</summary>
    [JsonPropertyName("rangeMatch")]
    public NetworkServicesHTTPRouteSpecRulesMatchesHeadersRangeMatch? RangeMatch { get; set; }

    /// <summary>The value of the header must match the regular expression specified in regex_match. For regular expression grammar, please see: https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffix_match.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesMatchesQueryParameters
{
    /// <summary>The value of the query parameter must exactly match the contents of exact_match. Only one of exact_match, regex_match, or present_match must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>Specifies that the QueryParameterMatcher matches if request contains query parameter, irrespective of whether the parameter has a value or not. Only one of exact_match, regex_match, or present_match must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The name of the query parameter to match.</summary>
    [JsonPropertyName("queryParameter")]
    public string? QueryParameter { get; set; }

    /// <summary>The value of the query parameter must match the regular expression specified by regex_match. For regular expression grammar, please see https://github.com/google/re2/wiki/Syntax Only one of exact_match, regex_match, or present_match must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRulesMatches
{
    /// <summary>The HTTP request path value should exactly match this value. Only one of full_path_match, prefix_match, or regex_match should be used.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of HTTP request headers to match against. ALL of the supplied headers must be matched.</summary>
    [JsonPropertyName("headers")]
    public IList<NetworkServicesHTTPRouteSpecRulesMatchesHeaders>? Headers { get; set; }

    /// <summary>Specifies if prefix_match and full_path_match matches are case sensitive. The default value is false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>The HTTP request path value must begin with specified prefix_match. prefix_match must begin with a /. Only one of full_path_match, prefix_match, or regex_match should be used.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameters to match against. ALL of the query parameters must be matched.</summary>
    [JsonPropertyName("queryParameters")]
    public IList<NetworkServicesHTTPRouteSpecRulesMatchesQueryParameters>? QueryParameters { get; set; }

    /// <summary>The HTTP request path value must satisfy the regular expression specified by regex_match after removing any query parameters and anchor supplied with the original URL. For regular expression grammar, please see https://github.com/google/re2/wiki/Syntax Only one of full_path_match, prefix_match, or regex_match should be used.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpecRules
{
    /// <summary>The detailed rule defining how to route matched traffic.</summary>
    [JsonPropertyName("action")]
    public NetworkServicesHTTPRouteSpecRulesAction? Action { get; set; }

    /// <summary>A list of matches define conditions used for matching the rule against incoming HTTP requests. Each match is independent, i.e. this rule will be matched if ANY one of the matches is satisfied.</summary>
    [JsonPropertyName("matches")]
    public IList<NetworkServicesHTTPRouteSpecRulesMatches>? Matches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteSpec
{
    /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gateways")]
    public IList<NetworkServicesHTTPRouteSpecGateways>? Gateways { get; set; }

    /// <summary>Required. Hostnames define a set of hosts that should match against the HTTP host header to select a HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined by RFC 1123 with the exception that ip addresses are not allowed. Wildcard hosts are supported as "*" (no prefix or suffix allowed).</summary>
    [JsonPropertyName("hostnames")]
    public IList<string> Hostnames { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("meshes")]
    public IList<NetworkServicesHTTPRouteSpecMeshes>? Meshes { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public NetworkServicesHTTPRouteSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Rules that define how traffic is routed and handled.</summary>
    [JsonPropertyName("rules")]
    public IList<NetworkServicesHTTPRouteSpecRules> Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRouteStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<NetworkServicesHTTPRouteStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Server-defined URL of this resource</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesHTTPRoute
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public NetworkServicesHTTPRouteMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public NetworkServicesHTTPRouteSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public NetworkServicesHTTPRouteStatus? Status { get; set; }
}