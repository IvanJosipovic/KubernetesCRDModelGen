using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.aws.upbound.io;
public enum V1beta1FirewallPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet>? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariables
{
    /// <summary></summary>
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceOverride>? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction>? PublishMetricAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinition>? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyPolicyVariables>? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. You can specify one of either or neither values of aws:drop_strict or aws:drop_established, as well as any combination of aws:alert_strict and aws:alert_established.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptions>? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy's stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. "You can only add a TLS inspection configuration to a new policy, not to an existing policy."  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecForProvider
{
    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1FirewallPolicySpecForProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public IList<V1beta1FirewallPolicySpecForProviderFirewallPolicy>? FirewallPolicy { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet>? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariables
{
    /// <summary></summary>
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceOverride>? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction>? PublishMetricAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinition>? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicySpecInitProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyPolicyVariables>? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. You can specify one of either or neither values of aws:drop_strict or aws:drop_established, as well as any combination of aws:alert_strict and aws:alert_established.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptions>? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy's stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. "You can only add a TLS inspection configuration to a new policy, not to an existing policy."  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1FirewallPolicySpecInitProvider
{
    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1FirewallPolicySpecInitProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public IList<V1beta1FirewallPolicySpecInitProviderFirewallPolicy>? FirewallPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1FirewallPolicySpecManagementPoliciesEnum
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

public enum V1beta1FirewallPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1FirewallPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1FirewallPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FirewallPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1FirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
public partial class V1beta1FirewallPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicySpecDeletionPolicyEnum>))]
    public V1beta1FirewallPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FirewallPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FirewallPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet>? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariables
{
    /// <summary></summary>
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReferenceOverride>? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction>? PublishMetricAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinition>? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariables>? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. You can specify one of either or neither values of aws:drop_strict or aws:drop_established, as well as any combination of aws:alert_strict and aws:alert_established.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptions>? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy's stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe. In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.</summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. "You can only add a TLS inspection configuration to a new policy, not to an existing policy."  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1FirewallPolicyStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) that identifies the firewall policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1FirewallPolicyStatusAtProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public IList<V1beta1FirewallPolicyStatusAtProviderFirewallPolicy>? FirewallPolicy { get; set; }

    /// <summary>The Amazon Resource Name (ARN) that identifies the firewall policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A string token used when updating a firewall policy.</summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1FirewallPolicyStatusConditions
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

/// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
public partial class V1beta1FirewallPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>FirewallPolicy is the Schema for the FirewallPolicys API. Provides an AWS Network Firewall Policy resource.</summary>
public partial class V1beta1FirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirewallPolicySpec>, IStatus<V1beta1FirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "firewallpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1FirewallPolicySpec Spec { get; set; }

    /// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1FirewallPolicyStatus? Status { get; set; }
}