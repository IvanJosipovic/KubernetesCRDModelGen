using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.cnrm.cloud.google.com;
/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecretValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecretValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecretValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecret
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecretValueFrom? ValueFrom { get; set; }
}

/// <summary>The multiple response type to request for in the OAuth authorization flow. This can possibly be a combination of set bits (e.g.: {id\_token, token}).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpecResponseType
{
    /// <summary>If true, authorization code is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary>If true, ID token is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("idToken")]
    public bool? IdToken { get; set; }

    /// <summary>If true, access token is returned from IdP's authorization endpoint.</summary>
    [JsonPropertyName("token")]
    public bool? Token { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpecTenantRef
{
    /// <summary>The tenant for the resource  Allowed value: The Google Cloud resource name of an `IdentityPlatformTenant` resource (format: `projects/{{project}}/tenants/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigSpec
{
    /// <summary>The client id of an OAuth client.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The client secret of the OAuth client, to enable OIDC code flow.</summary>
    [JsonPropertyName("clientSecret")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpecClientSecret? ClientSecret { get; set; }

    /// <summary>The config's display name set by developers.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>True if allows the user to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>For OIDC Idps, the issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The multiple response type to request for in the OAuth authorization flow. This can possibly be a combination of set bits (e.g.: {id\_token, token}).</summary>
    [JsonPropertyName("responseType")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpecResponseType? ResponseType { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpecTenantRef TenantRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IdentityPlatformTenantOAuthIDPConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IdentityPlatformTenantOAuthIDPConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IdentityPlatformTenantOAuthIDPConfigSpec>, IStatus<V1beta1IdentityPlatformTenantOAuthIDPConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IdentityPlatformTenantOAuthIDPConfig";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformtenantoauthidpconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IdentityPlatformTenantOAuthIDPConfigStatus? Status { get; set; }
}