using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.m.upbound.io;
#nullable enable
/// <summary>FrontdoorFirewallPolicy is the Schema for the FrontdoorFirewallPolicys API. Manages a Front Door (standard/premium) Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorFirewallPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorFirewallPolicyList";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
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
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode, or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, Redirect, or JSChallenge.</summary>
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
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderLogScrubbingScrubbingRule
{
    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderLogScrubbing
{
    /// <summary>Is log scrubbing enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more scrubbing_rule blocks as defined below.</summary>
    [JsonPropertyName("scrubbingRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderLogScrubbingScrubbingRule>? ScrubbingRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DefaultRuleSet 1.1 and below are Allow, Log, Block, or Redirect. Possible values for DefaultRuleSet 2.0 and above are Log or AnomalyScoring. Possible values for Microsoft_BotManagerRuleSet are Allow, Log, Block, Redirect, or JSChallenge.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
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
    /// <summary>The action to perform for all default rule set rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the default rule set you are using. Possible values include Allow, Log, Block, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecForProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection, or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which default rule set type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0, or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the possible values include 1.0 and 1.1.</summary>
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

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicy
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
/// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicy
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderSkuNameSelectorPolicy? Policy { get; set; }
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

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie lifetime in minutes, after which the user will be revalidated. Possible values are between 5 to 1440 minutes. Defaults to 30 minutes.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>A log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1FrontdoorFirewallPolicySpecForProviderLogScrubbing? LogScrubbing { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRuleMatchCondition
{
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode, or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, Redirect, or JSChallenge.</summary>
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
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderLogScrubbingScrubbingRule
{
    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderLogScrubbing
{
    /// <summary>Is log scrubbing enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more scrubbing_rule blocks as defined below.</summary>
    [JsonPropertyName("scrubbingRule")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderLogScrubbingScrubbingRule>? ScrubbingRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DefaultRuleSet 1.1 and below are Allow, Log, Block, or Redirect. Possible values for DefaultRuleSet 2.0 and above are Log or AnomalyScoring. Possible values for Microsoft_BotManagerRuleSet are Allow, Log, Block, Redirect, or JSChallenge.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
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
    /// <summary>The action to perform for all default rule set rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the default rule set you are using. Possible values include Allow, Log, Block, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicySpecInitProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection, or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which default rule set type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0, or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the possible values include 1.0 and 1.1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicy
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
/// <summary>Reference to a FrontdoorProfile in cdn to populate skuName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicy
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderSkuNameSelectorPolicy? Policy { get; set; }
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

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie lifetime in minutes, after which the user will be revalidated. Possible values are between 5 to 1440 minutes. Defaults to 30 minutes.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>A log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1FrontdoorFirewallPolicySpecInitProviderLogScrubbing? LogScrubbing { get; set; }

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
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpecProviderConfigRef
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
public partial class V1beta1FrontdoorFirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FrontdoorFirewallPolicySpec defines the desired state of FrontdoorFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorFirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorFirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
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
    /// <summary>Up to 600 possible values to match. Limit is in total across all match_condition blocks and match_values arguments. String value itself can be up to 256 characters in length.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Should the result of the condition be negated.</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Up to 5 transforms to apply. Possible values are Lowercase, RemoveNulls, Trim, Uppercase, URLDecode, or URLEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderCustomRule
{
    /// <summary>The action to perform when the rule is matched. Possible values are Allow, Block, Log, Redirect, or JSChallenge.</summary>
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
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderLogScrubbingScrubbingRule
{
    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderLogScrubbing
{
    /// <summary>Is log scrubbing enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more scrubbing_rule blocks as defined below.</summary>
    [JsonPropertyName("scrubbingRule")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderLogScrubbingScrubbingRule>? ScrubbingRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRuleExclusion
{
    /// <summary>The variable to be scrubbed from the logs. Possible values include QueryStringArgNames, RequestBodyJsonArgNames, RequestBodyPostArgNames, RequestCookieNames, RequestHeaderNames, RequestIPAddress, or RequestUri.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>When the match_variable is a collection, operate on the selector to specify which elements in the collection this scrubbing_rule applies to. Possible values are Equals or EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>When the match_variable is a collection, the operator is used to specify which elements in the collection this scrubbing_rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverrideRule
{
    /// <summary>The action to be applied when the managed rule matches or when the anomaly score is 5 or greater. Possible values for DefaultRuleSet 1.1 and below are Allow, Log, Block, or Redirect. Possible values for DefaultRuleSet 2.0 and above are Log or AnomalyScoring. Possible values for Microsoft_BotManagerRuleSet are Allow, Log, Block, Redirect, or JSChallenge.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Is this scrubbing_rule enabled? Defaults to true.</summary>
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
    /// <summary>The action to perform for all default rule set rules when the managed rule is matched or when the anomaly score is 5 or greater depending on which version of the default rule set you are using. Possible values include Allow, Log, Block, or Redirect.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleExclusion>? Exclusion { get; set; }

    /// <summary>One or more override blocks as defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FrontdoorFirewallPolicyStatusAtProviderManagedRuleOverride>? Override { get; set; }

    /// <summary>The name of the managed rule to use with this resource. Possible values include DefaultRuleSet, Microsoft_DefaultRuleSet, BotProtection, or Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the managed rule to use with this resource. Possible values depends on which default rule set type you are using, for the DefaultRuleSet type the possible values include 1.0 or preview-0.1. For Microsoft_DefaultRuleSet the possible values include 1.1, 2.0, or 2.1. For BotProtection the value must be preview-0.1 and for Microsoft_BotManagerRuleSet the possible values include 1.0 and 1.1.</summary>
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

    /// <summary>Is the Front Door Firewall Policy enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Front Door Profiles frontend endpoints associated with this Front Door Firewall Policy.</summary>
    [JsonPropertyName("frontendEndpointIds")]
    public IList<string>? FrontendEndpointIds { get; set; }

    /// <summary>The ID of the Front Door Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie lifetime in minutes, after which the user will be revalidated. Possible values are between 5 to 1440 minutes. Defaults to 30 minutes.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>A log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta1FrontdoorFirewallPolicyStatusAtProviderLogScrubbing? LogScrubbing { get; set; }

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
/// <summary>FrontdoorFirewallPolicy is the Schema for the FrontdoorFirewallPolicys API. Manages a Front Door (standard/premium) Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorFirewallPolicySpec>, IStatus<V1beta1FrontdoorFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorFirewallPolicy";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
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
