using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>WebApplicationFirewallPolicy is the Schema for the WebApplicationFirewallPolicys API. Manages a Azure Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "webapplicationfirewallpolicies";
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
    public IList<V1beta1WebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are GeoLocation, ClientAddr and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to. When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelector
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
    public V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecForProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta1WebApplicationFirewallPolicySpecForProviderCustomRules>? CustomRules { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are GeoLocation, ClientAddr and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to. When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecInitProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta1WebApplicationFirewallPolicySpecInitProviderCustomRules>? CustomRules { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta1WebApplicationFirewallPolicySpecInitProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta1WebApplicationFirewallPolicySpecInitProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WebApplicationFirewallPolicySpec defines the desired state of WebApplicationFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebApplicationFirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebApplicationFirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebApplicationFirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebApplicationFirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are GeoLocation, ClientAddr and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to. When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusAtProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusAtProviderCustomRules>? CustomRules { get; set; }

    /// <summary>A list of HTTP Listener IDs from an azurerm_application_gateway.</summary>
    [JsonPropertyName("httpListenerIds")]
    public IList<string>? HttpListenerIds { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta1WebApplicationFirewallPolicyStatusAtProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A list of URL Path Map Path Rule IDs from an azurerm_application_gateway.</summary>
    [JsonPropertyName("pathBasedRuleIds")]
    public IList<string>? PathBasedRuleIds { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta1WebApplicationFirewallPolicyStatusAtProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatusConditions
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

/// <summary>WebApplicationFirewallPolicyStatus defines the observed state of WebApplicationFirewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebApplicationFirewallPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebApplicationFirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebApplicationFirewallPolicy is the Schema for the WebApplicationFirewallPolicys API. Manages a Azure Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebApplicationFirewallPolicySpec>, IStatus<V1beta1WebApplicationFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebApplicationFirewallPolicySpec defines the desired state of WebApplicationFirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebApplicationFirewallPolicySpec Spec { get; set; }

    /// <summary>WebApplicationFirewallPolicyStatus defines the observed state of WebApplicationFirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebApplicationFirewallPolicyStatus? Status { get; set; }
}