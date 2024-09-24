using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.frontdoor.azure.com;
public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValue")]
    public IList<string>? MatchValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRules>? Rules { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetAction")]
    public string? RuleSetAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecPolicySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public string? RequestBodyCheck { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20220501.CustomRuleList Defines contents of custom rules</summary>
    [JsonPropertyName("customRules")]
    public V1api20220501storageWebApplicationFirewallPolicySpecCustomRules? CustomRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20220501.ManagedRuleSetList Defines the list of managed rule sets for the policy.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501storageWebApplicationFirewallPolicySpecManagedRules? ManagedRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220501storageWebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20220501.PolicySettings Defines top-level WebApplicationFirewallPolicy configuration settings.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501storageWebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    /// <summary>Storage version of v1api20220501.Sku The pricing tier of the web application firewall policy.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageWebApplicationFirewallPolicySpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValue")]
    public IList<string>? MatchValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRules>? Rules { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusFrontendEndpointLinks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetAction")]
    public string? RuleSetAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusPolicySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public string? RequestBodyCheck { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusRoutingRuleLinks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusSecurityPolicyLinks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20220501storageWebApplicationFirewallPolicyStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20220501.CustomRuleList_STATUS Defines contents of custom rules</summary>
    [JsonPropertyName("customRules")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusCustomRules? CustomRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendEndpointLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusFrontendEndpointLinks>? FrontendEndpointLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20220501.ManagedRuleSetList_STATUS Defines the list of managed rule sets for the policy.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220501.PolicySettings_STATUS Defines top-level WebApplicationFirewallPolicy configuration settings.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routingRuleLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusRoutingRuleLinks>? RoutingRuleLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityPolicyLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusSecurityPolicyLinks>? SecurityPolicyLinks { get; set; }

    /// <summary>Storage version of v1api20220501.Sku_STATUS The pricing tier of the web application firewall policy.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501storageWebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220501storageWebApplicationFirewallPolicySpec>, IStatus<V1api20220501storageWebApplicationFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1api20220501storage";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.frontdoor.azure.com";
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

    /// <summary>Storage version of v1api20220501.FrontDoorWebApplicationFirewallPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220501storageWebApplicationFirewallPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220501.FrontDoorWebApplicationFirewallPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220501storageWebApplicationFirewallPolicyStatus? Status { get; set; }
}