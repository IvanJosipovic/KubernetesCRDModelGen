using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azure.com;
/// <summary>Storage version of v1api20240301.EncryptionSettings The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>Storage version of v1api20240301.GlobalValidation The configuration settings that determines the validation flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecGlobalValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>Storage version of v1api20240301.ForwardProxy The configuration settings of a forward proxy used to make the requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecHttpSettingsForwardProxy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>Storage version of v1api20240301.HttpSettingsRoutes The configuration settings of the paths HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecHttpSettingsRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>Storage version of v1api20240301.HttpSettings The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecHttpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ForwardProxy The configuration settings of a forward proxy used to make the requests.</summary>
    [JsonPropertyName("forwardProxy")]
    public V1api20240301storageAuthConfigSpecHttpSettingsForwardProxy? ForwardProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>Storage version of v1api20240301.HttpSettingsRoutes The configuration settings of the paths HTTP requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301storageAuthConfigSpecHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAppleLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.AppleRegistration The configuration settings of the registration for the Apple provider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAppleRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Apple The configuration settings of the Apple provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersApple
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AppleRegistration The configuration settings of the registration for the Apple provider</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryLogin The configuration settings of the Azure Active Directory login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryRegistration The configuration settings of the Azure Active Directory app registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>Storage version of v1api20240301.AllowedPrincipals The configuration settings of the Azure Active Directory allowed principals.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>Storage version of v1api20240301.DefaultAuthorizationPolicy The configuration settings of the Azure Active Directory default authorization policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>Storage version of v1api20240301.AllowedPrincipals The configuration settings of the Azure Active Directory allowed principals.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>Storage version of v1api20240301.JwtClaimChecks The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryValidation The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>Storage version of v1api20240301.DefaultAuthorizationPolicy The configuration settings of the Azure Active Directory default authorization policy.</summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>Storage version of v1api20240301.JwtClaimChecks The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectory The configuration settings of the Azure Active directory provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryLogin The configuration settings of the Azure Active Directory login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryRegistration The configuration settings of the Azure Active Directory app registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryValidation The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureStaticWebAppsRegistration The configuration settings of the registration for the Azure Static Web Apps provider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureStaticWebApps The configuration settings of the Azure Static Web Apps provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersAzureStaticWebApps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.AzureStaticWebAppsRegistration The configuration settings of the registration for the Azure Static Web Apps provider</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectLogin The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectClientCredential The authentication client credentials of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectConfig The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectRegistration The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectClientCredential The authentication client credentials of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientCredential")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectConfig The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>Storage version of v1api20240301.CustomOpenIdConnectProvider The configuration settings of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectLogin The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectRegistration The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersFacebookLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.AppRegistration The configuration settings of the app registration for providers that have app ids and app secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersFacebookRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Facebook The configuration settings of the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersFacebook
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AppRegistration The configuration settings of the app registration for providers that have app ids and app secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGitHubLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.ClientRegistration The configuration settings of the app registration for providers that have client ids and client secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGitHubRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.GitHub The configuration settings of the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGitHub
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.ClientRegistration The configuration settings of the app registration for providers that have client ids and client secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGoogleLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.ClientRegistration The configuration settings of the app registration for providers that have client ids and client secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGoogleRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.AllowedAudiencesValidation The configuration settings of the Allowed Audiences validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGoogleValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>Storage version of v1api20240301.Google The configuration settings of the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersGoogle
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.ClientRegistration The configuration settings of the app registration for providers that have client ids and client secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>Storage version of v1api20240301.AllowedAudiencesValidation The configuration settings of the Allowed Audiences validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>Storage version of v1api20240301.TwitterRegistration The configuration settings of the app registration for the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersTwitterRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Twitter The configuration settings of the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProvidersTwitter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.TwitterRegistration The configuration settings of the app registration for the Twitter provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.IdentityProviders The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecIdentityProviders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.Apple The configuration settings of the Apple provider.</summary>
    [JsonPropertyName("apple")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersApple? Apple { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectory The configuration settings of the Azure Active directory provider.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>Storage version of v1api20240301.AzureStaticWebApps The configuration settings of the Azure Static Web Apps provider.</summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V1api20240301storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>Storage version of v1api20240301.Facebook The configuration settings of the Facebook provider.</summary>
    [JsonPropertyName("facebook")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>Storage version of v1api20240301.GitHub The configuration settings of the GitHub provider.</summary>
    [JsonPropertyName("gitHub")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>Storage version of v1api20240301.Google The configuration settings of the Google provider.</summary>
    [JsonPropertyName("google")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersGoogle? Google { get; set; }

    /// <summary>Storage version of v1api20240301.Twitter The configuration settings of the Twitter provider.</summary>
    [JsonPropertyName("twitter")]
    public V1api20240301storageAuthConfigSpecIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>Storage version of v1api20240301.CookieExpiration The configuration settings of the session cookie's expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLoginCookieExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>Storage version of v1api20240301.Nonce The configuration settings of the nonce used in the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLoginNonce
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginRoutes The routes that specify the endpoints used for login and logout requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLoginRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>Storage version of v1api20240301.BlobStorageTokenStore The configuration settings of the storage of the tokens if blob storage is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLoginTokenStoreAzureBlobStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sasUrlSettingName")]
    public string? SasUrlSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.TokenStore The configuration settings of the token store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLoginTokenStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.BlobStorageTokenStore The configuration settings of the storage of the tokens if blob storage is used.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1api20240301storageAuthConfigSpecLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>Storage version of v1api20240301.Login The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>Storage version of v1api20240301.CookieExpiration The configuration settings of the session cookie's expiration.</summary>
    [JsonPropertyName("cookieExpiration")]
    public V1api20240301storageAuthConfigSpecLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>Storage version of v1api20240301.Nonce The configuration settings of the nonce used in the login flow.</summary>
    [JsonPropertyName("nonce")]
    public V1api20240301storageAuthConfigSpecLoginNonce? Nonce { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>Storage version of v1api20240301.LoginRoutes The routes that specify the endpoints used for login and logout requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301storageAuthConfigSpecLoginRoutes? Routes { get; set; }

    /// <summary>Storage version of v1api20240301.TokenStore The configuration settings of the token store.</summary>
    [JsonPropertyName("tokenStore")]
    public V1api20240301storageAuthConfigSpecLoginTokenStore? TokenStore { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthConfigOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageAuthConfigSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageAuthConfigSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a app.azure.com/ContainerApp resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthPlatform The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpecPlatform
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthConfig_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240301.EncryptionSettings The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20240301storageAuthConfigSpecEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Storage version of v1api20240301.GlobalValidation The configuration settings that determines the validation flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("globalValidation")]
    public V1api20240301storageAuthConfigSpecGlobalValidation? GlobalValidation { get; set; }

    /// <summary>Storage version of v1api20240301.HttpSettings The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("httpSettings")]
    public V1api20240301storageAuthConfigSpecHttpSettings? HttpSettings { get; set; }

    /// <summary>Storage version of v1api20240301.IdentityProviders The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("identityProviders")]
    public V1api20240301storageAuthConfigSpecIdentityProviders? IdentityProviders { get; set; }

    /// <summary>Storage version of v1api20240301.Login The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigSpecLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AuthConfigOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageAuthConfigSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a app.azure.com/ContainerApp resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240301storageAuthConfigSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240301.AuthPlatform The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("platform")]
    public V1api20240301storageAuthConfigSpecPlatform? Platform { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusConditions
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

/// <summary>Storage version of v1api20240301.EncryptionSettings_STATUS The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>Storage version of v1api20240301.GlobalValidation_STATUS The configuration settings that determines the validation flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusGlobalValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>Storage version of v1api20240301.ForwardProxy_STATUS The configuration settings of a forward proxy used to make the requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusHttpSettingsForwardProxy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>Storage version of v1api20240301.HttpSettingsRoutes_STATUS The configuration settings of the paths HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusHttpSettingsRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>Storage version of v1api20240301.HttpSettings_STATUS The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusHttpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ForwardProxy_STATUS The configuration settings of a forward proxy used to make the requests.</summary>
    [JsonPropertyName("forwardProxy")]
    public V1api20240301storageAuthConfigStatusHttpSettingsForwardProxy? ForwardProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>Storage version of v1api20240301.HttpSettingsRoutes_STATUS The configuration settings of the paths HTTP requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301storageAuthConfigStatusHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAppleLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.AppleRegistration_STATUS The configuration settings of the registration for the Apple provider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAppleRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Apple_STATUS The configuration settings of the Apple provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersApple
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AppleRegistration_STATUS The configuration settings of the registration for the Apple provider</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryLogin_STATUS The configuration settings of the Azure Active Directory login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryRegistration_STATUS The configuration settings of the Azure Active Directory app registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>Storage version of v1api20240301.AllowedPrincipals_STATUS The configuration settings of the Azure Active Directory allowed principals.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>Storage version of v1api20240301.DefaultAuthorizationPolicy_STATUS The configuration settings of the Azure Active Directory default authorization policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>Storage version of v1api20240301.AllowedPrincipals_STATUS The configuration settings of the Azure Active Directory allowed principals.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>Storage version of v1api20240301.JwtClaimChecks_STATUS The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectoryValidation_STATUS The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>Storage version of v1api20240301.DefaultAuthorizationPolicy_STATUS The configuration settings of the Azure Active Directory default authorization policy.</summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>Storage version of v1api20240301.JwtClaimChecks_STATUS The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureActiveDirectory_STATUS The configuration settings of the Azure Active directory provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryLogin_STATUS The configuration settings of the Azure Active Directory login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryRegistration_STATUS The configuration settings of the Azure Active Directory app registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectoryValidation_STATUS The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureStaticWebAppsRegistration_STATUS The configuration settings of the registration for the Azure Static Web Apps provider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Storage version of v1api20240301.AzureStaticWebApps_STATUS The configuration settings of the Azure Static Web Apps provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersAzureStaticWebApps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.AzureStaticWebAppsRegistration_STATUS The configuration settings of the registration for the Azure Static Web Apps provider</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectLogin_STATUS The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectClientCredential_STATUS The authentication client credentials of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectConfig_STATUS The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>Storage version of v1api20240301.OpenIdConnectRegistration_STATUS The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectClientCredential_STATUS The authentication client credentials of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientCredential")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectConfig_STATUS The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>Storage version of v1api20240301.CustomOpenIdConnectProvider_STATUS The configuration settings of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectLogin_STATUS The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.OpenIdConnectRegistration_STATUS The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersFacebookLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.AppRegistration_STATUS The configuration settings of the app registration for providers that have app ids and app secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersFacebookRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Facebook_STATUS The configuration settings of the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersFacebook
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.AppRegistration_STATUS The configuration settings of the app registration for providers that have app ids and app secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGitHubLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.ClientRegistration_STATUS The configuration settings of the app registration for providers that have client ids and client secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGitHubRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.GitHub_STATUS The configuration settings of the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGitHub
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.ClientRegistration_STATUS The configuration settings of the app registration for providers that have client ids and client secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGoogleLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Storage version of v1api20240301.ClientRegistration_STATUS The configuration settings of the app registration for providers that have client ids and client secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGoogleRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.AllowedAudiencesValidation_STATUS The configuration settings of the Allowed Audiences validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGoogleValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>Storage version of v1api20240301.Google_STATUS The configuration settings of the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersGoogle
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.LoginScopes_STATUS The configuration settings of the login flow, including the scopes that should be requested.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>Storage version of v1api20240301.ClientRegistration_STATUS The configuration settings of the app registration for providers that have client ids and client secrets</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>Storage version of v1api20240301.AllowedAudiencesValidation_STATUS The configuration settings of the Allowed Audiences validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>Storage version of v1api20240301.TwitterRegistration_STATUS The configuration settings of the app registration for the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersTwitterRegistration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.Twitter_STATUS The configuration settings of the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProvidersTwitter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240301.TwitterRegistration_STATUS The configuration settings of the app registration for the Twitter provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>Storage version of v1api20240301.IdentityProviders_STATUS The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusIdentityProviders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.Apple_STATUS The configuration settings of the Apple provider.</summary>
    [JsonPropertyName("apple")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersApple? Apple { get; set; }

    /// <summary>Storage version of v1api20240301.AzureActiveDirectory_STATUS The configuration settings of the Azure Active directory provider.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>Storage version of v1api20240301.AzureStaticWebApps_STATUS The configuration settings of the Azure Static Web Apps provider.</summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V1api20240301storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>Storage version of v1api20240301.Facebook_STATUS The configuration settings of the Facebook provider.</summary>
    [JsonPropertyName("facebook")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>Storage version of v1api20240301.GitHub_STATUS The configuration settings of the GitHub provider.</summary>
    [JsonPropertyName("gitHub")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>Storage version of v1api20240301.Google_STATUS The configuration settings of the Google provider.</summary>
    [JsonPropertyName("google")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersGoogle? Google { get; set; }

    /// <summary>Storage version of v1api20240301.Twitter_STATUS The configuration settings of the Twitter provider.</summary>
    [JsonPropertyName("twitter")]
    public V1api20240301storageAuthConfigStatusIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>Storage version of v1api20240301.CookieExpiration_STATUS The configuration settings of the session cookie's expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLoginCookieExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>Storage version of v1api20240301.Nonce_STATUS The configuration settings of the nonce used in the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLoginNonce
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>Storage version of v1api20240301.LoginRoutes_STATUS The routes that specify the endpoints used for login and logout requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLoginRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>Storage version of v1api20240301.BlobStorageTokenStore_STATUS The configuration settings of the storage of the tokens if blob storage is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLoginTokenStoreAzureBlobStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sasUrlSettingName")]
    public string? SasUrlSettingName { get; set; }
}

/// <summary>Storage version of v1api20240301.TokenStore_STATUS The configuration settings of the token store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLoginTokenStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.BlobStorageTokenStore_STATUS The configuration settings of the storage of the tokens if blob storage is used.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1api20240301storageAuthConfigStatusLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>Storage version of v1api20240301.Login_STATUS The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusLogin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>Storage version of v1api20240301.CookieExpiration_STATUS The configuration settings of the session cookie's expiration.</summary>
    [JsonPropertyName("cookieExpiration")]
    public V1api20240301storageAuthConfigStatusLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>Storage version of v1api20240301.Nonce_STATUS The configuration settings of the nonce used in the login flow.</summary>
    [JsonPropertyName("nonce")]
    public V1api20240301storageAuthConfigStatusLoginNonce? Nonce { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>Storage version of v1api20240301.LoginRoutes_STATUS The routes that specify the endpoints used for login and logout requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301storageAuthConfigStatusLoginRoutes? Routes { get; set; }

    /// <summary>Storage version of v1api20240301.TokenStore_STATUS The configuration settings of the token store.</summary>
    [JsonPropertyName("tokenStore")]
    public V1api20240301storageAuthConfigStatusLoginTokenStore? TokenStore { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthPlatform_STATUS The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusPlatform
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Storage version of v1api20240301.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageAuthConfigStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageAuthConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240301.EncryptionSettings_STATUS The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20240301storageAuthConfigStatusEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Storage version of v1api20240301.GlobalValidation_STATUS The configuration settings that determines the validation flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("globalValidation")]
    public V1api20240301storageAuthConfigStatusGlobalValidation? GlobalValidation { get; set; }

    /// <summary>Storage version of v1api20240301.HttpSettings_STATUS The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("httpSettings")]
    public V1api20240301storageAuthConfigStatusHttpSettings? HttpSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240301.IdentityProviders_STATUS The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("identityProviders")]
    public V1api20240301storageAuthConfigStatusIdentityProviders? IdentityProviders { get; set; }

    /// <summary>Storage version of v1api20240301.Login_STATUS The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("login")]
    public V1api20240301storageAuthConfigStatusLogin? Login { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240301.AuthPlatform_STATUS The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("platform")]
    public V1api20240301storageAuthConfigStatusPlatform? Platform { get; set; }

    /// <summary>Storage version of v1api20240301.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240301storageAuthConfigStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240301.AuthConfig Generator information: - Generated from: /app/resource-manager/Microsoft.App/stable/2024-03-01/AuthConfigs.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageAuthConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageAuthConfigSpec>, IStatus<V1api20240301storageAuthConfigStatus>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "AuthConfig";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "authconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.AuthConfig_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageAuthConfigSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.AuthConfig_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageAuthConfigStatus? Status { get; set; }
}