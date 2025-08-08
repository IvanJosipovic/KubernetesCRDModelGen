using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.gcp.m.upbound.io;
/// <summary>The client id of an OAuth client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecForProviderClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecForProviderClientSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecForProviderResponseType
{
    /// <summary>If true, authorization code is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary>If true, ID token is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecForProvider
{
    /// <summary>The client id of an OAuth client.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1OAuthIdPConfigSpecForProviderClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1OAuthIdPConfigSpecForProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>For OIDC Idps, the issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The name of the OauthIdpConfig. Must start with oidc..</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
    [JsonPropertyName("responseType")]
    public V1beta1OAuthIdPConfigSpecForProviderResponseType? ResponseType { get; set; }
}

/// <summary>The client id of an OAuth client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecInitProviderClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecInitProviderClientSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecInitProviderResponseType
{
    /// <summary>If true, authorization code is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary>If true, ID token is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecInitProvider
{
    /// <summary>The client id of an OAuth client.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1OAuthIdPConfigSpecInitProviderClientIdSecretRef ClientIdSecretRef { get; set; }

    /// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1OAuthIdPConfigSpecInitProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>For OIDC Idps, the issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The name of the OauthIdpConfig. Must start with oidc..</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
    [JsonPropertyName("responseType")]
    public V1beta1OAuthIdPConfigSpecInitProviderResponseType? ResponseType { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpecProviderConfigRef
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
public partial class V1beta1OAuthIdPConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OAuthIdPConfigSpec defines the desired state of OAuthIdPConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OAuthIdPConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OAuthIdPConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OAuthIdPConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OAuthIdPConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigStatusAtProviderResponseType
{
    /// <summary>If true, authorization code is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary>If true, ID token is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigStatusAtProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/oauthIdpConfigs/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>For OIDC Idps, the issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The name of the OauthIdpConfig. Must start with oidc..</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The response type to request for in the OAuth authorization flow. You can set either idToken or code to true, but not both. Setting both types to be simultaneously true ({code: true, idToken: true}) is not yet supported. Structure is documented below.</summary>
    [JsonPropertyName("responseType")]
    public V1beta1OAuthIdPConfigStatusAtProviderResponseType? ResponseType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigStatusConditions
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

/// <summary>OAuthIdPConfigStatus defines the observed state of OAuthIdPConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OAuthIdPConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OAuthIdPConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OAuthIdPConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OAuthIdPConfig is the Schema for the OAuthIdPConfigs API. OIDC IdP configuration for a Identity Toolkit project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OAuthIdPConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OAuthIdPConfigSpec>, IStatus<V1beta1OAuthIdPConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OAuthIdPConfig";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "oauthidpconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OAuthIdPConfigSpec defines the desired state of OAuthIdPConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1OAuthIdPConfigSpec Spec { get; set; }

    /// <summary>OAuthIdPConfigStatus defines the observed state of OAuthIdPConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1OAuthIdPConfigStatus? Status { get; set; }
}

/// <summary>OAuthIdPConfig is the Schema for the OAuthIdPConfigs API. OIDC IdP configuration for a Identity Toolkit project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OAuthIdPConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OAuthIdPConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OAuthIdPConfigList";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "oauthidpconfigs";
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
    public IList<V1beta1OAuthIdPConfig> Items { get; set; }
}