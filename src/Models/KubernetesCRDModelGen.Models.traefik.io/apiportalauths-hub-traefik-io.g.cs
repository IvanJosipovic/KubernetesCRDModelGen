using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>Claims configures JWT claim mappings for user attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidcClaims
{
    /// <summary>Company is the JWT claim for user company.</summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>Email is the JWT claim for user email.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Firstname is the JWT claim for user first name.</summary>
    [JsonPropertyName("firstname")]
    public string? Firstname { get; set; }

    /// <summary>Groups is the JWT claim for user groups. This field is required for authorization.</summary>
    [JsonPropertyName("groups")]
    public string Groups { get; set; }

    /// <summary>Lastname is the JWT claim for user last name.</summary>
    [JsonPropertyName("lastname")]
    public string? Lastname { get; set; }

    /// <summary>UserID is the JWT claim for user ID mapping.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>OIDC configures the OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidc
{
    /// <summary>Claims configures JWT claim mappings for user attributes.</summary>
    [JsonPropertyName("claims")]
    public V1alpha1APIPortalAuthSpecOidcClaims Claims { get; set; }

    /// <summary>IssuerURL is the OIDC provider issuer URL.</summary>
    [JsonPropertyName("issuerUrl")]
    public string IssuerUrl { get; set; }

    /// <summary>Scopes is a list of OAuth2 scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>SecretName is the name of the Kubernetes Secret containing clientId and clientSecret keys.</summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }

    /// <summary>SyncedAttributes is a list of additional attributes to sync from the OIDC provider. Each attribute must correspond to a configured claim field.</summary>
    [JsonPropertyName("syncedAttributes")]
    public IList<string>? SyncedAttributes { get; set; }
}

/// <summary>The desired behavior of this APIPortalAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpec
{
    /// <summary>OIDC configures the OIDC authentication.</summary>
    [JsonPropertyName("oidc")]
    public V1alpha1APIPortalAuthSpecOidc Oidc { get; set; }
}

/// <summary>The current status of this APIPortalAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthStatus
{
    /// <summary>Hash is a hash representing the APIPortalAuth.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIPortalAuth defines the authentication configuration for an APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortalAuth : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPortalAuthSpec>, IStatus<V1alpha1APIPortalAuthStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortalAuth";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportalauths";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPortalAuth.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPortalAuthSpec? Spec { get; set; }

    /// <summary>The current status of this APIPortalAuth.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPortalAuthStatus? Status { get; set; }
}

/// <summary>APIPortalAuth defines the authentication configuration for an APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortalAuthList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIPortalAuth>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortalAuthList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportalauths";
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
    public IList<V1alpha1APIPortalAuth> Items { get; set; }
}