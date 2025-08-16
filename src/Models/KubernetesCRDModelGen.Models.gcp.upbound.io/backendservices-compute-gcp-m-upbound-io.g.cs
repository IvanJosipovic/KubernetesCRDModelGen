using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>BackendService is the Schema for the BackendServices API. A Backend Service defines a group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackendServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackendService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackendServiceList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "backendservices";
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
    public IList<V1beta1BackendService> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackendCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Optional parameter to define a target utilization for the Custom Metrics balancing mode. The valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackendGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecForProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackendGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackendGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecForProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderBackend
{
    /// <summary>Specifies the balancing mode for this backend. For global HTTP(S) or TCP/SSL load balancing, the default is UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)), CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL). See the Backend Services Overview for an explanation of load balancing modes. Default value is UTILIZATION. Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.</summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>A multiplier applied to the group's maximum servicing capacity (based on UTILIZATION, RATE or CONNECTION). Default value is 1, which means the group will serve up to 100% of its configured capacity (depending on balancingMode). A setting of 0 means the group is completely drained, offering 0% of its available Capacity. Valid range is [0.0,1.0].</summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>The set of custom metrics that are used for CUSTOM_METRICS BalancingMode. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceSpecForProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The fully-qualified URL of an Instance Group or Network Endpoint Group resource. In case of instance group this defines the list of instances that serve traffic. Member virtual machine instances from each instance group must live in the same zone as the instance group itself. No two backends in a backend service are allowed to use same Instance Group resource. For Network Endpoint Groups this defines list of endpoints. All endpoints of Network Endpoint Group must be hosted on instances located in the same zone as the Network Endpoint Group. Backend services cannot mix Instance Group and Network Endpoint Group backends. Note that you must specify an Instance Group or Network Endpoint Group resource using the fully-qualified URL, rather than a partial URL.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta1BackendServiceSpecForProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta1BackendServiceSpecForProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>The max number of simultaneous connections for the group. Can be used with either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or one of maxConnectionsPerInstance or maxConnectionsPerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerEndpoint must be set.</summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerInstance must be set.</summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>The max requests per second (RPS) of the group. Can be used with either RATE or UTILIZATION balancing modes, but required if RATE mode. For RATE mode, either maxRate or one of maxRatePerInstance or maxRatePerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerEndpoint must be set.</summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerInstance must be set.</summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>Used when balancingMode is UTILIZATION. This ratio defines the CPU utilization target for the group. Valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>This field indicates whether this backend should be fully utilized before sending traffic to backends with default preference. This field cannot be set when loadBalancingScheme is set to 'EXTERNAL'. The possible values are:</summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>Allows HTTP request headers (by name) to be used in the cache key.</summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>If true, include query string parameters in the cache key according to query_string_whitelist and query_string_blacklist. If neither is set, the entire query string will be included. If false, the query string will be excluded from the cache key entirely.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Names of query string parameters to exclude in cache keys. All other parameters will be included. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>Names of query string parameters to include in cache keys. All other parameters will be excluded. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501 can be specified as values, and you cannot specify a status code more than once.</summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCdnPolicy
{
    /// <summary>Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified. The cache is bypassed for all cdnPolicy.cacheMode settings. Structure is documented below.</summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta1BackendServiceSpecForProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta1BackendServiceSpecForProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>Specifies the cache setting for all responses from this backend. The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.</summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy. Omitting the policy and leaving negativeCaching enabled will use Cloud CDN's default cache TTLs. Structure is documented below.</summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta1BackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.</summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>Maximum number of seconds the response to a signed URL request will be considered fresh, defaults to 1hr (3600s). After this time period, the response will be revalidated before being served. When serving responses to signed URL requests, Cloud CDN will internally behave as though all responses from this backend had a "Cache-Control: public, max-age=[TTL]" header, regardless of any existing Cache-Control header. The actual headers served in responses will not be altered.</summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCircuitBreakers
{
    /// <summary>The maximum number of connections to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The maximum number of pending requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>The maximum number of parallel requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>Maximum requests for a single backend connection. This parameter is respected by both the HTTP/1.1 and HTTP/2 implementations. If not specified, there is no limit. Setting this parameter to 1 will effectively disable keep alive.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>The maximum number of parallel retries to the backend cluster. Defaults to 3.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderConsistentHashHttpCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceSpecForProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderConsistentHash
{
    /// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1BackendServiceSpecForProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>The hash based on the value of the specified header field. This field is applicable if the sessionAffinity is set to HEADER_FIELD.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>The minimum number of virtual nodes to use for the hash ring. Larger ring sizes result in more granular load distributions. If the number of hosts in the load balancing pool is larger than the ring size, each host will be assigned a single virtual node. Defaults to 1024.</summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Name of a custom utilization signal. The name must be 1-64 characters long and match the regular expression a-z? which means the first character must be a lowercase letter, and all following characters must be a dash, period, underscore, lowercase letter, or digit, except the last character, which cannot be a dash, period, or underscore. For usage guidelines, see Custom Metrics balancing mode. This field can only be used for a global or regional backend service with the loadBalancingScheme set to EXTERNAL_MANAGED, INTERNAL_MANAGED INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderHealthChecksRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecForProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderHealthChecksSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderHealthChecksSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecForProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>OAuth2 Client Secret for IAP Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderIapOauth2ClientSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>OAuth2 Client Secret for IAP Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public V1beta1BackendServiceSpecForProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>An optional, arbitrary JSON object with configuration data, understood by a locally installed custom policy implementation.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderLocalityLbPolicies
{
    /// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
    [JsonPropertyName("customPolicy")]
    public V1beta1BackendServiceSpecForProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecForProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service and "logConfig.optionalMode" was set to CUSTOM. Contains a list of optional fields you want to include in the logs. For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace For example: orca_load_report, tls.protocol</summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>Specifies the optional logging mode for the load balancer traffic. Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM. Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.</summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service. The value of the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderOutlierDetectionInterval
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderOutlierDetection
{
    /// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta1BackendServiceSpecForProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>Number of errors before a host is ejected from the connection pool. When the backend host is accessed over HTTP, a 5xx return code qualifies as an error. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>The number of consecutive gateway failures (502, 503, 504 status or connection errors that are mapped to one of those status codes) before a consecutive gateway failure ejection occurs. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive 5xx. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive gateway failures. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 0.</summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through success rate statistics. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
    [JsonPropertyName("interval")]
    public V1beta1BackendServiceSpecForProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in the load balancing pool for the backend service that can be ejected. Defaults to 10%.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>The number of hosts in a cluster that must have enough request volume to detect success rate outliers. If the number of hosts is less than this setting, outlier detection via success rate statistics is not performed for any host in the cluster. Defaults to 5.</summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>The minimum number of total requests that must be collected in one interval (as defined by the interval duration above) to include this host in success rate based outlier detection. If the volume is lower than this setting, outlier detection via success rate statistics is not performed for that host. Defaults to 100.</summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>This factor is used to determine the ejection threshold for success rate outlier ejection. The ejection threshold is the difference between the mean success rate, and the product of this factor and the standard deviation of the mean success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided by a thousand to get a double. That is, if the desired factor is 1.9, the runtime value should be 1900. Defaults to 1900.</summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>The access key used for s3 bucket authentication. Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>The access key used for s3 bucket authentication. Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1BackendServiceSpecForProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin. For example, "us-east-1" for AWS or "us-ashburn-1" for OCI.</summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderSecuritySettings
{
    /// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta1BackendServiceSpecForProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service. This resource itself does not affect configuration unless it is attached to a backend service resource.</summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate. If specified, the client will verify that the server certificate's subject alt name matches one of the specified values.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderStrongSessionAffinityCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceSpecForProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecForProvider
{
    /// <summary>Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the load balancing scheme is INTERNAL, this field is not used.</summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>The set of backends that serve this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1BackendServiceSpecForProviderBackend>? Backend { get; set; }

    /// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta1BackendServiceSpecForProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta1BackendServiceSpecForProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>Compress text responses using Brotli or gzip compression, based on the client's Accept-Encoding header. Possible values are: AUTOMATIC, DISABLED.</summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>Time for which instance will be drained (not accept new connections, but still work to finish started).</summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1BackendServiceSpecForProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceSpecForProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied requests.</summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied responses.</summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and TEST_ALL_TRAFFIC. To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate traffic by percentage using externalManagedMigrationTestingPercentage. Rolling back a migration requires the states to be set in reverse order. So changing the scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.</summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>Determines the fraction of requests that should be processed by the Global external Application Load Balancer. The value of this field must be in the range [0, 100]. Session affinity options will slightly affect this routing behavior, for more details, see: Session Affinity. This value can only be set if the loadBalancingScheme in the backend service is set to EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.</summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently at most one health check can be specified. A health check must be specified unless the backend service uses an internet or serverless NEG as a backend. For internal load balancing, a URL to a HealthCheck resource must be specified instead.</summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta1BackendServiceSpecForProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta1BackendServiceSpecForProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
    [JsonPropertyName("iap")]
    public V1beta1BackendServiceSpecForProviderIap? Iap { get; set; }

    /// <summary>Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.</summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>Indicates whether the backend service will be used with internal or external load balancing. A backend service created for one type of load balancing cannot be used with the other. For more information, refer to Choosing a load balancer. Default value is EXTERNAL. Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>A list of locality load balancing policies to be used in order of preference. Either the policy or the customPolicy field should be set. Overrides any value set in the localityLbPolicy field. localityLbPolicies is only supported when the BackendService is referenced by a URL Map that is referenced by a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta1BackendServiceSpecForProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>The load balancing algorithm used within the scope of the locality. The possible values are:</summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1BackendServiceSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta1BackendServiceSpecForProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1BackendServiceSpecForProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the load balancing scheme is EXTERNAL.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The protocol this BackendService uses to communicate with backends. The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP or GRPC. Refer to the documentation for the load balancers or for Traffic Director for more information. Must be set to GRPC when the backend service is referenced by a URL map that is bound to target gRPC proxy. Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("securitySettings")]
    public V1beta1BackendServiceSpecForProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>URL to networkservices.ServiceLbPolicy resource. Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.</summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP. Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta1BackendServiceSpecForProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>The backend service timeout has a different meaning depending on the type of load balancer. For more information see, Backend service settings. The default is 30 seconds. The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackendCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Optional parameter to define a target utilization for the Custom Metrics balancing mode. The valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackendGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecInitProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackendGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackendGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecInitProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderBackend
{
    /// <summary>Specifies the balancing mode for this backend. For global HTTP(S) or TCP/SSL load balancing, the default is UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)), CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL). See the Backend Services Overview for an explanation of load balancing modes. Default value is UTILIZATION. Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.</summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>A multiplier applied to the group's maximum servicing capacity (based on UTILIZATION, RATE or CONNECTION). Default value is 1, which means the group will serve up to 100% of its configured capacity (depending on balancingMode). A setting of 0 means the group is completely drained, offering 0% of its available Capacity. Valid range is [0.0,1.0].</summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>The set of custom metrics that are used for CUSTOM_METRICS BalancingMode. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceSpecInitProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The fully-qualified URL of an Instance Group or Network Endpoint Group resource. In case of instance group this defines the list of instances that serve traffic. Member virtual machine instances from each instance group must live in the same zone as the instance group itself. No two backends in a backend service are allowed to use same Instance Group resource. For Network Endpoint Groups this defines list of endpoints. All endpoints of Network Endpoint Group must be hosted on instances located in the same zone as the Network Endpoint Group. Backend services cannot mix Instance Group and Network Endpoint Group backends. Note that you must specify an Instance Group or Network Endpoint Group resource using the fully-qualified URL, rather than a partial URL.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta1BackendServiceSpecInitProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta1BackendServiceSpecInitProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>The max number of simultaneous connections for the group. Can be used with either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or one of maxConnectionsPerInstance or maxConnectionsPerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerEndpoint must be set.</summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerInstance must be set.</summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>The max requests per second (RPS) of the group. Can be used with either RATE or UTILIZATION balancing modes, but required if RATE mode. For RATE mode, either maxRate or one of maxRatePerInstance or maxRatePerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerEndpoint must be set.</summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerInstance must be set.</summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>Used when balancingMode is UTILIZATION. This ratio defines the CPU utilization target for the group. Valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>This field indicates whether this backend should be fully utilized before sending traffic to backends with default preference. This field cannot be set when loadBalancingScheme is set to 'EXTERNAL'. The possible values are:</summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>Allows HTTP request headers (by name) to be used in the cache key.</summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>If true, include query string parameters in the cache key according to query_string_whitelist and query_string_blacklist. If neither is set, the entire query string will be included. If false, the query string will be excluded from the cache key entirely.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Names of query string parameters to exclude in cache keys. All other parameters will be included. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>Names of query string parameters to include in cache keys. All other parameters will be excluded. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501 can be specified as values, and you cannot specify a status code more than once.</summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCdnPolicy
{
    /// <summary>Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified. The cache is bypassed for all cdnPolicy.cacheMode settings. Structure is documented below.</summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta1BackendServiceSpecInitProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta1BackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>Specifies the cache setting for all responses from this backend. The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.</summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy. Omitting the policy and leaving negativeCaching enabled will use Cloud CDN's default cache TTLs. Structure is documented below.</summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta1BackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.</summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>Maximum number of seconds the response to a signed URL request will be considered fresh, defaults to 1hr (3600s). After this time period, the response will be revalidated before being served. When serving responses to signed URL requests, Cloud CDN will internally behave as though all responses from this backend had a "Cache-Control: public, max-age=[TTL]" header, regardless of any existing Cache-Control header. The actual headers served in responses will not be altered.</summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCircuitBreakers
{
    /// <summary>The maximum number of connections to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The maximum number of pending requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>The maximum number of parallel requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>Maximum requests for a single backend connection. This parameter is respected by both the HTTP/1.1 and HTTP/2 implementations. If not specified, there is no limit. Setting this parameter to 1 will effectively disable keep alive.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>The maximum number of parallel retries to the backend cluster. Defaults to 3.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderConsistentHashHttpCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceSpecInitProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderConsistentHash
{
    /// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1BackendServiceSpecInitProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>The hash based on the value of the specified header field. This field is applicable if the sessionAffinity is set to HEADER_FIELD.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>The minimum number of virtual nodes to use for the hash ring. Larger ring sizes result in more granular load distributions. If the number of hosts in the load balancing pool is larger than the ring size, each host will be assigned a single virtual node. Defaults to 1024.</summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Name of a custom utilization signal. The name must be 1-64 characters long and match the regular expression a-z? which means the first character must be a lowercase letter, and all following characters must be a dash, period, underscore, lowercase letter, or digit, except the last character, which cannot be a dash, period, or underscore. For usage guidelines, see Custom Metrics balancing mode. This field can only be used for a global or regional backend service with the loadBalancingScheme set to EXTERNAL_MANAGED, INTERNAL_MANAGED INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderHealthChecksRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecInitProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderHealthChecksSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderHealthChecksSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecInitProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>OAuth2 Client Secret for IAP Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>OAuth2 Client Secret for IAP Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public V1beta1BackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>An optional, arbitrary JSON object with configuration data, understood by a locally installed custom policy implementation.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderLocalityLbPolicies
{
    /// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
    [JsonPropertyName("customPolicy")]
    public V1beta1BackendServiceSpecInitProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceSpecInitProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service and "logConfig.optionalMode" was set to CUSTOM. Contains a list of optional fields you want to include in the logs. For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace For example: orca_load_report, tls.protocol</summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>Specifies the optional logging mode for the load balancer traffic. Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM. Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.</summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service. The value of the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderOutlierDetectionInterval
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderOutlierDetection
{
    /// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta1BackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>Number of errors before a host is ejected from the connection pool. When the backend host is accessed over HTTP, a 5xx return code qualifies as an error. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>The number of consecutive gateway failures (502, 503, 504 status or connection errors that are mapped to one of those status codes) before a consecutive gateway failure ejection occurs. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive 5xx. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive gateway failures. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 0.</summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through success rate statistics. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
    [JsonPropertyName("interval")]
    public V1beta1BackendServiceSpecInitProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in the load balancing pool for the backend service that can be ejected. Defaults to 10%.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>The number of hosts in a cluster that must have enough request volume to detect success rate outliers. If the number of hosts is less than this setting, outlier detection via success rate statistics is not performed for any host in the cluster. Defaults to 5.</summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>The minimum number of total requests that must be collected in one interval (as defined by the interval duration above) to include this host in success rate based outlier detection. If the volume is lower than this setting, outlier detection via success rate statistics is not performed for that host. Defaults to 100.</summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>This factor is used to determine the ejection threshold for success rate outlier ejection. The ejection threshold is the difference between the mean success rate, and the product of this factor and the standard deviation of the mean success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided by a thousand to get a double. That is, if the desired factor is 1.9, the runtime value should be 1900. Defaults to 1900.</summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>The access key used for s3 bucket authentication. Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>The access key used for s3 bucket authentication. Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1BackendServiceSpecInitProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin. For example, "us-east-1" for AWS or "us-ashburn-1" for OCI.</summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderSecuritySettings
{
    /// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta1BackendServiceSpecInitProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service. This resource itself does not affect configuration unless it is attached to a backend service resource.</summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate. If specified, the client will verify that the server certificate's subject alt name matches one of the specified values.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderStrongSessionAffinityCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceSpecInitProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecInitProvider
{
    /// <summary>Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the load balancing scheme is INTERNAL, this field is not used.</summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>The set of backends that serve this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1BackendServiceSpecInitProviderBackend>? Backend { get; set; }

    /// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta1BackendServiceSpecInitProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta1BackendServiceSpecInitProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>Compress text responses using Brotli or gzip compression, based on the client's Accept-Encoding header. Possible values are: AUTOMATIC, DISABLED.</summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>Time for which instance will be drained (not accept new connections, but still work to finish started).</summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1BackendServiceSpecInitProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceSpecInitProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied requests.</summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied responses.</summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and TEST_ALL_TRAFFIC. To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate traffic by percentage using externalManagedMigrationTestingPercentage. Rolling back a migration requires the states to be set in reverse order. So changing the scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.</summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>Determines the fraction of requests that should be processed by the Global external Application Load Balancer. The value of this field must be in the range [0, 100]. Session affinity options will slightly affect this routing behavior, for more details, see: Session Affinity. This value can only be set if the loadBalancingScheme in the backend service is set to EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.</summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently at most one health check can be specified. A health check must be specified unless the backend service uses an internet or serverless NEG as a backend. For internal load balancing, a URL to a HealthCheck resource must be specified instead.</summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta1BackendServiceSpecInitProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta1BackendServiceSpecInitProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
    [JsonPropertyName("iap")]
    public V1beta1BackendServiceSpecInitProviderIap? Iap { get; set; }

    /// <summary>Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.</summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>Indicates whether the backend service will be used with internal or external load balancing. A backend service created for one type of load balancing cannot be used with the other. For more information, refer to Choosing a load balancer. Default value is EXTERNAL. Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>A list of locality load balancing policies to be used in order of preference. Either the policy or the customPolicy field should be set. Overrides any value set in the localityLbPolicy field. localityLbPolicies is only supported when the BackendService is referenced by a URL Map that is referenced by a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta1BackendServiceSpecInitProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>The load balancing algorithm used within the scope of the locality. The possible values are:</summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1BackendServiceSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta1BackendServiceSpecInitProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1BackendServiceSpecInitProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the load balancing scheme is EXTERNAL.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The protocol this BackendService uses to communicate with backends. The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP or GRPC. Refer to the documentation for the load balancers or for Traffic Director for more information. Must be set to GRPC when the backend service is referenced by a URL map that is bound to target gRPC proxy. Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("securitySettings")]
    public V1beta1BackendServiceSpecInitProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>URL to networkservices.ServiceLbPolicy resource. Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.</summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP. Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta1BackendServiceSpecInitProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>The backend service timeout has a different meaning depending on the type of load balancer. For more information see, Backend service settings. The default is 30 seconds. The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BackendServiceSpec defines the desired state of BackendService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackendServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackendServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackendServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackendServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderBackendCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Optional parameter to define a target utilization for the Custom Metrics balancing mode. The valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderBackend
{
    /// <summary>Specifies the balancing mode for this backend. For global HTTP(S) or TCP/SSL load balancing, the default is UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)), CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL). See the Backend Services Overview for an explanation of load balancing modes. Default value is UTILIZATION. Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.</summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>A multiplier applied to the group's maximum servicing capacity (based on UTILIZATION, RATE or CONNECTION). Default value is 1, which means the group will serve up to 100% of its configured capacity (depending on balancingMode). A setting of 0 means the group is completely drained, offering 0% of its available Capacity. Valid range is [0.0,1.0].</summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>The set of custom metrics that are used for CUSTOM_METRICS BalancingMode. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceStatusAtProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The fully-qualified URL of an Instance Group or Network Endpoint Group resource. In case of instance group this defines the list of instances that serve traffic. Member virtual machine instances from each instance group must live in the same zone as the instance group itself. No two backends in a backend service are allowed to use same Instance Group resource. For Network Endpoint Groups this defines list of endpoints. All endpoints of Network Endpoint Group must be hosted on instances located in the same zone as the Network Endpoint Group. Backend services cannot mix Instance Group and Network Endpoint Group backends. Note that you must specify an Instance Group or Network Endpoint Group resource using the fully-qualified URL, rather than a partial URL.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>The max number of simultaneous connections for the group. Can be used with either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or one of maxConnectionsPerInstance or maxConnectionsPerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerEndpoint must be set.</summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes. For CONNECTION mode, either maxConnections or maxConnectionsPerInstance must be set.</summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>The max requests per second (RPS) of the group. Can be used with either RATE or UTILIZATION balancing modes, but required if RATE mode. For RATE mode, either maxRate or one of maxRatePerInstance or maxRatePerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerEndpoint must be set.</summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerInstance must be set.</summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>Used when balancingMode is UTILIZATION. This ratio defines the CPU utilization target for the group. Valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>This field indicates whether this backend should be fully utilized before sending traffic to backends with default preference. This field cannot be set when loadBalancingScheme is set to 'EXTERNAL'. The possible values are:</summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>Allows HTTP request headers (by name) to be used in the cache key.</summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>If true, include query string parameters in the cache key according to query_string_whitelist and query_string_blacklist. If neither is set, the entire query string will be included. If false, the query string will be excluded from the cache key entirely.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Names of query string parameters to exclude in cache keys. All other parameters will be included. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>Names of query string parameters to include in cache keys. All other parameters will be excluded. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501 can be specified as values, and you cannot specify a status code more than once.</summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCdnPolicy
{
    /// <summary>Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified. The cache is bypassed for all cdnPolicy.cacheMode settings. Structure is documented below.</summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta1BackendServiceStatusAtProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>The CacheKeyPolicy for this CdnPolicy. Structure is documented below.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta1BackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>Specifies the cache setting for all responses from this backend. The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.</summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy. Omitting the policy and leaving negativeCaching enabled will use Cloud CDN's default cache TTLs. Structure is documented below.</summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta1BackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.</summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>Maximum number of seconds the response to a signed URL request will be considered fresh, defaults to 1hr (3600s). After this time period, the response will be revalidated before being served. When serving responses to signed URL requests, Cloud CDN will internally behave as though all responses from this backend had a "Cache-Control: public, max-age=[TTL]" header, regardless of any existing Cache-Control header. The actual headers served in responses will not be altered.</summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCircuitBreakers
{
    /// <summary>The maximum number of connections to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>The maximum number of pending requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>The maximum number of parallel requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>Maximum requests for a single backend connection. This parameter is respected by both the HTTP/1.1 and HTTP/2 implementations. If not specified, there is no limit. Setting this parameter to 1 will effectively disable keep alive.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>The maximum number of parallel retries to the backend cluster. Defaults to 3.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderConsistentHashHttpCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceStatusAtProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderConsistentHash
{
    /// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE. Structure is documented below.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1BackendServiceStatusAtProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>The hash based on the value of the specified header field. This field is applicable if the sessionAffinity is set to HEADER_FIELD.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>The minimum number of virtual nodes to use for the hash ring. Larger ring sizes result in more granular load distributions. If the number of hosts in the load balancing pool is larger than the ring size, each host will be assigned a single virtual node. Defaults to 1024.</summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderCustomMetrics
{
    /// <summary>If true, the metric data is collected and reported to Cloud Monitoring, but is not used for load balancing.</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Name of a custom utilization signal. The name must be 1-64 characters long and match the regular expression a-z? which means the first character must be a lowercase letter, and all following characters must be a dash, period, underscore, lowercase letter, or digit, except the last character, which cannot be a dash, period, or underscore. For usage guidelines, see Custom Metrics balancing mode. This field can only be used for a global or regional backend service with the loadBalancingScheme set to EXTERNAL_MANAGED, INTERNAL_MANAGED INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }
}

/// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>An optional, arbitrary JSON object with configuration data, understood by a locally installed custom policy implementation.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderLocalityLbPolicies
{
    /// <summary>The configuration for a custom policy implemented by the user and deployed with the client. Structure is documented below.</summary>
    [JsonPropertyName("customPolicy")]
    public V1beta1BackendServiceStatusAtProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>The configuration for a built-in load balancing policy. Structure is documented below.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendServiceStatusAtProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service and "logConfig.optionalMode" was set to CUSTOM. Contains a list of optional fields you want to include in the logs. For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace For example: orca_load_report, tls.protocol</summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>Specifies the optional logging mode for the load balancer traffic. Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM. Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.</summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service. The value of the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderMaxStreamDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderOutlierDetectionInterval
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderOutlierDetection
{
    /// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s. Structure is documented below.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta1BackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>Number of errors before a host is ejected from the connection pool. When the backend host is accessed over HTTP, a 5xx return code qualifies as an error. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>The number of consecutive gateway failures (502, 503, 504 status or connection errors that are mapped to one of those status codes) before a consecutive gateway failure ejection occurs. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive 5xx. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive gateway failures. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 0.</summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through success rate statistics. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds. Structure is documented below.</summary>
    [JsonPropertyName("interval")]
    public V1beta1BackendServiceStatusAtProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in the load balancing pool for the backend service that can be ejected. Defaults to 10%.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>The number of hosts in a cluster that must have enough request volume to detect success rate outliers. If the number of hosts is less than this setting, outlier detection via success rate statistics is not performed for any host in the cluster. Defaults to 5.</summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>The minimum number of total requests that must be collected in one interval (as defined by the interval duration above) to include this host in success rate based outlier detection. If the volume is lower than this setting, outlier detection via success rate statistics is not performed for that host. Defaults to 100.</summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>This factor is used to determine the ejection threshold for success rate outlier ejection. The ejection threshold is the difference between the mean success rate, and the product of this factor and the standard deviation of the mean success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided by a thousand to get a double. That is, if the desired factor is 1.9, the runtime value should be 1900. Defaults to 1900.</summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin. For example, "us-east-1" for AWS or "us-ashburn-1" for OCI.</summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderSecuritySettings
{
    /// <summary>The configuration needed to generate a signature for access to private storage buckets that support AWS's Signature Version 4 for authentication. Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends. Structure is documented below.</summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta1BackendServiceStatusAtProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service. This resource itself does not affect configuration unless it is attached to a backend service resource.</summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate. If specified, the client will verify that the server certificate's subject alt name matches one of the specified values.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Lifetime of the cookie. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderStrongSessionAffinityCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie. Structure is documented below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1BackendServiceStatusAtProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusAtProvider
{
    /// <summary>Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the load balancing scheme is INTERNAL, this field is not used.</summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>The set of backends that serve this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1BackendServiceStatusAtProviderBackend>? Backend { get; set; }

    /// <summary>Cloud CDN configuration for this BackendService. Structure is documented below.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta1BackendServiceStatusAtProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta1BackendServiceStatusAtProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>Compress text responses using Brotli or gzip compression, based on the client's Accept-Encoding header. Possible values are: AUTOMATIC, DISABLED.</summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>Time for which instance will be drained (not accept new connections, but still work to finish started).</summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH. Structure is documented below.</summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1BackendServiceStatusAtProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy. Structure is documented below.</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1BackendServiceStatusAtProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied requests.</summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>Headers that the HTTP/S load balancer should add to proxied responses.</summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and TEST_ALL_TRAFFIC. To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate traffic by percentage using externalManagedMigrationTestingPercentage. Rolling back a migration requires the states to be set in reverse order. So changing the scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.</summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>Determines the fraction of requests that should be processed by the Global external Application Load Balancer. The value of this field must be in the range [0, 100]. Session affinity options will slightly affect this routing behavior, for more details, see: Session Affinity. This value can only be set if the loadBalancingScheme in the backend service is set to EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.</summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("generatedId")]
    public double? GeneratedId { get; set; }

    /// <summary>The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently at most one health check can be specified. A health check must be specified unless the backend service uses an internet or serverless NEG as a backend. For internal load balancing, a URL to a HealthCheck resource must be specified instead.</summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy. If OAuth client is not set, the Google-managed OAuth client is used. Structure is documented below.</summary>
    [JsonPropertyName("iap")]
    public V1beta1BackendServiceStatusAtProviderIap? Iap { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/backendServices/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.</summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>Indicates whether the backend service will be used with internal or external load balancing. A backend service created for one type of load balancing cannot be used with the other. For more information, refer to Choosing a load balancer. Default value is EXTERNAL. Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>A list of locality load balancing policies to be used in order of preference. Either the policy or the customPolicy field should be set. Overrides any value set in the localityLbPolicy field. localityLbPolicies is only supported when the BackendService is referenced by a URL Map that is referenced by a target gRPC proxy that has the validateForProxyless field set to true. Structure is documented below.</summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta1BackendServiceStatusAtProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>The load balancing algorithm used within the scope of the locality. The possible values are:</summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1BackendServiceStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the beginning of the stream until the response has been completely processed, including all retries. A stream that does not complete in this duration is closed. If not specified, there will be no timeout limit, i.e. the maximum duration is infinite. This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service. This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta1BackendServiceStatusAtProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. Applicable backend service types can be a global backend service with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1BackendServiceStatusAtProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the load balancing scheme is EXTERNAL.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The protocol this BackendService uses to communicate with backends. The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP or GRPC. Refer to the documentation for the load balancers or for Traffic Director for more information. Must be set to GRPC when the backend service is referenced by a URL map that is bound to target gRPC proxy. Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. Structure is documented below.</summary>
    [JsonPropertyName("securitySettings")]
    public V1beta1BackendServiceStatusAtProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>URL to networkservices.ServiceLbPolicy resource. Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.</summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP. Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY. Structure is documented below.</summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta1BackendServiceStatusAtProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>The backend service timeout has a different meaning depending on the type of load balancer. For more information see, Backend service settings. The default is 30 seconds. The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatusConditions
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

/// <summary>BackendServiceStatus defines the observed state of BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackendServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackendServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackendService is the Schema for the BackendServices API. A Backend Service defines a group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackendService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackendServiceSpec>, IStatus<V1beta1BackendServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackendService";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "backendservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackendServiceSpec defines the desired state of BackendService</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackendServiceSpec Spec { get; set; }

    /// <summary>BackendServiceStatus defines the observed state of BackendService.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackendServiceStatus? Status { get; set; }
}