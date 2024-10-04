using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsGithubClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Linux Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2AppleV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2CustomOidcV2
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

    /// <summary>Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>The list of the scopes that should be requested while authenticating. The list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2GithubV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2Login
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1LinuxWebAppSpecForProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of the age of backup? Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
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
public partial class V1beta1LinuxWebAppSpecForProviderBackupStorageAccountUrlSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LinuxWebAppSpecForProviderBackupSchedule>? Schedule { get; set; }

    /// <summary>The SAS URL to the container. The SAS URL to the container.</summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderBackupStorageAccountUrlSecretRef StorageAccountUrlSecretRef { get; set; }
}

/// <summary>The connection string value. The connection string value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderConnectionStringValueSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderConnectionString
{
    /// <summary>The name of the Connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The connection string value. The connection string value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasurlSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef SasurlSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderServicePlanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderServicePlanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderServicePlanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigApplicationStack
{
    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public string? DockerImage { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImageTag")]
    public string? DockerImageTag { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryPasswordSecretRef")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? DockerRegistryPasswordSecretRef { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0 and 8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, and 17.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts and 20-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1 and 8.2.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.7, 3.8, 3.9, 3.10, 3.11 and 3.12.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerRequests
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigCors
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
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionHeaders
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionHeaders
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled? Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
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
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019 and VS2022.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderStorageAccountAccessKeySecretRef
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
public partial class V1beta1LinuxWebAppSpecForProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1LinuxWebAppSpecForProviderStorageAccountAccessKeySecretRef AccessKeySecretRef { get; set; }

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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecForProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1LinuxWebAppSpecForProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1LinuxWebAppSpecForProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1LinuxWebAppSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxWebAppSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1LinuxWebAppSpecForProviderLogs>? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LinuxWebAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LinuxWebAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta1LinuxWebAppSpecForProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta1LinuxWebAppSpecForProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1LinuxWebAppSpecForProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public IList<V1beta1LinuxWebAppSpecForProviderStickySettings>? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1LinuxWebAppSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Linux Web App. The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, "wl.basic" is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Linux Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2AppleV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2CustomOidcV2
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

    /// <summary>Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>The list of the scopes that should be requested while authenticating. The list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2GithubV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2Login
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of the age of backup? Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
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
public partial class V1beta1LinuxWebAppSpecInitProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LinuxWebAppSpecInitProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderConnectionString
{
    /// <summary>The name of the Connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderServicePlanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderServicePlanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigApplicationStack
{
    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public string? DockerImage { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImageTag")]
    public string? DockerImageTag { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryPasswordSecretRef")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? DockerRegistryPasswordSecretRef { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0 and 8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, and 17.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts and 20-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1 and 8.2.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.7, 3.8, 3.9, 3.10, 3.11 and 3.12.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerRequests
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigCors
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
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionHeaders
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionHeaders
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled? Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
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
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019 and VS2022.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderStorageAccount
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecInitProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1LinuxWebAppSpecInitProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1LinuxWebAppSpecInitProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1LinuxWebAppSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxWebAppSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1LinuxWebAppSpecInitProviderLogs>? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta1LinuxWebAppSpecInitProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta1LinuxWebAppSpecInitProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1LinuxWebAppSpecInitProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public IList<V1beta1LinuxWebAppSpecInitProviderStickySettings>? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1LinuxWebAppSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Linux Web App. The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxWebAppSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LinuxWebAppSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LinuxWebAppSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LinuxWebAppSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinuxWebAppSpec defines the desired state of LinuxWebApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinuxWebAppSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinuxWebAppSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinuxWebAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LinuxWebAppSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinuxWebAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsActiveDirectory
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsFacebook
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsGithub
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsGoogle
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsMicrosoft
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsTwitter
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled for the Linux Web App? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2AppleV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2CustomOidcV2
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

    /// <summary>Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration. The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2GithubV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2Login
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day, Hour The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of the age of backup? Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
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
public partial class V1beta1LinuxWebAppStatusAtProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LinuxWebAppStatusAtProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderConnectionString
{
    /// <summary>The name of the Connection String. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogsApplicationLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined below.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogsHttpLogsAzureBlobStorage>? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogsHttpLogsFileSystem>? FileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogsApplicationLogs>? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogsHttpLogs>? HttpLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigApplicationStack
{
    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public string? DockerImage { get; set; }

    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImageTag")]
    public string? DockerImageTag { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0 and 8.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, and 17.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts and 20-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1 and 8.2.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.7, 3.8, 3.9, 3.10, 3.11 and 3.12.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerRequests
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerRequests>? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest>? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingAction>? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigCors
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigIpRestrictionHeaders
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigScmIpRestrictionHeaders
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
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>Should Auto heal rules be enabled? Required with auto_heal_setting.</summary>
    [JsonPropertyName("autoHealEnabled")]
    public bool? AutoHealEnabled { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigAutoHealSetting>? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
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
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019 and VS2022.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusAtProviderStorageAccount
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
public partial class V1beta1LinuxWebAppStatusAtProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1LinuxWebAppStatusAtProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1LinuxWebAppStatusAtProviderBackup>? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1LinuxWebAppStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The default hostname of the Linux Web App.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The ID of the App Service Environment used by App Service.</summary>
    [JsonPropertyName("hostingEnvironmentId")]
    public string? HostingEnvironmentId { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Linux Web App.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxWebAppStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Kind value for this Linux Web App.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public IList<V1beta1LinuxWebAppStatusAtProviderLogs>? Logs { get; set; }

    /// <summary>A list of outbound IP addresses - such as ["52.23.25.3", "52.143.43.12"]</summary>
    [JsonPropertyName("outboundIpAddressList")]
    public IList<string>? OutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A list of possible outbound ip address.</summary>
    [JsonPropertyName("possibleOutboundIpAddressList")]
    public IList<string>? PossibleOutboundIpAddressList { get; set; }

    /// <summary>A comma-separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12,52.143.43.17 - not all of which are necessarily in use. Superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1LinuxWebAppStatusAtProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public IList<V1beta1LinuxWebAppStatusAtProviderStickySettings>? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1LinuxWebAppStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The local path and filename of the Zip packaged application to deploy to this Linux Web App. The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.</summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatusConditions
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

/// <summary>LinuxWebAppStatus defines the observed state of LinuxWebApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxWebAppStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinuxWebAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinuxWebAppStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinuxWebApp is the Schema for the LinuxWebApps API. Manages a Linux Web App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinuxWebApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinuxWebAppSpec>, IStatus<V1beta1LinuxWebAppStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinuxWebApp";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "linuxwebapps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinuxWebAppSpec defines the desired state of LinuxWebApp</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinuxWebAppSpec Spec { get; set; }

    /// <summary>LinuxWebAppStatus defines the observed state of LinuxWebApp.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinuxWebAppStatus? Status { get; set; }
}