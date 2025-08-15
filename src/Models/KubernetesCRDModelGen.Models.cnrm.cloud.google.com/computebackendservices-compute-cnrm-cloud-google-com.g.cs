using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackendGroupInstanceGroupRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstanceGroup` resource.</summary>
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
public partial class V1beta1ComputeBackendServiceSpecBackendGroupNetworkEndpointGroupRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetworkEndpointGroup` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a ComputeInstanceGroup or ComputeNetworkEndpointGroup resource. In case of instance group this defines the list of instances that serve traffic. Member virtual machine instances from each instance group must live in the same zone as the instance group itself. No two backends in a backend service are allowed to use same Instance Group resource.  For Network Endpoint Groups this defines list of endpoints. All endpoints of Network Endpoint Group must be hosted on instances located in the same zone as the Network Endpoint Group.  Backend services cannot mix Instance Group and Network Endpoint Group backends.  When the 'load_balancing_scheme' is INTERNAL, only instance groups are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackendGroup
{
    /// <summary></summary>
    [JsonPropertyName("instanceGroupRef")]
    public V1beta1ComputeBackendServiceSpecBackendGroupInstanceGroupRef? InstanceGroupRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkEndpointGroupRef")]
    public V1beta1ComputeBackendServiceSpecBackendGroupNetworkEndpointGroupRef? NetworkEndpointGroupRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackend
{
    /// <summary>Specifies the balancing mode for this backend.  For global HTTP(S) or TCP/SSL load balancing, the default is UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)) and CONNECTION (for TCP/SSL).  See the [Backend Services Overview](https://cloud.google.com/load-balancing/docs/backend-service#balancing-mode) for an explanation of load balancing modes. Default value: "UTILIZATION" Possible values: ["UTILIZATION", "RATE", "CONNECTION"].</summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>A multiplier applied to the group's maximum servicing capacity (based on UTILIZATION, RATE or CONNECTION).  Default value is 1, which means the group will serve up to 100% of its configured capacity (depending on balancingMode). A setting of 0 means the group is completely drained, offering 0% of its available Capacity. Valid range is [0.0,1.0].</summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>This field designates whether this is a failover backend. More than one failover backend can be configured for a given RegionBackendService.</summary>
    [JsonPropertyName("failover")]
    public bool? Failover { get; set; }

    /// <summary>Reference to a ComputeInstanceGroup or ComputeNetworkEndpointGroup resource. In case of instance group this defines the list of instances that serve traffic. Member virtual machine instances from each instance group must live in the same zone as the instance group itself. No two backends in a backend service are allowed to use same Instance Group resource.  For Network Endpoint Groups this defines list of endpoints. All endpoints of Network Endpoint Group must be hosted on instances located in the same zone as the Network Endpoint Group.  Backend services cannot mix Instance Group and Network Endpoint Group backends.  When the 'load_balancing_scheme' is INTERNAL, only instance groups are supported.</summary>
    [JsonPropertyName("group")]
    public V1beta1ComputeBackendServiceSpecBackendGroup Group { get; set; }

    /// <summary>The max number of simultaneous connections for the group. Can be used with either CONNECTION or UTILIZATION balancing modes.  For CONNECTION mode, either maxConnections or one of maxConnectionsPerInstance or maxConnectionsPerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes.  For CONNECTION mode, either maxConnections or maxConnectionsPerEndpoint must be set.</summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public int? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either CONNECTION or UTILIZATION balancing modes.  For CONNECTION mode, either maxConnections or maxConnectionsPerInstance must be set.</summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public int? MaxConnectionsPerInstance { get; set; }

    /// <summary>The max requests per second (RPS) of the group.  Can be used with either RATE or UTILIZATION balancing modes, but required if RATE mode. For RATE mode, either maxRate or one of maxRatePerInstance or maxRatePerEndpoint, as appropriate for group type, must be set.</summary>
    [JsonPropertyName("maxRate")]
    public int? MaxRate { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend network endpoint can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerEndpoint must be set.</summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend instance can handle. This is used to calculate the capacity of the group. Can be used in either balancing mode. For RATE mode, either maxRate or maxRatePerInstance must be set.</summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>Used when balancingMode is UTILIZATION. This ratio defines the CPU utilization target for the group. Valid range is [0.0, 1.0].</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }
}

/// <summary>The CacheKeyPolicy for this CdnPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyCacheKeyPolicy
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

    /// <summary>If true, include query string parameters in the cache key according to query_string_whitelist and query_string_blacklist. If neither is set, the entire query string will be included.  If false, the query string will be excluded from the cache key entirely.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Names of query string parameters to exclude in cache keys.  All other parameters will be included. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>Names of query string parameters to include in cache keys.  All other parameters will be excluded. Either specify query_string_whitelist or query_string_blacklist, not both. '&amp;' and '=' will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyNegativeCachingPolicy
{
    /// <summary>The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501 can be specified as values, and you cannot specify a status code more than once.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>The TTL (in seconds) for which to cache responses with the corresponding status code. The maximum allowed value is 1800s (30 minutes), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Cloud CDN configuration for this BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicy
{
    /// <summary>Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified. The cache is bypassed for all cdnPolicy.cacheMode settings.</summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta1ComputeBackendServiceSpecCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>The CacheKeyPolicy for this CdnPolicy.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta1ComputeBackendServiceSpecCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>Specifies the cache setting for all responses from this backend. The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: ["USE_ORIGIN_HEADERS", "FORCE_CACHE_ALL", "CACHE_ALL_STATIC"].</summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public int? ClientTtl { get; set; }

    /// <summary>Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).</summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public int? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy. Omitting the policy and leaving negativeCaching enabled will use Cloud CDN's default cache TTLs.</summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta1ComputeBackendServiceSpecCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public int? ServeWhileStale { get; set; }

    /// <summary>Maximum number of seconds the response to a signed URL request will be considered fresh, defaults to 1hr (3600s). After this time period, the response will be revalidated before being served.  When serving responses to signed URL requests, Cloud CDN will internally behave as though all responses from this backend had a "Cache-Control: public, max-age=[TTL]" header, regardless of any existing Cache-Control header. The actual headers served in responses will not be altered.</summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public int? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>The timeout for new network connections to hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCircuitBreakersConnectTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCircuitBreakers
{
    /// <summary>The timeout for new network connections to hosts.</summary>
    [JsonPropertyName("connectTimeout")]
    public V1beta1ComputeBackendServiceSpecCircuitBreakersConnectTimeout? ConnectTimeout { get; set; }

    /// <summary>The maximum number of connections to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>The maximum number of pending requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public int? MaxPendingRequests { get; set; }

    /// <summary>The maximum number of parallel requests to the backend cluster. Defaults to 1024.</summary>
    [JsonPropertyName("maxRequests")]
    public int? MaxRequests { get; set; }

    /// <summary>Maximum requests for a single backend connection. This parameter is respected by both the HTTP/1.1 and HTTP/2 implementations. If not specified, there is no limit. Setting this parameter to 1 will effectively disable keep alive.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>The maximum number of parallel retries to the backend cluster. Defaults to 3.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }
}

/// <summary>Connection Tracking configuration for this BackendService. This is available only for Layer 4 Internal Load Balancing and Network Load Balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConnectionTrackingPolicy
{
    /// <summary>Specifies connection persistence when backends are unhealthy.  If set to 'DEFAULT_FOR_PROTOCOL', the existing connections persist on unhealthy backends only for connection-oriented protocols (TCP and SCTP) and only if the Tracking Mode is PER_CONNECTION (default tracking mode) or the Session Affinity is configured for 5-tuple. They do not persist for UDP.  If set to 'NEVER_PERSIST', after a backend becomes unhealthy, the existing connections on the unhealthy backend are never persisted on the unhealthy backend. They are always diverted to newly selected healthy backends (unless all backends are unhealthy).  If set to 'ALWAYS_PERSIST', existing connections always persist on unhealthy backends regardless of protocol and session affinity. It is generally not recommended to use this mode overriding the default. Default value: "DEFAULT_FOR_PROTOCOL" Possible values: ["DEFAULT_FOR_PROTOCOL", "NEVER_PERSIST", "ALWAYS_PERSIST"].</summary>
    [JsonPropertyName("connectionPersistenceOnUnhealthyBackends")]
    public string? ConnectionPersistenceOnUnhealthyBackends { get; set; }

    /// <summary>Enable Strong Session Affinity for Network Load Balancing. This option is not available publicly.</summary>
    [JsonPropertyName("enableStrongAffinity")]
    public bool? EnableStrongAffinity { get; set; }

    /// <summary>Specifies how long to keep a Connection Tracking entry while there is no matching traffic (in seconds).  For L4 ILB the minimum(default) is 10 minutes and maximum is 16 hours.  For NLB the minimum(default) is 60 seconds and the maximum is 16 hours.</summary>
    [JsonPropertyName("idleTimeoutSec")]
    public int? IdleTimeoutSec { get; set; }

    /// <summary>Specifies the key used for connection tracking. There are two options: 'PER_CONNECTION': The Connection Tracking is performed as per the Connection Key (default Hash Method) for the specific protocol.  'PER_SESSION': The Connection Tracking is performed as per the configured Session Affinity. It matches the configured Session Affinity. Default value: "PER_CONNECTION" Possible values: ["PER_CONNECTION", "PER_SESSION"].</summary>
    [JsonPropertyName("trackingMode")]
    public string? TrackingMode { get; set; }
}

/// <summary>Lifetime of the cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHashHttpCookieTtl
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1ComputeBackendServiceSpecConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHash
{
    /// <summary>Hash is based on HTTP Cookie. This field describes a HTTP cookie that will be used as the hash key for the consistent hash load balancer. If the cookie is not present, it will be generated. This field is applicable if the sessionAffinity is set to HTTP_COOKIE.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1ComputeBackendServiceSpecConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>The hash based on the value of the specified header field. This field is applicable if the sessionAffinity is set to HEADER_FIELD.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>The minimum number of virtual nodes to use for the hash ring. Larger ring sizes result in more granular load distributions. If the number of hosts in the load balancing pool is larger than the ring size, each host will be assigned a single virtual node. Defaults to 1024.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecEdgeSecurityPolicyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSecurityPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Policy for failovers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecFailoverPolicy
{
    /// <summary>On failover or failback, this field indicates whether connection drain will be honored. Setting this to true has the following effect: connections to the old active pool are not drained. Connections to the new active pool use the timeout of 10 min (currently fixed). Setting to false has the following effect: both old and new connections will have a drain timeout of 10 min. This can be set to true only if the protocol is TCP. The default is false.</summary>
    [JsonPropertyName("disableConnectionDrainOnFailover")]
    public bool? DisableConnectionDrainOnFailover { get; set; }

    /// <summary>This option is used only when no healthy VMs are detected in the primary and backup instance groups. When set to true, traffic is dropped. When set to false, new connections are sent across all VMs in the primary group. The default is false.</summary>
    [JsonPropertyName("dropTrafficIfUnhealthy")]
    public bool? DropTrafficIfUnhealthy { get; set; }

    /// <summary>The value of the field must be in [0, 1]. If the ratio of the healthy VMs in the primary backend is at or below this number, traffic arriving at the load-balanced IP will be directed to the failover backend. In case where 'failoverRatio' is not set or all the VMs in the backup backend are unhealthy, the traffic will be directed back to the primary backend in the "force" mode, where traffic will be spread to the healthy VMs with the best effort, or to all VMs when no VM is healthy. This field is only used with l4 load balancing.</summary>
    [JsonPropertyName("failoverRatio")]
    public double? FailoverRatio { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecHealthChecksHealthCheckRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeHealthCheck` resource.</summary>
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
public partial class V1beta1ComputeBackendServiceSpecHealthChecksHttpHealthCheckRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeHTTPHealthCheck` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The health check resources for health checking this ComputeBackendService. Currently at most one health check can be specified, and a health check is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecHealthChecks
{
    /// <summary></summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1ComputeBackendServiceSpecHealthChecksHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHealthCheckRef")]
    public V1beta1ComputeBackendServiceSpecHealthChecksHttpHealthCheckRef? HttpHealthCheckRef { get; set; }
}

/// <summary>OAuth2 Client ID for IAP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientIdRef
{
    /// <summary>Allowed value: The `name` field of an `IAPIdentityAwareProxyClient` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>OAuth2 Client Secret for IAP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecret
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFrom? ValueFrom { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIap
{
    /// <summary>DEPRECATED. Although this field is still available, there is limited support. We recommend that you use `spec.iap.oauth2ClientIdRef` instead.</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>OAuth2 Client ID for IAP.</summary>
    [JsonPropertyName("oauth2ClientIdRef")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientIdRef? Oauth2ClientIdRef { get; set; }

    /// <summary>OAuth2 Client Secret for IAP.</summary>
    [JsonPropertyName("oauth2ClientSecret")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecret? Oauth2ClientSecret { get; set; }

    /// <summary>OAuth2 Client Secret SHA-256 for IAP.</summary>
    [JsonPropertyName("oauth2ClientSecretSha256")]
    public string? Oauth2ClientSecretSha256 { get; set; }
}

/// <summary>The configuration for a custom policy implemented by the user and deployed with the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPoliciesCustomPolicy
{
    /// <summary>An optional, arbitrary JSON object with configuration data, understood by a locally installed custom policy implementation.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Identifies the custom policy.  The value should match the type the custom implementation is registered with on the gRPC clients. It should follow protocol buffer message naming conventions and include the full path (e.g. myorg.CustomLbPolicy). The maximum length is 256 characters.  Note that specifying the same custom policy more than once for a backend is not a valid configuration and will be rejected.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The configuration for a built-in load balancing policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPoliciesPolicy
{
    /// <summary>The name of a locality load balancer policy to be used. The value should be one of the predefined ones as supported by localityLbPolicy, although at the moment only ROUND_ROBIN is supported.  This field should only be populated when the customPolicy field is not used.  Note that specifying the same policy more than once for a backend is not a valid configuration and will be rejected.  The possible values are:  * 'ROUND_ROBIN': This is a simple policy in which each healthy backend                 is selected in round robin order.  * 'LEAST_REQUEST': An O(1) algorithm which selects two random healthy                   hosts and picks the host which has fewer active requests.  * 'RING_HASH': The ring/modulo hash load balancer implements consistent               hashing to backends. The algorithm has the property that the               addition/removal of a host from a set of N hosts only affects               1/N of the requests.  * 'RANDOM': The load balancer selects a random healthy host.  * 'ORIGINAL_DESTINATION': Backend host is selected based on the client                           connection metadata, i.e., connections are opened                           to the same address as the destination address of                           the incoming connection before the connection                           was redirected to the load balancer.  * 'MAGLEV': used as a drop in replacement for the ring hash load balancer.             Maglev is not as stable as ring hash but has faster table lookup             build times and host selection times. For more information about             Maglev, refer to https://ai.google/research/pubs/pub44824 Possible values: ["ROUND_ROBIN", "LEAST_REQUEST", "RING_HASH", "RANDOM", "ORIGINAL_DESTINATION", "MAGLEV"].</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPolicies
{
    /// <summary>The configuration for a custom policy implemented by the user and deployed with the client.</summary>
    [JsonPropertyName("customPolicy")]
    public V1beta1ComputeBackendServiceSpecLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>The configuration for a built-in load balancing policy.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeBackendServiceSpecLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>This field can only be specified if logging is enabled for this backend service. The value of the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>The network to which this backend service belongs.  This field can only be specified when the load balancing scheme is set to INTERNAL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetectionBaseEjectionTime
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetectionInterval
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 'seconds' field and a positive 'nanos' field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetection
{
    /// <summary>The base time that a host is ejected for. The real time is equal to the base time multiplied by the number of times the host has been ejected. Defaults to 30000ms or 30s.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta1ComputeBackendServiceSpecOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>Number of errors before a host is ejected from the connection pool. When the backend host is accessed over HTTP, a 5xx return code qualifies as an error. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>The number of consecutive gateway failures (502, 503, 504 status or connection errors that are mapped to one of those status codes) before a consecutive gateway failure ejection occurs. Defaults to 5.</summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public int? ConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive 5xx. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public int? EnforcingConsecutiveErrors { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through consecutive gateway failures. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 0.</summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public int? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>The percentage chance that a host will be actually ejected when an outlier status is detected through success rate statistics. This setting can be used to disable ejection or to ramp it up slowly. Defaults to 100.</summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public int? EnforcingSuccessRate { get; set; }

    /// <summary>Time interval between ejection sweep analysis. This can result in both new ejections as well as hosts being returned to service. Defaults to 10 seconds.</summary>
    [JsonPropertyName("interval")]
    public V1beta1ComputeBackendServiceSpecOutlierDetectionInterval? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in the load balancing pool for the backend service that can be ejected. Defaults to 10%.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>The number of hosts in a cluster that must have enough request volume to detect success rate outliers. If the number of hosts is less than this setting, outlier detection via success rate statistics is not performed for any host in the cluster. Defaults to 5.</summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public int? SuccessRateMinimumHosts { get; set; }

    /// <summary>The minimum number of total requests that must be collected in one interval (as defined by the interval duration above) to include this host in success rate based outlier detection. If the volume is lower than this setting, outlier detection via success rate statistics is not performed for that host. Defaults to 100.</summary>
    [JsonPropertyName("successRateRequestVolume")]
    public int? SuccessRateRequestVolume { get; set; }

    /// <summary>This factor is used to determine the ejection threshold for success rate outlier ejection. The ejection threshold is the difference between the mean success rate, and the product of this factor and the standard deviation of the mean success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided by a thousand to get a double. That is, if the desired factor is 1.9, the runtime value should be 1900. Defaults to 1900.</summary>
    [JsonPropertyName("successRateStdevFactor")]
    public int? SuccessRateStdevFactor { get; set; }
}

/// <summary>The security policy associated with this backend service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecurityPolicyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSecurityPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service. This resource itself does not affect configuration unless it is attached to a backend service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecuritySettingsClientTLSPolicyRef
{
    /// <summary>Allowed value: string of the format `//networksecurity.googleapis.com/projects/{{project}}/locations/{{location}}/clientTlsPolicies/{{value}}`, where {{value}} is the `name` field of a `NetworkSecurityClientTLSPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, or HTTP2, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecuritySettings
{
    /// <summary>ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service. This resource itself does not affect configuration unless it is attached to a backend service resource.</summary>
    [JsonPropertyName("clientTLSPolicyRef")]
    public V1beta1ComputeBackendServiceSpecSecuritySettingsClientTLSPolicyRef ClientTLSPolicyRef { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate. If specified, the client will verify that the server certificate's subject alt name matches one of the specified values.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string> SubjectAltNames { get; set; }
}

/// <summary>Subsetting configuration for this BackendService. Currently this is applicable only for Internal TCP/UDP load balancing and Internal HTTP(S) load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSubsetting
{
    /// <summary>The algorithm used for subsetting. Possible values: ["CONSISTENT_HASH_SUBSETTING"].</summary>
    [JsonPropertyName("policy")]
    public string Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpec
{
    /// <summary>Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day.  When the load balancing scheme is INTERNAL, this field is not used.</summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public int? AffinityCookieTtlSec { get; set; }

    /// <summary>The set of backends that serve this BackendService.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1ComputeBackendServiceSpecBackend>? Backend { get; set; }

    /// <summary>Cloud CDN configuration for this BackendService.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta1ComputeBackendServiceSpecCdnPolicy? CdnPolicy { get; set; }

    /// <summary>Settings controlling the volume of connections to a backend service. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta1ComputeBackendServiceSpecCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>Compress text responses using Brotli or gzip compression, based on the client's Accept-Encoding header. Possible values: ["AUTOMATIC", "DISABLED"].</summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>Time for which instance will be drained (not accept new connections, but still work to finish started).</summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public int? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>Connection Tracking configuration for this BackendService. This is available only for Layer 4 Internal Load Balancing and Network Load Balancing.</summary>
    [JsonPropertyName("connectionTrackingPolicy")]
    public V1beta1ComputeBackendServiceSpecConnectionTrackingPolicy? ConnectionTrackingPolicy { get; set; }

    /// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH.</summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1ComputeBackendServiceSpecConsistentHash? ConsistentHash { get; set; }

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
    [JsonPropertyName("edgeSecurityPolicyRef")]
    public V1beta1ComputeBackendServiceSpecEdgeSecurityPolicyRef? EdgeSecurityPolicyRef { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>Policy for failovers.</summary>
    [JsonPropertyName("failoverPolicy")]
    public V1beta1ComputeBackendServiceSpecFailoverPolicy? FailoverPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1beta1ComputeBackendServiceSpecHealthChecks>? HealthChecks { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy.</summary>
    [JsonPropertyName("iap")]
    public V1beta1ComputeBackendServiceSpecIap? Iap { get; set; }

    /// <summary>Immutable. Indicates whether the backend service will be used with internal or external load balancing. A backend service created for one type of load balancing cannot be used with the other. For more information, refer to [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: "EXTERNAL" Possible values: ["EXTERNAL", "INTERNAL_SELF_MANAGED", "INTERNAL_MANAGED", "EXTERNAL_MANAGED"].</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>A list of locality load balancing policies to be used in order of preference. Either the policy or the customPolicy field should be set. Overrides any value set in the localityLbPolicy field.  localityLbPolicies is only supported when the BackendService is referenced by a URL Map that is referenced by a target gRPC proxy that has the validateForProxyless field set to true.</summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta1ComputeBackendServiceSpecLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>The load balancing algorithm used within the scope of the locality. The possible values are:  * 'ROUND_ROBIN': This is a simple policy in which each healthy backend                  is selected in round robin order.  * 'LEAST_REQUEST': An O(1) algorithm which selects two random healthy                    hosts and picks the host which has fewer active requests.  * 'RING_HASH': The ring/modulo hash load balancer implements consistent                hashing to backends. The algorithm has the property that the                addition/removal of a host from a set of N hosts only affects                1/N of the requests.  * 'RANDOM': The load balancer selects a random healthy host.  * 'ORIGINAL_DESTINATION': Backend host is selected based on the client                           connection metadata, i.e., connections are opened                           to the same address as the destination address of                           the incoming connection before the connection                           was redirected to the load balancer.  * 'MAGLEV': used as a drop in replacement for the ring hash load balancer.             Maglev is not as stable as ring hash but has faster table lookup             build times and host selection times. For more information about             Maglev, refer to https://ai.google/research/pubs/pub44824  * 'WEIGHTED_MAGLEV': Per-instance weighted Load Balancing via health check                      reported weights. If set, the Backend Service must                      configure a non legacy HTTP-based Health Check, and                      health check replies are expected to contain                      non-standard HTTP response header field                      X-Load-Balancing-Endpoint-Weight to specify the                      per-instance weights. If set, Load Balancing is weight                      based on the per-instance weights reported in the last                      processed health check replies, as long as every                      instance either reported a valid weight or had                      UNAVAILABLE_WEIGHT. Otherwise, Load Balancing remains                      equal-weight.   This field is applicable to either:  * A regional backend service with the service_protocol set to HTTP, HTTPS, or HTTP2,   and loadBalancingScheme set to INTERNAL_MANAGED. * A global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED. * A regional backend service with loadBalancingScheme set to EXTERNAL (External Network   Load Balancing). Only MAGLEV and WEIGHTED_MAGLEV values are possible for External   Network Load Balancing. The default is MAGLEV.   If session_affinity is not NONE, and this field is not set to MAGLEV, WEIGHTED_MAGLEV, or RING_HASH, session affinity settings will not take effect.  Only ROUND_ROBIN and RING_HASH are supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validate_for_proxyless field set to true. Possible values: ["ROUND_ROBIN", "LEAST_REQUEST", "RING_HASH", "RANDOM", "ORIGINAL_DESTINATION", "MAGLEV", "WEIGHTED_MAGLEV"].</summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>Location represents the geographical location of the ComputeBackendService. Specify a region name or "global" for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>This field denotes the logging options for the load balancer traffic served by this backend service. If logging is enabled, logs will be exported to Stackdriver.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeBackendServiceSpecLogConfig? LogConfig { get; set; }

    /// <summary>The network to which this backend service belongs.  This field can only be specified when the load balancing scheme is set to INTERNAL.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeBackendServiceSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Settings controlling eviction of unhealthy hosts from the load balancing pool. This field is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1ComputeBackendServiceSpecOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the load balancing scheme is EXTERNAL.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The protocol this BackendService uses to communicate with backends. The default is HTTP. **NOTE**: HTTP2 is only valid for beta HTTP/2 load balancer types and may result in errors if used with the GA API. **NOTE**: With protocol “UNSPECIFIED”, the backend service can be used by Layer 4 Internal Load Balancing or Network Load Balancing with TCP/UDP/L3_DEFAULT Forwarding Rule protocol. Possible values: ["HTTP", "HTTPS", "HTTP2", "TCP", "SSL", "GRPC", "UNSPECIFIED"].</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicyRef")]
    public V1beta1ComputeBackendServiceSpecSecurityPolicyRef? SecurityPolicyRef { get; set; }

    /// <summary>The security settings that apply to this backend service. This field is applicable to either a regional backend service with the service_protocol set to HTTP, HTTPS, or HTTP2, and load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("securitySettings")]
    public V1beta1ComputeBackendServiceSpecSecuritySettings? SecuritySettings { get; set; }

    /// <summary>Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP. Possible values: ["NONE", "CLIENT_IP", "CLIENT_IP_PORT_PROTO", "CLIENT_IP_PROTO", "GENERATED_COOKIE", "HEADER_FIELD", "HTTP_COOKIE"].</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Subsetting configuration for this BackendService. Currently this is applicable only for Internal TCP/UDP load balancing and Internal HTTP(S) load balancing.</summary>
    [JsonPropertyName("subsetting")]
    public V1beta1ComputeBackendServiceSpecSubsetting? Subsetting { get; set; }

    /// <summary>How many seconds to wait for the backend before considering it a failed request. Default is 30 seconds. Valid range is [1, 86400].</summary>
    [JsonPropertyName("timeoutSec")]
    public int? TimeoutSec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceStatusConditions
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
public partial class V1beta1ComputeBackendServiceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeBackendServiceStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("generatedId")]
    public int? GeneratedId { get; set; }

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
public partial class V1beta1ComputeBackendService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeBackendServiceSpec>, IStatus<V1beta1ComputeBackendServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeBackendService";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservices";
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
    public V1beta1ComputeBackendServiceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeBackendServiceStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeBackendServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeBackendService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeBackendServiceList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservices";
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
    public IList<V1beta1ComputeBackendService> Items { get; set; }
}