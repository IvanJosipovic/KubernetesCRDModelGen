using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    public string? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    public string? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>Indicates whether connections to this port should be secured using TLS.  Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

/// <summary>The upstream PROXY protocol settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol
{
    /// <summary>The PROXY protocol version to use.  Valid Options: V1, V2</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyRetryBudget
{
    /// <summary>Specifies the minimum retry concurrency allowed for the retry budget.</summary>
    [JsonPropertyName("minRetryConcurrency")]
    public int? MinRetryConcurrency { get; set; }

    /// <summary>Specifies the limit on concurrent retries as a percentage of the sum of active requests and active pending requests.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>Indicates whether connections to this port should be secured using TLS.  Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicyTunnel
{
    /// <summary>Specifies which protocol to use for tunneling the downstream connection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a host to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetHost")]
    public string TargetHost { get; set; }

    /// <summary>Specifies a port to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetPort")]
    public int TargetPort { get; set; }
}

/// <summary>Traffic policies that apply to this subset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsetsTrafficPolicy
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
    [JsonPropertyName("retryBudget")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyRetryBudget? RetryBudget { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1DestinationRuleSpecSubsetsTrafficPolicyTunnel? Tunnel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecSubsets
{
    /// <summary>Labels apply a filter over the endpoints of a service in the service registry.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Name of the subset.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Traffic policies that apply to this subset.</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1DestinationRuleSpecSubsetsTrafficPolicy? TrafficPolicy { get; set; }
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1DestinationRuleSpecTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1DestinationRuleSpecTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    public string? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    public string? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettingsTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>Indicates whether connections to this port should be secured using TLS.  Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyPortLevelSettings
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1DestinationRuleSpecTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

/// <summary>The upstream PROXY protocol settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyProxyProtocol
{
    /// <summary>The PROXY protocol version to use.  Valid Options: V1, V2</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyRetryBudget
{
    /// <summary>Specifies the minimum retry concurrency allowed for the retry budget.</summary>
    [JsonPropertyName("minRetryConcurrency")]
    public int? MinRetryConcurrency { get; set; }

    /// <summary>Specifies the limit on concurrent retries as a percentage of the sum of active requests and active pending requests.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>Indicates whether connections to this port should be secured using TLS.  Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicyTunnel
{
    /// <summary>Specifies which protocol to use for tunneling the downstream connection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a host to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetHost")]
    public string TargetHost { get; set; }

    /// <summary>Specifies a port to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetPort")]
    public int TargetPort { get; set; }
}

/// <summary>Traffic policies to apply (load balancing policy, connection pool sizes, outlier detection).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecTrafficPolicy
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1DestinationRuleSpecTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1DestinationRuleSpecTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1DestinationRuleSpecTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1DestinationRuleSpecTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1DestinationRuleSpecTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
    [JsonPropertyName("retryBudget")]
    public V1DestinationRuleSpecTrafficPolicyRetryBudget? RetryBudget { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1DestinationRuleSpecTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1DestinationRuleSpecTrafficPolicyTunnel? Tunnel { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Configuration affecting load balancing, outlier detection, etc. See more details at: https://istio.io/docs/reference/config/networking/destination-rule.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DestinationRuleSpec
{
    /// <summary>A list of namespaces to which this destination rule is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>One or more named sets that represent individual versions of a service.</summary>
    [JsonPropertyName("subsets")]
    public IList<V1DestinationRuleSpecSubsets>? Subsets { get; set; }

    /// <summary>Traffic policies to apply (load balancing policy, connection pool sizes, outlier detection).</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1DestinationRuleSpecTrafficPolicy? TrafficPolicy { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1DestinationRuleSpecWorkloadSelector? WorkloadSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DestinationRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1DestinationRuleSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DestinationRule";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "destinationrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting load balancing, outlier detection, etc. See more details at: https://istio.io/docs/reference/config/networking/destination-rule.html</summary>
    [JsonPropertyName("spec")]
    public V1DestinationRuleSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DestinationRuleList : IKubernetesObject<V1ListMeta>, IItems<V1DestinationRule>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DestinationRuleList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "destinationrules";
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
    public IList<V1DestinationRule> Items { get; set; }
}