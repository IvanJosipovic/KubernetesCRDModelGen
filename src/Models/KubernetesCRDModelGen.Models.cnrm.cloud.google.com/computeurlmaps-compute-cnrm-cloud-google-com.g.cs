using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>The specification for allowing client side cross-origin requests. Please see [W3C Recommendation for Cross Origin Resource Sharing](https://www.w3.org/TR/cors/).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionCorsPolicy
{
    /// <summary>In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This field translates to the Access-Control-Allow-Credentials header. Default is false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Specifies the regualar expression patterns that match allowed origins. For regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.</summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, the setting specifies the CORS policy is disabled. The default value of false, which indicates that the CORS policy is in effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long results of a preflight request can be cached in seconds. This translates to the Access-Control-Max-Age header.</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public int? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>Specifies the value of the fixed delay interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval.</summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by a load balancer on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted by the load balancer for a percentage of requests. timeout and retryPolicy is ignored by clients that are configured with a faultInjectionPolicy if: 1. The traffic is generated by fault injection AND 2. The fault injection is not a delay fault injection. Fault injection is not supported with the global external HTTP(S) load balancer (classic). To see which load balancers support fault injection, see Load balancing: [Routing and traffic management features](https://cloud.google.com/load-balancing/docs/features#routing-traffic-management).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
    [JsonPropertyName("abort")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
    [JsonPropertyName("delay")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>The backend service resource being mirrored to. The backend service configured for a mirroring policy must reference backends that are of the same type as the original backend service matched in the URL map. Serverless NEG backends are not currently supported as a mirrored backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. The load balancer does not wait for responses from the shadow service. Before sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The backend service resource being mirrored to. The backend service configured for a mirroring policy must reference backends that are of the same type as the original backend service matched in the URL map. Serverless NEG backends are not currently supported as a mirrored backend service.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }
}

/// <summary>Specifies a non-zero timeout per retry attempt.  If not specified, will use the timeout set in HttpRouteAction. If timeout in HttpRouteAction is not set, will use the largest timeout among all backend services associated with the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0. If not specified, defaults to 1.</summary>
    [JsonPropertyName("numRetries")]
    public int? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt.  If not specified, will use the timeout set in HttpRouteAction. If timeout in HttpRouteAction is not set, will use the largest timeout among all backend services associated with the route.</summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry policy applies. Valid values are listed below. Only the following codes are supported when the URL map is bound to target gRPC proxy that has validateForProxyless field set to true: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.   - 5xx : retry is attempted if the instance or endpoint responds with any 5xx response code, or if the instance or endpoint does not respond at all. For example, disconnects, reset, read timeout, connection failure, and refused streams.   - gateway-error : Similar to 5xx, but only applies to response codes 502, 503 or 504.   - connect-failure : a retry is attempted on failures connecting to the instance or endpoint. For example, connection timeouts.   - retriable-4xx : a retry is attempted if the instance or endpoint responds with a 4xx response code. The only error that you can retry is error code 409.   - refused-stream : a retry is attempted if the instance or endpoint resets the stream with a REFUSED_STREAM error code. This reset type indicates that it is safe to retry.   - cancelled : a retry is attempted if the gRPC status code in the response header is set to cancelled.   - deadline-exceeded : a retry is attempted if the gRPC status code in the response header is set to deadline-exceeded.   - internal :  a retry is attempted if the gRPC status code in the response header is set to internal.   - resource-exhausted : a retry is attempted if the gRPC status code in the response header is set to resource-exhausted.   - unavailable : a retry is attempted if the gRPC status code in the response header is set to unavailable.</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (known as end-of-stream) up until the response has been processed. Timeout includes all retries. If not specified, this field uses the largest timeout among all backend services associated with the route. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The spec to modify the URL of the request, before forwarding the request to the matched service. urlRewrite is the only action supported in UrlMaps for external HTTP(S) load balancers. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionUrlRewrite
{
    /// <summary>Before forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be from 1 to 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Before forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be from 1 to 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header. The default value is false.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header. The default value is false.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. headerAction is not supported for load balancers that have their loadBalancingScheme set to EXTERNAL. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request before forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request before forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response before sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response before sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. headerAction is not supported for load balancers that have their loadBalancingScheme set to EXTERNAL. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to a backend service, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backend service, subsequent requests are sent to the same backend service as determined by the backend service's session affinity policy. The value must be from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction. defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see [W3C Recommendation for Cross Origin Resource Sharing](https://www.w3.org/TR/cors/).</summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by a load balancer on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted by the load balancer for a percentage of requests. timeout and retryPolicy is ignored by clients that are configured with a faultInjectionPolicy if: 1. The traffic is generated by fault injection AND 2. The fault injection is not a delay fault injection. Fault injection is not supported with the global external HTTP(S) load balancer (classic). To see which load balancers support fault injection, see Load balancing: [Routing and traffic management features](https://cloud.google.com/load-balancing/docs/features#routing-traffic-management).</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. The load balancer does not wait for responses from the shadow service. Before sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (known as end-of-stream) up until the response has been processed. Timeout includes all retries. If not specified, this field uses the largest timeout among all backend services associated with the route. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, before forwarding the request to the matched service. urlRewrite is the only action supported in UrlMaps for external HTTP(S) load balancers. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1ComputeURLMapSpecDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non-zero number. After a backend service is identified and before forwarding the request to the backend service, advanced routing actions such as URL rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1ComputeURLMapSpecDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultServiceBackendBucketRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendBucket` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecDefaultServiceBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The defaultService resource to which traffic is directed if none of the hostRules match. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service. If defaultRouteAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if defaultService is specified, defaultRouteAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified. Only one of defaultService, defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultService
{
    /// <summary></summary>
    [JsonPropertyName("backendBucketRef")]
    public V1beta1ComputeURLMapSpecDefaultServiceBackendBucketRef? BackendBucketRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecDefaultServiceBackendServiceRef? BackendServiceRef { get; set; }
}

/// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecDefaultUrlRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this true for TargetHttpsProxy is not permitted. The default is set to false.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>The path that will be used in the redirect response instead of the one that was supplied in the request. pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch, retaining the remaining portion of the URL before redirecting the request. prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:  * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.  * FOUND, which corresponds to 302.  * SEE_OTHER which corresponds to 303.  * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method will be retained.  * PERMANENT_REDIRECT, which corresponds to 308. In this case, the request method will be retained. Possible values: ["FOUND", "MOVED_PERMANENTLY_DEFAULT", "PERMANENT_REDIRECT", "SEE_OTHER", "TEMPORARY_REDIRECT"].</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained.  This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here take effect after headerAction specified under pathMatcher.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecHostRule
{
    /// <summary>An optional description of this HostRule. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of host patterns to match. They must be valid hostnames, except * will match any string of ([a-z0-9-.]*). In that case, * must be the first character and must be followed in the pattern by either - or ..</summary>
    [JsonPropertyName("hosts")]
    public IList<string> Hosts { get; set; }

    /// <summary>The name of the PathMatcher to use to match the path portion of the URL if the hostRule matches the URL's host portion.</summary>
    [JsonPropertyName("pathMatcher")]
    public string PathMatcher { get; set; }
}

/// <summary>The specification for allowing client side cross-origin requests. Please see [W3C Recommendation for Cross Origin Resource Sharing](https://www.w3.org/TR/cors/).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionCorsPolicy
{
    /// <summary>In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This translates to the Access-Control-Allow-Credentials header.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Specifies the regular expression patterns that match allowed origins. For regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.</summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long results of a preflight request can be cached in seconds. This translates to the Access-Control-Max-Age header.</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public int? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>Specifies the value of the fixed delay interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval.</summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests.  timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
    [JsonPropertyName("abort")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
    [JsonPropertyName("delay")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>Required. The backend service resource being mirrored to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>Required. The backend service resource being mirrored to.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef BackendServiceRef { get; set; }
}

/// <summary>Specifies a non-zero timeout per retry attempt.  If not specified, will use the timeout set in HttpRouteAction. If timeout in HttpRouteAction is not set, will use the largest timeout among all backend services associated with the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0. If not specified, defaults to 1.</summary>
    [JsonPropertyName("numRetries")]
    public int? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt.  If not specified, will use the timeout set in HttpRouteAction. If timeout in HttpRouteAction is not set, will use the largest timeout among all backend services associated with the route.</summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specfies one or more conditions when this retry rule applies. Valid values are:  * 5xx: Loadbalancer will attempt a retry if the backend service responds with any 5xx response code,   or if the backend service does not respond at all, example: disconnects, reset, read timeout, * connection failure, and refused streams. * gateway-error: Similar to 5xx, but only applies to response codes 502, 503 or 504. * connect-failure: Loadbalancer will retry on failures connecting to backend services,   for example due to connection timeouts. * retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.   Currently the only retriable error supported is 409. * refused-stream:Loadbalancer will retry if the backend service resets the stream with a REFUSED_STREAM error code.   This reset type indicates that it is safe to retry. * cancelled: Loadbalancer will retry if the gRPC status code in the response header is set to cancelled * deadline-exceeded: Loadbalancer will retry if the gRPC status code in the response header is set to deadline-exceeded * resource-exhausted: Loadbalancer will retry if the gRPC status code in the response header is set to resource-exhausted * unavailable: Loadbalancer will retry if the gRPC status code in the response header is set to unavailable.</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.  If not specified, will use the largest timeout among all backend services associated with the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite.  The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite.  The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header to add.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header to add.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService.  headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService.  headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) .  The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy.  The value must be between 0 and 1000.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.  Only one of defaultRouteAction or defaultUrlRedirect must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see [W3C Recommendation for Cross Origin Resource Sharing](https://www.w3.org/TR/cors/).</summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests.  timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.  If not specified, will use the largest timeout among all backend services associated with the route.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non 0 number.  Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultServiceBackendBucketRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendBucket` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultServiceBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The default service to use if none of the pathRules defined by this PathMatcher is matched by the URL's path portion. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultService
{
    /// <summary></summary>
    [JsonPropertyName("backendBucketRef")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultServiceBackendBucketRef? BackendBucketRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultServiceBackendServiceRef? BackendServiceRef { get; set; }
}

/// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherDefaultUrlRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this true for TargetHttpsProxy is not permitted. The default is set to false.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>The path that will be used in the redirect response instead of the one that was supplied in the request. pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch, retaining the remaining portion of the URL before redirecting the request. prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:  * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.  * FOUND, which corresponds to 302.  * SEE_OTHER which corresponds to 303.  * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method will be retained.  * PERMANENT_REDIRECT, which corresponds to 308. In this case, the request method will be retained. Possible values: ["FOUND", "MOVED_PERMANENTLY_DEFAULT", "PERMANENT_REDIRECT", "SEE_OTHER", "TEMPORARY_REDIRECT"].</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained.  This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. HeaderAction specified here are applied after the matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionCorsPolicy
{
    /// <summary>In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This translates to the Access- Control-Allow-Credentials header. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Specifies the regular expression patterns that match allowed origins. For regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript An origin is allowed if it matches either allow_origins or allow_origin_regex.</summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches either allow_origins or allow_origin_regex.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached. This translates to the content for the Access-Control-Max-Age header.</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public int HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double Percentage { get; set; }
}

/// <summary>Specifies the value of the fixed delay interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval.</summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double Percentage { get; set; }
}

/// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
    [JsonPropertyName("abort")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
    [JsonPropertyName("delay")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>Required. The backend service resource being mirrored to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>Required. The backend service resource being mirrored to.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef BackendServiceRef { get; set; }
}

/// <summary>Specifies a non-zero timeout per retry attempt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public int? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt.</summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:  - 5xx: Loadbalancer will attempt a retry if the backend service responds with any 5xx response code, or if the backend service does not respond at all, example: disconnects, reset, read timeout, connection failure, and refused streams. - gateway-error: Similar to 5xx, but only applies to response codes 502, 503 or 504. - connect-failure: Loadbalancer will retry on failures connecting to backend services, for example due to connection timeouts. - retriable-4xx: Loadbalancer will retry for retriable 4xx response codes. Currently the only retriable error supported is 409. - refused-stream: Loadbalancer will retry if the backend service resets the stream with a REFUSED_STREAM error code. This reset type indicates that it is safe to retry. - cancelled: Loadbalancer will retry if the gRPC status code in the response header is set to cancelled - deadline-exceeded: Loadbalancer will retry if the gRPC status code in the response header is set to deadline-exceeded - resource-exhausted: Loadbalancer will retry if the gRPC status code in the response header is set to resource-exhausted - unavailable: Loadbalancer will retry if the gRPC status code in the response header is set to unavailable.</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>Required. The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>Required. The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef BackendServiceRef { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>In response to a matching path, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing.</summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleServiceBackendBucketRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendBucket` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleServiceBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The backend service to which traffic is directed if this rule is matched. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service. If routeAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if service is specified, routeAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified. Only one of urlRedirect, service or routeAction.weightedBackendService must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleService
{
    /// <summary></summary>
    [JsonPropertyName("backendBucketRef")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleServiceBackendBucketRef? BackendBucketRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleServiceBackendServiceRef? BackendServiceRef { get; set; }
}

/// <summary>When a path pattern is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRuleUrlRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this true for TargetHttpsProxy is not permitted. The default is set to false.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>The path that will be used in the redirect response instead of the one that was supplied in the request. pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch, retaining the remaining portion of the URL before redirecting the request. prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:  * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.  * FOUND, which corresponds to 302.  * SEE_OTHER which corresponds to 303.  * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method will be retained.  * PERMANENT_REDIRECT, which corresponds to 308. In this case, the request method will be retained. Possible values: ["FOUND", "MOVED_PERMANENTLY_DEFAULT", "PERMANENT_REDIRECT", "SEE_OTHER", "TEMPORARY_REDIRECT"].</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained.  This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherPathRule
{
    /// <summary>The list of path patterns to match. Each must start with / and the only place a \* is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string> Paths { get; set; }

    /// <summary>In response to a matching path, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set.</summary>
    [JsonPropertyName("routeAction")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>The backend service to which traffic is directed if this rule is matched. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service. If routeAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if service is specified, routeAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified. Only one of urlRedirect, service or routeAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("service")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleService? Service { get; set; }

    /// <summary>When a path pattern is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set.</summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta1ComputeURLMapSpecPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here are applied before the matching pathMatchers[].headerAction and after pathMatchers[].routeRules[].r outeAction.weightedBackendService.backendServiceWeightAction[].headerAction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]  * -3 will match * 0 will not match * 0.25 will not match * -3someString will not match.  Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public int RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public int RangeStart { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>The value should exactly match contents of exactMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the HTTP header to match. For matching against the HTTP request's authority, use a headerMatch with the header name ":authority". For matching a request's method, use the headerName ":method".</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>If set to false, the headerMatch is considered a match if the match criteria above are met. If set to true, the headerMatch is considered a match if the match criteria above are NOT met. Defaults to false.</summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>The value of the header must start with the contents of prefixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>A header with the contents of headerName must exist. The match takes place whether or not the request's header has a value or not. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]  * -3 will match * 0 will not match * 0.25 will not match * -3someString will not match.  Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

    /// <summary>The value of the header must match the regular expression specified in regexMatch. For regular expression grammar, please see: en.cppreference.com/w/cpp/regex/ecmascript  For matching against a port specified in the HTTP request, use a headerMatch with headerName set to PORT and a regular expression that satisfies the RFC2616 Host header's port specifier. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>Name of metadata label. The name can have a maximum length of 1024 characters and must be at least 1 character long.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The value of the label must match the specified value. value can have a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels> FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:  * MATCH_ANY: At least one of the filterLabels must have a matching label in the provided metadata. * MATCH_ALL: All filterLabels must have matching labels in the provided metadata. Possible values: ["MATCH_ALL", "MATCH_ANY"].</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL.  pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must satisfy the regular expression specified in regexMatch after removing any query parameters and anchor supplied with the original URL. For regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionCorsPolicy
{
    /// <summary>In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This translates to the Access- Control-Allow-Credentials header. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Specifies the regular expression patterns that match allowed origins. For regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript An origin is allowed if it matches either allow_origins or allow_origin_regex.</summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches either allow_origins or allow_origin_regex.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled. which indicates that the CORS policy is in effect. Defaults to false.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached. This translates to the content for the Access-Control-Max-Age header.</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public int? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>Specifies the value of the fixed delay interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval.</summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection.</summary>
    [JsonPropertyName("abort")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service.</summary>
    [JsonPropertyName("delay")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>Required. The backend service resource being mirrored to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>Required. The backend service resource being mirrored to.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRequestMirrorPolicyBackendServiceRef BackendServiceRef { get; set; }
}

/// <summary>Specifies a non-zero timeout per retry attempt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public int NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt.</summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:  * 5xx: Loadbalancer will attempt a retry if the backend service responds with   any 5xx response code, or if the backend service does not respond at all,   example: disconnects, reset, read timeout, connection failure, and refused   streams. * gateway-error: Similar to 5xx, but only applies to response codes   502, 503 or 504. * connect-failure: Loadbalancer will retry on failures   connecting to backend services, for example due to connection timeouts. * retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.   Currently the only retriable error supported is 409. * refused-stream: Loadbalancer will retry if the backend service resets the stream with a   REFUSED_STREAM error code. This reset type indicates that it is safe to retry. * cancelled: Loadbalancer will retry if the gRPC status code in the response   header is set to cancelled * deadline-exceeded: Loadbalancer will retry if the   gRPC status code in the response header is set to deadline-exceeded * resource-exhausted: Loadbalancer will retry if the gRPC status code in the response   header is set to resource-exhausted * unavailable: Loadbalancer will retry if the gRPC status code in   the response header is set to unavailable.</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string Seconds { get; set; }
}

/// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected origin, if the request matched a pathTemplateMatch, the matching portion of the request's path is replaced re-written using the pattern specified by pathTemplateRewrite.  pathTemplateRewrite must be between 1 and 255 characters (inclusive), must start with a '/', and must only use variables captured by the route's pathTemplate matchers.  pathTemplateRewrite may only be used when all of a route's MatchRules specify pathTemplate.  Only one of pathPrefixRewrite and pathTemplateRewrite may be specified.</summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

/// <summary>Required. The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.</summary>
    [JsonPropertyName("replace")]
    public bool Replace { get; set; }
}

/// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>Required. The default backend service resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesBackendServiceRef BackendServiceRef { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing.</summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRulesUrlRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this true for TargetHttpsProxy is not permitted. The default is set to false.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>The path that will be used in the redirect response instead of the one that was supplied in the request. pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch, retaining the remaining portion of the URL before redirecting the request. prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:  * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.  * FOUND, which corresponds to 302.  * SEE_OTHER which corresponds to 303.  * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method will be retained.  * PERMANENT_REDIRECT, which corresponds to 308. In this case, the request method will be retained. Possible values: ["FOUND", "MOVED_PERMANENTLY_DEFAULT", "PERMANENT_REDIRECT", "SEE_OTHER", "TEMPORARY_REDIRECT"].</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcherRouteRules
{
    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here are applied before the matching pathMatchers[].headerAction and after pathMatchers[].routeRules[].r outeAction.weightedBackendService.backendServiceWeightAction[].headerAction.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>The rules for determining a match.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied.  You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive.  Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set.</summary>
    [JsonPropertyName("routeAction")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>The region backend service resource to which traffic is directed if this rule is matched. If routeAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if service is specified, routeAction cannot contain any weightedBackendService s. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified. Only one of urlRedirect, service or routeAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set.</summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta1ComputeURLMapSpecPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecPathMatcher
{
    /// <summary>defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.  Only one of defaultRouteAction or defaultUrlRedirect must be set.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The default service to use if none of the pathRules defined by this PathMatcher is matched by the URL's path portion. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service.</summary>
    [JsonPropertyName("defaultService")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultService? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta1ComputeURLMapSpecPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. HeaderAction specified here are applied after the matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecPathMatcherHeaderAction? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1ComputeURLMapSpecPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecTestServiceBackendBucketRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendBucket` resource.</summary>
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
public partial class V1beta1ComputeURLMapSpecTestServiceBackendServiceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The backend service resource that should be matched by this test. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecTestService
{
    /// <summary></summary>
    [JsonPropertyName("backendBucketRef")]
    public V1beta1ComputeURLMapSpecTestServiceBackendBucketRef? BackendBucketRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeURLMapSpecTestServiceBackendServiceRef? BackendServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpecTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>The backend service resource that should be matched by this test. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service.</summary>
    [JsonPropertyName("service")]
    public V1beta1ComputeURLMapSpecTestService Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapSpec
{
    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction. defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta1ComputeURLMapSpecDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The defaultService resource to which traffic is directed if none of the hostRules match. For the Global URL Map, it should be a reference to the backend service or backend bucket. For the Regional URL Map, it should be a reference to the backend service. If defaultRouteAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if defaultService is specified, defaultRouteAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified. Only one of defaultService, defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("defaultService")]
    public V1beta1ComputeURLMapSpecDefaultService? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta1ComputeURLMapSpecDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here take effect after headerAction specified under pathMatcher.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeURLMapSpecHeaderAction? HeaderAction { get; set; }

    /// <summary>The list of HostRules to use against the URL.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1ComputeURLMapSpecHostRule>? HostRule { get; set; }

    /// <summary>Location represents the geographical location of the ComputeURLMap. Specify a region name or "global" for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1ComputeURLMapSpecPathMatcher>? PathMatcher { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases pass.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1ComputeURLMapSpecTest>? Test { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeURLMapStatusConditions
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
public partial class V1beta1ComputeURLMapStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeURLMapStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Fingerprint of this resource. This field is used internally during updates of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("mapId")]
    public int? MapId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeURLMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeURLMapSpec>, IStatus<V1beta1ComputeURLMapStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeURLMap";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeurlmaps";
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
    public V1beta1ComputeURLMapSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeURLMapStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeURLMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeURLMap>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeURLMapList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeurlmaps";
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
    public IList<V1beta1ComputeURLMap> Items { get; set; }
}