using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1FirewallPolicyRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderMatchLayer4Configs
{
    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecForProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10. Destination address groups is only supported in Egress rules.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of destination of traffic. Can only be specified if DIRECTION is egress.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 256.</summary>
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
    public IList<V1beta1FirewallPolicyRuleSpecForProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10. Source address groups is only supported in Ingress rules.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 256.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>The Unicode country codes whose IP addresses will be used to match against the source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>Name of the Google Cloud Threat Intelligence list.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecForProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are "allow", "deny" and "goto_next".</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The direction in which this rule applies. Possible values: INGRESS, EGRESS</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Denotes whether the firewall policy rule is disabled. When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist. If this is unspecified, the firewall policy rule will be enabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Denotes whether to enable logging for a particular rule. If logging is enabled, logs will be exported to the configured export destination in Stackdriver. Logs may be exported to BigQuery or Pub/Sub. Note: you cannot enable logging on "goto_next" rules.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public string? FirewallPolicy { get; set; }

    /// <summary>Reference to a FirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicyRef")]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicyRef? FirewallPolicyRef { get; set; }

    /// <summary>Selector for a FirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicySelector")]
    public V1beta1FirewallPolicyRuleSpecForProviderFirewallPolicySelector? FirewallPolicySelector { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding 'action' is enforced.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1FirewallPolicyRuleSpecForProviderMatch>? Match { get; set; }

    /// <summary>An integer indicating the priority of a rule in the list. The priority must be a positive value between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A fully-qualified URL of a SecurityProfileGroup resource. Example: https://networksecurity.googleapis.com/v1/organizations/{organizationId}/locations/global/securityProfileGroups/my-security-profile-group. It must be specified if action = 'apply_security_profile_group' and cannot be specified for other actions.</summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>A list of network resource URLs to which this rule applies. This field allows you to control which network's VMs get this rule. If this field is left blank, all VMs within the organization will receive the rule.</summary>
    [JsonPropertyName("targetResources")]
    public IList<string>? TargetResources { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>Boolean flag indicating if the traffic should be TLS decrypted. It can be set only if action = 'apply_security_profile_group' and cannot be set for other actions.</summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

public enum V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderMatchLayer4Configs
{
    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecInitProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10. Destination address groups is only supported in Egress rules.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of destination of traffic. Can only be specified if DIRECTION is egress.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 256.</summary>
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
    public IList<V1beta1FirewallPolicyRuleSpecInitProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10. Source address groups is only supported in Ingress rules.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 256.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>The Unicode country codes whose IP addresses will be used to match against the source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>Name of the Google Cloud Threat Intelligence list.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecInitProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are "allow", "deny" and "goto_next".</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The direction in which this rule applies. Possible values: INGRESS, EGRESS</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Denotes whether the firewall policy rule is disabled. When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist. If this is unspecified, the firewall policy rule will be enabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Denotes whether to enable logging for a particular rule. If logging is enabled, logs will be exported to the configured export destination in Stackdriver. Logs may be exported to BigQuery or Pub/Sub. Note: you cannot enable logging on "goto_next" rules.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public string? FirewallPolicy { get; set; }

    /// <summary>Reference to a FirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicyRef")]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicyRef? FirewallPolicyRef { get; set; }

    /// <summary>Selector for a FirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicySelector")]
    public V1beta1FirewallPolicyRuleSpecInitProviderFirewallPolicySelector? FirewallPolicySelector { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding 'action' is enforced.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1FirewallPolicyRuleSpecInitProviderMatch>? Match { get; set; }

    /// <summary>An integer indicating the priority of a rule in the list. The priority must be a positive value between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A fully-qualified URL of a SecurityProfileGroup resource. Example: https://networksecurity.googleapis.com/v1/organizations/{organizationId}/locations/global/securityProfileGroups/my-security-profile-group. It must be specified if action = 'apply_security_profile_group' and cannot be specified for other actions.</summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>A list of network resource URLs to which this rule applies. This field allows you to control which network's VMs get this rule. If this field is left blank, all VMs within the organization will receive the rule.</summary>
    [JsonPropertyName("targetResources")]
    public IList<string>? TargetResources { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>Boolean flag indicating if the traffic should be TLS decrypted. It can be set only if action = 'apply_security_profile_group' and cannot be set for other actions.</summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

public enum V1beta1FirewallPolicyRuleSpecManagementPoliciesEnum
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

public enum V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1FirewallPolicyRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleSpecDeletionPolicyEnum>))]
    public V1beta1FirewallPolicyRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FirewallPolicyRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FirewallPolicyRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FirewallPolicyRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FirewallPolicyRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FirewallPolicyRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FirewallPolicyRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1FirewallPolicyRuleStatusAtProviderMatchLayer4Configs
{
    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

public partial class V1beta1FirewallPolicyRuleStatusAtProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10. Destination address groups is only supported in Egress rules.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of destination of traffic. Can only be specified if DIRECTION is egress.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 256.</summary>
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
    public IList<V1beta1FirewallPolicyRuleStatusAtProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10. Source address groups is only supported in Ingress rules.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>Domain names that will be used to match against the resolved domain name of source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 256.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>The Unicode country codes whose IP addresses will be used to match against the source of traffic. Can only be specified if DIRECTION is ingress.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>Name of the Google Cloud Threat Intelligence list.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

public partial class V1beta1FirewallPolicyRuleStatusAtProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are "allow", "deny" and "goto_next".</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The direction in which this rule applies. Possible values: INGRESS, EGRESS</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Denotes whether the firewall policy rule is disabled. When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist. If this is unspecified, the firewall policy rule will be enabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Denotes whether to enable logging for a particular rule. If logging is enabled, logs will be exported to the configured export destination in Stackdriver. Logs may be exported to BigQuery or Pub/Sub. Note: you cannot enable logging on "goto_next" rules.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public string? FirewallPolicy { get; set; }

    /// <summary>an identifier for the resource with format locations/global/firewallPolicies/{{firewall_policy}}/rules/{{priority}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the resource. Always compute#firewallPolicyRule for firewall policy rules</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding 'action' is enforced.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1FirewallPolicyRuleStatusAtProviderMatch>? Match { get; set; }

    /// <summary>An integer indicating the priority of a rule in the list. The priority must be a positive value between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Calculation of the complexity of a single firewall policy rule.</summary>
    [JsonPropertyName("ruleTupleCount")]
    public double? RuleTupleCount { get; set; }

    /// <summary>A fully-qualified URL of a SecurityProfileGroup resource. Example: https://networksecurity.googleapis.com/v1/organizations/{organizationId}/locations/global/securityProfileGroups/my-security-profile-group. It must be specified if action = 'apply_security_profile_group' and cannot be specified for other actions.</summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>A list of network resource URLs to which this rule applies. This field allows you to control which network's VMs get this rule. If this field is left blank, all VMs within the organization will receive the rule.</summary>
    [JsonPropertyName("targetResources")]
    public IList<string>? TargetResources { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>Boolean flag indicating if the traffic should be TLS decrypted. It can be set only if action = 'apply_security_profile_group' and cannot be set for other actions.</summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

public partial class V1beta1FirewallPolicyRuleStatusConditions
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

public partial class V1beta1FirewallPolicyRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FirewallPolicyRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirewallPolicyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirewallPolicyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirewallPolicyRuleSpec>, IStatus<V1beta1FirewallPolicyRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirewallPolicyRule";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "firewallpolicyrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallPolicyRuleSpec defines the desired state of FirewallPolicyRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1FirewallPolicyRuleSpec Spec { get; set; }

    /// <summary>FirewallPolicyRuleStatus defines the observed state of FirewallPolicyRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1FirewallPolicyRuleStatus? Status { get; set; }
}