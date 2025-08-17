using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
#nullable enable
/// <summary>FrontdoorFirewallPolicy is the Schema for the FrontdoorFirewallPolicys API. Manages an Azure Front Door (classic) Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorFirewallPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorFirewallPolicyList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorfirewallpolicies";
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
    public IList<V1beta1FrontdoorFirewallPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters long.</summary>
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

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode orURLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the rule matches. Possible values are Allow, Block, Log, or Redirect.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRule
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version on the managed rule to use with this resource.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRefPolicy
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy
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
#nullable disable

#nullable enable
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

    /// <summary>Is the policy a enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The firewall policy mode. Possible values are Detection, Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters long.</summary>
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

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode orURLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the rule matches. Possible values are Allow, Block, Log, or Redirect.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRule
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version on the managed rule to use with this resource.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
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

    /// <summary>Is the policy a enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The firewall policy mode. Possible values are Detection, Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecProviderConfigRefPolicy
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
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
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
#nullable disable

#nullable enable
/// <summary>FrontdoorFirewallPolicySpec defines the desired state of FrontdoorFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorFirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorFirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorFirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorFirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters long.</summary>
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

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode orURLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the rule matches. Possible values are Allow, Block, Log, or Redirect.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRule
{
    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version on the managed rule to use with this resource.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
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

    /// <summary>Is the policy a enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Frontend Endpoints associated with this Front Door Web Application Firewall policy.</summary>
    [JsonPropertyName("frontendEndpointIds")]
    public IList<string>? FrontendEndpointIds { get; set; }

    /// <summary>The ID of the Front Door Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where this Front Door Firewall Policy exists.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more managed_rule blocks as defined below.</summary>
    [JsonPropertyName("managedRule")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRule>? ManagedRule { get; set; }

    /// <summary>The firewall policy mode. Possible values are Detection, Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>FrontdoorFirewallPolicy is the Schema for the FrontdoorFirewallPolicys API. Manages an Azure Front Door (classic) Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorFirewallPolicySpec>, IStatus<V1beta1FrontdoorFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorFirewallPolicy";
    public const string KubeGroup = "network.azure.upbound.io";
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
#nullable disable
