using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.azuread.upbound.io;
/// <summary>A ProviderConfig configures the AzureAD provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProviderConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ProviderConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProviderConfigList";
    public const string KubeGroup = "azuread.upbound.io";
    public const string KubePluralName = "providerconfigs";
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
    public IList<V1beta1ProviderConfig> Items { get; set; }
}

/// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsSecretRef
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

/// <summary>Credentials required to authenticate to this provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentials
{
    /// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("env")]
    public V1beta1ProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpec
{
    /// <summary>ClientID is the user-assigned managed identity's ID when Credentials.Source is `InjectedIdentity`. If unset and Credentials.Source is `InjectedIdentity`, then a system-assigned managed identity is used. Required if Credentials.Source is OIDCTokenFile.</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>Credentials required to authenticate to this provider.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1ProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>The Cloud Environment which should be used. Possible values are "public", "usgovernment", "german", and "china". Defaults to "public".</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>MSIEndpoint is the optional path to a custom endpoint for Managed Service Identity.</summary>
    [JsonPropertyName("msiEndpoint")]
    public string? MsiEndpoint { get; set; }

    /// <summary>OIDCTokenFilePath is the optional path to a token file that allows to access a managed identity.</summary>
    [JsonPropertyName("oidcTokenFilePath")]
    public string? OidcTokenFilePath { get; set; }

    /// <summary>TenantID is the Azure AD tenant ID to be used. If unset, tenant ID from Credentials will be used. Required if Credentials.Source is InjectedIdentity, OIDCTokenFile.</summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ProviderConfig configures the AzureAD provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProviderConfigSpec>, IStatus<V1beta1ProviderConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProviderConfig";
    public const string KubeGroup = "azuread.upbound.io";
    public const string KubePluralName = "providerconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProviderConfigStatus? Status { get; set; }
}