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
public enum V1beta1WindowsFunctionAppSlotSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication. Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Active Directory.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name. The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGithubClientSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name. The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in. The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name. The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettings
{
    /// <summary>an active_directory block as detailed below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>a facebook block as detailed below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>a github block as detailed below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>a google block as detailed below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>a microsoft block as detailed below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>a twitter block as detailed below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2AppleV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2CustomOidcV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2GithubV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2Login
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day and Hour. The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderBackupStorageAccountUrlSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a schedule block as detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderBackupSchedule>? Schedule { get; set; }

    /// <summary>The SAS URL to the container. The SAS URL to the container.</summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderBackupStorageAccountUrlSecretRef StorageAccountUrlSecretRef { get; set; }
}

/// <summary>The connection string value. The connection string value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderConnectionStringValueSecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderConnectionString
{
    /// <summary>The name which should be used for this Connection. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The connection string value. The connection string value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WindowsFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WindowsFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Function App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Function App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigAppServiceLogs
{
    /// <summary>The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35. The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

/// <summary>The Connection String for linking the Windows Function App to Application Insights. The Connection String for linking the Windows Function App to Application Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationInsightsConnectionStringSecretRef
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

/// <summary>The Instrumentation Key for connecting the Windows Function App to Application Insights. The Instrumentation Key for connecting the Windows Function App to Application Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationInsightsKeySecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationStack
{
    /// <summary>The version of .Net. Possible values are v3.0, v4.0, v6.0, v7.0 and v8.0. Defaults to v4.0. The version of .Net. Possible values are `v3.0`, `v4.0`, `v6.0` and `v7.0`</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Java to use. Possible values are 1.8, 11 and 17 (In-Preview). The version of Java to use. Possible values are `1.8`, `11` and `17`</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to use. Possible values are ~12, ~14, ~16 and ~18. The version of Node to use. Possible values include `12`, `14`, `16` and `18`</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The PowerShell Core version to use. Possible values are 7, and 7.2. The PowerShell Core version to use. Possible values are `7`, and `7.2`</summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>Does the Function App use a custom Application Stack? Does the Function App use a custom Application Stack?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>Should the DotNet process use an isolated runtime. Defaults to false. Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials allowed in CORS requests? Defaults to false. Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionHeaders
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfig
{
    /// <summary>If this Windows Web App is Always On enabled. Defaults to false. If this Windows Web App is Always On enabled. Defaults to `false`.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL of the API definition that describes this Windows Function App. The URL of the API definition that describes this Windows Function App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The ID of the API Management API for this Windows Function App. The ID of the API Management API for this Windows Function App.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The program and any arguments used to launch this app via the command line. (Example node myapp.js). The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan. The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>an app_service_logs block as detailed below.</summary>
    [JsonPropertyName("appServiceLogs")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigAppServiceLogs>? AppServiceLogs { get; set; }

    /// <summary>The Connection String for linking the Windows Function App to Application Insights. The Connection String for linking the Windows Function App to Application Insights.</summary>
    [JsonPropertyName("applicationInsightsConnectionStringSecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationInsightsConnectionStringSecretRef? ApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>The Instrumentation Key for connecting the Windows Function App to Application Insights. The Instrumentation Key for connecting the Windows Function App to Application Insights.</summary>
    [JsonPropertyName("applicationInsightsKeySecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationInsightsKeySecretRef? ApplicationInsightsKeySecretRef { get; set; }

    /// <summary>an application_stack block as detailed below.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>The name of the slot to automatically swap with when this slot is successfully deployed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>a cors block as detailed below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App. Specifies a list of Default Documents for the Windows Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans. The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled. State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Defaults to 0. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to be checked for this function app health. The path to be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies if the HTTP2 protocol should be enabled. Defaults to false. Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>an ip_restriction block as detailed below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted. The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>The Managed Pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated. The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan. The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false. Should Remote Debugging be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019, and VS2022 The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>Should Scale Monitoring of the Functions Runtime be enabled? Should Functions Runtime Scale Monitoring be enabled.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>a scm_ip_restriction block as detailed below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Windows Function App ip_restriction configuration be used for the SCM also. Should the Windows Function App `ip_restriction` configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App use a 32-bit worker. Defaults to true. Should the Windows Web App use a 32-bit worker.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false. Should Web Sockets be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Windows Function App. The number of Workers for this Windows Function App.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountAccessKeySecretRef
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountAccessKeySecretRef AccessKeySecretRef { get; set; }

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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecForProvider
{
    /// <summary>A map of key-value pairs for App Settings and custom values. A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>an auth_settings block as detailed below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>an auth_settings_v2 block as detailed below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>a backup block as detailed below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderBackup>? Backup { get; set; }

    /// <summary>Should built-in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true. Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>Should the Function App Slot use Client Certificates. Should the Function App Slot use Client Certificates.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional. The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>a connection_string block as detailed below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Force disable the content share settings. Force disable the content share settings.</summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans. Defaults to 0. The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Is the Windows Function App Slot enabled. Defaults to true. Is the Windows Function App Slot enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The name of the Windows Function App this Slot is a member of. Changing this forces a new resource to be created. The ID of the Windows Function App this Slot is a member of.</summary>
    [JsonPropertyName("functionAppId")]
    public string? FunctionAppId { get; set; }

    /// <summary>Reference to a WindowsFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdRef? FunctionAppIdRef { get; set; }

    /// <summary>Selector for a WindowsFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderFunctionAppIdSelector? FunctionAppIdSelector { get; set; }

    /// <summary>The runtime version associated with the Function App Slot. Defaults to ~4. The runtime version associated with the Function App Slot.</summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>Can the Function App Slot only be accessed via HTTPS?. Defaults to false. Can the Function App Slot only be accessed via HTTPS?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>an identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity The User Assigned Identity to use for Key Vault access.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Function App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>a site_config block as detailed below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>The access key which will be used to access the storage account for the Function App Slot. The access key which will be used to access the storage account for the Function App Slot.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App Slot. The backend storage account name which will be used by this Function App Slot.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App Slot. The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>Should the Function App Slot use its Managed Identity to access storage. Should the Function App Slot use its Managed Identity to access storage?</summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Function App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecForProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsActiveDirectory
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsTwitter
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettings
{
    /// <summary>an active_directory block as detailed below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>a facebook block as detailed below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>a github block as detailed below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>a google block as detailed below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>a microsoft block as detailed below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>a twitter block as detailed below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2AppleV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2CustomOidcV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2GithubV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2Login
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day and Hour. The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a schedule block as detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderConnectionString
{
    /// <summary>The name which should be used for this Connection. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Function App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Function App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigAppServiceLogs
{
    /// <summary>The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35. The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigApplicationStack
{
    /// <summary>The version of .Net. Possible values are v3.0, v4.0, v6.0, v7.0 and v8.0. Defaults to v4.0. The version of .Net. Possible values are `v3.0`, `v4.0`, `v6.0` and `v7.0`</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Java to use. Possible values are 1.8, 11 and 17 (In-Preview). The version of Java to use. Possible values are `1.8`, `11` and `17`</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to use. Possible values are ~12, ~14, ~16 and ~18. The version of Node to use. Possible values include `12`, `14`, `16` and `18`</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The PowerShell Core version to use. Possible values are 7, and 7.2. The PowerShell Core version to use. Possible values are `7`, and `7.2`</summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>Does the Function App use a custom Application Stack? Does the Function App use a custom Application Stack?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>Should the DotNet process use an isolated runtime. Defaults to false. Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials allowed in CORS requests? Defaults to false. Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfig
{
    /// <summary>If this Windows Web App is Always On enabled. Defaults to false. If this Windows Web App is Always On enabled. Defaults to `false`.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL of the API definition that describes this Windows Function App. The URL of the API definition that describes this Windows Function App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The ID of the API Management API for this Windows Function App. The ID of the API Management API for this Windows Function App.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The program and any arguments used to launch this app via the command line. (Example node myapp.js). The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan. The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>an app_service_logs block as detailed below.</summary>
    [JsonPropertyName("appServiceLogs")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigAppServiceLogs>? AppServiceLogs { get; set; }

    /// <summary>an application_stack block as detailed below.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>The name of the slot to automatically swap with when this slot is successfully deployed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>a cors block as detailed below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App. Specifies a list of Default Documents for the Windows Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans. The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled. State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Defaults to 0. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to be checked for this function app health. The path to be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies if the HTTP2 protocol should be enabled. Defaults to false. Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>an ip_restriction block as detailed below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted. The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>The Managed Pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated. The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan. The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false. Should Remote Debugging be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019, and VS2022 The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>Should Scale Monitoring of the Functions Runtime be enabled? Should Functions Runtime Scale Monitoring be enabled.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>a scm_ip_restriction block as detailed below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Windows Function App ip_restriction configuration be used for the SCM also. Should the Windows Function App `ip_restriction` configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App use a 32-bit worker. Defaults to true. Should the Windows Web App use a 32-bit worker.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false. Should Web Sockets be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Windows Function App. The number of Workers for this Windows Function App.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccount
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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecInitProvider
{
    /// <summary>A map of key-value pairs for App Settings and custom values. A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>an auth_settings block as detailed below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>an auth_settings_v2 block as detailed below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>a backup block as detailed below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderBackup>? Backup { get; set; }

    /// <summary>Should built-in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true. Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>Should the Function App Slot use Client Certificates. Should the Function App Slot use Client Certificates.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional. The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>a connection_string block as detailed below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Force disable the content share settings. Force disable the content share settings.</summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans. Defaults to 0. The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Is the Windows Function App Slot enabled. Defaults to true. Is the Windows Function App Slot enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The runtime version associated with the Function App Slot. Defaults to ~4. The runtime version associated with the Function App Slot.</summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>Can the Function App Slot only be accessed via HTTPS?. Defaults to false. Can the Function App Slot only be accessed via HTTPS?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>an identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity The User Assigned Identity to use for Key Vault access.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Function App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>a site_config block as detailed below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App Slot. The backend storage account name which will be used by this Function App Slot.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App Slot. The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>Should the Function App Slot use its Managed Identity to access storage. Should the Function App Slot use its Managed Identity to access storage?</summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Function App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1WindowsFunctionAppSlotSpecInitProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecManagementPoliciesEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WindowsFunctionAppSlotSpec defines the desired state of WindowsFunctionAppSlot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFunctionAppSlotSpecDeletionPolicyEnum>))]
    public V1beta1WindowsFunctionAppSlotSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WindowsFunctionAppSlotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WindowsFunctionAppSlotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WindowsFunctionAppSlotSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WindowsFunctionAppSlotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WindowsFunctionAppSlotSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WindowsFunctionAppSlotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsActiveDirectory
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login. The App ID of the Facebook app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The app setting name that contains the app_secret value used for Facebook Login. The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsGithub
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the GitHub app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OpenID Connect Client ID for the Google web application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, "openid", "profile", and "email" are used as default scopes.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope. The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsTwitter
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettings
{
    /// <summary>an active_directory block as detailed below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in. Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App. Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github. The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Should the Authentication / Authorization feature be enabled? Should the Authentication / Authorization feature be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>a facebook block as detailed below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>a github block as detailed below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsGithub>? Github { get; set; }

    /// <summary>a google block as detailed below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens. The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>a microsoft block as detailed below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use. The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours. The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false. Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>a twitter block as detailed below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous. The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2ActiveDirectoryV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2AppleV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication. The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2CustomOidcV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2FacebookV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2GithubV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2GoogleV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2Login
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2MicrosoftV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2TwitterV2
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2ActiveDirectoryV2>? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2AppleV2>? AppleV2 { get; set; }

    /// <summary>Should the AuthV2 Settings be enabled. Defaults to false. Should the AuthV2 Settings be enabled. Defaults to `false`</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2AzureStaticWebAppV2>? AzureStaticWebAppV2 { get; set; }

    /// <summary>The path to the App Auth settings. The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider. The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage. The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2FacebookV2>? FacebookV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2GithubV2>? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2GoogleV2>? GoogleV2 { get; set; }

    /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth. The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`</summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2Login>? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2MicrosoftV2>? MicrosoftV2 { get; set; }

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
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2TwitterV2>? TwitterV2 { get; set; }

    /// <summary>The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage. The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.</summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderBackupSchedule
{
    /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day). How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>The unit of time for how often the backup should take place. Possible values include: Day and Hour. The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to false. Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>The time the backup was last attempted. The time the backup was last attempted.</summary>
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderBackup
{
    /// <summary>Should this backup job be enabled? Defaults to true. Should this backup job be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name which should be used for this Backup. The name which should be used for this Backup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a schedule block as detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderBackupSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderConnectionString
{
    /// <summary>The name which should be used for this Connection. The name which should be used for this Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of database. Possible values include: APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure, and SQLServer. Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Windows Function App Slot.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Function App Slot. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigAppServiceLogs
{
    /// <summary>The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35. The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>After how many days backups should be deleted. Defaults to 30. The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigApplicationStack
{
    /// <summary>The version of .Net. Possible values are v3.0, v4.0, v6.0, v7.0 and v8.0. Defaults to v4.0. The version of .Net. Possible values are `v3.0`, `v4.0`, `v6.0` and `v7.0`</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Java to use. Possible values are 1.8, 11 and 17 (In-Preview). The version of Java to use. Possible values are `1.8`, `11` and `17`</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to use. Possible values are ~12, ~14, ~16 and ~18. The version of Node to use. Possible values include `12`, `14`, `16` and `18`</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The PowerShell Core version to use. Possible values are 7, and 7.2. The PowerShell Core version to use. Possible values are `7`, and `7.2`</summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>Does the Function App use a custom Application Stack? Does the Function App use a custom Application Stack?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>Should the DotNet process use an isolated runtime. Defaults to false. Should the DotNet process use an isolated runtime. Defaults to `false`.</summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigCors
{
    /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls. Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials allowed in CORS requests? Defaults to false. Are credentials allowed in CORS requests? Defaults to `false`.</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders
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
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow. The action to take. Possible values are `Allow` or `Deny`.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Description of this IP Restriction. The description of the IP restriction rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>a headers block as detailed below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

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

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration. The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfig
{
    /// <summary>If this Windows Web App is Always On enabled. Defaults to false. If this Windows Web App is Always On enabled. Defaults to `false`.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL of the API definition that describes this Windows Function App. The URL of the API definition that describes this Windows Function App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The ID of the API Management API for this Windows Function App. The ID of the API Management API for this Windows Function App.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The program and any arguments used to launch this app via the command line. (Example node myapp.js). The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan. The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>an app_service_logs block as detailed below.</summary>
    [JsonPropertyName("appServiceLogs")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigAppServiceLogs>? AppServiceLogs { get; set; }

    /// <summary>an application_stack block as detailed below.</summary>
    [JsonPropertyName("applicationStack")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigApplicationStack>? ApplicationStack { get; set; }

    /// <summary>The name of the slot to automatically swap with when this slot is successfully deployed.</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>a cors block as detailed below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Windows Web App. Specifies a list of Default Documents for the Windows Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>Is detailed error logging enabled Is detailed error logging enabled</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans. The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled. State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Defaults to 0. Only valid in conjunction with health_check_path. The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`</summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to be checked for this function app health. The path to be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies if the HTTP2 protocol should be enabled. Defaults to false. Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>an ip_restriction block as detailed below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted. The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>The Managed Pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated. The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan. The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Remote Debugging be enabled. Defaults to false. Should Remote Debugging be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Possible values include VS2017, VS2019, and VS2022 The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022`</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>Should Scale Monitoring of the Functions Runtime be enabled? Should Functions Runtime Scale Monitoring be enabled.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>a scm_ip_restriction block as detailed below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, and 1.2. Defaults to 1.2. Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>The SCM Type in use by the Windows Function App. The SCM Type in use by the Windows Function App.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>Should the Windows Function App ip_restriction configuration be used for the SCM also. Should the Windows Function App `ip_restriction` configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Windows Web App use a 32-bit worker. Defaults to true. Should the Windows Web App use a 32-bit worker.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false. Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled. Defaults to false. Should Web Sockets be enabled. Defaults to `false`.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The Windows FX Version string. The Windows FX Version string.</summary>
    [JsonPropertyName("windowsFxVersion")]
    public string? WindowsFxVersion { get; set; }

    /// <summary>The number of Workers for this Windows Function App. The number of Workers for this Windows Function App.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProviderStorageAccount
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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusAtProvider
{
    /// <summary>A map of key-value pairs for App Settings and custom values. A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>an auth_settings block as detailed below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>an auth_settings_v2 block as detailed below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderAuthSettingsV2>? AuthSettingsV2 { get; set; }

    /// <summary>a backup block as detailed below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderBackup>? Backup { get; set; }

    /// <summary>Should built-in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true. Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>Should the Function App Slot use Client Certificates. Should the Function App Slot use Client Certificates.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>Paths to exclude when using client certificates, separated by ; Paths to exclude when using client certificates, separated by ;</summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional. The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>a connection_string block as detailed below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Force disable the content share settings. Force disable the content share settings.</summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans. Defaults to 0. The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>The default hostname of the Windows Function App Slot. The default hostname of the Windows Function App Slot.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Is the Windows Function App Slot enabled. Defaults to true. Is the Windows Function App Slot enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The name of the Windows Function App this Slot is a member of. Changing this forces a new resource to be created. The ID of the Windows Function App this Slot is a member of.</summary>
    [JsonPropertyName("functionAppId")]
    public string? FunctionAppId { get; set; }

    /// <summary>The runtime version associated with the Function App Slot. Defaults to ~4. The runtime version associated with the Function App Slot.</summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>The ID of the App Service Environment used by Function App Slot.</summary>
    [JsonPropertyName("hostingEnvironmentId")]
    public string? HostingEnvironmentId { get; set; }

    /// <summary>Can the Function App Slot only be accessed via HTTPS?. Defaults to false. Can the Function App Slot only be accessed via HTTPS?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Windows Function App Slot</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>an identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity The User Assigned Identity to use for Key Vault access.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Kind value for this Windows Function App Slot. The Kind value for this Windows Function App Slot.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>A list of outbound IP addresses. For example ["52.23.25.3", "52.143.43.12"]. A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`.</summary>
    [JsonPropertyName("outboundIpAddressList")]
    public IList<string>? OutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses as a string. For example 52.23.25.3,52.143.43.12. A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of outbound_ip_address_list. For example ["52.23.25.3", "52.143.43.12"]. A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `["52.23.25.3", "52.143.43.12"]`.</summary>
    [JsonPropertyName("possibleOutboundIpAddressList")]
    public IList<string>? PossibleOutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of possible outbound IP addresses as a string. For example 52.23.25.3,52.143.43.12,52.143.43.17. This is a superset of outbound_ip_addresses. For example ["52.23.25.3", "52.143.43.12","52.143.43.17"]. A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan in which to run this slot. If not specified the same Service Plan as the Windows Function App will be used.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>a site_config block as detailed below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1WindowsFunctionAppSlotStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App Slot. The backend storage account name which will be used by this Function App Slot.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App Slot. The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>Should the Function App Slot use its Managed Identity to access storage. Should the Function App Slot use its Managed Identity to access storage?</summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Windows Function App Slot.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The subnet id which will be used by this Function App Slot for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatusConditions
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

/// <summary>WindowsFunctionAppSlotStatus defines the observed state of WindowsFunctionAppSlot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WindowsFunctionAppSlotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WindowsFunctionAppSlotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WindowsFunctionAppSlotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WindowsFunctionAppSlot is the Schema for the WindowsFunctionAppSlots API. Manages a Windows Function App Slot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WindowsFunctionAppSlot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WindowsFunctionAppSlotSpec>, IStatus<V1beta1WindowsFunctionAppSlotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WindowsFunctionAppSlot";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "windowsfunctionappslots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WindowsFunctionAppSlotSpec defines the desired state of WindowsFunctionAppSlot</summary>
    [JsonPropertyName("spec")]
    public V1beta1WindowsFunctionAppSlotSpec Spec { get; set; }

    /// <summary>WindowsFunctionAppSlotStatus defines the observed state of WindowsFunctionAppSlot.</summary>
    [JsonPropertyName("status")]
    public V1beta1WindowsFunctionAppSlotStatus? Status { get; set; }
}