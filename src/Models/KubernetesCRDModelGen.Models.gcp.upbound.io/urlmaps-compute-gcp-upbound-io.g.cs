using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>URLMap is the Schema for the URLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1URLMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta1URLMap>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "URLMapList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "urlmaps";
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
    public IList<V1beta1URLMap> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionTimeout
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, will use the largest timeout among all backend services associated with the route. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderDefaultUrlRedirect
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
public partial class V1beta1URLMapSpecForProviderHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderHostRule
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherDefaultUrlRedirect
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
public partial class V1beta1URLMapSpecForProviderPathMatcherHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRuleUrlRedirect
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
public partial class V1beta1URLMapSpecForProviderPathMatcherPathRule
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will not match.  - 0.25 will not match.  - -3someString will not match.   Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set. Structure is documented below.</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRulesUrlRedirect
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
public partial class V1beta1URLMapSpecForProviderPathMatcherRouteRules
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderPathMatcher
{
    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1URLMapSpecForProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. HeaderAction specified here are applied after the matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherHeaderAction>? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1URLMapSpecForProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTestHeaders
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTestServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTestServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTestServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecForProviderTestServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters. For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored. For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer's redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters. expectedOutputUrl is optional when service is specified.</summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer's redirect response. expectedRedirectResponseCode cannot be set when service is set.</summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>HTTP headers for this request. Structure is documented below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1URLMapSpecForProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecForProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecForProviderTestServiceSelector? ServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecForProvider
{
    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecForProviderDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapSpecForProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1URLMapSpecForProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1URLMapSpecForProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapSpecForProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here take effect after headerAction specified under pathMatcher. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecForProviderHeaderAction>? HeaderAction { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1URLMapSpecForProviderHostRule>? HostRule { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1URLMapSpecForProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The list of expected URL mapping tests. Request to update this UrlMap will succeed only if all of the test cases pass. You can specify a maximum of 100 tests per UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1URLMapSpecForProviderTest>? Test { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionTimeout
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, will use the largest timeout among all backend services associated with the route. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderDefaultUrlRedirect
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
public partial class V1beta1URLMapSpecInitProviderHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderHostRule
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherDefaultUrlRedirect
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRuleUrlRedirect
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherPathRule
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will not match.  - 0.25 will not match.  - -3someString will not match.   Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set. Structure is documented below.</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect
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
public partial class V1beta1URLMapSpecInitProviderPathMatcherRouteRules
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderPathMatcher
{
    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1URLMapSpecInitProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. HeaderAction specified here are applied after the matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherHeaderAction>? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTestHeaders
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTestServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTestServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTestServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecInitProviderTestServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters. For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored. For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer's redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters. expectedOutputUrl is optional when service is specified.</summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer's redirect response. expectedRedirectResponseCode cannot be set when service is set.</summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>HTTP headers for this request. Structure is documented below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1URLMapSpecInitProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1URLMapSpecInitProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1URLMapSpecInitProviderTestServiceSelector? ServiceSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecInitProvider
{
    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapSpecInitProviderDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapSpecInitProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta1URLMapSpecInitProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta1URLMapSpecInitProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapSpecInitProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here take effect after headerAction specified under pathMatcher. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapSpecInitProviderHeaderAction>? HeaderAction { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1URLMapSpecInitProviderHostRule>? HostRule { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1URLMapSpecInitProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The list of expected URL mapping tests. Request to update this UrlMap will succeed only if all of the test cases pass. You can specify a maximum of 100 tests per UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1URLMapSpecInitProviderTest>? Test { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecProviderConfigRefPolicy
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
public partial class V1beta1URLMapSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1URLMapSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>URLMapSpec defines the desired state of URLMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1URLMapSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1URLMapSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1URLMapSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1URLMapSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapStatusAtProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionTimeout
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, will use the largest timeout among all backend services associated with the route. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service. Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderDefaultUrlRedirect
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
public partial class V1beta1URLMapStatusAtProviderHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderHostRule
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherDefaultUrlRedirect
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRuleUrlRedirect
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherPathRule
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>The list of path patterns to match. Each must start with / and the only place a * is allowed is at the end following a /. The string fed to the path matcher does not include any text after the first ? or #, and those chars are not allowed here.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRuleUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>The HTTP status code returned with the response containing the custom error content. If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.</summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>Specifies rules for returning error responses. In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority. For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX). If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect. Structure is documented below.</summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are: https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket compute/v1/projects/project/global/backendBuckets/myBackendBucket global/backendBuckets/myBackendBucket If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService. If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).</summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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

    /// <summary>The header value must be an integer and its value must be in the range specified in rangeMatch. If the header does not contain an integer, number or is empty, the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will not match.  - 0.25 will not match.  - -3someString will not match.   Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set. Structure is documented below.</summary>
    [JsonPropertyName("rangeMatch")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch>? RangeMatch { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch. Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries. Structure is documented below.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match. Supported values are:</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL. FullPathMatch must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request. Structure is documented below.</summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive. Defaults to false.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies. For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata. metadataFilters specified here can be overrides those specified in ForwardingRule that refers to this UrlMap. metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>For satisfying the matchRule condition, the path of the request must match the wildcard pattern specified in pathTemplateMatch after removing any query parameters and anchor that may be part of the original URL. pathTemplateMatch must be between 1 and 255 characters (inclusive).  The pattern specified by pathTemplateMatch may have at most 5 wildcard operators and at most 5 variable captures in total.</summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request's path must begin with the specified prefixMatch. prefixMatch must begin with a /. The value must be between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must be specified.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request. Structure is documented below.</summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>The queryParameterMatch matches if the value of the parameter matches the regular expression specified by regexMatch. For the regular expression grammar, please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch, exactMatch and regexMatch must be set.</summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>Specifies the value of the fixed delay interval. Structure is documented below.</summary>
    [JsonPropertyName("fixedDelay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay>? FixedDelay { get; set; }

    /// <summary>The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection. The value must be between 0.0 and 100.0 inclusive.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>The specification for how client requests are aborted as part of fault injection. Structure is documented below.</summary>
    [JsonPropertyName("abort")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort>? Abort { get; set; }

    /// <summary>The specification for how client requests are delayed as part of fault injection, before being sent to a backend service. Structure is documented below.</summary>
    [JsonPropertyName("delay")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay>? Delay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Specifies a non-zero timeout per retry attempt. Structure is documented below.</summary>
    [JsonPropertyName("perTryTimeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout>? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>Headers to add to a matching request prior to forwarding the request to the backendService. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the backendService.</summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>Headers to add the response prior to sending the response back to the client. Structure is documented below.</summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the response prior to sending the response back to the client.</summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>The default BackendService resource. Before forwarding the request to backendService, the loadbalancer applies any relevant headerActions specified as part of this backendServiceWeight.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction>? HeaderAction { get; set; }

    /// <summary>Specifies the fraction of traffic sent to backendService, computed as weight / (sum of all weightedBackendService weights in routeAction) . The selection of a backend service is determined only for new traffic. Once a user's request has been directed to a backendService, subsequent requests will be sent to the same backendService as determined by the BackendService's session affinity policy. The value must be between 0 and 1000</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>The specification for allowing client side cross-origin requests. Please see W3C Recommendation for Cross Origin Resource Sharing Structure is documented below.</summary>
    [JsonPropertyName("corsPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy>? CorsPolicy { get; set; }

    /// <summary>The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure. As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted by the Loadbalancer for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy. Structure is documented below.</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy>? FaultInjectionPolicy { get; set; }

    /// <summary>Specifies the maximum duration (timeout) for streams on the selected route. Unlike the Timeout field where the timeout duration starts from the time the request has been fully processed (known as end-of-stream), the duration in this field is computed from the beginning of the stream until the response has been processed, including all retries. A stream that does not complete in this duration is closed. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionMaxStreamDuration>? MaxStreamDuration { get; set; }

    /// <summary>Specifies the policy on how requests intended for the route's backends are shadowed to a separate mirrored backend service. Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host / authority header is suffixed with -shadow. Structure is documented below.</summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy>? RequestMirrorPolicy { get; set; }

    /// <summary>Specifies the retry policy associated with this route. Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the timeout for the selected route. Timeout is computed from the time the request is has been fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries. If not specified, the default value is 15 seconds. Structure is documented below.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout>? Timeout { get; set; }

    /// <summary>The spec to modify the URL of the request, prior to forwarding the request to the matched service Structure is documented below.</summary>
    [JsonPropertyName("urlRewrite")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite>? UrlRewrite { get; set; }

    /// <summary>A list of weighted backend services to send traffic to when a route match occurs. The weights determine the fraction of traffic that flows to their corresponding backend service. If all traffic needs to go to a single backend service, there must be one  weightedBackendService with weight set to a non 0 number. Once a backendService is identified and before forwarding the request to the backend service, advanced routing actions like Url rewrites and header transformations are applied depending on additional settings specified in this HttpRouteAction. Structure is documented below.</summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect
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
public partial class V1beta1URLMapStatusAtProviderPathMatcherRouteRules
{
    /// <summary>customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. Structure is documented below.</summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicy>? CustomErrorResponsePolicy { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. headerAction specified here take effect before headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesHeaderAction>? HeaderAction { get; set; }

    /// <summary>The rules for determining a match. Structure is documented below.</summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>For routeRules within a given pathMatcher, priority determines the order in which load balancer will interpret routeRules. RouteRules are evaluated in order of priority, from the lowest to highest number. The priority of a rule decreases as its number increases (1, 2, 3, N+1). The first rule that matches the request is applied. You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 0 and 2147483647 inclusive. Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>In response to a matching matchRule, the load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If  routeAction specifies any weightedBackendServices, service must not be set. Conversely if service is set, routeAction cannot contain any  weightedBackendServices. Only one of routeAction or urlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("routeAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesRouteAction>? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>When this rule is matched, the request is redirected to a URL specified by urlRedirect. If urlRedirect is specified, service or routeAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("urlRedirect")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect>? UrlRedirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderPathMatcher
{
    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. HeaderAction specified here are applied after the matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherHeaderAction>? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The list of path rules. Use this list instead of routeRules when routing based on simple path matching is all that's required. The order by which path rules are specified does not matter. Matches are always done on the longest-path-first basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/* irrespective of the order in which those paths appear in this list. Within a given pathMatcher, only one of pathRules or routeRules must be set. Structure is documented below.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>The list of ordered HTTP route rules. Use this list instead of pathRules when advanced route matching and routing actions are desired. The order of specifying routeRules matters: the first rule that matches will cause its specified routing action to take effect. Within a given pathMatcher, only one of pathRules or routeRules must be set. routeRules are not supported in UrlMaps intended for External load balancers. Structure is documented below.</summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderTestHeaders
{
    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters. For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored. For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer's redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters. expectedOutputUrl is optional when service is specified.</summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer's redirect response. expectedRedirectResponseCode cannot be set when service is set.</summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>HTTP headers for this request. Structure is documented below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1URLMapStatusAtProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error. This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect. For example, consider a UrlMap with the following configuration: UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors A RouteRule for /coming_soon/ is configured for the error code 404. If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher's policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect. When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client. defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers. Structure is documented below.</summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public IList<V1beta1URLMapStatusAtProviderDefaultCustomErrorResponsePolicy>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices. Only one of defaultRouteAction or defaultUrlRedirect must be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultRouteAction")]
    public IList<V1beta1URLMapStatusAtProviderDefaultRouteAction>? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>When none of the specified hostRules match, the request is redirected to a URL specified by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or defaultRouteAction must not be set. Structure is documented below.</summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public IList<V1beta1URLMapStatusAtProviderDefaultUrlRedirect>? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>Specifies changes to request and response headers that need to take effect for the selected backendService. The headerAction specified here take effect after headerAction specified under pathMatcher. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public IList<V1beta1URLMapStatusAtProviderHeaderAction>? HeaderAction { get; set; }

    /// <summary>The list of HostRules to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta1URLMapStatusAtProviderHostRule>? HostRule { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/urlMaps/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("mapId")]
    public double? MapId { get; set; }

    /// <summary>The list of named PathMatchers to use against the URL. Structure is documented below.</summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta1URLMapStatusAtProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The list of expected URL mapping tests. Request to update this UrlMap will succeed only if all of the test cases pass. You can specify a maximum of 100 tests per UrlMap. Structure is documented below.</summary>
    [JsonPropertyName("test")]
    public IList<V1beta1URLMapStatusAtProviderTest>? Test { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatusConditions
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

/// <summary>URLMapStatus defines the observed state of URLMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1URLMapStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1URLMapStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1URLMapStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>URLMap is the Schema for the URLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1URLMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1URLMapSpec>, IStatus<V1beta1URLMapStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "URLMap";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "urlmaps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>URLMapSpec defines the desired state of URLMap</summary>
    [JsonPropertyName("spec")]
    public V1beta1URLMapSpec Spec { get; set; }

    /// <summary>URLMapStatus defines the observed state of URLMap.</summary>
    [JsonPropertyName("status")]
    public V1beta1URLMapStatus? Status { get; set; }
}