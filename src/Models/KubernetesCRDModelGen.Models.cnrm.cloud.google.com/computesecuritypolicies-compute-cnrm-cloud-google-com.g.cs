using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Auto Deploy Config of this security policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigAutoDeployConfig
{
    /// <summary>Rules are only automatically deployed for alerts on potential attacks with confidence scores greater than this threshold.</summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>Google Cloud Armor stops applying the action in the automatically deployed rule to an identified attacker after this duration. The rule continues to operate against new requests.</summary>
    [JsonPropertyName("expirationSec")]
    public int? ExpirationSec { get; set; }

    /// <summary>Rules are only automatically deployed when the estimated impact to baseline traffic from the suggested mitigation is below this threshold.</summary>
    [JsonPropertyName("impactedBaselineThreshold")]
    public double? ImpactedBaselineThreshold { get; set; }

    /// <summary>Identifies new attackers only when the load to the backend service that is under attack exceeds this threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }
}

/// <summary>Layer 7 DDoS Defense Config of this security policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility. Supported values include: "STANDARD", "PREMIUM".</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }
}

/// <summary>Adaptive Protection Config of this security policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfig
{
    /// <summary>Auto Deploy Config of this security policy.</summary>
    [JsonPropertyName("autoDeployConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigAutoDeployConfig? AutoDeployConfig { get; set; }

    /// <summary>Layer 7 DDoS Defense Config of this security policy.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigLayer7DdosDefenseConfig? Layer7DdosDefenseConfig { get; set; }
}

/// <summary>Custom configuration to apply the JSON parsing. Only applicable when JSON parsing is set to STANDARD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string> ContentTypes { get; set; }
}

/// <summary>Advanced Options Config of this security policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when JSON parsing is set to STANDARD.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfigJsonCustomConfig? JsonCustomConfig { get; set; }

    /// <summary>JSON body parsing. Supported values include: "DISABLED", "STANDARD".</summary>
    [JsonPropertyName("jsonParsing")]
    public string? JsonParsing { get; set; }

    /// <summary>Logging level. Supported values include: "NORMAL", "VERBOSE".</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>An optional list of case-insensitive request header names to use for resolving the callers client IP address.</summary>
    [JsonPropertyName("userIpRequestHeaders")]
    public IList<string>? UserIpRequestHeaders { get; set; }
}

/// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfigRedirectSiteKeyRef
{
    /// <summary>Allowed value: The `name` field of a `RecaptchaEnterpriseKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>reCAPTCHA configuration options to be applied for the security policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKeyRef")]
    public V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfigRedirectSiteKeyRef RedirectSiteKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>Additional actions that are performed on headers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1ComputeSecurityPolicySpecRuleHeaderActionRequestHeadersToAdds> RequestHeadersToAdds { get; set; }
}

/// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of '*' matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string> SrcIpRanges { get; set; }
}

/// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; }
}

/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified.</summary>
    [JsonPropertyName("config")]
    public V1beta1ComputeSecurityPolicySpecRuleMatchConfig? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header.</summary>
    [JsonPropertyName("expr")]
    public V1beta1ComputeSecurityPolicySpecRuleMatchExpr? Expr { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:   SRC_IPS_V1: Must specify the corresponding src_ip_ranges field in config.</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusion
{
    /// <summary>Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>Request header whose value will be excluded from inspection during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation.  Note that the parameter can be in the query string or in the POST body.</summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation. When specifying this field, the query or fragment part should be excluded.</summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.</summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string TargetRuleSet { get; set; }
}

/// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfig
{
    /// <summary>An exclusion to apply during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}

/// <summary>Can only be specified if the action for the rule is "rate_based_ban". If specified, the key will be banned for the configured 'banDurationSec' when the number of requests that exceed the 'rateLimitThreshold' also exceed this 'banThreshold'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public int IntervalSec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on.</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}

/// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Threshold at which to begin ratelimiting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public int IntervalSec { get; set; }
}

/// <summary>Rate limit threshold for this security policy. Must be specified if the action is "rate_based_ban" or "throttle". Cannot be specified for any other actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is "rate_based_ban". If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public int? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is "rate_based_ban". If specified, the key will be banned for the configured 'banDurationSec' when the number of requests that exceed the 'rateLimitThreshold' also exceed this 'banThreshold'.</summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is "allow" only.</summary>
    [JsonPropertyName("conformAction")]
    public string ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>Enforce On Key Config of this security policy.</summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint. Valid options are "deny()" where valid values for status are 403, 404, 429, and 502, and "redirect" where the redirect parameters come from exceedRedirectOptions below.</summary>
    [JsonPropertyName("exceedAction")]
    public string ExceedAction { get; set; }

    /// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect.</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsExceedRedirectOptions? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsRateLimitThreshold RateLimitThreshold { get; set; }
}

/// <summary>Parameters defining the redirect action. Cannot be specified for any other actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action. Available options: EXTERNAL_302: Must specify the corresponding target field in config. GOOGLE_RECAPTCHA: Cannot specify target field in config.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRule
{
    /// <summary>Action to take when match matches the request.</summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>An optional description of this rule. Max size is 64.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Additional actions that are performed on headers.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeSecurityPolicySpecRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced.</summary>
    [JsonPropertyName("match")]
    public V1beta1ComputeSecurityPolicySpecRuleMatch Match { get; set; }

    /// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.</summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    /// <summary>Rate limit threshold for this security policy. Must be specified if the action is "rate_based_ban" or "throttle". Cannot be specified for any other actions.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptions? RateLimitOptions { get; set; }

    /// <summary>Parameters defining the redirect action. Cannot be specified for any other actions.</summary>
    [JsonPropertyName("redirectOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRedirectOptions? RedirectOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpec
{
    /// <summary>Adaptive Protection Config of this security policy.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfig? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Options Config of this security policy.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfig? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>reCAPTCHA configuration options to be applied for the security policy.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfig? RecaptchaOptionsConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ComputeSecurityPolicySpecRule>? Rule { get; set; }

    /// <summary>The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google's cache.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSecurityPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Fingerprint of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSecurityPolicySpec>, IStatus<V1beta1ComputeSecurityPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSecurityPolicy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesecuritypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeSecurityPolicySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSecurityPolicyStatus? Status { get; set; }
}