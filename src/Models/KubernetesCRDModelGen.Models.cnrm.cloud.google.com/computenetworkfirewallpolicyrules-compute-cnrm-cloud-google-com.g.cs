using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>The firewall policy of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecFirewallPolicyRef
{
    /// <summary>Allowed value: The `networkFirewallPolicyId` field of a `ComputeNetworkFirewallPolicy` resource.</summary>
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
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatchLayer4Configs
{
    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (`tcp`, `udp`, `icmp`, `esp`, `ah`, `ipip`, `sctp`), or the IP protocol number.</summary>
    [JsonPropertyName("ipProtocol")]
    public string IpProtocol { get; set; }

    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port. Example inputs include: ``.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatchSrcSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager's TagValue API. @pattern tagValues/[0-9]+.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>[Output Only] State of the secure tag, either `EFFECTIVE` or `INEFFECTIVE`. A secure tag is `INEFFECTIVE` when it is deleted or its network is deleted.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding 'action' is enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10. Destination address groups is only supported in Egress rules.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of destination of traffic. Can only be specified if DIRECTION is egress.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>The Unicode country codes whose IP addresses will be used to match against the source of traffic. Can only be specified if DIRECTION is egress.</summary>
    [JsonPropertyName("destRegionCodes")]
    public IList<string>? DestRegionCodes { get; set; }

    /// <summary>Name of the Google Cloud Threat Intelligence list.</summary>
    [JsonPropertyName("destThreatIntelligences")]
    public IList<string>? DestThreatIntelligences { get; set; }

    /// <summary>Pairs of IP protocols and ports that the rule should match.</summary>
    [JsonPropertyName("layer4Configs")]
    public IList<V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatchLayer4Configs> Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10. Source address groups is only supported in Ingress rules.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>The Unicode country codes whose IP addresses will be used to match against the source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>List of secure tag values, which should be matched at the source of the traffic. For INGRESS rule, if all the &lt;code&gt;srcSecureTag&lt;/code&gt; are INEFFECTIVE, and there is no &lt;code&gt;srcIpRange&lt;/code&gt;, this rule will be ignored. Maximum number of source tag values allowed is 256.</summary>
    [JsonPropertyName("srcSecureTags")]
    public IList<V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatchSrcSecureTags>? SrcSecureTags { get; set; }

    /// <summary>Name of the Google Cloud Threat Intelligence list.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecTargetSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager's TagValue API. @pattern tagValues/[0-9]+.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>[Output Only] State of the secure tag, either `EFFECTIVE` or `INEFFECTIVE`. A secure tag is `INEFFECTIVE` when it is deleted or its network is deleted.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A list of service accounts indicating the sets of instances that are applied with this rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpecTargetServiceAccountRefs
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
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
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleSpec
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are "allow", "deny" and "goto_next".</summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The direction in which this rule applies. Possible values: INGRESS, EGRESS.</summary>
    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    /// <summary>Denotes whether the firewall policy rule is disabled. When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist. If this is unspecified, the firewall policy rule will be enabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Denotes whether to enable logging for a particular rule. If logging is enabled, logs will be exported to the configured export destination in Stackdriver. Logs may be exported to BigQuery or Pub/Sub. Note: you cannot enable logging on "goto_next" rules.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicyRef")]
    public V1alpha1ComputeNetworkFirewallPolicyRuleSpecFirewallPolicyRef FirewallPolicyRef { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding 'action' is enforced.</summary>
    [JsonPropertyName("match")]
    public V1alpha1ComputeNetworkFirewallPolicyRuleSpecMatch Match { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeNetworkFirewallPolicyRuleSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The priority of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>An optional name for the rule. This field is not a unique identifier and can be updated.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A list of secure tags that controls which instances the firewall rule applies to. If &lt;code&gt;targetSecureTag&lt;/code&gt; are specified, then the firewall rule applies only to instances in the VPC network that have one of those EFFECTIVE secure tags, if all the target_secure_tag are in INEFFECTIVE state, then this rule will be ignored. &lt;code&gt;targetSecureTag&lt;/code&gt; may not be set at the same time as &lt;code&gt;targetServiceAccounts&lt;/code&gt;. If neither &lt;code&gt;targetServiceAccounts&lt;/code&gt; nor &lt;code&gt;targetSecureTag&lt;/code&gt; are specified, the firewall rule applies to all instances on the specified network. Maximum number of target label tags allowed is 256.</summary>
    [JsonPropertyName("targetSecureTags")]
    public IList<V1alpha1ComputeNetworkFirewallPolicyRuleSpecTargetSecureTags>? TargetSecureTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetServiceAccountRefs")]
    public IList<V1alpha1ComputeNetworkFirewallPolicyRuleSpecTargetServiceAccountRefs>? TargetServiceAccountRefs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleStatusConditions
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
public partial class V1alpha1ComputeNetworkFirewallPolicyRuleStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeNetworkFirewallPolicyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Type of the resource. Always `compute#firewallPolicyRule` for firewall policy rules.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Calculation of the complexity of a single firewall policy rule.</summary>
    [JsonPropertyName("ruleTupleCount")]
    public int? RuleTupleCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeNetworkFirewallPolicyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeNetworkFirewallPolicyRuleSpec>, IStatus<V1alpha1ComputeNetworkFirewallPolicyRuleStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeNetworkFirewallPolicyRule";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkfirewallpolicyrules";
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
    public V1alpha1ComputeNetworkFirewallPolicyRuleSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeNetworkFirewallPolicyRuleStatus? Status { get; set; }
}