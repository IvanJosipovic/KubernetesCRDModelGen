using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
#nullable enable
/// <summary>SecurityPolicy is the Schema for the SecurityPolicys API. Creates a Security Policy resource for Google Compute Engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SecurityPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityPolicyList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "securitypolicies";
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
    public IList<V1beta1SecurityPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs
{
    /// <summary>If enabled, traffic matching each unique value for the specified type constitutes a separate traffic unit. It can only be set to true if value is empty.</summary>
    [JsonPropertyName("enableEachUniqueValue")]
    public bool? EnableEachUniqueValue { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs
{
    /// <summary>Confidence threshold above which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployConfidenceThreshold")]
    public double? AutoDeployConfidenceThreshold { get; set; }

    /// <summary>Duration over which Adaptive Protection's auto-deployed actions last.</summary>
    [JsonPropertyName("autoDeployExpirationSec")]
    public double? AutoDeployExpirationSec { get; set; }

    /// <summary>Impacted baseline threshold below which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployImpactedBaselineThreshold")]
    public double? AutoDeployImpactedBaselineThreshold { get; set; }

    /// <summary>Load threshold above which Adaptive Protection automatically deploy threshold based on the backend load threshold and detect a new rule during an alerted attack.</summary>
    [JsonPropertyName("autoDeployLoadThreshold")]
    public double? AutoDeployLoadThreshold { get; set; }

    /// <summary>Detection threshold based on absolute QPS.</summary>
    [JsonPropertyName("detectionAbsoluteQps")]
    public double? DetectionAbsoluteQps { get; set; }

    /// <summary>Detection threshold based on the backend service's load.</summary>
    [JsonPropertyName("detectionLoadThreshold")]
    public double? DetectionLoadThreshold { get; set; }

    /// <summary>Detection threshold based on QPS relative to the average of baseline traffic.</summary>
    [JsonPropertyName("detectionRelativeToBaselineQps")]
    public double? DetectionRelativeToBaselineQps { get; set; }

    /// <summary>The name of config. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the security policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options for enabling Adaptive Protection to work on the specified service granularity. Structure is documented below.</summary>
    [JsonPropertyName("trafficGranularityConfigs")]
    public IList<V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs>? TrafficGranularityConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }

    /// <summary>Configuration options for layer7 adaptive protection for various customizable thresholds. Structure is documented below.</summary>
    [JsonPropertyName("thresholdConfigs")]
    public IList<V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs>? ThresholdConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig? Layer7DdosDefenseConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Advanced Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfigJsonCustomConfig? JsonCustomConfig { get; set; }

    /// <summary>Whether or not to JSON parse the payload body. Defaults to DISABLED.</summary>
    [JsonPropertyName("jsonParsing")]
    public string? JsonParsing { get; set; }

    /// <summary>Log level to use. Defaults to NORMAL.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>An optional list of case-insensitive request header names to use for resolving the callers client IP address.</summary>
    [JsonPropertyName("userIpRequestHeaders")]
    public IList<string>? UserIpRequestHeaders { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}
#nullable disable

#nullable enable
/// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public V1beta1SecurityPolicySpecForProviderRuleMatchExprOptionsRecaptchaOptions? RecaptchaOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta1SecurityPolicySpecForProviderRuleMatchConfig? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public V1beta1SecurityPolicySpecForProviderRuleMatchExpr? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public V1beta1SecurityPolicySpecForProviderRuleMatchExprOptions? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusion
{
    /// <summary>Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>Request header whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation. Note that the parameter can be in the query string or in the POST body. Structure is documented below.</summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation. When specifying this field, the query or fragment part should be excluded. Structure is documented below.</summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.</summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfig
{
    /// <summary>An exclusion to apply during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>If specified, any combination of values of enforce_on_key_type/enforce_on_key_name is treated as the key on which rate limit threshold/action is enforced. You can specify up to 3 enforce_on_key_configs. If enforce_on_key_configs is specified, enforce_on_key must be set to an empty string. Structure is documented below.</summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsExceedRedirectOptions? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRuleRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProviderRule
{
    /// <summary>Action to take when match matches the request. Valid values:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this rule. Max size is 64.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1SecurityPolicySpecForProviderRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public V1beta1SecurityPolicySpecForProviderRuleMatch? Match { get; set; }

    /// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1SecurityPolicySpecForProviderRulePreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1SecurityPolicySpecForProviderRuleRateLimitOptions? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public V1beta1SecurityPolicySpecForProviderRuleRedirectOptions? RedirectOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecForProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfig? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfig? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public V1beta1SecurityPolicySpecForProviderRecaptchaOptionsConfig? RecaptchaOptionsConfig { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added. Structure is documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1SecurityPolicySpecForProviderRule>? Rule { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs
{
    /// <summary>If enabled, traffic matching each unique value for the specified type constitutes a separate traffic unit. It can only be set to true if value is empty.</summary>
    [JsonPropertyName("enableEachUniqueValue")]
    public bool? EnableEachUniqueValue { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs
{
    /// <summary>Confidence threshold above which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployConfidenceThreshold")]
    public double? AutoDeployConfidenceThreshold { get; set; }

    /// <summary>Duration over which Adaptive Protection's auto-deployed actions last.</summary>
    [JsonPropertyName("autoDeployExpirationSec")]
    public double? AutoDeployExpirationSec { get; set; }

    /// <summary>Impacted baseline threshold below which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployImpactedBaselineThreshold")]
    public double? AutoDeployImpactedBaselineThreshold { get; set; }

    /// <summary>Load threshold above which Adaptive Protection automatically deploy threshold based on the backend load threshold and detect a new rule during an alerted attack.</summary>
    [JsonPropertyName("autoDeployLoadThreshold")]
    public double? AutoDeployLoadThreshold { get; set; }

    /// <summary>Detection threshold based on absolute QPS.</summary>
    [JsonPropertyName("detectionAbsoluteQps")]
    public double? DetectionAbsoluteQps { get; set; }

    /// <summary>Detection threshold based on the backend service's load.</summary>
    [JsonPropertyName("detectionLoadThreshold")]
    public double? DetectionLoadThreshold { get; set; }

    /// <summary>Detection threshold based on QPS relative to the average of baseline traffic.</summary>
    [JsonPropertyName("detectionRelativeToBaselineQps")]
    public double? DetectionRelativeToBaselineQps { get; set; }

    /// <summary>The name of config. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the security policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options for enabling Adaptive Protection to work on the specified service granularity. Structure is documented below.</summary>
    [JsonPropertyName("trafficGranularityConfigs")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs>? TrafficGranularityConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }

    /// <summary>Configuration options for layer7 adaptive protection for various customizable thresholds. Structure is documented below.</summary>
    [JsonPropertyName("thresholdConfigs")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs>? ThresholdConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig? Layer7DdosDefenseConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Advanced Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfigJsonCustomConfig? JsonCustomConfig { get; set; }

    /// <summary>Whether or not to JSON parse the payload body. Defaults to DISABLED.</summary>
    [JsonPropertyName("jsonParsing")]
    public string? JsonParsing { get; set; }

    /// <summary>Log level to use. Defaults to NORMAL.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>An optional list of case-insensitive request header names to use for resolving the callers client IP address.</summary>
    [JsonPropertyName("userIpRequestHeaders")]
    public IList<string>? UserIpRequestHeaders { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}
#nullable disable

#nullable enable
/// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptionsRecaptchaOptions? RecaptchaOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta1SecurityPolicySpecInitProviderRuleMatchConfig? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public V1beta1SecurityPolicySpecInitProviderRuleMatchExpr? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptions? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusion
{
    /// <summary>Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>Request header whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation. Note that the parameter can be in the query string or in the POST body. Structure is documented below.</summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation. When specifying this field, the query or fragment part should be excluded. Structure is documented below.</summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.</summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfig
{
    /// <summary>An exclusion to apply during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>If specified, any combination of values of enforce_on_key_type/enforce_on_key_name is treated as the key on which rate limit threshold/action is enforced. You can specify up to 3 enforce_on_key_configs. If enforce_on_key_configs is specified, enforce_on_key must be set to an empty string. Structure is documented below.</summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsExceedRedirectOptions? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRuleRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProviderRule
{
    /// <summary>Action to take when match matches the request. Valid values:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this rule. Max size is 64.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1SecurityPolicySpecInitProviderRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public V1beta1SecurityPolicySpecInitProviderRuleMatch? Match { get; set; }

    /// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1SecurityPolicySpecInitProviderRulePreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptions? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public V1beta1SecurityPolicySpecInitProviderRuleRedirectOptions? RedirectOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecInitProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfig? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfig? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public V1beta1SecurityPolicySpecInitProviderRecaptchaOptionsConfig? RecaptchaOptionsConfig { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added. Structure is documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1SecurityPolicySpecInitProviderRule>? Rule { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpecProviderConfigRef
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
public partial class V1beta1SecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecurityPolicySpec defines the desired state of SecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecurityPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecurityPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs
{
    /// <summary>If enabled, traffic matching each unique value for the specified type constitutes a separate traffic unit. It can only be set to true if value is empty.</summary>
    [JsonPropertyName("enableEachUniqueValue")]
    public bool? EnableEachUniqueValue { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs
{
    /// <summary>Confidence threshold above which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployConfidenceThreshold")]
    public double? AutoDeployConfidenceThreshold { get; set; }

    /// <summary>Duration over which Adaptive Protection's auto-deployed actions last.</summary>
    [JsonPropertyName("autoDeployExpirationSec")]
    public double? AutoDeployExpirationSec { get; set; }

    /// <summary>Impacted baseline threshold below which Adaptive Protection's auto-deploy takes actions.</summary>
    [JsonPropertyName("autoDeployImpactedBaselineThreshold")]
    public double? AutoDeployImpactedBaselineThreshold { get; set; }

    /// <summary>Load threshold above which Adaptive Protection automatically deploy threshold based on the backend load threshold and detect a new rule during an alerted attack.</summary>
    [JsonPropertyName("autoDeployLoadThreshold")]
    public double? AutoDeployLoadThreshold { get; set; }

    /// <summary>Detection threshold based on absolute QPS.</summary>
    [JsonPropertyName("detectionAbsoluteQps")]
    public double? DetectionAbsoluteQps { get; set; }

    /// <summary>Detection threshold based on the backend service's load.</summary>
    [JsonPropertyName("detectionLoadThreshold")]
    public double? DetectionLoadThreshold { get; set; }

    /// <summary>Detection threshold based on QPS relative to the average of baseline traffic.</summary>
    [JsonPropertyName("detectionRelativeToBaselineQps")]
    public double? DetectionRelativeToBaselineQps { get; set; }

    /// <summary>The name of config. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the security policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options for enabling Adaptive Protection to work on the specified service granularity. Structure is documented below.</summary>
    [JsonPropertyName("trafficGranularityConfigs")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigsTrafficGranularityConfigs>? TrafficGranularityConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }

    /// <summary>Configuration options for layer7 adaptive protection for various customizable thresholds. Structure is documented below.</summary>
    [JsonPropertyName("thresholdConfigs")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigs>? ThresholdConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig? Layer7DdosDefenseConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Advanced Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfigJsonCustomConfig? JsonCustomConfig { get; set; }

    /// <summary>Whether or not to JSON parse the payload body. Defaults to DISABLED.</summary>
    [JsonPropertyName("jsonParsing")]
    public string? JsonParsing { get; set; }

    /// <summary>Log level to use. Defaults to NORMAL.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>An optional list of case-insensitive request header names to use for resolving the callers client IP address.</summary>
    [JsonPropertyName("userIpRequestHeaders")]
    public IList<string>? UserIpRequestHeaders { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}
#nullable disable

#nullable enable
/// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}
#nullable disable

#nullable enable
/// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptionsRecaptchaOptions? RecaptchaOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta1SecurityPolicyStatusAtProviderRuleMatchConfig? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public V1beta1SecurityPolicyStatusAtProviderRuleMatchExpr? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptions? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Requests that match this value constitute a granular traffic unit.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusion
{
    /// <summary>Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>Request header whose value will be excluded from inspection during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation. Note that the parameter can be in the query string or in the POST body. Structure is documented below.</summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation. When specifying this field, the query or fragment part should be excluded. Structure is documented below.</summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.</summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfig
{
    /// <summary>An exclusion to apply during preconfigured WAF evaluation. Structure is documented below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>If specified, any combination of values of enforce_on_key_type/enforce_on_key_name is treated as the key on which rate limit threshold/action is enforced. You can specify up to 3 enforce_on_key_configs. If enforce_on_key_configs is specified, enforce_on_key must be set to an empty string. Structure is documented below.</summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. Structure is documented below.</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsExceedRedirectOptions? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRedirectOptions
{
    /// <summary>External redirection target when EXTERNAL_302 is set in type.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProviderRule
{
    /// <summary>Action to take when match matches the request. Valid values:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this rule. Max size is 64.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Additional actions that are performed on headers. Structure is documented below.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1SecurityPolicyStatusAtProviderRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public V1beta1SecurityPolicyStatusAtProviderRuleMatch? Match { get; set; }

    /// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect. Structure is documented below.</summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1SecurityPolicyStatusAtProviderRulePreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptions? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public V1beta1SecurityPolicyStatusAtProviderRuleRedirectOptions? RedirectOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusAtProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfig? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfig? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fingerprint of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/securityPolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public V1beta1SecurityPolicyStatusAtProviderRecaptchaOptionsConfig? RecaptchaOptionsConfig { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added. Structure is documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRule>? Rule { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatusConditions
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
/// <summary>SecurityPolicyStatus defines the observed state of SecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SecurityPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecurityPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecurityPolicy is the Schema for the SecurityPolicys API. Creates a Security Policy resource for Google Compute Engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityPolicySpec>, IStatus<V1beta1SecurityPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityPolicy";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "securitypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityPolicySpec defines the desired state of SecurityPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecurityPolicySpec Spec { get; set; }

    /// <summary>SecurityPolicyStatus defines the observed state of SecurityPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecurityPolicyStatus? Status { get; set; }
}
#nullable disable
