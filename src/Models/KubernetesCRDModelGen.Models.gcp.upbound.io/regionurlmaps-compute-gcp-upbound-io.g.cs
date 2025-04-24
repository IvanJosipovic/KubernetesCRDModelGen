using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by a load balancer on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted by the load balancer for a percentage of requests. timeout and retryPolicy is ignored by clients that are configured with a faultInjectionPolicy if: 1. The traffic is generated by fault injection AND 2. The fault injection is not a delay fault injection. Fault injection is not supported with the global external HTTP(S) load balancer (classic). To see which load balancers support fault injection, see Load balancing: Routing and traffic management features. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. The load balancer does not wait for responses from the shadow service. Before sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (known as end-of-stream) up until the response has been processed. Timeout includes all retries. If not specified, this field uses the largest timeout among all backend services associated with the route. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, before forwarding the request to the matched service. urlRewrite is the only action supported in UrlMaps for external HTTP(S) load balancers. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non-zero number. After a backend service is identified and before forwarding the request to the backend service, advanced routing actions such as URL rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderHostRule
{
    /// <summary>An optional description of this HostRule. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of host patterns to match. They must be valid hostnames, except * will match any string of ([a-z0-9-.]*). In that case, * must be the first character and must be followed in the pattern by either - or ..</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>The name of the PathMatcher to use to match the path portion of the URL if the hostRule matches the URL's host portion.</summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherPathRule
{
    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>If set to false, the headerMatch is considered a match if the match criteria above are met. If set to true, the headerMatch is considered a match if the match criteria above are NOT met. Defaults to false.</summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the label must match the specified value. value can have a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected origin, if the request matched a pathTemplateMatch, the matching portion of the request's path is replaced re-written using the pattern specified by pathTemplateRewrite. pathTemplateRewrite must be between 1 and 255 characters (inclusive), must start with a '/', and must only use variables captured by the route's pathTemplate matchers. pathTemplateRewrite may only be used when all of a route's MatchRules specify pathTemplate. Only one of pathPrefixRewrite and pathTemplateRewrite may be specified.</summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcherRouteRules
{
    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderPathMatcher
{
    /// <summary>A reference to a RegionBackendService resource. This will be used if none of the pathRules defined by this PathMatcher is matched by the URL's path portion.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderTestServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderTestServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderTestServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecForProviderTestServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecForProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecForProviderTestServiceSelector? ServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecForProvider
{
    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction. defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The full or partial URL of the defaultService resource to which traffic is directed if none of the hostRules match. If defaultRouteAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if defaultService is specified, defaultRouteAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified.  Only one of defaultService, defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1RegionURLMapSpecForProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1RegionURLMapSpecForProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapSpecForProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1RegionURLMapSpecForProviderHostRule>? HostRule { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1RegionURLMapSpecForProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the url map should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases pass. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1RegionURLMapSpecForProviderTest>? Test { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by a load balancer on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted by the load balancer for a percentage of requests. timeout and retryPolicy is ignored by clients that are configured with a faultInjectionPolicy if: 1. The traffic is generated by fault injection AND 2. The fault injection is not a delay fault injection. Fault injection is not supported with the global external HTTP(S) load balancer (classic). To see which load balancers support fault injection, see Load balancing: Routing and traffic management features. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. The load balancer does not wait for responses from the shadow service. Before sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (known as end-of-stream) up until the response has been processed. Timeout includes all retries. If not specified, this field uses the largest timeout among all backend services associated with the route. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, before forwarding the request to the matched service. urlRewrite is the only action supported in UrlMaps for external HTTP(S) load balancers. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non-zero number. After a backend service is identified and before forwarding the request to the backend service, advanced routing actions such as URL rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderHostRule
{
    /// <summary>An optional description of this HostRule. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of host patterns to match. They must be valid hostnames, except * will match any string of ([a-z0-9-.]*). In that case, * must be the first character and must be followed in the pattern by either - or ..</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>The name of the PathMatcher to use to match the path portion of the URL if the hostRule matches the URL's host portion.</summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherPathRule
{
    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>If set to false, the headerMatch is considered a match if the match criteria above are met. If set to true, the headerMatch is considered a match if the match criteria above are NOT met. Defaults to false.</summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the label must match the specified value. value can have a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected origin, if the request matched a pathTemplateMatch, the matching portion of the request's path is replaced re-written using the pattern specified by pathTemplateRewrite. pathTemplateRewrite must be between 1 and 255 characters (inclusive), must start with a '/', and must only use variables captured by the route's pathTemplate matchers. pathTemplateRewrite may only be used when all of a route's MatchRules specify pathTemplate. Only one of pathPrefixRewrite and pathTemplateRewrite may be specified.</summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRules
{
    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderPathMatcher
{
    /// <summary>A reference to a RegionBackendService resource. This will be used if none of the pathRules defined by this PathMatcher is matched by the URL's path portion.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderTestServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderTestServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderTestServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecInitProviderTestServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionURLMapSpecInitProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionURLMapSpecInitProviderTestServiceSelector? ServiceSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecInitProvider
{
    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction. defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The full or partial URL of the defaultService resource to which traffic is directed if none of the hostRules match. If defaultRouteAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if defaultService is specified, defaultRouteAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified.  Only one of defaultService, defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1RegionURLMapSpecInitProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1RegionURLMapSpecInitProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapSpecInitProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1RegionURLMapSpecInitProviderHostRule>? HostRule { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1RegionURLMapSpecInitProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases pass. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1RegionURLMapSpecInitProviderTest>? Test { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionURLMapSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegionURLMapSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegionURLMapSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegionURLMapSpec defines the desired state of RegionURLMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionURLMapSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionURLMapSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionURLMapSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegionURLMapSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionURLMapSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by a load balancer on a percentage of requests before sending those requests to the backend service. Similarly requests from clients can be aborted by the load balancer for a percentage of requests. timeout and retryPolicy is ignored by clients that are configured with a faultInjectionPolicy if: 1. The traffic is generated by fault injection AND 2. The fault injection is not a delay fault injection. Fault injection is not supported with the global external HTTP(S) load balancer (classic). To see which load balancers support fault injection, see Load balancing: Routing and traffic management features. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. The load balancer does not wait for responses from the shadow service. Before sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (known as end-of-stream) up until the response has been processed. Timeout includes all retries. If not specified, this field uses the largest timeout among all backend services associated with the route. Not supported when the URL map is bound to a target gRPC proxy that has validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, before forwarding the request to the matched service. urlRewrite is the only action supported in UrlMaps for external HTTP(S) load balancers. Not supported when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non-zero number. After a backend service is identified and before forwarding the request to the backend service, advanced routing actions such as URL rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. This field is required to ensure an empty block is not set. The normal default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderHostRule
{
    /// <summary>An optional description of this HostRule. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of host patterns to match. They must be valid hostnames, except * will match any string of ([a-z0-9-.]*). In that case, * must be the first character and must be followed in the pattern by either - or ..</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>The name of the PathMatcher to use to match the path portion of the URL if the hostRule matches the URL's host portion.</summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherDefaultUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherPathRule
{
    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>If set to false, the headerMatch is considered a match if the match criteria above are met. If set to true, the headerMatch is considered a match if the match criteria above are NOT met. Defaults to false.</summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the label must match the specified value. value can have a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not. Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected service, the request's host header is replaced with contents of hostRewrite. The value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected backend service, the matching portion of the request's path is replaced by pathPrefixRewrite. The value must be between 1 and 1024 characters.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected origin, if the request matched a pathTemplateMatch, the matching portion of the request's path is replaced re-written using the pattern specified by pathTemplateRewrite. pathTemplateRewrite must be between 1 and 255 characters (inclusive), must start with a '/', and must only use variables captured by the route's pathTemplate matchers. pathTemplateRewrite may only be used when all of a route's MatchRules specify pathTemplate. Only one of pathPrefixRewrite and pathTemplateRewrite may be specified.</summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
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
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default RegionBackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect
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

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained. The default value is false.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRules
{
    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderPathMatcher
{
    /// <summary>A reference to a RegionBackendService resource. This will be used if none of the pathRules defined by this PathMatcher is matched by the URL's path portion.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction. defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The full or partial URL of the defaultService resource to which traffic is directed if none of the hostRules match. If defaultRouteAction is additionally specified, advanced routing actions like URL Rewrites, etc. take effect prior to sending the request to the backend. However, if defaultService is specified, defaultRouteAction cannot contain any weightedBackendServices. Conversely, if routeAction specifies any weightedBackendServices, service must not be specified.  Only one of defaultService, defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1RegionURLMapStatusAtProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fingerprint of this resource. This field is used internally during updates of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1RegionURLMapStatusAtProviderHostRule>? HostRule { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/urlMaps/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("mapId")]
    public double? MapId { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1RegionURLMapStatusAtProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the url map should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The list of expected URL mappings. Requests to update this UrlMap will succeed only if all of the test cases pass. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1RegionURLMapStatusAtProviderTest>? Test { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>RegionURLMapStatus defines the observed state of RegionURLMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionURLMapStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionURLMapStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionURLMapStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionURLMap is the Schema for the RegionURLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionURLMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionURLMapSpec>, IStatus<V1beta1RegionURLMapStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionURLMap";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionurlmaps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionURLMapSpec defines the desired state of RegionURLMap</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionURLMapSpec Spec { get; set; }

    /// <summary>RegionURLMapStatus defines the observed state of RegionURLMap.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionURLMapStatus? Status { get; set; }
}

/// <summary>RegionURLMap is the Schema for the RegionURLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionURLMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionURLMap>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionURLMapList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionurlmaps";
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
    public IList<V1beta1RegionURLMap> Items { get; set; }
}