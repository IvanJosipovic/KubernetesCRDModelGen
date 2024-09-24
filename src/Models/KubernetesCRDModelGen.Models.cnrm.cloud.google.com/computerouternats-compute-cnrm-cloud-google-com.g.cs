using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>A list of IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecDrainNatIps
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for logging on NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>Specifies the desired filtering of logs on this NAT. Possible values: ["ERRORS_ONLY", "TRANSLATIONS_ONLY", "ALL"].</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

/// <summary>NAT IPs. Only valid if natIpAllocateOption is set to MANUAL_ONLY.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecNatIps
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Cloud Router in which this NAT will be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecRouterRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeRouter` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of URLs of the IP resources used for this NAT rule. These IP addresses must be valid static external IP addresses assigned to the project. This field is used for public NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecRulesActionSourceNatActiveIpsRefs
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT. These IPs should be used for updating/patching a NAT rule only. This field is used for public NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecRulesActionSourceNatDrainIpsRefs
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The action to be enforced for traffic that matches this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecRulesAction
{
    /// <summary></summary>
    [JsonPropertyName("sourceNatActiveIpsRefs")]
    public IList<V1beta1ComputeRouterNATSpecRulesActionSourceNatActiveIpsRefs>? SourceNatActiveIpsRefs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceNatDrainIpsRefs")]
    public IList<V1beta1ComputeRouterNATSpecRulesActionSourceNatDrainIpsRefs>? SourceNatDrainIpsRefs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecRules
{
    /// <summary>The action to be enforced for traffic that matches this rule.</summary>
    [JsonPropertyName("action")]
    public V1beta1ComputeRouterNATSpecRulesAction? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CEL expression that specifies the match condition that egress traffic from a VM is evaluated against. If it evaluates to true, the corresponding action is enforced.  The following examples are valid match expressions for public NAT:  "inIpRange(destination.ip, '1.1.0.0/16') || inIpRange(destination.ip, '2.2.0.0/16')"  "destination.ip == '1.1.0.1' || destination.ip == '8.8.8.8'"  The following example is a valid match expression for private NAT:  "nexthop.hub == 'https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1'".</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }

    /// <summary>An integer uniquely identifying a rule in the list. The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.</summary>
    [JsonPropertyName("ruleNumber")]
    public int RuleNumber { get; set; }
}

/// <summary>The subnetwork to NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpecSubnetworkSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
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
public partial class V1beta1ComputeRouterNATSpecSubnetwork
{
    /// <summary>List of the secondary ranges of the subnetwork that are allowed to use NAT. This can be populated only if 'LIST_OF_SECONDARY_IP_RANGES' is one of the values in sourceIpRangesToNat.</summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>List of options for which source IPs in the subnetwork should have NAT enabled. Supported values include: 'ALL_IP_RANGES', 'LIST_OF_SECONDARY_IP_RANGES', 'PRIMARY_IP_RANGE'.</summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string> SourceIpRangesToNat { get; set; }

    /// <summary>The subnetwork to NAT.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeRouterNATSpecSubnetworkSubnetworkRef SubnetworkRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATSpec
{
    /// <summary></summary>
    [JsonPropertyName("drainNatIps")]
    public IList<V1beta1ComputeRouterNATSpecDrainNatIps>? DrainNatIps { get; set; }

    /// <summary>Enable Dynamic Port Allocation. If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32. If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config. If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm. If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.  Mutually exclusive with enableEndpointIndependentMapping.</summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>Specifies if endpoint independent mapping is enabled. This is enabled by default. For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).</summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public int? IcmpIdleTimeoutSec { get; set; }

    /// <summary>Configuration for logging on NAT.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeRouterNATSpecLogConfig? LogConfig { get; set; }

    /// <summary>Maximum number of ports allocated to a VM from this NAT. This field can only be set when enableDynamicPortAllocation is enabled.</summary>
    [JsonPropertyName("maxPortsPerVm")]
    public int? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public int? MinPortsPerVm { get; set; }

    /// <summary>How external IPs should be allocated for this NAT. Valid values are 'AUTO_ONLY' for only allowing NAT IPs allocated by Google Cloud Platform, or 'MANUAL_ONLY' for only user-allocated NAT IP addresses. Possible values: ["MANUAL_ONLY", "AUTO_ONLY"].</summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string NatIpAllocateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natIps")]
    public IList<V1beta1ComputeRouterNATSpecNatIps>? NatIps { get; set; }

    /// <summary>Immutable. Region where the router and NAT reside.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The Cloud Router in which this NAT will be configured.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1ComputeRouterNATSpecRouterRef RouterRef { get; set; }

    /// <summary>A list of rules associated with this NAT.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1ComputeRouterNATSpecRules>? Rules { get; set; }

    /// <summary>How NAT should be configured per Subnetwork. If 'ALL_SUBNETWORKS_ALL_IP_RANGES', all of the IP ranges in every Subnetwork are allowed to Nat. If 'ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES', all of the primary IP ranges in every Subnetwork are allowed to Nat. 'LIST_OF_SUBNETWORKS': A list of Subnetworks are allowed to Nat (specified in the field subnetwork below). Note that if this field contains ALL_SUBNETWORKS_ALL_IP_RANGES or ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any other RouterNat section in any Router for this network in this region. Possible values: ["ALL_SUBNETWORKS_ALL_IP_RANGES", "ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES", "LIST_OF_SUBNETWORKS"].</summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>One or more subnetwork NAT configurations. Only used if 'source_subnetwork_ip_ranges_to_nat' is set to 'LIST_OF_SUBNETWORKS'.</summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta1ComputeRouterNATSpecSubnetwork>? Subnetwork { get; set; }

    /// <summary>Timeout (in seconds) for TCP established connections. Defaults to 1200s if not set.</summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public int? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP connections that are in TIME_WAIT state. Defaults to 120s if not set.</summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public int? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for TCP transitory connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public int? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public int? UdpIdleTimeoutSec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterNATStatusConditions
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
public partial class V1beta1ComputeRouterNATStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeRouterNATStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRouterNAT : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeRouterNATSpec>, IStatus<V1beta1ComputeRouterNATStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRouterNAT";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computerouternats";
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
    public V1beta1ComputeRouterNATSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeRouterNATStatus? Status { get; set; }
}