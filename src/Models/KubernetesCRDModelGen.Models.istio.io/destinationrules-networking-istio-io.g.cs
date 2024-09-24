using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    /// <summary>DEFAULT</summary>
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    /// <summary>DO_NOT_UPGRADE</summary>
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    /// <summary>UPGRADE</summary>
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive
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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp
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
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie
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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>enable locality load balancing, this is DestinationRule-level and will override mesh wide settings in entirety.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    /// <summary>UNSPECIFIED</summary>
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    /// <summary>LEAST_CONN</summary>
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    /// <summary>RANDOM</summary>
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    /// <summary>PASSTHROUGH</summary>
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    /// <summary>ROUND_ROBIN</summary>
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    /// <summary>LEAST_REQUEST</summary>
    LEASTREQUEST
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup duration of Service.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection
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

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least min_health_percent hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    /// <summary>DEFAULT</summary>
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    /// <summary>DO_NOT_UPGRADE</summary>
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    /// <summary>UPGRADE</summary>
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp
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
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>enable locality load balancing, this is DestinationRule-level and will override mesh wide settings in entirety.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    /// <summary>UNSPECIFIED</summary>
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    /// <summary>LEAST_CONN</summary>
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    /// <summary>RANDOM</summary>
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    /// <summary>PASSTHROUGH</summary>
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    /// <summary>ROUND_ROBIN</summary>
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    /// <summary>LEAST_REQUEST</summary>
    LEASTREQUEST
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup duration of Service.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection
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

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least min_health_percent hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    /// <summary>SIMPLE</summary>
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    /// <summary>MUTUAL</summary>
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    /// <summary>ISTIO_MUTUAL</summary>
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum? Mode { get; set; }

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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    /// <summary>V1</summary>
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    /// <summary>V2</summary>
    V2
}

/// <summary>The upstream PROXY protocol settings.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol
{
    /// <summary>The PROXY protocol version to use.  Valid Options: V1, V2</summary>
    [JsonPropertyName("version")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum? Version { get; set; }
}

public enum V1beta1DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    /// <summary>SIMPLE</summary>
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    /// <summary>MUTUAL</summary>
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    /// <summary>ISTIO_MUTUAL</summary>
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyTls
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum>))]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum? Mode { get; set; }

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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicyTunnel
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
public partial class V1beta1DestinationRuleSpecSubsetsTrafficPolicy
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1beta1DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicyTunnel? Tunnel { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecSubsets
{
    /// <summary>Labels apply a filter over the endpoints of a service in the service registry.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Name of the subset.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Traffic policies that apply to this subset.</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1beta1DestinationRuleSpecSubsetsTrafficPolicy? TrafficPolicy { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    /// <summary>DEFAULT</summary>
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    /// <summary>DO_NOT_UPGRADE</summary>
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    /// <summary>UPGRADE</summary>
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

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
public partial class V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive
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
public partial class V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolTcp
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
    public V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1DestinationRuleSpecTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie
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
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>enable locality load balancing, this is DestinationRule-level and will override mesh wide settings in entirety.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    /// <summary>UNSPECIFIED</summary>
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    /// <summary>LEAST_CONN</summary>
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    /// <summary>RANDOM</summary>
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    /// <summary>PASSTHROUGH</summary>
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    /// <summary>ROUND_ROBIN</summary>
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    /// <summary>LEAST_REQUEST</summary>
    LEASTREQUEST
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup duration of Service.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyOutlierDetection
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

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least min_health_percent hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    /// <summary>DEFAULT</summary>
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    /// <summary>DO_NOT_UPGRADE</summary>
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    /// <summary>UPGRADE</summary>
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

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
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
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
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp
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
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
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
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, '/' separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>enable locality load balancing, this is DestinationRule-level and will override mesh wide settings in entirety.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    /// <summary>UNSPECIFIED</summary>
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    /// <summary>LEAST_CONN</summary>
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    /// <summary>RANDOM</summary>
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    /// <summary>PASSTHROUGH</summary>
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    /// <summary>ROUND_ROBIN</summary>
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    /// <summary>LEAST_REQUEST</summary>
    LEASTREQUEST
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localityLbSetting")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>  Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST</summary>
    [JsonPropertyName("simple")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup duration of Service.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection
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

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least min_health_percent hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    /// <summary>SIMPLE</summary>
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    /// <summary>MUTUAL</summary>
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    /// <summary>ISTIO_MUTUAL</summary>
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsTls
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum? Mode { get; set; }

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
public partial class V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettings
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    /// <summary>V1</summary>
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    /// <summary>V2</summary>
    V2
}

/// <summary>The upstream PROXY protocol settings.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyProxyProtocol
{
    /// <summary>The PROXY protocol version to use.  Valid Options: V1, V2</summary>
    [JsonPropertyName("version")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum? Version { get; set; }
}

public enum V1beta1DestinationRuleSpecTrafficPolicyTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    /// <summary>SIMPLE</summary>
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    /// <summary>MUTUAL</summary>
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    /// <summary>ISTIO_MUTUAL</summary>
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
public partial class V1beta1DestinationRuleSpecTrafficPolicyTls
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DestinationRuleSpecTrafficPolicyTlsModeEnum>))]
    public V1beta1DestinationRuleSpecTrafficPolicyTlsModeEnum? Mode { get; set; }

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
public partial class V1beta1DestinationRuleSpecTrafficPolicyTunnel
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
public partial class V1beta1DestinationRuleSpecTrafficPolicy
{
    /// <summary></summary>
    [JsonPropertyName("connectionPool")]
    public V1beta1DestinationRuleSpecTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1beta1DestinationRuleSpecTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1DestinationRuleSpecTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1beta1DestinationRuleSpecTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1beta1DestinationRuleSpecTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1beta1DestinationRuleSpecTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1beta1DestinationRuleSpecTrafficPolicyTunnel? Tunnel { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
public partial class V1beta1DestinationRuleSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Configuration affecting load balancing, outlier detection, etc. See more details at: https://istio.io/docs/reference/config/networking/destination-rule.html</summary>
public partial class V1beta1DestinationRuleSpec
{
    /// <summary>A list of namespaces to which this destination rule is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>One or more named sets that represent individual versions of a service.</summary>
    [JsonPropertyName("subsets")]
    public IList<V1beta1DestinationRuleSpecSubsets>? Subsets { get; set; }

    /// <summary>Traffic policies to apply (load balancing policy, connection pool sizes, outlier detection).</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1beta1DestinationRuleSpecTrafficPolicy? TrafficPolicy { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1beta1DestinationRuleSpecWorkloadSelector? WorkloadSelector { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1DestinationRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DestinationRuleSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
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
    public V1beta1DestinationRuleSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}