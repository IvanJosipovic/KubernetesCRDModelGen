using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
#nullable enable
/// <summary>APIAuth defines the authentication configuration for APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIAuthList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIAuth>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIAuthList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiauths";
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
    public IList<V1alpha1APIAuth> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIKey configures API key authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecApiKey
{
}
#nullable disable

#nullable enable
/// <summary>JWT configures JWT authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecJwt
{
    /// <summary>AppIDClaim is the name of the claim holding the identifier of the application. This field is sometimes named `client_id`.</summary>
    [JsonPropertyName("appIdClaim")]
    public string AppIdClaim { get; set; }

    /// <summary>ForwardHeaders specifies additional headers to forward with the request.</summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary>JWKSFile contains the JWKS file content for JWT verification.</summary>
    [JsonPropertyName("jwksFile")]
    public string? JwksFile { get; set; }

    /// <summary>JWKSURL is the URL to fetch the JWKS for JWT verification.</summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary>PublicKey is the PEM-encoded public key for JWT verification.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>SigningSecretName is the name of the Kubernetes Secret containing the signing secret. The secret must be of type Opaque and contain a key named 'value'.</summary>
    [JsonPropertyName("signingSecretName")]
    public string? SigningSecretName { get; set; }

    /// <summary>StripAuthorizationHeader determines whether to strip the Authorization header before forwarding the request.</summary>
    [JsonPropertyName("stripAuthorizationHeader")]
    public bool? StripAuthorizationHeader { get; set; }

    /// <summary>TokenNameClaim is the name of the claim holding the name of the token. This name, if provided, will be used in the metrics.</summary>
    [JsonPropertyName("tokenNameClaim")]
    public string? TokenNameClaim { get; set; }

    /// <summary>TokenQueryKey specifies the query parameter name for the JWT token.</summary>
    [JsonPropertyName("tokenQueryKey")]
    public string? TokenQueryKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The desired behavior of this APIAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpec
{
    /// <summary>APIKey configures API key authentication.</summary>
    [JsonPropertyName("apiKey")]
    public V1alpha1APIAuthSpecApiKey? ApiKey { get; set; }

    /// <summary>IsDefault specifies if this APIAuth should be used as the default API authentication method for the namespace. Only one APIAuth per namespace should have isDefault set to true.</summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }

    /// <summary>JWT configures JWT authentication.</summary>
    [JsonPropertyName("jwt")]
    public V1alpha1APIAuthSpecJwt? Jwt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The current status of this APIAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthStatus
{
    /// <summary>Hash is a hash representing the APIAuth.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIAuth defines the authentication configuration for APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIAuth : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIAuthSpec>, IStatus<V1alpha1APIAuthStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIAuth";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiauths";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIAuth.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIAuthSpec? Spec { get; set; }

    /// <summary>The current status of this APIAuth.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIAuthStatus? Status { get; set; }
}
#nullable disable
