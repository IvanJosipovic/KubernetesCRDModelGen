using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>UI holds the UI customization options.</summary>
public partial class V1alpha1APIPortalSpecUi
{
    /// <summary>LogoURL is the public URL of the logo.</summary>
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }
}

/// <summary>The desired behavior of this APIPortal.</summary>
public partial class V1alpha1APIPortalSpec
{
    /// <summary>Description of the APIPortal.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Title is the public facing name of the APIPortal.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>TrustedURLs are the urls that are trusted by the OAuth 2.0 authorization server.</summary>
    [JsonPropertyName("trustedUrls")]
    public IList<string> TrustedUrls { get; set; }

    /// <summary>UI holds the UI customization options.</summary>
    [JsonPropertyName("ui")]
    public V1alpha1APIPortalSpecUi? Ui { get; set; }
}

/// <summary>OIDC is the OIDC configuration for accessing the exposed APIPortal WebUI.</summary>
public partial class V1alpha1APIPortalStatusOidc
{
    /// <summary>ClientID is the OIDC ClientID for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>CompanyClaim is the name of the JWT claim containing the user company.</summary>
    [JsonPropertyName("companyClaim")]
    public string? CompanyClaim { get; set; }

    /// <summary>EmailClaim is the name of the JWT claim containing the user email.</summary>
    [JsonPropertyName("emailClaim")]
    public string? EmailClaim { get; set; }

    /// <summary>FirstnameClaim is the name of the JWT claim containing the user firstname.</summary>
    [JsonPropertyName("firstnameClaim")]
    public string? FirstnameClaim { get; set; }

    /// <summary>Generic indicates whether or not the APIPortal authentication relies on Generic OIDC.</summary>
    [JsonPropertyName("generic")]
    public bool? Generic { get; set; }

    /// <summary>GroupsClaim is the name of the JWT claim containing the user groups.</summary>
    [JsonPropertyName("groupsClaim")]
    public string? GroupsClaim { get; set; }

    /// <summary>Issuer is the OIDC issuer for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>LastnameClaim is the name of the JWT claim containing the user lastname.</summary>
    [JsonPropertyName("lastnameClaim")]
    public string? LastnameClaim { get; set; }

    /// <summary>Scopes is the OIDC scopes for getting user attributes during the authentication to the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("scopes")]
    public string? Scopes { get; set; }

    /// <summary>SecretName is the name of the secret containing the OIDC ClientSecret for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>SyncedAttributes configure the user attributes to sync.</summary>
    [JsonPropertyName("syncedAttributes")]
    public IList<string>? SyncedAttributes { get; set; }

    /// <summary>UserIDClaim is the name of the JWT claim containing the user ID.</summary>
    [JsonPropertyName("userIdClaim")]
    public string? UserIdClaim { get; set; }
}

/// <summary>The current status of this APIPortal.</summary>
public partial class V1alpha1APIPortalStatus
{
    /// <summary>Hash is a hash representing the APIPortal.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>OIDC is the OIDC configuration for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("oidc")]
    public V1alpha1APIPortalStatusOidc? Oidc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>APIPortal defines a developer portal for accessing the documentation of APIs.</summary>
public partial class V1alpha1APIPortal : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPortalSpec>, IStatus<V1alpha1APIPortalStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortal";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportals";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPortal.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPortalSpec? Spec { get; set; }

    /// <summary>The current status of this APIPortal.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPortalStatus? Status { get; set; }
}