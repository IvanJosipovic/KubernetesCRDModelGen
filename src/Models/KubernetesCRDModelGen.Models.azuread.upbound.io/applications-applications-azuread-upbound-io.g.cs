using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.applications.azuread.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApiOauth2PermissionScope
{
    /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users. Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDescription")]
    public string? AdminConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users. Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDisplayName")]
    public string? AdminConsentDisplayName { get; set; }

    /// <summary>Determines if the permission scope is enabled. Defaults to true. Determines if the permission scope is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the delegated permission. Must be a valid UUID. The unique identifier of the delegated permission</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. Defaults to User. Possible values are User or Admin. Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf. Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf</summary>
    [JsonPropertyName("userConsentDescription")]
    public string? UserConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission that appears in the end user consent experience. Display name for the delegated permission that appears in the end user consent experience</summary>
    [JsonPropertyName("userConsentDisplayName")]
    public string? UserConsentDisplayName { get; set; }

    /// <summary>The value that is used for the scp claim in OAuth 2.0 access tokens. The value that is used for the `scp` claim in OAuth 2.0 access tokens</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApi
{
    /// <summary>A set of application IDs (client IDs), used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app</summary>
    [JsonPropertyName("knownClientApplications")]
    public IList<string>? KnownClientApplications { get; set; }

    /// <summary>Allows an application to use claims mapping without specifying a custom signing key. Defaults to false. Allows an application to use claims mapping without specifying a custom signing key</summary>
    [JsonPropertyName("mappedClaimsEnabled")]
    public bool? MappedClaimsEnabled { get; set; }

    /// <summary>One or more oauth2_permission_scope blocks as documented below, to describe delegated permissions exposed by the web API represented by this application. One or more `oauth2_permission_scope` blocks to describe delegated permissions exposed by the web API represented by this application</summary>
    [JsonPropertyName("oauth2PermissionScope")]
    public IList<V1beta1ApplicationSpecForProviderApiOauth2PermissionScope>? Oauth2PermissionScope { get; set; }

    /// <summary>The access token version expected by this resource. Must be one of 1 or 2, and must be 2 when sign_in_audience is either AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount Defaults to 1. The access token version expected by this resource</summary>
    [JsonPropertyName("requestedAccessTokenVersion")]
    public double? RequestedAccessTokenVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderAppRole
{
    /// <summary>Specifies whether this app role definition can be assigned to users and groups by setting to User, or to other applications (that are accessing this application in a standalone scenario) by setting to Application, or to both. Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both</summary>
    [JsonPropertyName("allowedMemberTypes")]
    public IList<string>? AllowedMemberTypes { get; set; }

    /// <summary>Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences. Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for the app role that appears during app role assignment and in consent experiences. Display name for the app role that appears during app role assignment and in consent experiences</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Determines if the app role is enabled. Defaults to true. Determines if the app role is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the app role. Must be a valid UUID. The unique identifier of the app role</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The value that is used for the roles claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal. The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderFeatureTags
{
    /// <summary>Whether this application represents a custom SAML application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this application represents a custom SAML application for linked service principals</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this application represents an Enterprise Application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this application represents an Enterprise Application for linked service principals</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this application represents a gallery application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this application represents a gallery application for linked service principals</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this application is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOptionalClaimsAccessToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOptionalClaimsIdToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOptionalClaimsSaml2Token
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOptionalClaims
{
    /// <summary>One or more access_token blocks as documented below.</summary>
    [JsonPropertyName("accessToken")]
    public IList<V1beta1ApplicationSpecForProviderOptionalClaimsAccessToken>? AccessToken { get; set; }

    /// <summary>One or more id_token blocks as documented below.</summary>
    [JsonPropertyName("idToken")]
    public IList<V1beta1ApplicationSpecForProviderOptionalClaimsIdToken>? IdToken { get; set; }

    /// <summary>One or more saml2_token blocks as documented below.</summary>
    [JsonPropertyName("saml2Token")]
    public IList<V1beta1ApplicationSpecForProviderOptionalClaimsSaml2Token>? Saml2Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderPassword
{
    /// <summary>A display name for the password. Changing this field forces a new resource to be created. A display name for the password</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The end date until which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created. The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date from which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn't specified, the current date is used.  Changing this field forces a new resource to be created. The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderPublicClient
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https or ms-appx-web URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderRequiredResourceAccessResourceAccess
{
    /// <summary>The unique identifier for an app role or OAuth2 permission scope published by the resource application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies whether the id property references an app role or an OAuth2 permission scope. Possible values are Role or Scope.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderRequiredResourceAccess
{
    /// <summary>A collection of resource_access blocks as documented below, describing OAuth2.0 permission scopes and app roles that the application requires from the specified resource.</summary>
    [JsonPropertyName("resourceAccess")]
    public IList<V1beta1ApplicationSpecForProviderRequiredResourceAccessResourceAccess>? ResourceAccess { get; set; }

    /// <summary>The unique identifier for the resource that the application requires access to. This should be the Application ID of the target application.</summary>
    [JsonPropertyName("resourceAppId")]
    public string? ResourceAppId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderSinglePageApplication
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderWebImplicitGrant
{
    /// <summary>Whether this web application can request an access token using OAuth 2.0 implicit flow. Whether this web application can request an access token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("accessTokenIssuanceEnabled")]
    public bool? AccessTokenIssuanceEnabled { get; set; }

    /// <summary>Whether this web application can request an ID token using OAuth 2.0 implicit flow. Whether this web application can request an ID token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("idTokenIssuanceEnabled")]
    public bool? IdTokenIssuanceEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderWeb
{
    /// <summary>Home page or landing page of the application. Home page or landing page of the application</summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>An implicit_grant block as documented above.</summary>
    [JsonPropertyName("implicitGrant")]
    public IList<V1beta1ApplicationSpecForProviderWebImplicitGrant>? ImplicitGrant { get; set; }

    /// <summary>The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols. The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols</summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid http URL or a URN. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>An api block as documented below, which configures API related settings for this application.</summary>
    [JsonPropertyName("api")]
    public IList<V1beta1ApplicationSpecForProviderApi>? Api { get; set; }

    /// <summary>A collection of app_role blocks as documented below. For more information see official documentation on Application Roles.</summary>
    [JsonPropertyName("appRole")]
    public IList<V1beta1ApplicationSpecForProviderAppRole>? AppRole { get; set; }

    /// <summary>A description of the application, as shown to end users. Description of the application as shown to end users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether this application supports device authentication without a user. Defaults to false. Specifies whether this application supports device authentication without a user.</summary>
    [JsonPropertyName("deviceOnlyAuthEnabled")]
    public bool? DeviceOnlyAuthEnabled { get; set; }

    /// <summary>The display name for the application. The display name for the application</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI. Defaults to false. Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI</summary>
    [JsonPropertyName("fallbackPublicClientEnabled")]
    public bool? FallbackPublicClientEnabled { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this application using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1ApplicationSpecForProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects. Possible values are None, SecurityGroup, DirectoryRole, ApplicationGroup or All. Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects</summary>
    [JsonPropertyName("groupMembershipClaims")]
    public IList<string>? GroupMembershipClaims { get; set; }

    /// <summary>A set of user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant</summary>
    [JsonPropertyName("identifierUris")]
    public IList<string>? IdentifierUris { get; set; }

    /// <summary>A logo image to upload for the application, as a raw base64-encoded string. The image should be in gif, jpeg or png format. Note that once an image has been uploaded, it is not possible to remove it without replacing it with another image. Base64 encoded logo image in gif, png or jpeg format</summary>
    [JsonPropertyName("logoImage")]
    public string? LogoImage { get; set; }

    /// <summary>URL of the application's marketing page. URL of the application's marketing page</summary>
    [JsonPropertyName("marketingUrl")]
    public string? MarketingUrl { get; set; }

    /// <summary>User-specified notes relevant for the management of the application. User-specified notes relevant for the management of the application</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests. Defaults to false, which specifies that only GET requests are allowed. Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.</summary>
    [JsonPropertyName("oauth2PostResponseRequired")]
    public bool? Oauth2PostResponseRequired { get; set; }

    /// <summary>An optional_claims block as documented below.</summary>
    [JsonPropertyName("optionalClaims")]
    public IList<V1beta1ApplicationSpecForProviderOptionalClaims>? OptionalClaims { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the application. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the application</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>A single password block as documented below. The password is generated during creation. By default, no password is generated. App password definition</summary>
    [JsonPropertyName("password")]
    public IList<V1beta1ApplicationSpecForProviderPassword>? Password { get; set; }

    /// <summary>If true, will return an error if an existing application is found with the same name. Defaults to false. If `true`, will return an error if an existing application is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>URL of the application's privacy statement. URL of the application's privacy statement</summary>
    [JsonPropertyName("privacyStatementUrl")]
    public string? PrivacyStatementUrl { get; set; }

    /// <summary>A public_client block as documented below, which configures non-web app or non-web API application settings, for example mobile or other public clients such as an installed application running on a desktop device.</summary>
    [JsonPropertyName("publicClient")]
    public IList<V1beta1ApplicationSpecForProviderPublicClient>? PublicClient { get; set; }

    /// <summary>A collection of required_resource_access blocks as documented below.</summary>
    [JsonPropertyName("requiredResourceAccess")]
    public IList<V1beta1ApplicationSpecForProviderRequiredResourceAccess>? RequiredResourceAccess { get; set; }

    /// <summary>References application context information from a Service or Asset Management database. References application or service contact information from a Service or Asset Management database</summary>
    [JsonPropertyName("serviceManagementReference")]
    public string? ServiceManagementReference { get; set; }

    /// <summary>The Microsoft account types that are supported for the current application. Must be one of AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount. Defaults to AzureADMyOrg. The Microsoft account types that are supported for the current application</summary>
    [JsonPropertyName("signInAudience")]
    public string? SignInAudience { get; set; }

    /// <summary>A single_page_application block as documented below, which configures single-page application (SPA) related settings for this application.</summary>
    [JsonPropertyName("singlePageApplication")]
    public IList<V1beta1ApplicationSpecForProviderSinglePageApplication>? SinglePageApplication { get; set; }

    /// <summary>URL of the application's support page. URL of the application's support page</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>A set of tags to apply to the application for configuring specific behaviours of the application and linked service principals. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the application</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Unique ID for a templated application in the Azure AD App Gallery, from which to create the application. Changing this forces a new resource to be created. Unique ID of the application template from which this application is created</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>URL of the application's terms of service statement. URL of the application's terms of service statement</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>A web block as documented below, which configures web related settings for this application.</summary>
    [JsonPropertyName("web")]
    public IList<V1beta1ApplicationSpecForProviderWeb>? Web { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApiOauth2PermissionScope
{
    /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users. Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDescription")]
    public string? AdminConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users. Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDisplayName")]
    public string? AdminConsentDisplayName { get; set; }

    /// <summary>Determines if the permission scope is enabled. Defaults to true. Determines if the permission scope is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the delegated permission. Must be a valid UUID. The unique identifier of the delegated permission</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. Defaults to User. Possible values are User or Admin. Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf. Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf</summary>
    [JsonPropertyName("userConsentDescription")]
    public string? UserConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission that appears in the end user consent experience. Display name for the delegated permission that appears in the end user consent experience</summary>
    [JsonPropertyName("userConsentDisplayName")]
    public string? UserConsentDisplayName { get; set; }

    /// <summary>The value that is used for the scp claim in OAuth 2.0 access tokens. The value that is used for the `scp` claim in OAuth 2.0 access tokens</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApi
{
    /// <summary>A set of application IDs (client IDs), used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app</summary>
    [JsonPropertyName("knownClientApplications")]
    public IList<string>? KnownClientApplications { get; set; }

    /// <summary>Allows an application to use claims mapping without specifying a custom signing key. Defaults to false. Allows an application to use claims mapping without specifying a custom signing key</summary>
    [JsonPropertyName("mappedClaimsEnabled")]
    public bool? MappedClaimsEnabled { get; set; }

    /// <summary>One or more oauth2_permission_scope blocks as documented below, to describe delegated permissions exposed by the web API represented by this application. One or more `oauth2_permission_scope` blocks to describe delegated permissions exposed by the web API represented by this application</summary>
    [JsonPropertyName("oauth2PermissionScope")]
    public IList<V1beta1ApplicationSpecInitProviderApiOauth2PermissionScope>? Oauth2PermissionScope { get; set; }

    /// <summary>The access token version expected by this resource. Must be one of 1 or 2, and must be 2 when sign_in_audience is either AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount Defaults to 1. The access token version expected by this resource</summary>
    [JsonPropertyName("requestedAccessTokenVersion")]
    public double? RequestedAccessTokenVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderAppRole
{
    /// <summary>Specifies whether this app role definition can be assigned to users and groups by setting to User, or to other applications (that are accessing this application in a standalone scenario) by setting to Application, or to both. Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both</summary>
    [JsonPropertyName("allowedMemberTypes")]
    public IList<string>? AllowedMemberTypes { get; set; }

    /// <summary>Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences. Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for the app role that appears during app role assignment and in consent experiences. Display name for the app role that appears during app role assignment and in consent experiences</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Determines if the app role is enabled. Defaults to true. Determines if the app role is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the app role. Must be a valid UUID. The unique identifier of the app role</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The value that is used for the roles claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal. The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderFeatureTags
{
    /// <summary>Whether this application represents a custom SAML application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this application represents a custom SAML application for linked service principals</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this application represents an Enterprise Application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this application represents an Enterprise Application for linked service principals</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this application represents a gallery application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this application represents a gallery application for linked service principals</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this application is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOptionalClaimsAccessToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOptionalClaimsIdToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOptionalClaimsSaml2Token
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOptionalClaims
{
    /// <summary>One or more access_token blocks as documented below.</summary>
    [JsonPropertyName("accessToken")]
    public IList<V1beta1ApplicationSpecInitProviderOptionalClaimsAccessToken>? AccessToken { get; set; }

    /// <summary>One or more id_token blocks as documented below.</summary>
    [JsonPropertyName("idToken")]
    public IList<V1beta1ApplicationSpecInitProviderOptionalClaimsIdToken>? IdToken { get; set; }

    /// <summary>One or more saml2_token blocks as documented below.</summary>
    [JsonPropertyName("saml2Token")]
    public IList<V1beta1ApplicationSpecInitProviderOptionalClaimsSaml2Token>? Saml2Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderPassword
{
    /// <summary>A display name for the password. Changing this field forces a new resource to be created. A display name for the password</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The end date until which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created. The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date from which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn't specified, the current date is used.  Changing this field forces a new resource to be created. The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderPublicClient
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https or ms-appx-web URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderRequiredResourceAccessResourceAccess
{
    /// <summary>The unique identifier for an app role or OAuth2 permission scope published by the resource application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies whether the id property references an app role or an OAuth2 permission scope. Possible values are Role or Scope.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderRequiredResourceAccess
{
    /// <summary>A collection of resource_access blocks as documented below, describing OAuth2.0 permission scopes and app roles that the application requires from the specified resource.</summary>
    [JsonPropertyName("resourceAccess")]
    public IList<V1beta1ApplicationSpecInitProviderRequiredResourceAccessResourceAccess>? ResourceAccess { get; set; }

    /// <summary>The unique identifier for the resource that the application requires access to. This should be the Application ID of the target application.</summary>
    [JsonPropertyName("resourceAppId")]
    public string? ResourceAppId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderSinglePageApplication
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderWebImplicitGrant
{
    /// <summary>Whether this web application can request an access token using OAuth 2.0 implicit flow. Whether this web application can request an access token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("accessTokenIssuanceEnabled")]
    public bool? AccessTokenIssuanceEnabled { get; set; }

    /// <summary>Whether this web application can request an ID token using OAuth 2.0 implicit flow. Whether this web application can request an ID token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("idTokenIssuanceEnabled")]
    public bool? IdTokenIssuanceEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderWeb
{
    /// <summary>Home page or landing page of the application. Home page or landing page of the application</summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>An implicit_grant block as documented above.</summary>
    [JsonPropertyName("implicitGrant")]
    public IList<V1beta1ApplicationSpecInitProviderWebImplicitGrant>? ImplicitGrant { get; set; }

    /// <summary>The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols. The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols</summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid http URL or a URN. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>An api block as documented below, which configures API related settings for this application.</summary>
    [JsonPropertyName("api")]
    public IList<V1beta1ApplicationSpecInitProviderApi>? Api { get; set; }

    /// <summary>A collection of app_role blocks as documented below. For more information see official documentation on Application Roles.</summary>
    [JsonPropertyName("appRole")]
    public IList<V1beta1ApplicationSpecInitProviderAppRole>? AppRole { get; set; }

    /// <summary>A description of the application, as shown to end users. Description of the application as shown to end users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether this application supports device authentication without a user. Defaults to false. Specifies whether this application supports device authentication without a user.</summary>
    [JsonPropertyName("deviceOnlyAuthEnabled")]
    public bool? DeviceOnlyAuthEnabled { get; set; }

    /// <summary>The display name for the application. The display name for the application</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI. Defaults to false. Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI</summary>
    [JsonPropertyName("fallbackPublicClientEnabled")]
    public bool? FallbackPublicClientEnabled { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this application using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1ApplicationSpecInitProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects. Possible values are None, SecurityGroup, DirectoryRole, ApplicationGroup or All. Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects</summary>
    [JsonPropertyName("groupMembershipClaims")]
    public IList<string>? GroupMembershipClaims { get; set; }

    /// <summary>A set of user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant</summary>
    [JsonPropertyName("identifierUris")]
    public IList<string>? IdentifierUris { get; set; }

    /// <summary>A logo image to upload for the application, as a raw base64-encoded string. The image should be in gif, jpeg or png format. Note that once an image has been uploaded, it is not possible to remove it without replacing it with another image. Base64 encoded logo image in gif, png or jpeg format</summary>
    [JsonPropertyName("logoImage")]
    public string? LogoImage { get; set; }

    /// <summary>URL of the application's marketing page. URL of the application's marketing page</summary>
    [JsonPropertyName("marketingUrl")]
    public string? MarketingUrl { get; set; }

    /// <summary>User-specified notes relevant for the management of the application. User-specified notes relevant for the management of the application</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests. Defaults to false, which specifies that only GET requests are allowed. Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.</summary>
    [JsonPropertyName("oauth2PostResponseRequired")]
    public bool? Oauth2PostResponseRequired { get; set; }

    /// <summary>An optional_claims block as documented below.</summary>
    [JsonPropertyName("optionalClaims")]
    public IList<V1beta1ApplicationSpecInitProviderOptionalClaims>? OptionalClaims { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the application. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the application</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>A single password block as documented below. The password is generated during creation. By default, no password is generated. App password definition</summary>
    [JsonPropertyName("password")]
    public IList<V1beta1ApplicationSpecInitProviderPassword>? Password { get; set; }

    /// <summary>If true, will return an error if an existing application is found with the same name. Defaults to false. If `true`, will return an error if an existing application is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>URL of the application's privacy statement. URL of the application's privacy statement</summary>
    [JsonPropertyName("privacyStatementUrl")]
    public string? PrivacyStatementUrl { get; set; }

    /// <summary>A public_client block as documented below, which configures non-web app or non-web API application settings, for example mobile or other public clients such as an installed application running on a desktop device.</summary>
    [JsonPropertyName("publicClient")]
    public IList<V1beta1ApplicationSpecInitProviderPublicClient>? PublicClient { get; set; }

    /// <summary>A collection of required_resource_access blocks as documented below.</summary>
    [JsonPropertyName("requiredResourceAccess")]
    public IList<V1beta1ApplicationSpecInitProviderRequiredResourceAccess>? RequiredResourceAccess { get; set; }

    /// <summary>References application context information from a Service or Asset Management database. References application or service contact information from a Service or Asset Management database</summary>
    [JsonPropertyName("serviceManagementReference")]
    public string? ServiceManagementReference { get; set; }

    /// <summary>The Microsoft account types that are supported for the current application. Must be one of AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount. Defaults to AzureADMyOrg. The Microsoft account types that are supported for the current application</summary>
    [JsonPropertyName("signInAudience")]
    public string? SignInAudience { get; set; }

    /// <summary>A single_page_application block as documented below, which configures single-page application (SPA) related settings for this application.</summary>
    [JsonPropertyName("singlePageApplication")]
    public IList<V1beta1ApplicationSpecInitProviderSinglePageApplication>? SinglePageApplication { get; set; }

    /// <summary>URL of the application's support page. URL of the application's support page</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>A set of tags to apply to the application for configuring specific behaviours of the application and linked service principals. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the application</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Unique ID for a templated application in the Azure AD App Gallery, from which to create the application. Changing this forces a new resource to be created. Unique ID of the application template from which this application is created</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>URL of the application's terms of service statement. URL of the application's terms of service statement</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>A web block as documented below, which configures web related settings for this application.</summary>
    [JsonPropertyName("web")]
    public IList<V1beta1ApplicationSpecInitProviderWeb>? Web { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecProviderConfigRefPolicy
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
public partial class V1beta1ApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ApplicationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ApplicationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ApplicationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApiOauth2PermissionScope
{
    /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users. Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDescription")]
    public string? AdminConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users. Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users</summary>
    [JsonPropertyName("adminConsentDisplayName")]
    public string? AdminConsentDisplayName { get; set; }

    /// <summary>Determines if the permission scope is enabled. Defaults to true. Determines if the permission scope is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the delegated permission. Must be a valid UUID. The unique identifier of the delegated permission</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. Defaults to User. Possible values are User or Admin. Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf. Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf</summary>
    [JsonPropertyName("userConsentDescription")]
    public string? UserConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission that appears in the end user consent experience. Display name for the delegated permission that appears in the end user consent experience</summary>
    [JsonPropertyName("userConsentDisplayName")]
    public string? UserConsentDisplayName { get; set; }

    /// <summary>The value that is used for the scp claim in OAuth 2.0 access tokens. The value that is used for the `scp` claim in OAuth 2.0 access tokens</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApi
{
    /// <summary>A set of application IDs (client IDs), used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app</summary>
    [JsonPropertyName("knownClientApplications")]
    public IList<string>? KnownClientApplications { get; set; }

    /// <summary>Allows an application to use claims mapping without specifying a custom signing key. Defaults to false. Allows an application to use claims mapping without specifying a custom signing key</summary>
    [JsonPropertyName("mappedClaimsEnabled")]
    public bool? MappedClaimsEnabled { get; set; }

    /// <summary>One or more oauth2_permission_scope blocks as documented below, to describe delegated permissions exposed by the web API represented by this application. One or more `oauth2_permission_scope` blocks to describe delegated permissions exposed by the web API represented by this application</summary>
    [JsonPropertyName("oauth2PermissionScope")]
    public IList<V1beta1ApplicationStatusAtProviderApiOauth2PermissionScope>? Oauth2PermissionScope { get; set; }

    /// <summary>The access token version expected by this resource. Must be one of 1 or 2, and must be 2 when sign_in_audience is either AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount Defaults to 1. The access token version expected by this resource</summary>
    [JsonPropertyName("requestedAccessTokenVersion")]
    public double? RequestedAccessTokenVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderAppRole
{
    /// <summary>Specifies whether this app role definition can be assigned to users and groups by setting to User, or to other applications (that are accessing this application in a standalone scenario) by setting to Application, or to both. Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both</summary>
    [JsonPropertyName("allowedMemberTypes")]
    public IList<string>? AllowedMemberTypes { get; set; }

    /// <summary>Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences. Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for the app role that appears during app role assignment and in consent experiences. Display name for the app role that appears during app role assignment and in consent experiences</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Determines if the app role is enabled. Defaults to true. Determines if the app role is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the app role. Must be a valid UUID. The unique identifier of the app role</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The value that is used for the roles claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal. The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderFeatureTags
{
    /// <summary>Whether this application represents a custom SAML application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this application represents a custom SAML application for linked service principals</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this application represents an Enterprise Application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this application represents an Enterprise Application for linked service principals</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this application represents a gallery application for linked service principals. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this application represents a gallery application for linked service principals</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this application is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOptionalClaimsAccessToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOptionalClaimsIdToken
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOptionalClaimsSaml2Token
{
    /// <summary>List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim. Possible values are: cloud_displayname, dns_domain_and_sam_account_name, emit_as_roles, include_externally_authenticated_upn_without_hash, include_externally_authenticated_upn, max_size_limit, netbios_domain_and_sam_account_name, on_premise_security_identifier, sam_account_name, and use_guid. List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim</summary>
    [JsonPropertyName("additionalProperties")]
    public IList<string>? AdditionalProperties { get; set; }

    /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience. Whether the claim specified by the client is necessary to ensure a smooth authorization experience</summary>
    [JsonPropertyName("essential")]
    public bool? Essential { get; set; }

    /// <summary>The name of the optional claim. The name of the optional claim</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source of the claim. If source is absent, the claim is a predefined optional claim. If source is user, the value of name is the extension property from the user object. The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOptionalClaims
{
    /// <summary>One or more access_token blocks as documented below.</summary>
    [JsonPropertyName("accessToken")]
    public IList<V1beta1ApplicationStatusAtProviderOptionalClaimsAccessToken>? AccessToken { get; set; }

    /// <summary>One or more id_token blocks as documented below.</summary>
    [JsonPropertyName("idToken")]
    public IList<V1beta1ApplicationStatusAtProviderOptionalClaimsIdToken>? IdToken { get; set; }

    /// <summary>One or more saml2_token blocks as documented below.</summary>
    [JsonPropertyName("saml2Token")]
    public IList<V1beta1ApplicationStatusAtProviderOptionalClaimsSaml2Token>? Saml2Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderPassword
{
    /// <summary>A display name for the password. Changing this field forces a new resource to be created. A display name for the password</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The end date until which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created. The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The unique key ID for the generated password. A UUID used to uniquely identify this password credential</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The start date from which the password is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn't specified, the current date is used.  Changing this field forces a new resource to be created. The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderPublicClient
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https or ms-appx-web URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderRequiredResourceAccessResourceAccess
{
    /// <summary>The unique identifier for an app role or OAuth2 permission scope published by the resource application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies whether the id property references an app role or an OAuth2 permission scope. Possible values are Role or Scope.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderRequiredResourceAccess
{
    /// <summary>A collection of resource_access blocks as documented below, describing OAuth2.0 permission scopes and app roles that the application requires from the specified resource.</summary>
    [JsonPropertyName("resourceAccess")]
    public IList<V1beta1ApplicationStatusAtProviderRequiredResourceAccessResourceAccess>? ResourceAccess { get; set; }

    /// <summary>The unique identifier for the resource that the application requires access to. This should be the Application ID of the target application.</summary>
    [JsonPropertyName("resourceAppId")]
    public string? ResourceAppId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderSinglePageApplication
{
    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid https URL. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderWebImplicitGrant
{
    /// <summary>Whether this web application can request an access token using OAuth 2.0 implicit flow. Whether this web application can request an access token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("accessTokenIssuanceEnabled")]
    public bool? AccessTokenIssuanceEnabled { get; set; }

    /// <summary>Whether this web application can request an ID token using OAuth 2.0 implicit flow. Whether this web application can request an ID token using OAuth 2.0 implicit flow</summary>
    [JsonPropertyName("idTokenIssuanceEnabled")]
    public bool? IdTokenIssuanceEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderWeb
{
    /// <summary>Home page or landing page of the application. Home page or landing page of the application</summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>An implicit_grant block as documented above.</summary>
    [JsonPropertyName("implicitGrant")]
    public IList<V1beta1ApplicationStatusAtProviderWebImplicitGrant>? ImplicitGrant { get; set; }

    /// <summary>The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols. The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols</summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary>A set of URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Must be a valid http URL or a URN. The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>An api block as documented below, which configures API related settings for this application.</summary>
    [JsonPropertyName("api")]
    public IList<V1beta1ApplicationStatusAtProviderApi>? Api { get; set; }

    /// <summary>A collection of app_role blocks as documented below. For more information see official documentation on Application Roles.</summary>
    [JsonPropertyName("appRole")]
    public IList<V1beta1ApplicationStatusAtProviderAppRole>? AppRole { get; set; }

    /// <summary>A mapping of app role values to app role IDs, intended to be useful when referencing app roles in other resources in your configuration. Mapping of app role names to UUIDs</summary>
    [JsonPropertyName("appRoleIds")]
    public IDictionary<string, string>? AppRoleIds { get; set; }

    /// <summary>The Application ID (also called Client ID)</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The Client ID for the application. The Client ID (also called Application ID)</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>A description of the application, as shown to end users. Description of the application as shown to end users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether this application supports device authentication without a user. Defaults to false. Specifies whether this application supports device authentication without a user.</summary>
    [JsonPropertyName("deviceOnlyAuthEnabled")]
    public bool? DeviceOnlyAuthEnabled { get; set; }

    /// <summary>Whether Microsoft has disabled the registered application. If the application is disabled, this will be a string indicating the status/reason, e.g. DisabledDueToViolationOfServicesAgreement Whether Microsoft has disabled the registered application</summary>
    [JsonPropertyName("disabledByMicrosoft")]
    public string? DisabledByMicrosoft { get; set; }

    /// <summary>The display name for the application. The display name for the application</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI. Defaults to false. Specifies whether the application is a public client. Appropriate for apps using token grant flows that don't use a redirect URI</summary>
    [JsonPropertyName("fallbackPublicClientEnabled")]
    public bool? FallbackPublicClientEnabled { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this application using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1ApplicationStatusAtProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects. Possible values are None, SecurityGroup, DirectoryRole, ApplicationGroup or All. Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects</summary>
    [JsonPropertyName("groupMembershipClaims")]
    public IList<string>? GroupMembershipClaims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant</summary>
    [JsonPropertyName("identifierUris")]
    public IList<string>? IdentifierUris { get; set; }

    /// <summary>A logo image to upload for the application, as a raw base64-encoded string. The image should be in gif, jpeg or png format. Note that once an image has been uploaded, it is not possible to remove it without replacing it with another image. Base64 encoded logo image in gif, png or jpeg format</summary>
    [JsonPropertyName("logoImage")]
    public string? LogoImage { get; set; }

    /// <summary>CDN URL to the application's logo, as uploaded with the logo_image property. CDN URL to the application's logo</summary>
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }

    /// <summary>URL of the application's marketing page. URL of the application's marketing page</summary>
    [JsonPropertyName("marketingUrl")]
    public string? MarketingUrl { get; set; }

    /// <summary>User-specified notes relevant for the management of the application. User-specified notes relevant for the management of the application</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A mapping of OAuth2.0 permission scope values to scope IDs, intended to be useful when referencing permission scopes in other resources in your configuration. Mapping of OAuth2.0 permission scope names to UUIDs</summary>
    [JsonPropertyName("oauth2PermissionScopeIds")]
    public IDictionary<string, string>? Oauth2PermissionScopeIds { get; set; }

    /// <summary>Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests. Defaults to false, which specifies that only GET requests are allowed. Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.</summary>
    [JsonPropertyName("oauth2PostResponseRequired")]
    public bool? Oauth2PostResponseRequired { get; set; }

    /// <summary>The application's object ID. The application's object ID</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>An optional_claims block as documented below.</summary>
    [JsonPropertyName("optionalClaims")]
    public IList<V1beta1ApplicationStatusAtProviderOptionalClaims>? OptionalClaims { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the application. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the application</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>A single password block as documented below. The password is generated during creation. By default, no password is generated. App password definition</summary>
    [JsonPropertyName("password")]
    public IList<V1beta1ApplicationStatusAtProviderPassword>? Password { get; set; }

    /// <summary>If true, will return an error if an existing application is found with the same name. Defaults to false. If `true`, will return an error if an existing application is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>URL of the application's privacy statement. URL of the application's privacy statement</summary>
    [JsonPropertyName("privacyStatementUrl")]
    public string? PrivacyStatementUrl { get; set; }

    /// <summary>A public_client block as documented below, which configures non-web app or non-web API application settings, for example mobile or other public clients such as an installed application running on a desktop device.</summary>
    [JsonPropertyName("publicClient")]
    public IList<V1beta1ApplicationStatusAtProviderPublicClient>? PublicClient { get; set; }

    /// <summary>The verified publisher domain for the application. The verified publisher domain for the application</summary>
    [JsonPropertyName("publisherDomain")]
    public string? PublisherDomain { get; set; }

    /// <summary>A collection of required_resource_access blocks as documented below.</summary>
    [JsonPropertyName("requiredResourceAccess")]
    public IList<V1beta1ApplicationStatusAtProviderRequiredResourceAccess>? RequiredResourceAccess { get; set; }

    /// <summary>References application context information from a Service or Asset Management database. References application or service contact information from a Service or Asset Management database</summary>
    [JsonPropertyName("serviceManagementReference")]
    public string? ServiceManagementReference { get; set; }

    /// <summary>The Microsoft account types that are supported for the current application. Must be one of AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount. Defaults to AzureADMyOrg. The Microsoft account types that are supported for the current application</summary>
    [JsonPropertyName("signInAudience")]
    public string? SignInAudience { get; set; }

    /// <summary>A single_page_application block as documented below, which configures single-page application (SPA) related settings for this application.</summary>
    [JsonPropertyName("singlePageApplication")]
    public IList<V1beta1ApplicationStatusAtProviderSinglePageApplication>? SinglePageApplication { get; set; }

    /// <summary>URL of the application's support page. URL of the application's support page</summary>
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; set; }

    /// <summary>A set of tags to apply to the application for configuring specific behaviours of the application and linked service principals. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the application</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Unique ID for a templated application in the Azure AD App Gallery, from which to create the application. Changing this forces a new resource to be created. Unique ID of the application template from which this application is created</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>URL of the application's terms of service statement. URL of the application's terms of service statement</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>A web block as documented below, which configures web related settings for this application.</summary>
    [JsonPropertyName("web")]
    public IList<V1beta1ApplicationStatusAtProviderWeb>? Web { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "applications.azuread.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}

/// <summary>Application is the Schema for the Applications API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "applications.azuread.upbound.io";
    public const string KubePluralName = "applications";
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
    public IList<V1beta1Application> Items { get; set; }
}