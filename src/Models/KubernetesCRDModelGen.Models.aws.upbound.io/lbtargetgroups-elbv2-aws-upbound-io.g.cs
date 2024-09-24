using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderHealthCheck
{
    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of consecutive health check successes required before considering a target healthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Approximate amount of time, in seconds, between health checks of an individual target. The range is 5-300. For lambda target groups, it needs to be greater than the timeout of the underlying lambda. Defaults to 30.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>separated individual values (e.g., "200,202") or a range of values (e.g., "200-299").</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }

    /// <summary>(May be required) Destination for the health check request. Required for HTTP/HTTPS ALB and HTTP NLB. Only applies to HTTP/HTTPS.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port the load balancer uses when performing health checks on targets. Valid values are either traffic-port, to use the same port as the target group, or a valid port number between 1 and 65536. Default is traffic-port.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol the load balancer uses when performing health checks on targets. Must be one of TCP, HTTP, or HTTPS. The TCP protocol is not supported for health checks if the protocol of the target group is HTTP or HTTPS. Default is HTTP. Cannot be specified when the target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time, in seconds, during which no response from a target means a failed health check. The range is 2–120 seconds. For target groups with a protocol of HTTP, the default is 6 seconds. For target groups with a protocol of TCP, TLS or HTTPS, the default is 10 seconds. For target groups with a protocol of GENEVE, the default is 5 seconds. If the target type is lambda, the default is 30 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive health check failures required before considering a target unhealthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderStickiness
{
    /// <summary>Only used when the type is lb_cookie. The time period, in seconds, during which requests from a client should be routed to the same target. After this time period expires, the load balancer-generated cookie is considered stale. The range is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).</summary>
    [JsonPropertyName("cookieDuration")]
    public double? CookieDuration { get; set; }

    /// <summary>Name of the application based cookie. AWSALB, AWSALBAPP, and AWSALBTG prefixes are reserved and cannot be used. Only needed when type is app_cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The type of sticky sessions. The only current possible values are lb_cookie, app_cookie for ALBs, source_ip for NLBs, and source_ip_dest_ip, source_ip_dest_ip_proto for GWLBs.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderTargetFailover
{
    /// <summary>Indicates how the GWLB handles existing flows when a target is deregistered. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_unhealthy. Default: no_rebalance.</summary>
    [JsonPropertyName("onDeregistration")]
    public string? OnDeregistration { get; set; }

    /// <summary>Indicates how the GWLB handles existing flows when a target is unhealthy. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_deregistration. Default: no_rebalance.</summary>
    [JsonPropertyName("onUnhealthy")]
    public string? OnUnhealthy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderTargetHealthState
{
    /// <summary>Indicates whether the load balancer terminates connections to unhealthy targets. Possible values are true or false. Default: true.</summary>
    [JsonPropertyName("enableUnhealthyConnectionTermination")]
    public bool? EnableUnhealthyConnectionTermination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecForProvider
{
    /// <summary>Whether to terminate connections at the end of the deregistration timeout on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("connectionTermination")]
    public bool? ConnectionTermination { get; set; }

    /// <summary>Amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.</summary>
    [JsonPropertyName("deregistrationDelay")]
    public string? DeregistrationDelay { get; set; }

    /// <summary>Health Check configuration block. Detailed below.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1LBTargetGroupSpecForProviderHealthCheck>? HealthCheck { get; set; }

    /// <summary>The type of IP addresses used by the target group, only supported when target type is set to ip. Possible values are ipv4 or ipv6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when target_type is lambda. Default is false.</summary>
    [JsonPropertyName("lambdaMultiValueHeadersEnabled")]
    public bool? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is round_robin, least_outstanding_requests, or weighted_random. The default is round_robin.</summary>
    [JsonPropertyName("loadBalancingAlgorithmType")]
    public string? LoadBalancingAlgorithmType { get; set; }

    /// <summary>Determines whether to enable target anomaly mitigation.  Target anomaly mitigation is only supported by the weighted_random load balancing algorithm type.  See doc for more information.  The value is "on" or "off". The default is "off".</summary>
    [JsonPropertyName("loadBalancingAnomalyMitigation")]
    public string? LoadBalancingAnomalyMitigation { get; set; }

    /// <summary>Indicates whether cross zone load balancing is enabled. The value is "true", "false" or "use_load_balancer_configuration". The default is "use_load_balancer_configuration".</summary>
    [JsonPropertyName("loadBalancingCrossZoneEnabled")]
    public string? LoadBalancingCrossZoneEnabled { get; set; }

    /// <summary>Name of the target group. This name must be unique per region per account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(May be required, Forces new resource) Port on which targets receive traffic, unless overridden when registering a specific target. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Whether client IP preservation is enabled. See doc for more information.</summary>
    [JsonPropertyName("preserveClientIp")]
    public string? PreserveClientIp { get; set; }

    /// <summary>(May be required, Forces new resource) Protocol to use for routing traffic to the targets. Should be one of GENEVE, HTTP, HTTPS, TCP, TCP_UDP, TLS, or UDP. Required when target_type is instance, ip, or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Only applicable when protocol is HTTP or HTTPS. The protocol version. Specify GRPC to send requests to targets using gRPC. Specify HTTP2 to send requests to targets using HTTP/2. The default is HTTP1, which sends requests to targets using HTTP/1.1</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>Whether to enable support for proxy protocol v2 on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("proxyProtocolV2")]
    public bool? ProxyProtocolV2 { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.</summary>
    [JsonPropertyName("slowStart")]
    public double? SlowStart { get; set; }

    /// <summary>Stickiness configuration block. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBTargetGroupSpecForProviderStickiness>? Stickiness { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target failover block. Only applicable for Gateway Load Balancer target groups. See target_failover for more information.</summary>
    [JsonPropertyName("targetFailover")]
    public IList<V1beta1LBTargetGroupSpecForProviderTargetFailover>? TargetFailover { get; set; }

    /// <summary>Target health state block. Only applicable for Network Load Balancer target groups when protocol is TCP or TLS. See target_health_state for more information.</summary>
    [JsonPropertyName("targetHealthState")]
    public IList<V1beta1LBTargetGroupSpecForProviderTargetHealthState>? TargetHealthState { get; set; }

    /// <summary>Type of target that you must specify when registering targets with this target group. See doc for supported values. The default is instance.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>Identifier of the VPC in which to create the target group. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1LBTargetGroupSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1LBTargetGroupSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderHealthCheck
{
    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of consecutive health check successes required before considering a target healthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Approximate amount of time, in seconds, between health checks of an individual target. The range is 5-300. For lambda target groups, it needs to be greater than the timeout of the underlying lambda. Defaults to 30.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>separated individual values (e.g., "200,202") or a range of values (e.g., "200-299").</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }

    /// <summary>(May be required) Destination for the health check request. Required for HTTP/HTTPS ALB and HTTP NLB. Only applies to HTTP/HTTPS.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port the load balancer uses when performing health checks on targets. Valid values are either traffic-port, to use the same port as the target group, or a valid port number between 1 and 65536. Default is traffic-port.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol the load balancer uses when performing health checks on targets. Must be one of TCP, HTTP, or HTTPS. The TCP protocol is not supported for health checks if the protocol of the target group is HTTP or HTTPS. Default is HTTP. Cannot be specified when the target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time, in seconds, during which no response from a target means a failed health check. The range is 2–120 seconds. For target groups with a protocol of HTTP, the default is 6 seconds. For target groups with a protocol of TCP, TLS or HTTPS, the default is 10 seconds. For target groups with a protocol of GENEVE, the default is 5 seconds. If the target type is lambda, the default is 30 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive health check failures required before considering a target unhealthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderStickiness
{
    /// <summary>Only used when the type is lb_cookie. The time period, in seconds, during which requests from a client should be routed to the same target. After this time period expires, the load balancer-generated cookie is considered stale. The range is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).</summary>
    [JsonPropertyName("cookieDuration")]
    public double? CookieDuration { get; set; }

    /// <summary>Name of the application based cookie. AWSALB, AWSALBAPP, and AWSALBTG prefixes are reserved and cannot be used. Only needed when type is app_cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The type of sticky sessions. The only current possible values are lb_cookie, app_cookie for ALBs, source_ip for NLBs, and source_ip_dest_ip, source_ip_dest_ip_proto for GWLBs.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderTargetFailover
{
    /// <summary>Indicates how the GWLB handles existing flows when a target is deregistered. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_unhealthy. Default: no_rebalance.</summary>
    [JsonPropertyName("onDeregistration")]
    public string? OnDeregistration { get; set; }

    /// <summary>Indicates how the GWLB handles existing flows when a target is unhealthy. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_deregistration. Default: no_rebalance.</summary>
    [JsonPropertyName("onUnhealthy")]
    public string? OnUnhealthy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderTargetHealthState
{
    /// <summary>Indicates whether the load balancer terminates connections to unhealthy targets. Possible values are true or false. Default: true.</summary>
    [JsonPropertyName("enableUnhealthyConnectionTermination")]
    public bool? EnableUnhealthyConnectionTermination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecInitProvider
{
    /// <summary>Whether to terminate connections at the end of the deregistration timeout on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("connectionTermination")]
    public bool? ConnectionTermination { get; set; }

    /// <summary>Amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.</summary>
    [JsonPropertyName("deregistrationDelay")]
    public string? DeregistrationDelay { get; set; }

    /// <summary>Health Check configuration block. Detailed below.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1LBTargetGroupSpecInitProviderHealthCheck>? HealthCheck { get; set; }

    /// <summary>The type of IP addresses used by the target group, only supported when target type is set to ip. Possible values are ipv4 or ipv6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when target_type is lambda. Default is false.</summary>
    [JsonPropertyName("lambdaMultiValueHeadersEnabled")]
    public bool? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is round_robin, least_outstanding_requests, or weighted_random. The default is round_robin.</summary>
    [JsonPropertyName("loadBalancingAlgorithmType")]
    public string? LoadBalancingAlgorithmType { get; set; }

    /// <summary>Determines whether to enable target anomaly mitigation.  Target anomaly mitigation is only supported by the weighted_random load balancing algorithm type.  See doc for more information.  The value is "on" or "off". The default is "off".</summary>
    [JsonPropertyName("loadBalancingAnomalyMitigation")]
    public string? LoadBalancingAnomalyMitigation { get; set; }

    /// <summary>Indicates whether cross zone load balancing is enabled. The value is "true", "false" or "use_load_balancer_configuration". The default is "use_load_balancer_configuration".</summary>
    [JsonPropertyName("loadBalancingCrossZoneEnabled")]
    public string? LoadBalancingCrossZoneEnabled { get; set; }

    /// <summary>Name of the target group. This name must be unique per region per account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(May be required, Forces new resource) Port on which targets receive traffic, unless overridden when registering a specific target. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Whether client IP preservation is enabled. See doc for more information.</summary>
    [JsonPropertyName("preserveClientIp")]
    public string? PreserveClientIp { get; set; }

    /// <summary>(May be required, Forces new resource) Protocol to use for routing traffic to the targets. Should be one of GENEVE, HTTP, HTTPS, TCP, TCP_UDP, TLS, or UDP. Required when target_type is instance, ip, or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Only applicable when protocol is HTTP or HTTPS. The protocol version. Specify GRPC to send requests to targets using gRPC. Specify HTTP2 to send requests to targets using HTTP/2. The default is HTTP1, which sends requests to targets using HTTP/1.1</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>Whether to enable support for proxy protocol v2 on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("proxyProtocolV2")]
    public bool? ProxyProtocolV2 { get; set; }

    /// <summary>Amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.</summary>
    [JsonPropertyName("slowStart")]
    public double? SlowStart { get; set; }

    /// <summary>Stickiness configuration block. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBTargetGroupSpecInitProviderStickiness>? Stickiness { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target failover block. Only applicable for Gateway Load Balancer target groups. See target_failover for more information.</summary>
    [JsonPropertyName("targetFailover")]
    public IList<V1beta1LBTargetGroupSpecInitProviderTargetFailover>? TargetFailover { get; set; }

    /// <summary>Target health state block. Only applicable for Network Load Balancer target groups when protocol is TCP or TLS. See target_health_state for more information.</summary>
    [JsonPropertyName("targetHealthState")]
    public IList<V1beta1LBTargetGroupSpecInitProviderTargetHealthState>? TargetHealthState { get; set; }

    /// <summary>Type of target that you must specify when registering targets with this target group. See doc for supported values. The default is instance.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>Identifier of the VPC in which to create the target group. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1LBTargetGroupSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LBTargetGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LBTargetGroupSpec defines the desired state of LBTargetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBTargetGroupSpecDeletionPolicyEnum>))]
    public V1beta1LBTargetGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LBTargetGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LBTargetGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LBTargetGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LBTargetGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LBTargetGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LBTargetGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusAtProviderHealthCheck
{
    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of consecutive health check successes required before considering a target healthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Approximate amount of time, in seconds, between health checks of an individual target. The range is 5-300. For lambda target groups, it needs to be greater than the timeout of the underlying lambda. Defaults to 30.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>separated individual values (e.g., "200,202") or a range of values (e.g., "200-299").</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }

    /// <summary>(May be required) Destination for the health check request. Required for HTTP/HTTPS ALB and HTTP NLB. Only applies to HTTP/HTTPS.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port the load balancer uses when performing health checks on targets. Valid values are either traffic-port, to use the same port as the target group, or a valid port number between 1 and 65536. Default is traffic-port.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol the load balancer uses when performing health checks on targets. Must be one of TCP, HTTP, or HTTPS. The TCP protocol is not supported for health checks if the protocol of the target group is HTTP or HTTPS. Default is HTTP. Cannot be specified when the target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time, in seconds, during which no response from a target means a failed health check. The range is 2–120 seconds. For target groups with a protocol of HTTP, the default is 6 seconds. For target groups with a protocol of TCP, TLS or HTTPS, the default is 10 seconds. For target groups with a protocol of GENEVE, the default is 5 seconds. If the target type is lambda, the default is 30 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive health check failures required before considering a target unhealthy. The range is 2-10. Defaults to 3.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusAtProviderStickiness
{
    /// <summary>Only used when the type is lb_cookie. The time period, in seconds, during which requests from a client should be routed to the same target. After this time period expires, the load balancer-generated cookie is considered stale. The range is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).</summary>
    [JsonPropertyName("cookieDuration")]
    public double? CookieDuration { get; set; }

    /// <summary>Name of the application based cookie. AWSALB, AWSALBAPP, and AWSALBTG prefixes are reserved and cannot be used. Only needed when type is app_cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>Whether health checks are enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The type of sticky sessions. The only current possible values are lb_cookie, app_cookie for ALBs, source_ip for NLBs, and source_ip_dest_ip, source_ip_dest_ip_proto for GWLBs.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusAtProviderTargetFailover
{
    /// <summary>Indicates how the GWLB handles existing flows when a target is deregistered. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_unhealthy. Default: no_rebalance.</summary>
    [JsonPropertyName("onDeregistration")]
    public string? OnDeregistration { get; set; }

    /// <summary>Indicates how the GWLB handles existing flows when a target is unhealthy. Possible values are rebalance and no_rebalance. Must match the attribute value set for on_deregistration. Default: no_rebalance.</summary>
    [JsonPropertyName("onUnhealthy")]
    public string? OnUnhealthy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusAtProviderTargetHealthState
{
    /// <summary>Indicates whether the load balancer terminates connections to unhealthy targets. Possible values are true or false. Default: true.</summary>
    [JsonPropertyName("enableUnhealthyConnectionTermination")]
    public bool? EnableUnhealthyConnectionTermination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusAtProvider
{
    /// <summary>ARN of the Target Group (matches id).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN suffix for use with CloudWatch Metrics.</summary>
    [JsonPropertyName("arnSuffix")]
    public string? ArnSuffix { get; set; }

    /// <summary>Whether to terminate connections at the end of the deregistration timeout on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("connectionTermination")]
    public bool? ConnectionTermination { get; set; }

    /// <summary>Amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.</summary>
    [JsonPropertyName("deregistrationDelay")]
    public string? DeregistrationDelay { get; set; }

    /// <summary>Health Check configuration block. Detailed below.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1LBTargetGroupStatusAtProviderHealthCheck>? HealthCheck { get; set; }

    /// <summary>ARN of the Target Group (matches arn).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of IP addresses used by the target group, only supported when target type is set to ip. Possible values are ipv4 or ipv6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when target_type is lambda. Default is false.</summary>
    [JsonPropertyName("lambdaMultiValueHeadersEnabled")]
    public bool? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>ARNs of the Load Balancers associated with the Target Group.</summary>
    [JsonPropertyName("loadBalancerArns")]
    public IList<string>? LoadBalancerArns { get; set; }

    /// <summary>Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is round_robin, least_outstanding_requests, or weighted_random. The default is round_robin.</summary>
    [JsonPropertyName("loadBalancingAlgorithmType")]
    public string? LoadBalancingAlgorithmType { get; set; }

    /// <summary>Determines whether to enable target anomaly mitigation.  Target anomaly mitigation is only supported by the weighted_random load balancing algorithm type.  See doc for more information.  The value is "on" or "off". The default is "off".</summary>
    [JsonPropertyName("loadBalancingAnomalyMitigation")]
    public string? LoadBalancingAnomalyMitigation { get; set; }

    /// <summary>Indicates whether cross zone load balancing is enabled. The value is "true", "false" or "use_load_balancer_configuration". The default is "use_load_balancer_configuration".</summary>
    [JsonPropertyName("loadBalancingCrossZoneEnabled")]
    public string? LoadBalancingCrossZoneEnabled { get; set; }

    /// <summary>Name of the target group. This name must be unique per region per account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(May be required, Forces new resource) Port on which targets receive traffic, unless overridden when registering a specific target. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Whether client IP preservation is enabled. See doc for more information.</summary>
    [JsonPropertyName("preserveClientIp")]
    public string? PreserveClientIp { get; set; }

    /// <summary>(May be required, Forces new resource) Protocol to use for routing traffic to the targets. Should be one of GENEVE, HTTP, HTTPS, TCP, TCP_UDP, TLS, or UDP. Required when target_type is instance, ip, or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Only applicable when protocol is HTTP or HTTPS. The protocol version. Specify GRPC to send requests to targets using gRPC. Specify HTTP2 to send requests to targets using HTTP/2. The default is HTTP1, which sends requests to targets using HTTP/1.1</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>Whether to enable support for proxy protocol v2 on Network Load Balancers. See doc for more information. Default is false.</summary>
    [JsonPropertyName("proxyProtocolV2")]
    public bool? ProxyProtocolV2 { get; set; }

    /// <summary>Amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.</summary>
    [JsonPropertyName("slowStart")]
    public double? SlowStart { get; set; }

    /// <summary>Stickiness configuration block. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBTargetGroupStatusAtProviderStickiness>? Stickiness { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Target failover block. Only applicable for Gateway Load Balancer target groups. See target_failover for more information.</summary>
    [JsonPropertyName("targetFailover")]
    public IList<V1beta1LBTargetGroupStatusAtProviderTargetFailover>? TargetFailover { get; set; }

    /// <summary>Target health state block. Only applicable for Network Load Balancer target groups when protocol is TCP or TLS. See target_health_state for more information.</summary>
    [JsonPropertyName("targetHealthState")]
    public IList<V1beta1LBTargetGroupStatusAtProviderTargetHealthState>? TargetHealthState { get; set; }

    /// <summary>Type of target that you must specify when registering targets with this target group. See doc for supported values. The default is instance.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>Identifier of the VPC in which to create the target group. Required when target_type is instance, ip or alb. Does not apply when target_type is lambda.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatusConditions
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

/// <summary>LBTargetGroupStatus defines the observed state of LBTargetGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBTargetGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LBTargetGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LBTargetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LBTargetGroup is the Schema for the LBTargetGroups API. Provides a Target Group resource for use with Load Balancers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LBTargetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LBTargetGroupSpec>, IStatus<V1beta1LBTargetGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LBTargetGroup";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lbtargetgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBTargetGroupSpec defines the desired state of LBTargetGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1LBTargetGroupSpec Spec { get; set; }

    /// <summary>LBTargetGroupStatus defines the observed state of LBTargetGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1LBTargetGroupStatus? Status { get; set; }
}