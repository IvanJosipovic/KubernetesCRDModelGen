using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
public enum V1beta1LBSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderAccessLogsBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderAccessLogsBucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderAccessLogsBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderAccessLogsBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderAccessLogsBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderAccessLogsBucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecForProviderAccessLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1LBSpecForProviderAccessLogsBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1LBSpecForProviderAccessLogsBucketSelector? BucketSelector { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1LBSpecForProviderConnectionLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Boolean to enable / disable connection_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public enum V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSubnetMappingSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSubnetMappingSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecForProviderSubnetMapping
{
    /// <summary>Allocation ID of the Elastic IP address for an internet-facing load balancer.</summary>
    [JsonPropertyName("allocationId")]
    public string? AllocationId { get; set; }

    /// <summary>IPv6 address. You associate IPv6 CIDR blocks with your VPC and choose the subnets where you launch both internet-facing and internal Application Load Balancers or Network Load Balancers.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>Private IPv4 address for an internal load balancer.</summary>
    [JsonPropertyName("privateIpv4Address")]
    public string? PrivateIpv4Address { get; set; }

    /// <summary>ID of the subnet of which to attach to the load balancer. You can specify only one subnet per Availability Zone.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LBSpecForProviderSubnetMappingSubnetIdSelector? SubnetIdSelector { get; set; }
}

public enum V1beta1LBSpecForProviderSubnetRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSubnetRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetRefsPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetRefsPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSubnetRefsPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecForProviderSubnetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecForProviderSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecForProviderSubnetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecForProviderSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecForProviderSubnetSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecForProviderSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecForProviderSubnetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecForProviderSubnetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecForProvider
{
    /// <summary>Access Logs block. See below.</summary>
    [JsonPropertyName("accessLogs")]
    public IList<V1beta1LBSpecForProviderAccessLogs>? AccessLogs { get; set; }

    /// <summary>Client keep alive value in seconds. The valid range is 60-604800 seconds. The default is 3600 seconds.</summary>
    [JsonPropertyName("clientKeepAlive")]
    public double? ClientKeepAlive { get; set; }

    /// <summary>Connection Logs block. See below. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("connectionLogs")]
    public IList<V1beta1LBSpecForProviderConnectionLogs>? ConnectionLogs { get; set; }

    /// <summary>ID of the customer owned ipv4 pool to use for this load balancer.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>How the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>How traffic is distributed among the load balancer Availability Zones. Possible values are any_availability_zone (default), availability_zone_affinity, or partial_availability_zone_affinity. See   Availability Zone DNS affinity for additional details. Only valid for network type load balancers.</summary>
    [JsonPropertyName("dnsRecordClientRoutingPolicy")]
    public string? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>Whether HTTP headers with header fields that are not valid are removed by the load balancer (true) or routed to targets (false). The default is false. Elastic Load Balancing requires that message header names contain only alphanumeric characters and hyphens. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("dropInvalidHeaderFields")]
    public bool? DropInvalidHeaderFields { get; set; }

    /// <summary>If true, cross-zone load balancing of the load balancer will be enabled. For network and gateway type load balancers, this feature is disabled by default (false). For application load balancer this feature is always enabled (true) and cannot be disabled. Defaults to false.</summary>
    [JsonPropertyName("enableCrossZoneLoadBalancing")]
    public bool? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>If true, deletion of the load balancer will be disabled via the AWS API. Defaults to false.</summary>
    [JsonPropertyName("enableDeletionProtection")]
    public bool? EnableDeletionProtection { get; set; }

    /// <summary>Whether HTTP/2 is enabled in application load balancers. Defaults to true.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Whether the two headers (x-amzn-tls-version and x-amzn-tls-cipher-suite), which contain information about the negotiated TLS version and cipher suite, are added to the client request before sending it to the target. Only valid for Load Balancers of type application. Defaults to false</summary>
    [JsonPropertyName("enableTlsVersionAndCipherSuiteHeaders")]
    public bool? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>Whether to allow a WAF-enabled load balancer to route requests to targets if it is unable to forward the request to AWS WAF. Defaults to false.</summary>
    [JsonPropertyName("enableWafFailOpen")]
    public bool? EnableWafFailOpen { get; set; }

    /// <summary>Whether the X-Forwarded-For header should preserve the source port that the client used to connect to the load balancer in application load balancers. Defaults to false.</summary>
    [JsonPropertyName("enableXffClientPort")]
    public bool? EnableXffClientPort { get; set; }

    /// <summary>Whether inbound security group rules are enforced for traffic originating from a PrivateLink. Only valid for Load Balancers of type network. The possible values are on and off.</summary>
    [JsonPropertyName("enforceSecurityGroupInboundRulesOnPrivateLinkTraffic")]
    public string? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

    /// <summary>Time in seconds that the connection is allowed to be idle. Only valid for Load Balancers of type application. Default: 60.</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>If true, the LB will be internal. Defaults to false.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>Type of IP addresses used by the subnets for your load balancer. The possible values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Type of load balancer to create. Possible values are application, gateway, or network. The default value is application.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Name of the LB. This name must be unique within your AWS account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the Application Load Balancer should preserve the Host header in the HTTP request and send it to the target without any change. Defaults to false.</summary>
    [JsonPropertyName("preserveHostHeader")]
    public bool? PreserveHostHeader { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1LBSpecForProviderSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1LBSpecForProviderSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>List of security group IDs to assign to the LB. Only valid for Load Balancers of type application or network. For load balancers of type network security groups cannot be added if none are currently present, and cannot all be removed once added. If either of these conditions are met, this will force a recreation of the resource.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnet mapping block. See below. For Load Balancers of type network subnet mappings can only be added.</summary>
    [JsonPropertyName("subnetMapping")]
    public IList<V1beta1LBSpecForProviderSubnetMapping>? SubnetMapping { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta1LBSpecForProviderSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta1LBSpecForProviderSubnetSelector? SubnetSelector { get; set; }

    /// <summary>List of subnet IDs to attach to the LB. For Load Balancers of type network subnets can only be added (see Availability Zones), deleting a subnet for load balancers of type network will force a recreation of the resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Determines how the load balancer modifies the X-Forwarded-For header in the HTTP request before sending the request to the target. The possible values are append, preserve, and remove. Only valid for Load Balancers of type application. The default is append.</summary>
    [JsonPropertyName("xffHeaderProcessingMode")]
    public string? XffHeaderProcessingMode { get; set; }
}

public enum V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderAccessLogsBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderAccessLogsBucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderAccessLogsBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderAccessLogsBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderAccessLogsBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderAccessLogsBucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecInitProviderAccessLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1LBSpecInitProviderAccessLogsBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1LBSpecInitProviderAccessLogsBucketSelector? BucketSelector { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1LBSpecInitProviderConnectionLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Boolean to enable / disable connection_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public enum V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSubnetMappingSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecInitProviderSubnetMapping
{
    /// <summary>Allocation ID of the Elastic IP address for an internet-facing load balancer.</summary>
    [JsonPropertyName("allocationId")]
    public string? AllocationId { get; set; }

    /// <summary>IPv6 address. You associate IPv6 CIDR blocks with your VPC and choose the subnets where you launch both internet-facing and internal Application Load Balancers or Network Load Balancers.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>Private IPv4 address for an internal load balancer.</summary>
    [JsonPropertyName("privateIpv4Address")]
    public string? PrivateIpv4Address { get; set; }

    /// <summary>ID of the subnet of which to attach to the load balancer. You can specify only one subnet per Availability Zone.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LBSpecInitProviderSubnetMappingSubnetIdSelector? SubnetIdSelector { get; set; }
}

public enum V1beta1LBSpecInitProviderSubnetRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSubnetRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetRefsPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetRefsPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSubnetRefsPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecInitProviderSubnetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecInitProviderSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecInitProviderSubnetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetSelectorPolicyResolutionEnum>))]
    public V1beta1LBSpecInitProviderSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecInitProviderSubnetSelectorPolicyResolveEnum>))]
    public V1beta1LBSpecInitProviderSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecInitProviderSubnetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecInitProviderSubnetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecInitProvider
{
    /// <summary>Access Logs block. See below.</summary>
    [JsonPropertyName("accessLogs")]
    public IList<V1beta1LBSpecInitProviderAccessLogs>? AccessLogs { get; set; }

    /// <summary>Client keep alive value in seconds. The valid range is 60-604800 seconds. The default is 3600 seconds.</summary>
    [JsonPropertyName("clientKeepAlive")]
    public double? ClientKeepAlive { get; set; }

    /// <summary>Connection Logs block. See below. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("connectionLogs")]
    public IList<V1beta1LBSpecInitProviderConnectionLogs>? ConnectionLogs { get; set; }

    /// <summary>ID of the customer owned ipv4 pool to use for this load balancer.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>How the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>How traffic is distributed among the load balancer Availability Zones. Possible values are any_availability_zone (default), availability_zone_affinity, or partial_availability_zone_affinity. See   Availability Zone DNS affinity for additional details. Only valid for network type load balancers.</summary>
    [JsonPropertyName("dnsRecordClientRoutingPolicy")]
    public string? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>Whether HTTP headers with header fields that are not valid are removed by the load balancer (true) or routed to targets (false). The default is false. Elastic Load Balancing requires that message header names contain only alphanumeric characters and hyphens. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("dropInvalidHeaderFields")]
    public bool? DropInvalidHeaderFields { get; set; }

    /// <summary>If true, cross-zone load balancing of the load balancer will be enabled. For network and gateway type load balancers, this feature is disabled by default (false). For application load balancer this feature is always enabled (true) and cannot be disabled. Defaults to false.</summary>
    [JsonPropertyName("enableCrossZoneLoadBalancing")]
    public bool? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>If true, deletion of the load balancer will be disabled via the AWS API. Defaults to false.</summary>
    [JsonPropertyName("enableDeletionProtection")]
    public bool? EnableDeletionProtection { get; set; }

    /// <summary>Whether HTTP/2 is enabled in application load balancers. Defaults to true.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Whether the two headers (x-amzn-tls-version and x-amzn-tls-cipher-suite), which contain information about the negotiated TLS version and cipher suite, are added to the client request before sending it to the target. Only valid for Load Balancers of type application. Defaults to false</summary>
    [JsonPropertyName("enableTlsVersionAndCipherSuiteHeaders")]
    public bool? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>Whether to allow a WAF-enabled load balancer to route requests to targets if it is unable to forward the request to AWS WAF. Defaults to false.</summary>
    [JsonPropertyName("enableWafFailOpen")]
    public bool? EnableWafFailOpen { get; set; }

    /// <summary>Whether the X-Forwarded-For header should preserve the source port that the client used to connect to the load balancer in application load balancers. Defaults to false.</summary>
    [JsonPropertyName("enableXffClientPort")]
    public bool? EnableXffClientPort { get; set; }

    /// <summary>Whether inbound security group rules are enforced for traffic originating from a PrivateLink. Only valid for Load Balancers of type network. The possible values are on and off.</summary>
    [JsonPropertyName("enforceSecurityGroupInboundRulesOnPrivateLinkTraffic")]
    public string? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

    /// <summary>Time in seconds that the connection is allowed to be idle. Only valid for Load Balancers of type application. Default: 60.</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>If true, the LB will be internal. Defaults to false.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>Type of IP addresses used by the subnets for your load balancer. The possible values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Type of load balancer to create. Possible values are application, gateway, or network. The default value is application.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Name of the LB. This name must be unique within your AWS account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the Application Load Balancer should preserve the Host header in the HTTP request and send it to the target without any change. Defaults to false.</summary>
    [JsonPropertyName("preserveHostHeader")]
    public bool? PreserveHostHeader { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1LBSpecInitProviderSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1LBSpecInitProviderSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>List of security group IDs to assign to the LB. Only valid for Load Balancers of type application or network. For load balancers of type network security groups cannot be added if none are currently present, and cannot all be removed once added. If either of these conditions are met, this will force a recreation of the resource.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnet mapping block. See below. For Load Balancers of type network subnet mappings can only be added.</summary>
    [JsonPropertyName("subnetMapping")]
    public IList<V1beta1LBSpecInitProviderSubnetMapping>? SubnetMapping { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta1LBSpecInitProviderSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta1LBSpecInitProviderSubnetSelector? SubnetSelector { get; set; }

    /// <summary>List of subnet IDs to attach to the LB. For Load Balancers of type network subnets can only be added (see Availability Zones), deleting a subnet for load balancers of type network will force a recreation of the resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Determines how the load balancer modifies the X-Forwarded-For header in the HTTP request before sending the request to the target. The possible values are append, preserve, and remove. Only valid for Load Balancers of type application. The default is append.</summary>
    [JsonPropertyName("xffHeaderProcessingMode")]
    public string? XffHeaderProcessingMode { get; set; }
}

public enum V1beta1LBSpecManagementPoliciesEnum
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

public enum V1beta1LBSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LBSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LBSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LBSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1LBSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1LBSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LBSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LBSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1LBSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1LBSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LBSpecDeletionPolicyEnum>))]
    public V1beta1LBSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LBSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LBSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LBSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LBSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LBSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LBSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1LBStatusAtProviderAccessLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1LBStatusAtProviderConnectionLogs
{
    /// <summary>S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Boolean to enable / disable connection_logs. Defaults to false, even when bucket is specified.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1LBStatusAtProviderSubnetMapping
{
    /// <summary>Allocation ID of the Elastic IP address for an internet-facing load balancer.</summary>
    [JsonPropertyName("allocationId")]
    public string? AllocationId { get; set; }

    /// <summary>IPv6 address. You associate IPv6 CIDR blocks with your VPC and choose the subnets where you launch both internet-facing and internal Application Load Balancers or Network Load Balancers.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>ID of the Outpost containing the load balancer.</summary>
    [JsonPropertyName("outpostId")]
    public string? OutpostId { get; set; }

    /// <summary>Private IPv4 address for an internal load balancer.</summary>
    [JsonPropertyName("privateIpv4Address")]
    public string? PrivateIpv4Address { get; set; }

    /// <summary>ID of the subnet of which to attach to the load balancer. You can specify only one subnet per Availability Zone.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

public partial class V1beta1LBStatusAtProvider
{
    /// <summary>Access Logs block. See below.</summary>
    [JsonPropertyName("accessLogs")]
    public IList<V1beta1LBStatusAtProviderAccessLogs>? AccessLogs { get; set; }

    /// <summary>ARN of the load balancer (matches id).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN suffix for use with CloudWatch Metrics.</summary>
    [JsonPropertyName("arnSuffix")]
    public string? ArnSuffix { get; set; }

    /// <summary>Client keep alive value in seconds. The valid range is 60-604800 seconds. The default is 3600 seconds.</summary>
    [JsonPropertyName("clientKeepAlive")]
    public double? ClientKeepAlive { get; set; }

    /// <summary>Connection Logs block. See below. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("connectionLogs")]
    public IList<V1beta1LBStatusAtProviderConnectionLogs>? ConnectionLogs { get; set; }

    /// <summary>ID of the customer owned ipv4 pool to use for this load balancer.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>How the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>DNS name of the load balancer.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>How traffic is distributed among the load balancer Availability Zones. Possible values are any_availability_zone (default), availability_zone_affinity, or partial_availability_zone_affinity. See   Availability Zone DNS affinity for additional details. Only valid for network type load balancers.</summary>
    [JsonPropertyName("dnsRecordClientRoutingPolicy")]
    public string? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>Whether HTTP headers with header fields that are not valid are removed by the load balancer (true) or routed to targets (false). The default is false. Elastic Load Balancing requires that message header names contain only alphanumeric characters and hyphens. Only valid for Load Balancers of type application.</summary>
    [JsonPropertyName("dropInvalidHeaderFields")]
    public bool? DropInvalidHeaderFields { get; set; }

    /// <summary>If true, cross-zone load balancing of the load balancer will be enabled. For network and gateway type load balancers, this feature is disabled by default (false). For application load balancer this feature is always enabled (true) and cannot be disabled. Defaults to false.</summary>
    [JsonPropertyName("enableCrossZoneLoadBalancing")]
    public bool? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>If true, deletion of the load balancer will be disabled via the AWS API. Defaults to false.</summary>
    [JsonPropertyName("enableDeletionProtection")]
    public bool? EnableDeletionProtection { get; set; }

    /// <summary>Whether HTTP/2 is enabled in application load balancers. Defaults to true.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Whether the two headers (x-amzn-tls-version and x-amzn-tls-cipher-suite), which contain information about the negotiated TLS version and cipher suite, are added to the client request before sending it to the target. Only valid for Load Balancers of type application. Defaults to false</summary>
    [JsonPropertyName("enableTlsVersionAndCipherSuiteHeaders")]
    public bool? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>Whether to allow a WAF-enabled load balancer to route requests to targets if it is unable to forward the request to AWS WAF. Defaults to false.</summary>
    [JsonPropertyName("enableWafFailOpen")]
    public bool? EnableWafFailOpen { get; set; }

    /// <summary>Whether the X-Forwarded-For header should preserve the source port that the client used to connect to the load balancer in application load balancers. Defaults to false.</summary>
    [JsonPropertyName("enableXffClientPort")]
    public bool? EnableXffClientPort { get; set; }

    /// <summary>Whether inbound security group rules are enforced for traffic originating from a PrivateLink. Only valid for Load Balancers of type network. The possible values are on and off.</summary>
    [JsonPropertyName("enforceSecurityGroupInboundRulesOnPrivateLinkTraffic")]
    public string? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

    /// <summary>ARN of the load balancer (matches arn).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Time in seconds that the connection is allowed to be idle. Only valid for Load Balancers of type application. Default: 60.</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>If true, the LB will be internal. Defaults to false.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>Type of IP addresses used by the subnets for your load balancer. The possible values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Type of load balancer to create. Possible values are application, gateway, or network. The default value is application.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Name of the LB. This name must be unique within your AWS account, can have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and must not begin or end with a hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the Application Load Balancer should preserve the Host header in the HTTP request and send it to the target without any change. Defaults to false.</summary>
    [JsonPropertyName("preserveHostHeader")]
    public bool? PreserveHostHeader { get; set; }

    /// <summary>List of security group IDs to assign to the LB. Only valid for Load Balancers of type application or network. For load balancers of type network security groups cannot be added if none are currently present, and cannot all be removed once added. If either of these conditions are met, this will force a recreation of the resource.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnet mapping block. See below. For Load Balancers of type network subnet mappings can only be added.</summary>
    [JsonPropertyName("subnetMapping")]
    public IList<V1beta1LBStatusAtProviderSubnetMapping>? SubnetMapping { get; set; }

    /// <summary>List of subnet IDs to attach to the LB. For Load Balancers of type network subnets can only be added (see Availability Zones), deleting a subnet for load balancers of type network will force a recreation of the resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>ARN of the load balancer (matches arn).</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Determines how the load balancer modifies the X-Forwarded-For header in the HTTP request before sending the request to the target. The possible values are append, preserve, and remove. Only valid for Load Balancers of type application. The default is append.</summary>
    [JsonPropertyName("xffHeaderProcessingMode")]
    public string? XffHeaderProcessingMode { get; set; }

    /// <summary>Canonical hosted zone ID of the load balancer (to be used in a Route 53 Alias record).</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

public partial class V1beta1LBStatusConditions
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

public partial class V1beta1LBStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LBStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LBStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LB : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LBSpec>, IStatus<V1beta1LBStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LB";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lbs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBSpec defines the desired state of LB</summary>
    [JsonPropertyName("spec")]
    public V1beta1LBSpec Spec { get; set; }

    /// <summary>LBStatus defines the observed state of LB.</summary>
    [JsonPropertyName("status")]
    public V1beta1LBStatus? Status { get; set; }
}