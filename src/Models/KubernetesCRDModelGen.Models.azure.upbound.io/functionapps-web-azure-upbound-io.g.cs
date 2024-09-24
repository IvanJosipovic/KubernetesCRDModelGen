using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAppServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAppServicePlanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1FunctionAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef AppSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1FunctionAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef ConsumerSecretSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderAuthSettings
{
    /// <summary>A active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>The value for the Connection String.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderConnectionStringValueSecretRef
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
public partial class V1beta1FunctionAppSpecForProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the Connection String.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1FunctionAppSpecForProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>The version of the .NET framework's CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you're targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to AllAllowed.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by the Function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to false.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderSourceControl
{
    /// <summary>The branch of the remote repository to use. Defaults to 'master'.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Limits to manual integration. Defaults to false if not specified.</summary>
    [JsonPropertyName("manualIntegration")]
    public bool? ManualIntegration { get; set; }

    /// <summary>The URL of the source code repository.</summary>
    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }

    /// <summary>Enable roll-back for the repository. Defaults to false if not specified.</summary>
    [JsonPropertyName("rollbackEnabled")]
    public bool? RollbackEnabled { get; set; }

    /// <summary>Use Mercurial if true, otherwise uses Git.</summary>
    [JsonPropertyName("useMercurial")]
    public bool? UseMercurial { get; set; }
}

/// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderStorageAccountAccessKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProviderStorageAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecForProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdRef")]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdRef? AppServicePlanIdRef { get; set; }

    /// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdSelector")]
    public V1beta1FunctionAppSpecForProviderAppServicePlanIdSelector? AppServicePlanIdSelector { get; set; }

    /// <summary>A map of key-value pairs for App Settings and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1FunctionAppSpecForProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>The mode of the Function App's client certificates requirement for incoming requests. Possible values are Required and Optional.</summary>
    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>An connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Should the built-in logging of this Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FunctionAppSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity Id used for looking up KeyVault secrets. The identity must be assigned to the application. See Access vaults with a user-assigned identity for more information.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Function App. Changing this forces a new resource to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. Possible values are linux and “(empty string). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The name of the resource group in which to create the Function App. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FunctionAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1FunctionAppSpecForProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A source_control block, as defined below.</summary>
    [JsonPropertyName("sourceControl")]
    public IList<V1beta1FunctionAppSpecForProviderSourceControl>? SourceControl { get; set; }

    /// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta1FunctionAppSpecForProviderStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1FunctionAppSpecForProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAppServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderAuthSettings
{
    /// <summary>A active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>The version of the .NET framework's CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you're targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to AllAllowed.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by the Function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to false.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderSourceControl
{
    /// <summary>The branch of the remote repository to use. Defaults to 'master'.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Limits to manual integration. Defaults to false if not specified.</summary>
    [JsonPropertyName("manualIntegration")]
    public bool? ManualIntegration { get; set; }

    /// <summary>The URL of the source code repository.</summary>
    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }

    /// <summary>Enable roll-back for the repository. Defaults to false if not specified.</summary>
    [JsonPropertyName("rollbackEnabled")]
    public bool? RollbackEnabled { get; set; }

    /// <summary>Use Mercurial if true, otherwise uses Git.</summary>
    [JsonPropertyName("useMercurial")]
    public bool? UseMercurial { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProviderStorageAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecInitProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdRef")]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdRef? AppServicePlanIdRef { get; set; }

    /// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdSelector")]
    public V1beta1FunctionAppSpecInitProviderAppServicePlanIdSelector? AppServicePlanIdSelector { get; set; }

    /// <summary>A map of key-value pairs for App Settings and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1FunctionAppSpecInitProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>The mode of the Function App's client certificates requirement for incoming requests. Possible values are Required and Optional.</summary>
    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>An connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Should the built-in logging of this Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FunctionAppSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity Id used for looking up KeyVault secrets. The identity must be assigned to the application. See Access vaults with a user-assigned identity for more information.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Function App. Changing this forces a new resource to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. Possible values are linux and “(empty string). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The name of the resource group in which to create the Function App. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FunctionAppSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1FunctionAppSpecInitProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A source_control block, as defined below.</summary>
    [JsonPropertyName("sourceControl")]
    public IList<V1beta1FunctionAppSpecInitProviderSourceControl>? SourceControl { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1FunctionAppSpecInitProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FunctionAppSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FunctionAppSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FunctionAppSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionAppSpec defines the desired state of FunctionApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSpecDeletionPolicyEnum>))]
    public V1beta1FunctionAppSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionAppSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionAppSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FunctionAppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FunctionAppSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderAuthSettings
{
    /// <summary>A active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettingsActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettingsFacebook>? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettingsGoogle>? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettingsMicrosoft>? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettingsTwitter>? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfigIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is "1".</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-For' IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed 'X-Forwarded-Host' domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfigScmIpRestrictionHeaders>? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfigCors>? Cors { get; set; }

    /// <summary>The version of the .NET framework's CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you're targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to AllAllowed.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by the Function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to false.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSiteCredential
{
    /// <summary>The password associated with the username, which can be used to publish to this App Service.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>The username which can be used to publish to this App Service</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProviderSourceControl
{
    /// <summary>The branch of the remote repository to use. Defaults to 'master'.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Limits to manual integration. Defaults to false if not specified.</summary>
    [JsonPropertyName("manualIntegration")]
    public bool? ManualIntegration { get; set; }

    /// <summary>The URL of the source code repository.</summary>
    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }

    /// <summary>Enable roll-back for the repository. Defaults to false if not specified.</summary>
    [JsonPropertyName("rollbackEnabled")]
    public bool? RollbackEnabled { get; set; }

    /// <summary>Use Mercurial if true, otherwise uses Git.</summary>
    [JsonPropertyName("useMercurial")]
    public bool? UseMercurial { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusAtProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>A map of key-value pairs for App Settings and custom values.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public IList<V1beta1FunctionAppStatusAtProviderAuthSettings>? AuthSettings { get; set; }

    /// <summary>The mode of the Function App's client certificates requirement for incoming requests. Possible values are Required and Optional.</summary>
    [JsonPropertyName("clientCertMode")]
    public string? ClientCertMode { get; set; }

    /// <summary>An connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>An identifier used by App Service to perform domain ownership verification via DNS TXT record.</summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>The default hostname associated with the Function App - such as mysite.azurewebsites.net</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Should the built-in logging of this Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Function App</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FunctionAppStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The User Assigned Identity Id used for looking up KeyVault secrets. The identity must be assigned to the application. See Access vaults with a user-assigned identity for more information.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Function App kind - such as functionapp,linux,container</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Function App. Changing this forces a new resource to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. Possible values are linux and “(empty string). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12,52.143.43.17 - not all of which are necessarily in use. Superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>The name of the resource group in which to create the Function App. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteConfig>? SiteConfig { get; set; }

    /// <summary>A site_credential block as defined below, which contains the site-level credentials used to publish to this App Service.</summary>
    [JsonPropertyName("siteCredential")]
    public IList<V1beta1FunctionAppStatusAtProviderSiteCredential>? SiteCredential { get; set; }

    /// <summary>A source_control block, as defined below.</summary>
    [JsonPropertyName("sourceControl")]
    public IList<V1beta1FunctionAppStatusAtProviderSourceControl>? SourceControl { get; set; }

    /// <summary>The backend storage account name which will be used by this Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatusConditions
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

/// <summary>FunctionAppStatus defines the observed state of FunctionApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionAppStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FunctionApp is the Schema for the FunctionApps API. Manages a Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionAppSpec>, IStatus<V1beta1FunctionAppStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionApp";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "functionapps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionAppSpec defines the desired state of FunctionApp</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionAppSpec Spec { get; set; }

    /// <summary>FunctionAppStatus defines the observed state of FunctionApp.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionAppStatus? Status { get; set; }
}