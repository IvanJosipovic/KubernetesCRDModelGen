using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.gcp.m.upbound.io;
/// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderBlockingFunctionsForwardInboundCredentials
{
    /// <summary>Whether to pass the user's OAuth identity provider's access token.</summary>
    [JsonPropertyName("accessToken")]
    public bool? AccessToken { get; set; }

    /// <summary>Whether to pass the user's OIDC identity provider's ID token.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }

    /// <summary>Whether to pass the user's OAuth identity provider's refresh token.</summary>
    [JsonPropertyName("refreshToken")]
    public bool? RefreshToken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderBlockingFunctionsTriggers
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>HTTP URI trigger for the Cloud Function.</summary>
    [JsonPropertyName("functionUri")]
    public string? FunctionUri { get; set; }
}

/// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderBlockingFunctions
{
    /// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
    [JsonPropertyName("forwardInboundCredentials")]
    public V1beta1ConfigSpecForProviderBlockingFunctionsForwardInboundCredentials? ForwardInboundCredentials { get; set; }

    /// <summary>Map of Trigger to event type. Key should be one of the supported event types: "beforeCreate", "beforeSignIn". Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1ConfigSpecForProviderBlockingFunctionsTriggers>? Triggers { get; set; }
}

/// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderClientPermissions
{
    /// <summary>When true, end users cannot delete their account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserDeletion")]
    public bool? DisabledUserDeletion { get; set; }

    /// <summary>When true, end users cannot sign up for a new account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserSignup")]
    public bool? DisabledUserSignup { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderClient
{
    /// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
    [JsonPropertyName("permissions")]
    public V1beta1ConfigSpecForProviderClientPermissions? Permissions { get; set; }
}

/// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMfaProviderConfigsTotpProviderConfig
{
    /// <summary>The allowed number of adjacent intervals that will be used for verification to avoid clock skew.</summary>
    [JsonPropertyName("adjacentIntervals")]
    public double? AdjacentIntervals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMfaProviderConfigs
{
    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
    [JsonPropertyName("totpProviderConfig")]
    public V1beta1ConfigSpecForProviderMfaProviderConfigsTotpProviderConfig? TotpProviderConfig { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMfa
{
    /// <summary>A list of usable second factors for this project. Each value may be one of: PHONE_SMS.</summary>
    [JsonPropertyName("enabledProviders")]
    public IList<string>? EnabledProviders { get; set; }

    /// <summary>A list of usable second factors for this project along with their configurations. This field does not support phone based MFA, for that use the 'enabledProviders' field. Structure is documented below.</summary>
    [JsonPropertyName("providerConfigs")]
    public IList<V1beta1ConfigSpecForProviderMfaProviderConfigs>? ProviderConfigs { get; set; }

    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMonitoringRequestLogging
{
    /// <summary>Whether logging is enabled for this project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMonitoring
{
    /// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
    [JsonPropertyName("requestLogging")]
    public V1beta1ConfigSpecForProviderMonitoringRequestLogging? RequestLogging { get; set; }
}

/// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderMultiTenant
{
    /// <summary>Whether this project can have tenants or not.</summary>
    [JsonPropertyName("allowTenants")]
    public bool? AllowTenants { get; set; }

    /// <summary>The default cloud parent org or folder that the tenant project should be created under. The parent resource name should be in the format of "/", such as "folders/123" or "organizations/456". If the value is not set, the tenant will be created under the same organization or folder as the agent project.</summary>
    [JsonPropertyName("defaultTenantLocation")]
    public string? DefaultTenantLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigSpecForProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderProjectSelector
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
    public V1beta1ConfigSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderQuotaSignUpQuotaConfig
{
    /// <summary>A sign up APIs quota that customers can override temporarily. Value can be in between 1 and 1000.</summary>
    [JsonPropertyName("quota")]
    public double? Quota { get; set; }

    /// <summary>How long this quota will be active for. It is measurred in seconds, e.g., Example: "9.615s".</summary>
    [JsonPropertyName("quotaDuration")]
    public string? QuotaDuration { get; set; }

    /// <summary>When this quota will take affect.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Configuration related to quotas. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderQuota
{
    /// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
    [JsonPropertyName("signUpQuotaConfig")]
    public V1beta1ConfigSpecForProviderQuotaSignUpQuotaConfig? SignUpQuotaConfig { get; set; }
}

/// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSignInAnonymous
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSignInEmail
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether a password is required for email auth or not. If true, both an email and password must be provided to sign in. If false, a user may sign in via either email/password or email link.</summary>
    [JsonPropertyName("passwordRequired")]
    public bool? PasswordRequired { get; set; }
}

/// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSignInPhoneNumber
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A map of &lt;test phone number, fake code&gt; that can be used for phone auth testing.</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

/// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSignIn
{
    /// <summary>Whether to allow more than one account to have the same email.</summary>
    [JsonPropertyName("allowDuplicateEmails")]
    public bool? AllowDuplicateEmails { get; set; }

    /// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
    [JsonPropertyName("anonymous")]
    public V1beta1ConfigSpecForProviderSignInAnonymous? Anonymous { get; set; }

    /// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
    [JsonPropertyName("email")]
    public V1beta1ConfigSpecForProviderSignInEmail? Email { get; set; }

    /// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
    [JsonPropertyName("phoneNumber")]
    public V1beta1ConfigSpecForProviderSignInPhoneNumber? PhoneNumber { get; set; }
}

/// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSmsRegionConfigAllowByDefault
{
    /// <summary>Two letter unicode region codes to disallow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("disallowedRegions")]
    public IList<string>? DisallowedRegions { get; set; }
}

/// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSmsRegionConfigAllowlistOnly
{
    /// <summary>Two letter unicode region codes to allow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("allowedRegions")]
    public IList<string>? AllowedRegions { get; set; }
}

/// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProviderSmsRegionConfig
{
    /// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
    [JsonPropertyName("allowByDefault")]
    public V1beta1ConfigSpecForProviderSmsRegionConfigAllowByDefault? AllowByDefault { get; set; }

    /// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
    [JsonPropertyName("allowlistOnly")]
    public V1beta1ConfigSpecForProviderSmsRegionConfigAllowlistOnly? AllowlistOnly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecForProvider
{
    /// <summary>List of domains authorized for OAuth redirects.</summary>
    [JsonPropertyName("authorizedDomains")]
    public IList<string>? AuthorizedDomains { get; set; }

    /// <summary>Whether anonymous users will be auto-deleted after a period of 30 days</summary>
    [JsonPropertyName("autodeleteAnonymousUsers")]
    public bool? AutodeleteAnonymousUsers { get; set; }

    /// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
    [JsonPropertyName("blockingFunctions")]
    public V1beta1ConfigSpecForProviderBlockingFunctions? BlockingFunctions { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("client")]
    public V1beta1ConfigSpecForProviderClient? Client { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("mfa")]
    public V1beta1ConfigSpecForProviderMfa? Mfa { get; set; }

    /// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1ConfigSpecForProviderMonitoring? Monitoring { get; set; }

    /// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
    [JsonPropertyName("multiTenant")]
    public V1beta1ConfigSpecForProviderMultiTenant? MultiTenant { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ConfigSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1ConfigSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Configuration related to quotas. Structure is documented below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1ConfigSpecForProviderQuota? Quota { get; set; }

    /// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ConfigSpecForProviderSignIn? SignIn { get; set; }

    /// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
    [JsonPropertyName("smsRegionConfig")]
    public V1beta1ConfigSpecForProviderSmsRegionConfig? SmsRegionConfig { get; set; }
}

/// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderBlockingFunctionsForwardInboundCredentials
{
    /// <summary>Whether to pass the user's OAuth identity provider's access token.</summary>
    [JsonPropertyName("accessToken")]
    public bool? AccessToken { get; set; }

    /// <summary>Whether to pass the user's OIDC identity provider's ID token.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }

    /// <summary>Whether to pass the user's OAuth identity provider's refresh token.</summary>
    [JsonPropertyName("refreshToken")]
    public bool? RefreshToken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderBlockingFunctionsTriggers
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>HTTP URI trigger for the Cloud Function.</summary>
    [JsonPropertyName("functionUri")]
    public string? FunctionUri { get; set; }
}

/// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderBlockingFunctions
{
    /// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
    [JsonPropertyName("forwardInboundCredentials")]
    public V1beta1ConfigSpecInitProviderBlockingFunctionsForwardInboundCredentials? ForwardInboundCredentials { get; set; }

    /// <summary>Map of Trigger to event type. Key should be one of the supported event types: "beforeCreate", "beforeSignIn". Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1ConfigSpecInitProviderBlockingFunctionsTriggers>? Triggers { get; set; }
}

/// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderClientPermissions
{
    /// <summary>When true, end users cannot delete their account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserDeletion")]
    public bool? DisabledUserDeletion { get; set; }

    /// <summary>When true, end users cannot sign up for a new account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserSignup")]
    public bool? DisabledUserSignup { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderClient
{
    /// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
    [JsonPropertyName("permissions")]
    public V1beta1ConfigSpecInitProviderClientPermissions? Permissions { get; set; }
}

/// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMfaProviderConfigsTotpProviderConfig
{
    /// <summary>The allowed number of adjacent intervals that will be used for verification to avoid clock skew.</summary>
    [JsonPropertyName("adjacentIntervals")]
    public double? AdjacentIntervals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMfaProviderConfigs
{
    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
    [JsonPropertyName("totpProviderConfig")]
    public V1beta1ConfigSpecInitProviderMfaProviderConfigsTotpProviderConfig? TotpProviderConfig { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMfa
{
    /// <summary>A list of usable second factors for this project. Each value may be one of: PHONE_SMS.</summary>
    [JsonPropertyName("enabledProviders")]
    public IList<string>? EnabledProviders { get; set; }

    /// <summary>A list of usable second factors for this project along with their configurations. This field does not support phone based MFA, for that use the 'enabledProviders' field. Structure is documented below.</summary>
    [JsonPropertyName("providerConfigs")]
    public IList<V1beta1ConfigSpecInitProviderMfaProviderConfigs>? ProviderConfigs { get; set; }

    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMonitoringRequestLogging
{
    /// <summary>Whether logging is enabled for this project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMonitoring
{
    /// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
    [JsonPropertyName("requestLogging")]
    public V1beta1ConfigSpecInitProviderMonitoringRequestLogging? RequestLogging { get; set; }
}

/// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderMultiTenant
{
    /// <summary>Whether this project can have tenants or not.</summary>
    [JsonPropertyName("allowTenants")]
    public bool? AllowTenants { get; set; }

    /// <summary>The default cloud parent org or folder that the tenant project should be created under. The parent resource name should be in the format of "/", such as "folders/123" or "organizations/456". If the value is not set, the tenant will be created under the same organization or folder as the agent project.</summary>
    [JsonPropertyName("defaultTenantLocation")]
    public string? DefaultTenantLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderProjectSelector
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
    public V1beta1ConfigSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderQuotaSignUpQuotaConfig
{
    /// <summary>A sign up APIs quota that customers can override temporarily. Value can be in between 1 and 1000.</summary>
    [JsonPropertyName("quota")]
    public double? Quota { get; set; }

    /// <summary>How long this quota will be active for. It is measurred in seconds, e.g., Example: "9.615s".</summary>
    [JsonPropertyName("quotaDuration")]
    public string? QuotaDuration { get; set; }

    /// <summary>When this quota will take affect.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Configuration related to quotas. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderQuota
{
    /// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
    [JsonPropertyName("signUpQuotaConfig")]
    public V1beta1ConfigSpecInitProviderQuotaSignUpQuotaConfig? SignUpQuotaConfig { get; set; }
}

/// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSignInAnonymous
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSignInEmail
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether a password is required for email auth or not. If true, both an email and password must be provided to sign in. If false, a user may sign in via either email/password or email link.</summary>
    [JsonPropertyName("passwordRequired")]
    public bool? PasswordRequired { get; set; }
}

/// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSignInPhoneNumber
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A map of &lt;test phone number, fake code&gt; that can be used for phone auth testing.</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

/// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSignIn
{
    /// <summary>Whether to allow more than one account to have the same email.</summary>
    [JsonPropertyName("allowDuplicateEmails")]
    public bool? AllowDuplicateEmails { get; set; }

    /// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
    [JsonPropertyName("anonymous")]
    public V1beta1ConfigSpecInitProviderSignInAnonymous? Anonymous { get; set; }

    /// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
    [JsonPropertyName("email")]
    public V1beta1ConfigSpecInitProviderSignInEmail? Email { get; set; }

    /// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
    [JsonPropertyName("phoneNumber")]
    public V1beta1ConfigSpecInitProviderSignInPhoneNumber? PhoneNumber { get; set; }
}

/// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSmsRegionConfigAllowByDefault
{
    /// <summary>Two letter unicode region codes to disallow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("disallowedRegions")]
    public IList<string>? DisallowedRegions { get; set; }
}

/// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSmsRegionConfigAllowlistOnly
{
    /// <summary>Two letter unicode region codes to allow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("allowedRegions")]
    public IList<string>? AllowedRegions { get; set; }
}

/// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProviderSmsRegionConfig
{
    /// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
    [JsonPropertyName("allowByDefault")]
    public V1beta1ConfigSpecInitProviderSmsRegionConfigAllowByDefault? AllowByDefault { get; set; }

    /// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
    [JsonPropertyName("allowlistOnly")]
    public V1beta1ConfigSpecInitProviderSmsRegionConfigAllowlistOnly? AllowlistOnly { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecInitProvider
{
    /// <summary>List of domains authorized for OAuth redirects.</summary>
    [JsonPropertyName("authorizedDomains")]
    public IList<string>? AuthorizedDomains { get; set; }

    /// <summary>Whether anonymous users will be auto-deleted after a period of 30 days</summary>
    [JsonPropertyName("autodeleteAnonymousUsers")]
    public bool? AutodeleteAnonymousUsers { get; set; }

    /// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
    [JsonPropertyName("blockingFunctions")]
    public V1beta1ConfigSpecInitProviderBlockingFunctions? BlockingFunctions { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("client")]
    public V1beta1ConfigSpecInitProviderClient? Client { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("mfa")]
    public V1beta1ConfigSpecInitProviderMfa? Mfa { get; set; }

    /// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1ConfigSpecInitProviderMonitoring? Monitoring { get; set; }

    /// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
    [JsonPropertyName("multiTenant")]
    public V1beta1ConfigSpecInitProviderMultiTenant? MultiTenant { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ConfigSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1ConfigSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Configuration related to quotas. Structure is documented below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1ConfigSpecInitProviderQuota? Quota { get; set; }

    /// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ConfigSpecInitProviderSignIn? SignIn { get; set; }

    /// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
    [JsonPropertyName("smsRegionConfig")]
    public V1beta1ConfigSpecInitProviderSmsRegionConfig? SmsRegionConfig { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpecProviderConfigRef
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
public partial class V1beta1ConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConfigSpec defines the desired state of Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderBlockingFunctionsForwardInboundCredentials
{
    /// <summary>Whether to pass the user's OAuth identity provider's access token.</summary>
    [JsonPropertyName("accessToken")]
    public bool? AccessToken { get; set; }

    /// <summary>Whether to pass the user's OIDC identity provider's ID token.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }

    /// <summary>Whether to pass the user's OAuth identity provider's refresh token.</summary>
    [JsonPropertyName("refreshToken")]
    public bool? RefreshToken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderBlockingFunctionsTriggers
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>HTTP URI trigger for the Cloud Function.</summary>
    [JsonPropertyName("functionUri")]
    public string? FunctionUri { get; set; }

    /// <summary>(Output) When the trigger was changed.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderBlockingFunctions
{
    /// <summary>The user credentials to include in the JWT payload that is sent to the registered Blocking Functions. Structure is documented below.</summary>
    [JsonPropertyName("forwardInboundCredentials")]
    public V1beta1ConfigStatusAtProviderBlockingFunctionsForwardInboundCredentials? ForwardInboundCredentials { get; set; }

    /// <summary>Map of Trigger to event type. Key should be one of the supported event types: "beforeCreate", "beforeSignIn". Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1ConfigStatusAtProviderBlockingFunctionsTriggers>? Triggers { get; set; }
}

/// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderClientPermissions
{
    /// <summary>When true, end users cannot delete their account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserDeletion")]
    public bool? DisabledUserDeletion { get; set; }

    /// <summary>When true, end users cannot sign up for a new account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserSignup")]
    public bool? DisabledUserSignup { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderClient
{
    /// <summary>(Output) Firebase subdomain.</summary>
    [JsonPropertyName("firebaseSubdomain")]
    public string? FirebaseSubdomain { get; set; }

    /// <summary>Configuration related to restricting a user's ability to affect their account. Structure is documented below.</summary>
    [JsonPropertyName("permissions")]
    public V1beta1ConfigStatusAtProviderClientPermissions? Permissions { get; set; }
}

/// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMfaProviderConfigsTotpProviderConfig
{
    /// <summary>The allowed number of adjacent intervals that will be used for verification to avoid clock skew.</summary>
    [JsonPropertyName("adjacentIntervals")]
    public double? AdjacentIntervals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMfaProviderConfigs
{
    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>TOTP MFA provider config for this project. Structure is documented below.</summary>
    [JsonPropertyName("totpProviderConfig")]
    public V1beta1ConfigStatusAtProviderMfaProviderConfigsTotpProviderConfig? TotpProviderConfig { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMfa
{
    /// <summary>A list of usable second factors for this project. Each value may be one of: PHONE_SMS.</summary>
    [JsonPropertyName("enabledProviders")]
    public IList<string>? EnabledProviders { get; set; }

    /// <summary>A list of usable second factors for this project along with their configurations. This field does not support phone based MFA, for that use the 'enabledProviders' field. Structure is documented below.</summary>
    [JsonPropertyName("providerConfigs")]
    public IList<V1beta1ConfigStatusAtProviderMfaProviderConfigs>? ProviderConfigs { get; set; }

    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values are: DISABLED, ENABLED, MANDATORY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMonitoringRequestLogging
{
    /// <summary>Whether logging is enabled for this project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMonitoring
{
    /// <summary>Configuration for logging requests made to this project to Stackdriver Logging Structure is documented below.</summary>
    [JsonPropertyName("requestLogging")]
    public V1beta1ConfigStatusAtProviderMonitoringRequestLogging? RequestLogging { get; set; }
}

/// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderMultiTenant
{
    /// <summary>Whether this project can have tenants or not.</summary>
    [JsonPropertyName("allowTenants")]
    public bool? AllowTenants { get; set; }

    /// <summary>The default cloud parent org or folder that the tenant project should be created under. The parent resource name should be in the format of "/", such as "folders/123" or "organizations/456". If the value is not set, the tenant will be created under the same organization or folder as the agent project.</summary>
    [JsonPropertyName("defaultTenantLocation")]
    public string? DefaultTenantLocation { get; set; }
}

/// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderQuotaSignUpQuotaConfig
{
    /// <summary>A sign up APIs quota that customers can override temporarily. Value can be in between 1 and 1000.</summary>
    [JsonPropertyName("quota")]
    public double? Quota { get; set; }

    /// <summary>How long this quota will be active for. It is measurred in seconds, e.g., Example: "9.615s".</summary>
    [JsonPropertyName("quotaDuration")]
    public string? QuotaDuration { get; set; }

    /// <summary>When this quota will take affect.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Configuration related to quotas. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderQuota
{
    /// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP. None of quota, startTime, or quotaDuration can be skipped. Structure is documented below.</summary>
    [JsonPropertyName("signUpQuotaConfig")]
    public V1beta1ConfigStatusAtProviderQuotaSignUpQuotaConfig? SignUpQuotaConfig { get; set; }
}

/// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSignInAnonymous
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSignInEmail
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether a password is required for email auth or not. If true, both an email and password must be provided to sign in. If false, a user may sign in via either email/password or email link.</summary>
    [JsonPropertyName("passwordRequired")]
    public bool? PasswordRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSignInHashConfig
{
    /// <summary>(Output) Different password hash algorithms used in Identity Toolkit.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>(Output) Memory cost for hash calculation. Used by scrypt and other similar password derivation algorithms. See https://tools.ietf.org/html/rfc7914 for explanation of field.</summary>
    [JsonPropertyName("memoryCost")]
    public double? MemoryCost { get; set; }

    /// <summary>(Output) How many rounds for hash calculation. Used by scrypt and other similar password derivation algorithms.</summary>
    [JsonPropertyName("rounds")]
    public double? Rounds { get; set; }

    /// <summary>(Output) Non-printable character to be inserted between the salt and plain text password in base64.</summary>
    [JsonPropertyName("saltSeparator")]
    public string? SaltSeparator { get; set; }

    /// <summary>(Output) Signer key in base64.</summary>
    [JsonPropertyName("signerKey")]
    public string? SignerKey { get; set; }
}

/// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSignInPhoneNumber
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A map of &lt;test phone number, fake code&gt; that can be used for phone auth testing.</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

/// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSignIn
{
    /// <summary>Whether to allow more than one account to have the same email.</summary>
    [JsonPropertyName("allowDuplicateEmails")]
    public bool? AllowDuplicateEmails { get; set; }

    /// <summary>Configuration options related to authenticating an anonymous user. Structure is documented below.</summary>
    [JsonPropertyName("anonymous")]
    public V1beta1ConfigStatusAtProviderSignInAnonymous? Anonymous { get; set; }

    /// <summary>Configuration options related to authenticating a user by their email address. Structure is documented below.</summary>
    [JsonPropertyName("email")]
    public V1beta1ConfigStatusAtProviderSignInEmail? Email { get; set; }

    /// <summary>(Output) Output only. Hash config information. Structure is documented below.</summary>
    [JsonPropertyName("hashConfig")]
    public IList<V1beta1ConfigStatusAtProviderSignInHashConfig>? HashConfig { get; set; }

    /// <summary>Configuration options related to authenticated a user by their phone number. Structure is documented below.</summary>
    [JsonPropertyName("phoneNumber")]
    public V1beta1ConfigStatusAtProviderSignInPhoneNumber? PhoneNumber { get; set; }
}

/// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSmsRegionConfigAllowByDefault
{
    /// <summary>Two letter unicode region codes to disallow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("disallowedRegions")]
    public IList<string>? DisallowedRegions { get; set; }
}

/// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSmsRegionConfigAllowlistOnly
{
    /// <summary>Two letter unicode region codes to allow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json</summary>
    [JsonPropertyName("allowedRegions")]
    public IList<string>? AllowedRegions { get; set; }
}

/// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProviderSmsRegionConfig
{
    /// <summary>A policy of allowing SMS to every region by default and adding disallowed regions to a disallow list. Structure is documented below.</summary>
    [JsonPropertyName("allowByDefault")]
    public V1beta1ConfigStatusAtProviderSmsRegionConfigAllowByDefault? AllowByDefault { get; set; }

    /// <summary>A policy of only allowing regions by explicitly adding them to an allowlist. Structure is documented below.</summary>
    [JsonPropertyName("allowlistOnly")]
    public V1beta1ConfigStatusAtProviderSmsRegionConfigAllowlistOnly? AllowlistOnly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusAtProvider
{
    /// <summary>List of domains authorized for OAuth redirects.</summary>
    [JsonPropertyName("authorizedDomains")]
    public IList<string>? AuthorizedDomains { get; set; }

    /// <summary>Whether anonymous users will be auto-deleted after a period of 30 days</summary>
    [JsonPropertyName("autodeleteAnonymousUsers")]
    public bool? AutodeleteAnonymousUsers { get; set; }

    /// <summary>Configuration related to blocking functions. Structure is documented below.</summary>
    [JsonPropertyName("blockingFunctions")]
    public V1beta1ConfigStatusAtProviderBlockingFunctions? BlockingFunctions { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("client")]
    public V1beta1ConfigStatusAtProviderClient? Client { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/config</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured. Structure is documented below.</summary>
    [JsonPropertyName("mfa")]
    public V1beta1ConfigStatusAtProviderMfa? Mfa { get; set; }

    /// <summary>Configuration related to monitoring project activity. Structure is documented below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1ConfigStatusAtProviderMonitoring? Monitoring { get; set; }

    /// <summary>Configuration related to multi-tenant functionality. Structure is documented below.</summary>
    [JsonPropertyName("multiTenant")]
    public V1beta1ConfigStatusAtProviderMultiTenant? MultiTenant { get; set; }

    /// <summary>The name of the Config resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration related to quotas. Structure is documented below.</summary>
    [JsonPropertyName("quota")]
    public V1beta1ConfigStatusAtProviderQuota? Quota { get; set; }

    /// <summary>Configuration related to local sign in methods. Structure is documented below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ConfigStatusAtProviderSignIn? SignIn { get; set; }

    /// <summary>Configures the regions where users are allowed to send verification SMS for the project or tenant. This is based on the calling code of the destination phone number. Structure is documented below.</summary>
    [JsonPropertyName("smsRegionConfig")]
    public V1beta1ConfigStatusAtProviderSmsRegionConfig? SmsRegionConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatusConditions
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

/// <summary>ConfigStatus defines the observed state of Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Config is the Schema for the Configs API. Identity Platform configuration for a Cloud project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Config : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigSpec>, IStatus<V1beta1ConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Config";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "configs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigSpec defines the desired state of Config</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigSpec Spec { get; set; }

    /// <summary>ConfigStatus defines the observed state of Config.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigStatus? Status { get; set; }
}

/// <summary>Config is the Schema for the Configs API. Identity Platform configuration for a Cloud project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Config>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigList";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "configs";
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
    public IList<V1beta1Config> Items { get; set; }
}