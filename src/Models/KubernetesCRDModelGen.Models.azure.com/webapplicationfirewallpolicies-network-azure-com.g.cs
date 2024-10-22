using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Storage version of v1api20240101.GroupByVariable Define user session group by clause variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Storage version of v1api20240101.GroupByUserSession Define user session identifier group by clauses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSession
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupByVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables>? GroupByVariables { get; set; }
}

/// <summary>Storage version of v1api20240101.MatchVariable Define match variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Storage version of v1api20240101.MatchCondition Define match conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallCustomRule Defines contents of a web application rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRule Defines a managed rule to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRuleGroup Defines a managed rule group to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRuleSet Defines a managed rule set for Exclusions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Storage version of v1api20240101.OwaspCrsExclusionEntry Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

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

/// <summary>Storage version of v1api20240101.ManagedRuleOverride Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRuleGroupOverride Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRuleSet Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRulesDefinition Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallScrubbingRules Allow certain variables to be scrubbed on WAF logs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules
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

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbing
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings Defines contents of a web application firewall global configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettings
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
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRules>? CustomRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240101.ManagedRulesDefinition Allow to exclude some variable satisfy the condition for the WAF check.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20240101storageWebApplicationFirewallPolicySpecManagedRules? ManagedRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240101storageWebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings Defines contents of a web application firewall global configuration.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101storageWebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Storage version of v1api20240101.ApplicationGateway_STATUS_ApplicationGatewayWebApplicationFirewallPolicy_SubResourceEmbedded Application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusApplicationGateways
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusConditions
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

/// <summary>Storage version of v1api20240101.GroupByVariable_STATUS Define user session group by clause variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Storage version of v1api20240101.GroupByUserSession_STATUS Define user session identifier group by clauses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupByVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables>? GroupByVariables { get; set; }
}

/// <summary>Storage version of v1api20240101.MatchVariable_STATUS Define match variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Storage version of v1api20240101.MatchCondition_STATUS Define match conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallCustomRule_STATUS Defines contents of a web application rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusHttpListeners
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRule_STATUS Defines a managed rule to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRuleGroup_STATUS Defines a managed rule group to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240101.ExclusionManagedRuleSet_STATUS Defines a managed rule set for Exclusions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Storage version of v1api20240101.OwaspCrsExclusionEntry_STATUS Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

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

/// <summary>Storage version of v1api20240101.ManagedRuleOverride_STATUS Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRuleGroupOverride_STATUS Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRuleSet_STATUS Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Storage version of v1api20240101.ManagedRulesDefinition_STATUS Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>Storage version of v1api20240101.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPathBasedRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallScrubbingRules_STATUS Allow certain variables to be scrubbed on WAF logs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules
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

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings_STATUS Defines contents of a web application firewall global configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettings
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
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing_STATUS</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGateways")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusApplicationGateways>? ApplicationGateways { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRules>? CustomRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusHttpListeners>? HttpListeners { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240101.ManagedRulesDefinition_STATUS Allow to exclude some variable satisfy the condition for the WAF check.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathBasedRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusPathBasedRules>? PathBasedRules { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings_STATUS Defines contents of a web application firewall global configuration.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2024-01-01/webapplicationfirewall.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageWebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101storageWebApplicationFirewallPolicySpec>, IStatus<V1api20240101storageWebApplicationFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.azure.com";
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

    /// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240101storageWebApplicationFirewallPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240101storageWebApplicationFirewallPolicyStatus? Status { get; set; }
}