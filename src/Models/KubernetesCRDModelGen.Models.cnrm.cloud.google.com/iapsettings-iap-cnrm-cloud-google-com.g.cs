using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iap.cnrm.cloud.google.com;
/// <summary>Settings to configure and enable allowed domains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettingsAllowedDomainsSettings
{
    /// <summary>List of trusted domains.</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>Configuration for customers to opt in for the feature.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>Configuration to allow cross-origin requests via IAP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettingsCorsSettings
{
    /// <summary>Configuration to allow HTTP OPTIONS calls to skip authorization. If undefined, IAP will not apply any special logic to OPTIONS requests.</summary>
    [JsonPropertyName("allowHTTPOptions")]
    public bool? AllowHTTPOptions { get; set; }
}

/// <summary>GCIP claims and endpoint configurations for 3p identity providers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettingsGcipSettings
{
    /// <summary>Login page URI associated with the GCIP tenants. Typically, all resources within the same project share the same login page, though it could be overridden at the sub resource level.</summary>
    [JsonPropertyName("loginPageURI")]
    public string? LoginPageURI { get; set; }

    /// <summary>GCIP tenant ids that are linked to the IAP resource. tenant_ids could be a string beginning with a number character to indicate authenticating with GCIP tenant flow, or in the format of _&lt;ProjectNumber&gt; to indicate authenticating with GCIP agent flow. If agent flow is used, tenant_ids should only contain one single element, while for tenant flow, tenant_ids can contain multiple elements.</summary>
    [JsonPropertyName("tenantIds")]
    public IList<string>? TenantIds { get; set; }
}

/// <summary>Settings to configure IAP's OAuth behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettingsOauthSettings
{
    /// <summary>Domain hint to send as hd=? parameter in OAuth request flow. Enables redirect to primary IDP by skipping Google's login screen. https://developers.google.com/identity/protocols/OpenIDConnect#hd-param Note: IAP does not verify that the id token's hd claim matches this value since access behavior is managed by IAM policies.</summary>
    [JsonPropertyName("loginHint")]
    public string? LoginHint { get; set; }

    /// <summary>List of OAuth client IDs allowed to programmatically authenticate with IAP.</summary>
    [JsonPropertyName("programmaticClients")]
    public IList<string>? ProgrammaticClients { get; set; }
}

/// <summary>Settings to configure reauthentication policies in IAP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettingsReauthSettings
{
    /// <summary>Reauth session lifetime, how long before a user has to reauthenticate again.</summary>
    [JsonPropertyName("maxAge")]
    public string? MaxAge { get; set; }

    /// <summary>Reauth method requested.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>How IAP determines the effective policy in cases of hierarchial policies. Policies are merged from higher in the hierarchy to lower in the hierarchy.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>Top level wrapper for all access related setting in IAP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecAccessSettings
{
    /// <summary>Settings to configure and enable allowed domains.</summary>
    [JsonPropertyName("allowedDomainsSettings")]
    public V1alpha1IAPSettingsSpecAccessSettingsAllowedDomainsSettings? AllowedDomainsSettings { get; set; }

    /// <summary>Configuration to allow cross-origin requests via IAP.</summary>
    [JsonPropertyName("corsSettings")]
    public V1alpha1IAPSettingsSpecAccessSettingsCorsSettings? CorsSettings { get; set; }

    /// <summary>GCIP claims and endpoint configurations for 3p identity providers.</summary>
    [JsonPropertyName("gcipSettings")]
    public V1alpha1IAPSettingsSpecAccessSettingsGcipSettings? GcipSettings { get; set; }

    /// <summary>Settings to configure IAP's OAuth behavior.</summary>
    [JsonPropertyName("oauthSettings")]
    public V1alpha1IAPSettingsSpecAccessSettingsOauthSettings? OauthSettings { get; set; }

    /// <summary>Settings to configure reauthentication policies in IAP.</summary>
    [JsonPropertyName("reauthSettings")]
    public V1alpha1IAPSettingsSpecAccessSettingsReauthSettings? ReauthSettings { get; set; }
}

/// <summary>Customization for Access Denied page.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecApplicationSettingsAccessDeniedPageSettings
{
    /// <summary>The URI to be redirected to when access is denied.</summary>
    [JsonPropertyName("accessDeniedPageURI")]
    public string? AccessDeniedPageURI { get; set; }

    /// <summary>Whether to generate a troubleshooting URL on access denied events to this application.</summary>
    [JsonPropertyName("generateTroubleshootingURI")]
    public bool? GenerateTroubleshootingURI { get; set; }

    /// <summary>Whether to generate remediation token on access denied events to this application.</summary>
    [JsonPropertyName("remediationTokenGenerationEnabled")]
    public bool? RemediationTokenGenerationEnabled { get; set; }
}

/// <summary>Settings to configure attribute propagation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecApplicationSettingsAttributePropagationSettings
{
    /// <summary>Whether the provided attribute propagation settings should be evaluated on user requests. If set to true, attributes returned from the expression will be propagated in the set output credentials.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Raw string CEL expression. Must return a list of attributes. A maximum of  45 attributes can be selected. Expressions can select different attribute  types from `attributes`: `attributes.saml_attributes`,  `attributes.iap_attributes`. The following functions are supported:    - filter `&lt;list&gt;.filter(&lt;iter_var&gt;, &lt;predicate&gt;)`: Returns a subset of   `&lt;list&gt;` where `&lt;predicate&gt;` is true for every item.    - in `&lt;var&gt; in &lt;list&gt;`: Returns true if `&lt;list&gt;` contains `&lt;var&gt;`.    - selectByName `&lt;list&gt;.selectByName(&lt;string&gt;)`: Returns the attribute   in   `&lt;list&gt;` with the given `&lt;string&gt;` name, otherwise returns empty.    - emitAs `&lt;attribute&gt;.emitAs(&lt;string&gt;)`: Sets the `&lt;attribute&gt;` name   field to the given `&lt;string&gt;` for propagation in selected output   credentials.    - strict `&lt;attribute&gt;.strict()`: Ignores the `x-goog-iap-attr-` prefix   for the provided `&lt;attribute&gt;` when propagating with the `HEADER` output   credential, such as request headers.    - append `&lt;target_list&gt;.append(&lt;attribute&gt;)` OR   `&lt;target_list&gt;.append(&lt;list&gt;)`: Appends the provided `&lt;attribute&gt;` or   `&lt;list&gt;` to the end of `&lt;target_list&gt;`.   Example expression: `attributes.saml_attributes.filter(x, x.name in  ['test']).append(attributes.iap_attributes.selectByName('exact').emitAs('custom').strict())`</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Which output credentials attributes selected by the CEL expression should be propagated in. All attributes will be fully duplicated in each selected output credential.</summary>
    [JsonPropertyName("outputCredentials")]
    public IList<string>? OutputCredentials { get; set; }
}

/// <summary>Settings to configure IAP's behavior for a service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecApplicationSettingsCsmSettings
{
    /// <summary>Audience claim set in the generated RCToken. This value is not validated by IAP.</summary>
    [JsonPropertyName("rctokenAud")]
    public string? RctokenAud { get; set; }
}

/// <summary>Top level wrapper for all application related settings in IAP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpecApplicationSettings
{
    /// <summary>Customization for Access Denied page.</summary>
    [JsonPropertyName("accessDeniedPageSettings")]
    public V1alpha1IAPSettingsSpecApplicationSettingsAccessDeniedPageSettings? AccessDeniedPageSettings { get; set; }

    /// <summary>Settings to configure attribute propagation.</summary>
    [JsonPropertyName("attributePropagationSettings")]
    public V1alpha1IAPSettingsSpecApplicationSettingsAttributePropagationSettings? AttributePropagationSettings { get; set; }

    /// <summary>The Domain value to set for cookies generated by IAP. This value is not validated by the API, but will be ignored at runtime if invalid.</summary>
    [JsonPropertyName("cookieDomain")]
    public string? CookieDomain { get; set; }

    /// <summary>Settings to configure IAP's behavior for a service mesh.</summary>
    [JsonPropertyName("csmSettings")]
    public V1alpha1IAPSettingsSpecApplicationSettingsCsmSettings? CsmSettings { get; set; }
}

/// <summary>IAPSettingsSpec defines the desired state of IAPSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsSpec
{
    /// <summary>Top level wrapper for all access related setting in IAP</summary>
    [JsonPropertyName("accessSettings")]
    public V1alpha1IAPSettingsSpecAccessSettings? AccessSettings { get; set; }

    /// <summary>Top level wrapper for all application related settings in IAP</summary>
    [JsonPropertyName("applicationSettings")]
    public V1alpha1IAPSettingsSpecApplicationSettings? ApplicationSettings { get; set; }

    /// <summary>Required. The resource name of the IAP protected resource. The name could have the following format: organizations/{organization_id} folders/{folder_id} projects/{projects_id} projects/{projects_id}/iap_web projects/{projects_id}/iap_web/compute projects/{projects_id}/iap_web/compute-{region} projects/{projects_id}/iap_web/compute/service/{service_id} projects/{projects_id}/iap_web/compute-{region}/service/{service_id} projects/{projects_id}/iap_web/appengine-{app_id} projects/{projects_id}/iap_web/appengine-{app_id}/service/{service_id} projects/{projects_id}/iap_web/appengine-{app_id}/service/{service_id}/version/{version_id}</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The IAPSettings name.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsStatusConditions
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

/// <summary>IAPSettingsStatus defines the config connector machine state of IAPSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAPSettingsStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IAPSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the IAPSettings resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAPSettings is the Schema for the IAPSettings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IAPSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IAPSettingsSpec>, IStatus<V1alpha1IAPSettingsStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IAPSettings";
    public const string KubeGroup = "iap.cnrm.cloud.google.com";
    public const string KubePluralName = "iapsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAPSettingsSpec defines the desired state of IAPSettings</summary>
    [JsonPropertyName("spec")]
    public V1alpha1IAPSettingsSpec Spec { get; set; }

    /// <summary>IAPSettingsStatus defines the config connector machine state of IAPSettings</summary>
    [JsonPropertyName("status")]
    public V1alpha1IAPSettingsStatus? Status { get; set; }
}