using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1SecurityPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public IList<V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig>? Layer7DdosDefenseConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public IList<V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfigJsonCustomConfig>? JsonCustomConfig { get; set; }

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

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleMatchExprOptionsRecaptchaOptions>? RecaptchaOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleMatchConfig>? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleMatchExpr>? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleMatchExprOptions>? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsBanThreshold>? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>block supports:</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsExceedRedirectOptions>? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRateLimitOptionsRateLimitThreshold>? RateLimitThreshold { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProviderRuleRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
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
    public IList<V1beta1SecurityPolicySpecForProviderRuleHeaderAction>? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleMatch>? Match { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRateLimitOptions>? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public IList<V1beta1SecurityPolicySpecForProviderRuleRedirectOptions>? RedirectOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecForProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public IList<V1beta1SecurityPolicySpecForProviderAdaptiveProtectionConfig>? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public IList<V1beta1SecurityPolicySpecForProviderAdvancedOptionsConfig>? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public IList<V1beta1SecurityPolicySpecForProviderRecaptchaOptionsConfig>? RecaptchaOptionsConfig { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added. Structure is documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1SecurityPolicySpecForProviderRule>? Rule { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig>? Layer7DdosDefenseConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfigJsonCustomConfig>? JsonCustomConfig { get; set; }

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

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptionsRecaptchaOptions>? RecaptchaOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleMatchConfig>? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleMatchExpr>? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleMatchExprOptions>? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsBanThreshold>? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>block supports:</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsExceedRedirectOptions>? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptionsRateLimitThreshold>? RateLimitThreshold { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicySpecInitProviderRuleRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
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
    public IList<V1beta1SecurityPolicySpecInitProviderRuleHeaderAction>? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleMatch>? Match { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRateLimitOptions>? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public IList<V1beta1SecurityPolicySpecInitProviderRuleRedirectOptions>? RedirectOptions { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SecurityPolicySpecInitProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdaptiveProtectionConfig>? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public IList<V1beta1SecurityPolicySpecInitProviderAdvancedOptionsConfig>? AdvancedOptionsConfig { get; set; }

    /// <summary>An optional description of this security policy. Max size is 2048.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>reCAPTCHA Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptionsConfig")]
    public IList<V1beta1SecurityPolicySpecInitProviderRecaptchaOptionsConfig>? RecaptchaOptionsConfig { get; set; }

    /// <summary>The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a security policy, a default rule with action "allow" will be added. Structure is documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1SecurityPolicySpecInitProviderRule>? Rule { get; set; }

    /// <summary>The type indicates the intended use of the security policy. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1SecurityPolicySpecManagementPoliciesEnum
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

public enum V1beta1SecurityPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SecurityPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SecurityPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SecurityPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SecurityPolicySpec defines the desired state of SecurityPolicy</summary>
public partial class V1beta1SecurityPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityPolicySpecDeletionPolicyEnum>))]
    public V1beta1SecurityPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecurityPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecurityPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SecurityPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SecurityPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility can be one of the following:</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfig
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection Layer 7 DDoS Defense. Structure is documented below.</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfigLayer7DdosDefenseConfig>? Layer7DdosDefenseConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. The format of the Content-Type header values is defined in RFC 1341. When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public IList<string>? ContentTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD. Structure is documented below.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfigJsonCustomConfig>? JsonCustomConfig { get; set; }

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

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRecaptchaOptionsConfig
{
    /// <summary>A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.</summary>
    [JsonPropertyName("redirectSiteKey")]
    public string? RedirectSiteKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they're already present. Structure is documented below.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchConfig
{
    /// <summary>Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of * matches all IPs (can be used to override the default behavior).</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptionsRecaptchaOptions
{
    /// <summary>A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("actionTokenSiteKeys")]
    public IList<string>? ActionTokenSiteKeys { get; set; }

    /// <summary>A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.</summary>
    [JsonPropertyName("sessionTokenSiteKeys")]
    public IList<string>? SessionTokenSiteKeys { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptions
{
    /// <summary>reCAPTCHA configuration options to be applied for the rule. If the rule does not evaluate reCAPTCHA tokens, this field has no effect. Structure is documented below.</summary>
    [JsonPropertyName("recaptchaOptions")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptionsRecaptchaOptions>? RecaptchaOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleMatchConfig>? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleMatchExpr>? Expr { get; set; }

    /// <summary>The configuration options available when specifying a user defined CEVAL expression (i.e., 'expr'). Structure is documented below.</summary>
    [JsonPropertyName("exprOptions")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleMatchExprOptions>? ExprOptions { get; set; }

    /// <summary>Predefined rule expression. If this field is specified, config must also be specified. Available options:</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is rate_based_ban. If specified, the key will be banned for the configured ban_duration_sec when the number of requests that exceed the rate_limit_threshold also exceed this ban_threshold. Structure is documented below.</summary>
    [JsonPropertyName("banThreshold")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsBanThreshold>? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is allow only.</summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. If not specified, defaults to ALL.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types:</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>When a request is denied, returns the HTTP response code specified. Valid options are deny() where valid values for status are 403, 404, 429, and 502.</summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>block supports:</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsExceedRedirectOptions>? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptionsRateLimitThreshold>? RateLimitThreshold { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProviderRuleRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
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
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleHeaderAction>? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding action is enforced. Structure is documented below.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleMatch>? Match { get; set; }

    /// <summary>When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Must be specified if the action is rate_based_ban or throttle. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRateLimitOptions>? RateLimitOptions { get; set; }

    /// <summary>Can be specified if the action is redirect. Cannot be specified for other actions. Structure is documented below.</summary>
    [JsonPropertyName("redirectOptions")]
    public IList<V1beta1SecurityPolicyStatusAtProviderRuleRedirectOptions>? RedirectOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityPolicyStatusAtProvider
{
    /// <summary>Configuration for Google Cloud Armor Adaptive Protection. Structure is documented below.</summary>
    [JsonPropertyName("adaptiveProtectionConfig")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdaptiveProtectionConfig>? AdaptiveProtectionConfig { get; set; }

    /// <summary>Advanced Configuration Options. Structure is documented below.</summary>
    [JsonPropertyName("advancedOptionsConfig")]
    public IList<V1beta1SecurityPolicyStatusAtProviderAdvancedOptionsConfig>? AdvancedOptionsConfig { get; set; }

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
    public IList<V1beta1SecurityPolicyStatusAtProviderRecaptchaOptionsConfig>? RecaptchaOptionsConfig { get; set; }

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

/// <summary>A Condition that may apply to a resource.</summary>
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

/// <summary>SecurityPolicyStatus defines the observed state of SecurityPolicy.</summary>
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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SecurityPolicy is the Schema for the SecurityPolicys API. Creates a Security Policy resource for Google Compute Engine.</summary>
public partial class V1beta1SecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityPolicySpec>, IStatus<V1beta1SecurityPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityPolicy";
    public const string KubeGroup = "compute.gcp.upbound.io";
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