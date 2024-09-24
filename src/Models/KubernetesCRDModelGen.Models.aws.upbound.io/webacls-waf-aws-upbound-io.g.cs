using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.waf.aws.upbound.io;
public enum V1beta1WebACLSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF to respond to requests that don't match the criteria in any of the rules. e.g., ALLOW or BLOCK</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}

public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum>))]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum>))]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationRef")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRef? LogDestinationRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationSelector")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelector? LogDestinationSelector { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields>? RedactedFields { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecForProviderRulesRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Rule in waf to populate ruleId.</summary>
public partial class V1beta1WebACLSpecForProviderRulesRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum>))]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Rule in waf to populate ruleId.</summary>
public partial class V1beta1WebACLSpecForProviderRulesRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WebACLSpecForProviderRulesAction>? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public IList<V1beta1WebACLSpecForProviderRulesOverrideAction>? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecForProvider
{
    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1WebACLSpecForProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1WebACLSpecForProviderLoggingConfiguration>? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLSpecForProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF to respond to requests that don't match the criteria in any of the rules. e.g., ALLOW or BLOCK</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}

public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum>))]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum>))]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationRef")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRef? LogDestinationRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationSelector")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelector? LogDestinationSelector { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields>? RedactedFields { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Rule in waf to populate ruleId.</summary>
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum>))]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Rule in waf to populate ruleId.</summary>
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLSpecInitProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WebACLSpecInitProviderRulesAction>? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public IList<V1beta1WebACLSpecInitProviderRulesOverrideAction>? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1WebACLSpecInitProvider
{
    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1WebACLSpecInitProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1WebACLSpecInitProviderLoggingConfiguration>? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLSpecInitProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1WebACLSpecManagementPoliciesEnum
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

public enum V1beta1WebACLSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1WebACLSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1WebACLSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1WebACLSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WebACLSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WebACLSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WebACLSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1WebACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WebACLSpec defines the desired state of WebACL</summary>
public partial class V1beta1WebACLSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecDeletionPolicyEnum>))]
    public V1beta1WebACLSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebACLSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WebACLSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WebACLSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF to respond to requests that don't match the criteria in any of the rules. e.g., ALLOW or BLOCK</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields>? RedactedFields { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WebACLStatusAtProviderRulesAction>? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public IList<V1beta1WebACLStatusAtProviderRulesOverrideAction>? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1WebACLStatusAtProvider
{
    /// <summary>The ARN of the WAF WebACL.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1WebACLStatusAtProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>The ID of the WAF WebACL.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1WebACLStatusAtProviderLoggingConfiguration>? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLStatusAtProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1WebACLStatusConditions
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

/// <summary>WebACLStatus defines the observed state of WebACL.</summary>
public partial class V1beta1WebACLStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebACLStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebACLStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>WebACL is the Schema for the WebACLs API. Provides a AWS WAF web access control group (ACL) resource.</summary>
public partial class V1beta1WebACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLSpec>, IStatus<V1beta1WebACLStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACL";
    public const string KubeGroup = "waf.aws.upbound.io";
    public const string KubePluralName = "webacls";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebACLSpec defines the desired state of WebACL</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebACLSpec Spec { get; set; }

    /// <summary>WebACLStatus defines the observed state of WebACL.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebACLStatus? Status { get; set; }
}