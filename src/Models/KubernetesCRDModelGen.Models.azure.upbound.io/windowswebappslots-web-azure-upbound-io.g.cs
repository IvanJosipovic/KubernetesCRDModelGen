using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WindowsWebApp in web to populate appServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WindowsWebApp in web to populate appServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGithubClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App Slot. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Windows Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Windows Web App Slot. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Windows Web App Slot. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App Slot durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>The list of allowed Applications for the Default Authorisation Policy. The list of allowed Applications for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The list of allowed Group Names for the Default Authorisation Policy. The list of allowed Group Names for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>The list of allowed Identities for the Default Authorisation Policy. The list of allowed Identities for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The thumbprint of the certificate used for signing purposes. The thumbprint of the certificate used for signing purposes.</summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>A list of Allowed Client Applications in the JWT Claim. A list of Allowed Client Applications in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>A list of Allowed Groups in the JWT Claim. A list of Allowed Groups in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>A map of key-value pairs to send to the Authorisation Endpoint when a user logs in. A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.</summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/ The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.</summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>Should the www-authenticate provider should be omitted from the request? Defaults to false. Should the www-authenticate provider should be omitted from the request? Defaults to `false`</summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2AppleV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Apple web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Apple Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with this Custom OIDC.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name of the Custom OIDC Authentication Provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the claim that contains the users name. The name of the claim that contains the users name.</summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>The app setting name that contains the client_secret value used for the Custom OIDC Login. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>The list of the scopes that should be requested while authenticating. The list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2FacebookV2
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>The version of the Facebook API to be used while logging in. The version of the Facebook API to be used while logging in.</summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2GithubV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2GoogleV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2Login
{
    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime. The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.</summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>The time after the request is made when the session cookie should expire. Defaults to 08:00:00. The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.</summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>The endpoint to which logout requests should be made. The endpoint to which logout requests should be made.</summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>The time after the request is made when the nonce should expire. Defaults to 00:05:00. The time after the request is made when the nonce should expire. Defaults to `00:05:00`.</summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>Should the fragments from the request be preserved after the login request is made. Defaults to false. Should the fragments from the request be preserved after the login request is made. Defaults to `false`.</summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>Should the Token Store configuration Enabled. Defaults to false Should the Token Store configuration Enabled. Defaults to `false`</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>The directory path in the App Filesystem in which the tokens will be stored. The directory path in the App Filesystem in which the tokens will be stored.</summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>The name of the app setting which contains the SAS URL of the blob storage containing the tokens. The name of the app setting which contains the SAS URL of the blob storage containing the tokens.</summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>Should the nonce be validated while completing the login flow. Defaults to true. Should the nonce be validated while completing the login flow. Defaults to `true`.</summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2TwitterV2
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

    /// <summary>The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy. The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`</summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>The name of the custom header containing the host of the request. The name of the header containing the host of the request.</summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>The name of the custom header containing the scheme of the request. The name of the header containing the scheme of the request.</summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

    /// <summary>Should the authentication flow be used for all requests. Should the authentication flow be used for all requests.</summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>Should HTTPS be required on connections? Defaults to true. Should HTTPS be required on connections? Defaults to true.</summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1. The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. After how many days backups should be deleted.</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>When the schedule should start working in RFC-3339 format. When the schedule should start working in RFC-3339 format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>The SAS URL to the container. The SAS URL to the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderBackupStorageAccountUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderBackupSchedule>? Schedule { get; set; }

    /// <summary>The SAS URL to the container. The SAS URL to the container.</summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderBackupStorageAccountUrlSecretRef StorageAccountUrlSecretRef { get; set; }
}

/// <summary>The connection string value. The connection string value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderConnectionStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderConnectionString
{
    /// <summary>The name of the connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The connection string value. The connection string value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Web App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Web App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasurlSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef SasurlSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled.</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should failed request tracing be enabled.</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigApplicationStack
{
    /// <summary>The Application Stack for the Windows Web App. Possible values include dotnet, dotnetcore, node, python, php, and java.</summary>
    [JsonPropertyName("currentStack")]
    public string? CurrentStack { get; set; }

    /// <summary>The name of the container to be used. This value is required with docker_container_tag.</summary>
    [JsonPropertyName("dockerContainerName")]
    public string? DockerContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerContainerRegistry")]
    public string? DockerContainerRegistry { get; set; }

    /// <summary>The tag of the container to be used. This value is required with docker_container_name.</summary>
    [JsonPropertyName("dockerContainerTag")]
    public string? DockerContainerTag { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. azure-app-service/windows/parkingpage:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryPasswordSecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? DockerRegistryPasswordSecretRef { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnetcore. Possible values include v4.0. The version of DotNetCore to use.</summary>
    [JsonPropertyName("dotnetCoreVersion")]
    public string? DotnetCoreVersion { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnet. Possible values include v2.0,v3.0, v4.0, v5.0, v6.0, v7.0 and v8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    /// <summary>Should the Java Embedded Server (Java SE) be used to run the app. Should the application use the embedded web server for the version of Java in use.</summary>
    [JsonPropertyName("javaEmbeddedServerEnabled")]
    public bool? JavaEmbeddedServerEnabled { get; set; }

    /// <summary>The version of Java to use when current_stack is set to java. Possible values include 1.7, 1.8, 11 and 17. Required with java_container and java_container_version.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of node to use when current_stack is set to node. Possible values include ~12, ~14, ~16, and ~18.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to use when current_stack is set to php. Possible values are 7.1, 7.4 and Off.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The app is a Python app. Defaults to false.</summary>
    [JsonPropertyName("python")]
    public bool? Python { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Tomcat the Java App should use.</summary>
    [JsonPropertyName("tomcatVersion")]
    public string? TomcatVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingActionCustomAction
{
    /// <summary>The executable to run for the custom_action.</summary>
    [JsonPropertyName("executable")]
    public string? Executable { get; set; }

    /// <summary>The parameters to pass to the specified executable.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values are CustomAction, LogEvent and Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>A custom_action block as defined below.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingActionCustomAction>? CustomAction { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Windows Web App Slot must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>The amount of Private Memory to be consumed for this rule to trigger. Possible values are between 102400 and 13631488.</summary>
    [JsonPropertyName("privateMemoryKb")]
    public double? PrivateMemoryKb { get; set; }

    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>One or more slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Whether CORS requests with credentials are allowed. Defaults to false Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigVirtualApplicationVirtualDirectory
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfigVirtualApplication
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>Should pre-loading be enabled.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }

    /// <summary>One or more virtual_directory blocks as defined below.</summary>
    [JsonPropertyName("virtualDirectory")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigVirtualApplicationVirtualDirectory>? VirtualDirectory { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderSiteConfig
{
    /// <summary>If this Windows Web App Slot is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Windows Web App Slot.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Windows Web App Slot os associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled. Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Windows Web App Slot Name to automatically swap to when deployment to that slot is successfully completed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App Slot.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include: AllAllowed, FtpsOnly, Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017 and VS2019</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Windows Web App Slot ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App Slotuse a 32-bit worker. Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>One or more virtual_application blocks as defined below.</summary>
    [JsonPropertyName("virtualApplication")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfigVirtualApplication>? VirtualApplication { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Windows App Service Slot.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderStorageAccountAccessKeySecretRef AccessKeySecretRef { get; set; }

    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecForProvider
{
    /// <summary>The ID of the Windows Web App this Deployment Slot will be part of. Changing this forces a new Windows Web App to be created.</summary>
    [JsonPropertyName("appServiceId")]
    public string? AppServiceId { get; set; }

    /// <summary>Reference to a WindowsWebApp in web to populate appServiceId.</summary>
    [JsonPropertyName("appServiceIdRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdRef? AppServiceIdRef { get; set; }

    /// <summary>Selector for a WindowsWebApp in web to populate appServiceId.</summary>
    [JsonPropertyName("appServiceIdSelector")]
    public V1beta1WindowsWebAppSlotSpecForProviderAppServiceIdSelector? AppServiceIdSelector { get; set; }

    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_cert_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Windows Web App Slot be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Windows Web App Slot require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderLogs>? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Web App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsWebAppSlotSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Web App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecForProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Windows Web App. The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App Slot. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Windows Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Windows Web App Slot. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Windows Web App Slot. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App Slot durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>The list of allowed Applications for the Default Authorisation Policy. The list of allowed Applications for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The list of allowed Group Names for the Default Authorisation Policy. The list of allowed Group Names for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>The list of allowed Identities for the Default Authorisation Policy. The list of allowed Identities for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The thumbprint of the certificate used for signing purposes. The thumbprint of the certificate used for signing purposes.</summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>A list of Allowed Client Applications in the JWT Claim. A list of Allowed Client Applications in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>A list of Allowed Groups in the JWT Claim. A list of Allowed Groups in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>A map of key-value pairs to send to the Authorisation Endpoint when a user logs in. A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.</summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/ The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.</summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>Should the www-authenticate provider should be omitted from the request? Defaults to false. Should the www-authenticate provider should be omitted from the request? Defaults to `false`</summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2AppleV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Apple web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Apple Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with this Custom OIDC.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name of the Custom OIDC Authentication Provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the claim that contains the users name. The name of the claim that contains the users name.</summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>The app setting name that contains the client_secret value used for the Custom OIDC Login. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>The list of the scopes that should be requested while authenticating. The list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2FacebookV2
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>The version of the Facebook API to be used while logging in. The version of the Facebook API to be used while logging in.</summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2GithubV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2GoogleV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2Login
{
    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime. The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.</summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>The time after the request is made when the session cookie should expire. Defaults to 08:00:00. The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.</summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>The endpoint to which logout requests should be made. The endpoint to which logout requests should be made.</summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>The time after the request is made when the nonce should expire. Defaults to 00:05:00. The time after the request is made when the nonce should expire. Defaults to `00:05:00`.</summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>Should the fragments from the request be preserved after the login request is made. Defaults to false. Should the fragments from the request be preserved after the login request is made. Defaults to `false`.</summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>Should the Token Store configuration Enabled. Defaults to false Should the Token Store configuration Enabled. Defaults to `false`</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>The directory path in the App Filesystem in which the tokens will be stored. The directory path in the App Filesystem in which the tokens will be stored.</summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>The name of the app setting which contains the SAS URL of the blob storage containing the tokens. The name of the app setting which contains the SAS URL of the blob storage containing the tokens.</summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>Should the nonce be validated while completing the login flow. Defaults to true. Should the nonce be validated while completing the login flow. Defaults to `true`.</summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2TwitterV2
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

    /// <summary>The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy. The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`</summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>The name of the custom header containing the host of the request. The name of the header containing the host of the request.</summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>The name of the custom header containing the scheme of the request. The name of the header containing the scheme of the request.</summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

    /// <summary>Should the authentication flow be used for all requests. Should the authentication flow be used for all requests.</summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>Should HTTPS be required on connections? Defaults to true. Should HTTPS be required on connections? Defaults to true.</summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1. The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. After how many days backups should be deleted.</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>When the schedule should start working in RFC-3339 format. When the schedule should start working in RFC-3339 format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderConnectionString
{
    /// <summary>The name of the connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Web App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Web App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled.</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should failed request tracing be enabled.</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigApplicationStack
{
    /// <summary>The Application Stack for the Windows Web App. Possible values include dotnet, dotnetcore, node, python, php, and java.</summary>
    [JsonPropertyName("currentStack")]
    public string? CurrentStack { get; set; }

    /// <summary>The name of the container to be used. This value is required with docker_container_tag.</summary>
    [JsonPropertyName("dockerContainerName")]
    public string? DockerContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerContainerRegistry")]
    public string? DockerContainerRegistry { get; set; }

    /// <summary>The tag of the container to be used. This value is required with docker_container_name.</summary>
    [JsonPropertyName("dockerContainerTag")]
    public string? DockerContainerTag { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. azure-app-service/windows/parkingpage:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnetcore. Possible values include v4.0. The version of DotNetCore to use.</summary>
    [JsonPropertyName("dotnetCoreVersion")]
    public string? DotnetCoreVersion { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnet. Possible values include v2.0,v3.0, v4.0, v5.0, v6.0, v7.0 and v8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    /// <summary>Should the Java Embedded Server (Java SE) be used to run the app. Should the application use the embedded web server for the version of Java in use.</summary>
    [JsonPropertyName("javaEmbeddedServerEnabled")]
    public bool? JavaEmbeddedServerEnabled { get; set; }

    /// <summary>The version of Java to use when current_stack is set to java. Possible values include 1.7, 1.8, 11 and 17. Required with java_container and java_container_version.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of node to use when current_stack is set to node. Possible values include ~12, ~14, ~16, and ~18.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to use when current_stack is set to php. Possible values are 7.1, 7.4 and Off.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The app is a Python app. Defaults to false.</summary>
    [JsonPropertyName("python")]
    public bool? Python { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Tomcat the Java App should use.</summary>
    [JsonPropertyName("tomcatVersion")]
    public string? TomcatVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingActionCustomAction
{
    /// <summary>The executable to run for the custom_action.</summary>
    [JsonPropertyName("executable")]
    public string? Executable { get; set; }

    /// <summary>The parameters to pass to the specified executable.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values are CustomAction, LogEvent and Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>A custom_action block as defined below.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingActionCustomAction>? CustomAction { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Windows Web App Slot must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>The amount of Private Memory to be consumed for this rule to trigger. Possible values are between 102400 and 13631488.</summary>
    [JsonPropertyName("privateMemoryKb")]
    public double? PrivateMemoryKb { get; set; }

    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>One or more slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Whether CORS requests with credentials are allowed. Defaults to false Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigVirtualApplicationVirtualDirectory
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigVirtualApplication
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>Should pre-loading be enabled.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }

    /// <summary>One or more virtual_directory blocks as defined below.</summary>
    [JsonPropertyName("virtualDirectory")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigVirtualApplicationVirtualDirectory>? VirtualDirectory { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderSiteConfig
{
    /// <summary>If this Windows Web App Slot is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Windows Web App Slot.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Windows Web App Slot os associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled. Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Windows Web App Slot Name to automatically swap to when deployment to that slot is successfully completed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App Slot.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include: AllAllowed, FtpsOnly, Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017 and VS2019</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Windows Web App Slot ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App Slotuse a 32-bit worker. Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>One or more virtual_application blocks as defined below.</summary>
    [JsonPropertyName("virtualApplication")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfigVirtualApplication>? VirtualApplication { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Windows App Service Slot.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderStorageAccount
{
    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecInitProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_cert_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Windows Web App Slot be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Windows Web App Slot require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderLogs>? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Web App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsWebAppSlotSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Web App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsWebAppSlotSpecInitProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Windows Web App. The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecManagementPoliciesEnum
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
public enum V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WindowsWebAppSlotSpec defines the desired state of WindowsWebAppSlot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsWebAppSlotSpecDeletionPolicyEnum>))]
    public V1beta1WindowsWebAppSlotSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WindowsWebAppSlotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WindowsWebAppSlotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WindowsWebAppSlotSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WindowsWebAppSlotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WindowsWebAppSlotSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WindowsWebAppSlotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App Slot. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Windows Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Windows Web App Slot. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Windows Web App Slot. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App Slot durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>The list of allowed Applications for the Default Authorisation Policy. The list of allowed Applications for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The list of allowed Group Names for the Default Authorisation Policy. The list of allowed Group Names for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>The list of allowed Identities for the Default Authorisation Policy. The list of allowed Identities for the Default Authorisation Policy.</summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The thumbprint of the certificate used for signing purposes. The thumbprint of the certificate used for signing purposes.</summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>A list of Allowed Client Applications in the JWT Claim. A list of Allowed Client Applications in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>A list of Allowed Groups in the JWT Claim. A list of Allowed Groups in the JWT Claim.</summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>A map of key-value pairs to send to the Authorisation Endpoint when a user logs in. A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.</summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/ The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.</summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>Should the www-authenticate provider should be omitted from the request? Defaults to false. Should the www-authenticate provider should be omitted from the request? Defaults to `false`</summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2AppleV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Apple web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Apple Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>The endpoint to make the Authorisation Request as supplied by openid_configuration_endpoint response. The endpoint to make the Authorisation Request.</summary>
    [JsonPropertyName("authorisationEndpoint")]
    public string? AuthorisationEndpoint { get; set; }

    /// <summary>The endpoint that provides the keys necessary to validate the token as supplied by openid_configuration_endpoint response. The endpoint that provides the keys necessary to validate the token.</summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary>The Client Credential Method used. The Client Credential Method used. Currently the only supported value is `ClientSecretPost`.</summary>
    [JsonPropertyName("clientCredentialMethod")]
    public string? ClientCredentialMethod { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with this Custom OIDC.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the secret for this Custom OIDC Client.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The endpoint that issued the Token as supplied by openid_configuration_endpoint response. The endpoint that issued the Token.</summary>
    [JsonPropertyName("issuerEndpoint")]
    public string? IssuerEndpoint { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name of the Custom OIDC Authentication Provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the claim that contains the users name. The name of the claim that contains the users name.</summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>The app setting name that contains the client_secret value used for the Custom OIDC Login. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>The list of the scopes that should be requested while authenticating. The list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>The endpoint used to request a Token as supplied by openid_configuration_endpoint response. The endpoint used to request a Token.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2FacebookV2
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>The version of the Facebook API to be used while logging in. The version of the Facebook API to be used while logging in.</summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2GithubV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2GoogleV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2Login
{
    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime. The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.</summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>The time after the request is made when the session cookie should expire. Defaults to 08:00:00. The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.</summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>The endpoint to which logout requests should be made. The endpoint to which logout requests should be made.</summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>The time after the request is made when the nonce should expire. Defaults to 00:05:00. The time after the request is made when the nonce should expire. Defaults to `00:05:00`.</summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>Should the fragments from the request be preserved after the login request is made. Defaults to false. Should the fragments from the request be preserved after the login request is made. Defaults to `false`.</summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>Should the Token Store configuration Enabled. Defaults to false Should the Token Store configuration Enabled. Defaults to `false`</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>The directory path in the App Filesystem in which the tokens will be stored. The directory path in the App Filesystem in which the tokens will be stored.</summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>The name of the app setting which contains the SAS URL of the blob storage containing the tokens. The name of the app setting which contains the SAS URL of the blob storage containing the tokens.</summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>Should the nonce be validated while completing the login flow. Defaults to true. Should the nonce be validated while completing the login flow. Defaults to `true`.</summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication. The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2TwitterV2
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

    /// <summary>The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy. The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`</summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>The name of the custom header containing the host of the request. The name of the header containing the host of the request.</summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>The name of the custom header containing the scheme of the request. The name of the header containing the scheme of the request.</summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

    /// <summary>Should the authentication flow be used for all requests. Should the authentication flow be used for all requests.</summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>Should HTTPS be required on connections? Defaults to true. Should HTTPS be required on connections? Defaults to true.</summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1. The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>The time the backup was last attempted.</summary>
    [JsonPropertyName("lastExecutionTime")]
    public string? LastExecutionTime { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. After how many days backups should be deleted.</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>When the schedule should start working in RFC-3339 format. When the schedule should start working in RFC-3339 format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderConnectionString
{
    /// <summary>The name of the connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Web App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Web App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A values of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled.</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should failed request tracing be enabled.</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigApplicationStack
{
    /// <summary>The Application Stack for the Windows Web App. Possible values include dotnet, dotnetcore, node, python, php, and java.</summary>
    [JsonPropertyName("currentStack")]
    public string? CurrentStack { get; set; }

    /// <summary>The name of the container to be used. This value is required with docker_container_tag.</summary>
    [JsonPropertyName("dockerContainerName")]
    public string? DockerContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerContainerRegistry")]
    public string? DockerContainerRegistry { get; set; }

    /// <summary>The tag of the container to be used. This value is required with docker_container_name.</summary>
    [JsonPropertyName("dockerContainerTag")]
    public string? DockerContainerTag { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. azure-app-service/windows/parkingpage:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnetcore. Possible values include v4.0. The version of DotNetCore to use.</summary>
    [JsonPropertyName("dotnetCoreVersion")]
    public string? DotnetCoreVersion { get; set; }

    /// <summary>The version of .NET to use when current_stack is set to dotnet. Possible values include v2.0,v3.0, v4.0, v5.0, v6.0, v7.0 and v8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainer")]
    public string? JavaContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("javaContainerVersion")]
    public string? JavaContainerVersion { get; set; }

    /// <summary>Should the Java Embedded Server (Java SE) be used to run the app. Should the application use the embedded web server for the version of Java in use.</summary>
    [JsonPropertyName("javaEmbeddedServerEnabled")]
    public bool? JavaEmbeddedServerEnabled { get; set; }

    /// <summary>The version of Java to use when current_stack is set to java. Possible values include 1.7, 1.8, 11 and 17. Required with java_container and java_container_version.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of node to use when current_stack is set to node. Possible values include ~12, ~14, ~16, and ~18.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to use when current_stack is set to php. Possible values are 7.1, 7.4 and Off.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The app is a Python app. Defaults to false.</summary>
    [JsonPropertyName("python")]
    public bool? Python { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Tomcat the Java App should use.</summary>
    [JsonPropertyName("tomcatVersion")]
    public string? TomcatVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingActionCustomAction
{
    /// <summary>The executable to run for the custom_action.</summary>
    [JsonPropertyName("executable")]
    public string? Executable { get; set; }

    /// <summary>The parameters to pass to the specified executable.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values are CustomAction, LogEvent and Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>A custom_action block as defined below.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingActionCustomAction>? CustomAction { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Windows Web App Slot must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>The amount of Private Memory to be consumed for this rule to trigger. Possible values are between 102400 and 13631488.</summary>
    [JsonPropertyName("privateMemoryKb")]
    public double? PrivateMemoryKb { get; set; }

    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>One or more slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Whether CORS requests with credentials are allowed. Defaults to false Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32 The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this Storage Account. The name which should be used for this `ip_restriction`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority value of this ip_restriction. Defaults to 65000. The priority value of this `ip_restriction`.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction. The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigVirtualApplicationVirtualDirectory
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigVirtualApplication
{
    /// <summary>The physical path for the Virtual Application.</summary>
    [JsonPropertyName("physicalPath")]
    public string? PhysicalPath { get; set; }

    /// <summary>Should pre-loading be enabled.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }

    /// <summary>One or more virtual_directory blocks as defined below.</summary>
    [JsonPropertyName("virtualDirectory")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigVirtualApplicationVirtualDirectory>? VirtualDirectory { get; set; }

    /// <summary>The Virtual Path for the Virtual Application.</summary>
    [JsonPropertyName("virtualPath")]
    public string? VirtualPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderSiteConfig
{
    /// <summary>If this Windows Web App Slot is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Windows Web App Slot.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Windows Web App Slot os associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled. Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Windows Web App Slot Name to automatically swap to when deployment to that slot is successfully completed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App Slot.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>Should the Windows Web App Slot be enabled? Defaults to true.</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include: AllAllowed, FtpsOnly, Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017 and VS2019</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>Should the Windows Web App Slot ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App Slotuse a 32-bit worker. Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>One or more virtual_application blocks as defined below.</summary>
    [JsonPropertyName("virtualApplication")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfigVirtualApplication>? VirtualApplication { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    /// <summary>The number of Workers for this Windows App Service Slot.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProviderStorageAccount
{
    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusAtProvider
{
    /// <summary>The ID of the Windows Web App this Deployment Slot will be part of. Changing this forces a new Windows Web App to be created.</summary>
    [JsonPropertyName("appServiceId")]
    public string? AppServiceId { get; set; }

    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_cert_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The default hostname of the Windows Web App Slot.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Should the Windows Web App Slot be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The ID of the App Service Environment used by App Service Slot.</summary>
    [JsonPropertyName("hostingEnvironmentId")]
    public string? HostingEnvironmentId { get; set; }

    /// <summary>Should the Windows Web App Slot require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Windows Web App Slot.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Kind value for this Windows Web App Slot.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderLogs>? Logs { get; set; }

    /// <summary>A list of outbound IP addresses - such as ["52.23.25.3", "52.143.43.12"]</summary>
    [JsonPropertyName("outboundIpAddressList")]
    public IList<string>? OutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A list of possible outbound ip address.</summary>
    [JsonPropertyName("possibleOutboundIpAddressList")]
    public IList<string>? PossibleOutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12,52.143.43.17 - not all of which are necessarily in use. Superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Web App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsWebAppSlotStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Web App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Windows Web App. The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatusConditions
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

/// <summary>WindowsWebAppSlotStatus defines the observed state of WindowsWebAppSlot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsWebAppSlotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WindowsWebAppSlotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WindowsWebAppSlotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WindowsWebAppSlot is the Schema for the WindowsWebAppSlots API. Manages a Windows Web App Slot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WindowsWebAppSlot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WindowsWebAppSlotSpec>, IStatus<V1beta1WindowsWebAppSlotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WindowsWebAppSlot";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "windowswebappslots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WindowsWebAppSlotSpec defines the desired state of WindowsWebAppSlot</summary>
    [JsonPropertyName("spec")]
    public V1beta1WindowsWebAppSlotSpec Spec { get; set; }

    /// <summary>WindowsWebAppSlotStatus defines the observed state of WindowsWebAppSlot.</summary>
    [JsonPropertyName("status")]
    public V1beta1WindowsWebAppSlotStatus? Status { get; set; }
}