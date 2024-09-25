using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecDeletionPolicyEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the rule is enabled or disabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more match_condition block defined below. Can support up to 10 match_condition blocks.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderCustomRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The rate limit duration in minutes. Defaults to 1.</summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public double? RateLimitDurationInMinutes { get; set; }

    /// <summary>The rate limit threshold. Defaults to 10.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>The type of rule. Possible values are MatchRule or RateLimitRule.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DRS 1.1 and below are Allow, Log, Block, and Redirect. For DRS 2.0 and above the possible values are Log or AnomalyScoring.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the managed rule override enabled or disabled. Defaults to false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRuleExclusion>? Exclusion { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverride
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideExclusion>? Exclusion { get; set; }

    /// <summary>One or more rule blocks as defined below. If none are specified, all of the rules in the group will be disabled.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRule>? Rule { get; set; }

    /// <summary>The managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRule
{
    /// <summary>The action to perform for all DRS rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the DRS you are using. Possible values include Allow, Log, Block, and Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which DRS type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0 or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the value must be 1.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProvider
{
    /// <summary>If a custom_rule block's action type is block, this is the response body. The body must be specified in base64 encoding.</summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary>If a custom_rule block's action type is block, this is the response status code. Possible values are 200, 403, 405, 406, or 429.</summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public double? CustomBlockResponseStatusCode { get; set; }

    /// <summary>One or more custom_rule blocks as defined below.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The Front Door Firewall Policy mode. Possible values are Detection, Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Should policy managed rules inspect the request body content? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheckEnabled")]
    public bool? RequestBodyCheckEnabled { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The sku's pricing tier for this Front Door Firewall Policy. Possible values include Standard_AzureFrontDoor or Premium_AzureFrontDoor. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
    [JsonPropertyName("skuNameRef")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRef? SkuNameRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate skuName.</summary>
    [JsonPropertyName("skuNameSelector")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelector? SkuNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Front Door Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the rule is enabled or disabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more match_condition block defined below. Can support up to 10 match_condition blocks.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The rate limit duration in minutes. Defaults to 1.</summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public double? RateLimitDurationInMinutes { get; set; }

    /// <summary>The rate limit threshold. Defaults to 10.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>The type of rule. Possible values are MatchRule or RateLimitRule.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DRS 1.1 and below are Allow, Log, Block, and Redirect. For DRS 2.0 and above the possible values are Log or AnomalyScoring.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the managed rule override enabled or disabled. Defaults to false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRuleExclusion>? Exclusion { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverride
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideExclusion>? Exclusion { get; set; }

    /// <summary>One or more rule blocks as defined below. If none are specified, all of the rules in the group will be disabled.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRule>? Rule { get; set; }

    /// <summary>The managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRule
{
    /// <summary>The action to perform for all DRS rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the DRS you are using. Possible values include Allow, Log, Block, and Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which DRS type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0 or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the value must be 1.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProvider
{
    /// <summary>If a custom_rule block's action type is block, this is the response body. The body must be specified in base64 encoding.</summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary>If a custom_rule block's action type is block, this is the response status code. Possible values are 200, 403, 405, 406, or 429.</summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public double? CustomBlockResponseStatusCode { get; set; }

    /// <summary>One or more custom_rule blocks as defined below.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The Front Door Firewall Policy mode. Possible values are Detection, Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Should policy managed rules inspect the request body content? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheckEnabled")]
    public bool? RequestBodyCheckEnabled { get; set; }

    /// <summary>The sku's pricing tier for this Front Door Firewall Policy. Possible values include Standard_AzureFrontDoor or Premium_AzureFrontDoor. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
    [JsonPropertyName("skuNameRef")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRef? SkuNameRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate skuName.</summary>
    [JsonPropertyName("skuNameSelector")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelector? SkuNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Front Door Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FrontdoorFirewallPolicySpec defines the desired state of FrontdoorFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorFirewallPolicySpecDeletionPolicyEnum>))]
    public V1beta1FrontdoorFirewallPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorFirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorFirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FrontdoorFirewallPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorFirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FrontdoorFirewallPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorFirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the rule is enabled or disabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more match_condition block defined below. Can support up to 10 match_condition blocks.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The rate limit duration in minutes. Defaults to 1.</summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public double? RateLimitDurationInMinutes { get; set; }

    /// <summary>The rate limit threshold. Defaults to 10.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>The type of rule. Possible values are MatchRule or RateLimitRule.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The request variable to compare with. Possible values are Cookies, PostArgs, QueryString, RemoteAddr, RequestBody, RequestHeader, RequestMethod, RequestUri, or SocketAddr.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Comparison type to use for matching with the variable value. Possible values are Any, BeginsWith, Contains, EndsWith, Equal, GeoMatch, GreaterThan, GreaterThanOrEqual, IPMatch, LessThan, LessThanOrEqual or RegEx.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Match against a specific key if the match_variable is QueryString, PostArgs, RequestHeader or Cookies.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DRS 1.1 and below are Allow, Log, Block, and Redirect. For DRS 2.0 and above the possible values are Log or AnomalyScoring.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is the managed rule override enabled or disabled. Defaults to false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRuleExclusion>? Exclusion { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverride
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideExclusion>? Exclusion { get; set; }

    /// <summary>One or more rule blocks as defined below. If none are specified, all of the rules in the group will be disabled.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRule>? Rule { get; set; }

    /// <summary>The managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRule
{
    /// <summary>The action to perform for all DRS rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the DRS you are using. Possible values include Allow, Log, Block, and Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which DRS type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0 or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the value must be 1.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProvider
{
    /// <summary>If a custom_rule block's action type is block, this is the response body. The body must be specified in base64 encoding.</summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary>If a custom_rule block's action type is block, this is the response status code. Possible values are 200, 403, 405, 406, or 429.</summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public double? CustomBlockResponseStatusCode { get; set; }

    /// <summary>One or more custom_rule blocks as defined below.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Front Door Profiles frontend endpoints associated with this Front Door Firewall Policy.</summary>
    [JsonPropertyName("frontendEndpointIds")]
    public IList<string>? FrontendEndpointIds { get; set; }

    /// <summary>The ID of the Front Door Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The Front Door Firewall Policy mode. Possible values are Detection, Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Should policy managed rules inspect the request body content? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheckEnabled")]
    public bool? RequestBodyCheckEnabled { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The sku's pricing tier for this Front Door Firewall Policy. Possible values include Standard_AzureFrontDoor or Premium_AzureFrontDoor. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags to assign to the Front Door Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusConditions
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

/// <summary>FrontdoorFirewallPolicyStatus defines the observed state of FrontdoorFirewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorFirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorFirewallPolicy is the Schema for the FrontdoorFirewallPolicys API. Manages a Front Door (standard/premium) Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorFirewallPolicySpec>, IStatus<V1beta1FrontdoorFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorFirewallPolicy";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorfirewallpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorFirewallPolicySpec defines the desired state of FrontdoorFirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorFirewallPolicySpec Spec { get; set; }

    /// <summary>FrontdoorFirewallPolicyStatus defines the observed state of FrontdoorFirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorFirewallPolicyStatus? Status { get; set; }
}