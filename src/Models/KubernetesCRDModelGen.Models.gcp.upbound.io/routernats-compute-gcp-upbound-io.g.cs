using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1RouterNATSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecForProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the desired filtering of logs on this NAT. Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

public enum V1beta1RouterNATSpecForProviderRouterRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecForProviderRouterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RouterNATSpecForProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderRouterRefPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecForProviderRouterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderRouterRefPolicyResolveEnum>))]
    public V1beta1RouterNATSpecForProviderRouterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
public partial class V1beta1RouterNATSpecForProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecForProviderRouterRefPolicy? Policy { get; set; }
}

public enum V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RouterNATSpecForProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolveEnum>))]
    public V1beta1RouterNATSpecForProviderRouterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
public partial class V1beta1RouterNATSpecForProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecForProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecForProviderRulesAction
{
    /// <summary>A list of URLs of the IP resources used for this NAT rule. These IP addresses must be valid static external IP addresses assigned to the project. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT. These IPs should be used for updating/patching a NAT rule only. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecForProviderRules
{
    /// <summary>The action to be enforced for traffic that matches this rule. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouterNATSpecForProviderRulesAction>? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CEL expression that specifies the match condition that egress traffic from a VM is evaluated against. If it evaluates to true, the corresponding action is enforced. The following examples are valid match expressions for public NAT: "inIpRange(destination.ip, '1.1.0.0/16') || inIpRange(destination.ip, '2.2.0.0/16')" "destination.ip == '1.1.0.1' || destination.ip == '8.8.8.8'" The following example is a valid match expression for private NAT: "nexthop.hub == 'https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1'"</summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>An integer uniquely identifying a rule in the list. The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

public enum V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum>))]
    public V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate name.</summary>
public partial class V1beta1RouterNATSpecForProviderSubnetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecForProviderSubnetworkNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum>))]
    public V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate name.</summary>
public partial class V1beta1RouterNATSpecForProviderSubnetworkNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecForProviderSubnetworkNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecForProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1RouterNATSpecForProviderSubnetworkNameRef? NameRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1RouterNATSpecForProviderSubnetworkNameSelector? NameSelector { get; set; }

    /// <summary>List of the secondary ranges of the subnetwork that are allowed to use NAT. This can be populated only if LIST_OF_SECONDARY_IP_RANGES is one of the values in sourceIpRangesToNat</summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>List of options for which source IPs in the subnetwork should have NAT enabled. Supported values include: ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES, PRIMARY_IP_RANGE.</summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecForProvider
{
    /// <summary>The network tier to use when automatically reserving NAT IP addresses. Must be one of: PREMIUM, STANDARD. If not specified, then the current project-level default tier is used. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT.</summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>Enable Dynamic Port Allocation. If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32. If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config. If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm. If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config. Mutually exclusive with enableEndpointIndependentMapping.</summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>Enable endpoint independent mapping. For more information see the official documentation.</summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>Specifies the endpoint Types supported by the NAT Gateway. Supported values include: ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG, ENDPOINT_TYPE_MANAGED_PROXY_LB.</summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>Configuration for logging on NAT Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RouterNATSpecForProviderLogConfig>? LogConfig { get; set; }

    /// <summary>Maximum number of ports allocated to a VM from this NAT. This field can only be set when enableDynamicPortAllocation is enabled.</summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>How external IPs should be allocated for this NAT. Valid values are AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses. Possible values are: MANUAL_ONLY, AUTO_ONLY.</summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>Self-links of NAT IPs. Only valid if natIpAllocateOption is set to MANUAL_ONLY.</summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and NAT reside.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the Cloud Router in which this NAT will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1RouterNATSpecForProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1RouterNATSpecForProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>A list of rules associated with this NAT. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RouterNATSpecForProviderRules>? Rules { get; set; }

    /// <summary>How NAT should be configured per Subnetwork. If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the IP ranges in every Subnetwork are allowed to Nat. If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP ranges in every Subnetwork are allowed to Nat. LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field subnetwork below). Note that if this field contains ALL_SUBNETWORKS_ALL_IP_RANGES or ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any other RouterNat section in any Router for this network in this region. Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.</summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>One or more subnetwork NAT configurations. Only used if source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS Structure is documented below.</summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta1RouterNATSpecForProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>Timeout (in seconds) for TCP established connections. Defaults to 1200s if not set.</summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP connections that are in TIME_WAIT state. Defaults to 120s if not set.</summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP transitory connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecInitProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the desired filtering of logs on this NAT. Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecInitProviderRulesAction
{
    /// <summary>A list of URLs of the IP resources used for this NAT rule. These IP addresses must be valid static external IP addresses assigned to the project. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT. These IPs should be used for updating/patching a NAT rule only. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecInitProviderRules
{
    /// <summary>The action to be enforced for traffic that matches this rule. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouterNATSpecInitProviderRulesAction>? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CEL expression that specifies the match condition that egress traffic from a VM is evaluated against. If it evaluates to true, the corresponding action is enforced. The following examples are valid match expressions for public NAT: "inIpRange(destination.ip, '1.1.0.0/16') || inIpRange(destination.ip, '2.2.0.0/16')" "destination.ip == '1.1.0.1' || destination.ip == '8.8.8.8'" The following example is a valid match expression for private NAT: "nexthop.hub == 'https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1'"</summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>An integer uniquely identifying a rule in the list. The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

public enum V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum>))]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate name.</summary>
public partial class V1beta1RouterNATSpecInitProviderSubnetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum>))]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate name.</summary>
public partial class V1beta1RouterNATSpecInitProviderSubnetworkNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATSpecInitProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameRef? NameRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1RouterNATSpecInitProviderSubnetworkNameSelector? NameSelector { get; set; }

    /// <summary>List of the secondary ranges of the subnetwork that are allowed to use NAT. This can be populated only if LIST_OF_SECONDARY_IP_RANGES is one of the values in sourceIpRangesToNat</summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>List of options for which source IPs in the subnetwork should have NAT enabled. Supported values include: ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES, PRIMARY_IP_RANGE.</summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RouterNATSpecInitProvider
{
    /// <summary>The network tier to use when automatically reserving NAT IP addresses. Must be one of: PREMIUM, STANDARD. If not specified, then the current project-level default tier is used. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT.</summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>Enable Dynamic Port Allocation. If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32. If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config. If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm. If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config. Mutually exclusive with enableEndpointIndependentMapping.</summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>Enable endpoint independent mapping. For more information see the official documentation.</summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>Specifies the endpoint Types supported by the NAT Gateway. Supported values include: ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG, ENDPOINT_TYPE_MANAGED_PROXY_LB.</summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>Configuration for logging on NAT Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RouterNATSpecInitProviderLogConfig>? LogConfig { get; set; }

    /// <summary>Maximum number of ports allocated to a VM from this NAT. This field can only be set when enableDynamicPortAllocation is enabled.</summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>How external IPs should be allocated for this NAT. Valid values are AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses. Possible values are: MANUAL_ONLY, AUTO_ONLY.</summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>Self-links of NAT IPs. Only valid if natIpAllocateOption is set to MANUAL_ONLY.</summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A list of rules associated with this NAT. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RouterNATSpecInitProviderRules>? Rules { get; set; }

    /// <summary>How NAT should be configured per Subnetwork. If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the IP ranges in every Subnetwork are allowed to Nat. If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP ranges in every Subnetwork are allowed to Nat. LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field subnetwork below). Note that if this field contains ALL_SUBNETWORKS_ALL_IP_RANGES or ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any other RouterNat section in any Router for this network in this region. Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.</summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>One or more subnetwork NAT configurations. Only used if source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS Structure is documented below.</summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta1RouterNATSpecInitProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>Timeout (in seconds) for TCP established connections. Defaults to 1200s if not set.</summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP connections that are in TIME_WAIT state. Defaults to 120s if not set.</summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP transitory connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

public enum V1beta1RouterNATSpecManagementPoliciesEnum
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

public enum V1beta1RouterNATSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RouterNATSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RouterNATSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RouterNATSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RouterNATSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterNATSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RouterNATSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RouterNATSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RouterNATSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RouterNATSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RouterNATSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RouterNATSpec defines the desired state of RouterNAT</summary>
public partial class V1beta1RouterNATSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RouterNATSpecDeletionPolicyEnum>))]
    public V1beta1RouterNATSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RouterNATSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RouterNATSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RouterNATSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RouterNATSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RouterNATSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RouterNATSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATStatusAtProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the desired filtering of logs on this NAT. Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATStatusAtProviderRulesAction
{
    /// <summary>A list of URLs of the IP resources used for this NAT rule. These IP addresses must be valid static external IP addresses assigned to the project. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT. These IPs should be used for updating/patching a NAT rule only. This field is used for public NAT.</summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATStatusAtProviderRules
{
    /// <summary>The action to be enforced for traffic that matches this rule. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouterNATStatusAtProviderRulesAction>? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CEL expression that specifies the match condition that egress traffic from a VM is evaluated against. If it evaluates to true, the corresponding action is enforced. The following examples are valid match expressions for public NAT: "inIpRange(destination.ip, '1.1.0.0/16') || inIpRange(destination.ip, '2.2.0.0/16')" "destination.ip == '1.1.0.1' || destination.ip == '8.8.8.8'" The following example is a valid match expression for private NAT: "nexthop.hub == 'https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1'"</summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>An integer uniquely identifying a rule in the list. The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATStatusAtProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of the secondary ranges of the subnetwork that are allowed to use NAT. This can be populated only if LIST_OF_SECONDARY_IP_RANGES is one of the values in sourceIpRangesToNat</summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>List of options for which source IPs in the subnetwork should have NAT enabled. Supported values include: ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES, PRIMARY_IP_RANGE.</summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
}

/// <summary></summary>
public partial class V1beta1RouterNATStatusAtProvider
{
    /// <summary>The network tier to use when automatically reserving NAT IP addresses. Must be one of: PREMIUM, STANDARD. If not specified, then the current project-level default tier is used. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT.</summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>Enable Dynamic Port Allocation. If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32. If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config. If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm. If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config. Mutually exclusive with enableEndpointIndependentMapping.</summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>Enable endpoint independent mapping. For more information see the official documentation.</summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>Specifies the endpoint Types supported by the NAT Gateway. Supported values include: ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG, ENDPOINT_TYPE_MANAGED_PROXY_LB.</summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{region}}/{{router}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for logging on NAT Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RouterNATStatusAtProviderLogConfig>? LogConfig { get; set; }

    /// <summary>Maximum number of ports allocated to a VM from this NAT. This field can only be set when enableDynamicPortAllocation is enabled.</summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>How external IPs should be allocated for this NAT. Valid values are AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses. Possible values are: MANUAL_ONLY, AUTO_ONLY.</summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>Self-links of NAT IPs. Only valid if natIpAllocateOption is set to MANUAL_ONLY.</summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and NAT reside.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the Cloud Router in which this NAT will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>A list of rules associated with this NAT. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RouterNATStatusAtProviderRules>? Rules { get; set; }

    /// <summary>How NAT should be configured per Subnetwork. If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the IP ranges in every Subnetwork are allowed to Nat. If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP ranges in every Subnetwork are allowed to Nat. LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field subnetwork below). Note that if this field contains ALL_SUBNETWORKS_ALL_IP_RANGES or ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any other RouterNat section in any Router for this network in this region. Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.</summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>One or more subnetwork NAT configurations. Only used if source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS Structure is documented below.</summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta1RouterNATStatusAtProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>Timeout (in seconds) for TCP established connections. Defaults to 1200s if not set.</summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP connections that are in TIME_WAIT state. Defaults to 120s if not set.</summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP transitory connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RouterNATStatusConditions
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

/// <summary>RouterNATStatus defines the observed state of RouterNAT.</summary>
public partial class V1beta1RouterNATStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RouterNATStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RouterNATStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RouterNAT is the Schema for the RouterNATs API. A NAT service created in a router.</summary>
public partial class V1beta1RouterNAT : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RouterNATSpec>, IStatus<V1beta1RouterNATStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouterNAT";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "routernats";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouterNATSpec defines the desired state of RouterNAT</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouterNATSpec Spec { get; set; }

    /// <summary>RouterNATStatus defines the observed state of RouterNAT.</summary>
    [JsonPropertyName("status")]
    public V1beta1RouterNATStatus? Status { get; set; }
}