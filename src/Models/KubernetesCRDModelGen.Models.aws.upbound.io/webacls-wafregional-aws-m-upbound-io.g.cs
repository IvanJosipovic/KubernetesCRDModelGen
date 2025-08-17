using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafregional.aws.m.upbound.io;
#nullable enable
/// <summary>WebACL is the Schema for the WebACLs API. Provides a AWS WAF Regional web access control group (ACL) resource for use with ALB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebACL>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLList";
    public const string KubeGroup = "wafregional.aws.m.upbound.io";
    public const string KubePluralName = "webacls";
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
    public IList<V1beta1WebACL> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a ruleE.g., ALLOW, BLOCK or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleOverrideAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Rule in wafregional to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRuleRuleIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Rule in wafregional to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRuleRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRuleRuleIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRule
{
    /// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLSpecForProviderRuleAction? Action { get; set; }

    /// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLSpecForProviderRuleOverrideAction? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Regional) rule (e.g., aws_wafregional_rule). WAF (Global) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in wafregional to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecForProviderRuleRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in wafregional to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecForProviderRuleRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProvider
{
    /// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecForProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLSpecForProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Set of configuration blocks containing rules for the web ACL. Detailed below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebACLSpecForProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a ruleE.g., ALLOW, BLOCK or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleOverrideAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Rule in wafregional to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRuleRuleIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Rule in wafregional to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRuleRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRuleRuleIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRule
{
    /// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLSpecInitProviderRuleAction? Action { get; set; }

    /// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLSpecInitProviderRuleOverrideAction? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Regional) rule (e.g., aws_wafregional_rule). WAF (Global) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in wafregional to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecInitProviderRuleRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in wafregional to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecInitProviderRuleRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProvider
{
    /// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecInitProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLSpecInitProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of configuration blocks containing rules for the web ACL. Detailed below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebACLSpecInitProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WebACLSpec defines the desired state of WebACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebACLSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a ruleE.g., ALLOW, BLOCK or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRuleAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRuleOverrideAction
{
    /// <summary>Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. Valid values for action are ALLOW, BLOCK or COUNT. Valid values for override_action are COUNT and NONE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRule
{
    /// <summary>Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLStatusAtProviderRuleAction? Action { get; set; }

    /// <summary>Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if type is GROUP. Detailed below.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLStatusAtProviderRuleOverrideAction? OverrideAction { get; set; }

    /// <summary>Specifies the order in which the rules in a WebACL are evaluated. Rules with a lower value are evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Regional) rule (e.g., aws_wafregional_rule). WAF (Global) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the WAF Regional WebACL.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The action that you want AWS WAF Regional to take when a request doesn't match the criteria in any of the rules that are associated with the web ACL.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLStatusAtProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>The ID of the WAF Regional WebACL.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLStatusAtProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Set of configuration blocks containing rules for the web ACL. Detailed below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebACLStatusAtProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>WebACLStatus defines the observed state of WebACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>WebACL is the Schema for the WebACLs API. Provides a AWS WAF Regional web access control group (ACL) resource for use with ALB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLSpec>, IStatus<V1beta1WebACLStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACL";
    public const string KubeGroup = "wafregional.aws.m.upbound.io";
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
#nullable disable
