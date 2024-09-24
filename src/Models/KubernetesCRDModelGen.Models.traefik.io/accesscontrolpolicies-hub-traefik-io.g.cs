using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
public partial class V1alpha1AccessControlPolicySpecApiKeyKeySource
{
    /// <summary>Cookie is the name of a cookie.</summary>
    [JsonPropertyName("cookie")]
    public string? Cookie { get; set; }

    /// <summary>Header is the name of a header.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>HeaderAuthScheme sets an optional auth scheme when Header is set to "Authorization". If set, this scheme is removed from the token, and all requests not including it are dropped.</summary>
    [JsonPropertyName("headerAuthScheme")]
    public string? HeaderAuthScheme { get; set; }

    /// <summary>Query is the name of a query parameter.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecApiKeyKeys
{
    /// <summary>ID is the unique identifier of the key.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Metadata holds arbitrary metadata for this key, can be used by ForwardHeaders.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Value is the SHAKE-256 hash (using 64 bytes) of the API key.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecApiKey
{
    /// <summary>ForwardHeaders instructs the middleware to forward key metadata as header values upon successful authentication.</summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary>KeySource defines how to extract API keys from requests.</summary>
    [JsonPropertyName("keySource")]
    public V1alpha1AccessControlPolicySpecApiKeyKeySource KeySource { get; set; }

    /// <summary>Keys define the set of authorized keys to access a protected resource.</summary>
    [JsonPropertyName("keys")]
    public IList<V1alpha1AccessControlPolicySpecApiKeyKeys>? Keys { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("forwardUsernameHeader")]
    public string? ForwardUsernameHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stripAuthorizationHeader")]
    public bool? StripAuthorizationHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecJwt
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public string? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jwksFile")]
    public string? JwksFile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("signingSecret")]
    public string? SigningSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("signingSecretBase64Encoded")]
    public bool? SigningSecretBase64Encoded { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stripAuthorizationHeader")]
    public bool? StripAuthorizationHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenQueryKey")]
    public string? TokenQueryKey { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOAuthIntroClientConfigTls
{
    /// <summary>CA sets the CA bundle used to sign the Authorization Server certificate.</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

    /// <summary>InsecureSkipVerify skips the Authorization Server certificate validation. For testing purposes only, do not use in production.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOAuthIntroClientConfig
{
    /// <summary>Headers to set when sending requests to the Authorization Server.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>MaxRetries defines the number of retries for introspection requests.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>TimeoutSeconds configures the maximum amount of seconds to wait before giving up on requests.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>TLS configures TLS communication with the Authorization Server.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1AccessControlPolicySpecOAuthIntroClientConfigTls? Tls { get; set; }

    /// <summary>TokenTypeHint is a hint to pass to the Authorization Server. See https://tools.ietf.org/html/rfc7662#section-2.1 for more information.</summary>
    [JsonPropertyName("tokenTypeHint")]
    public string? TokenTypeHint { get; set; }

    /// <summary>URL of the Authorization Server.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOAuthIntroTokenSource
{
    /// <summary>Cookie is the name of a cookie.</summary>
    [JsonPropertyName("cookie")]
    public string? Cookie { get; set; }

    /// <summary>Header is the name of a header.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>HeaderAuthScheme sets an optional auth scheme when Header is set to "Authorization". If set, this scheme is removed from the token, and all requests not including it are dropped.</summary>
    [JsonPropertyName("headerAuthScheme")]
    public string? HeaderAuthScheme { get; set; }

    /// <summary>Query is the name of a query parameter.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOAuthIntro
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public string? Claims { get; set; }

    /// <summary>AccessControlOAuthIntroClientConfig configures the OAuth 2.0 client for issuing token introspection requests.</summary>
    [JsonPropertyName("clientConfig")]
    public V1alpha1AccessControlPolicySpecOAuthIntroClientConfig ClientConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary>TokenSource describes how to extract tokens from HTTP requests. If multiple sources are set, the order is the following: header > query > cookie.</summary>
    [JsonPropertyName("tokenSource")]
    public V1alpha1AccessControlPolicySpecOAuthIntroTokenSource TokenSource { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcSecret
{
    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcSession
{
    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("refresh")]
    public bool? Refresh { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcStateCookie
{
    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidc
{
    /// <summary></summary>
    [JsonPropertyName("authParams")]
    public IDictionary<string, string>? AuthParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("claims")]
    public string? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAuthRedirectionPaths")]
    public IList<string>? DisableAuthRedirectionPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary>
    [JsonPropertyName("secret")]
    public V1alpha1AccessControlPolicySpecOidcSecret? Secret { get; set; }

    /// <summary>Session holds session configuration.</summary>
    [JsonPropertyName("session")]
    public V1alpha1AccessControlPolicySpecOidcSession? Session { get; set; }

    /// <summary>StateCookie holds state cookie configuration.</summary>
    [JsonPropertyName("stateCookie")]
    public V1alpha1AccessControlPolicySpecOidcStateCookie? StateCookie { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcGoogleSecret
{
    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcGoogleSession
{
    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("refresh")]
    public bool? Refresh { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcGoogleStateCookie
{
    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

public partial class V1alpha1AccessControlPolicySpecOidcGoogle
{
    /// <summary></summary>
    [JsonPropertyName("authParams")]
    public IDictionary<string, string>? AuthParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Emails are the allowed emails to connect.</summary>
    [JsonPropertyName("emails")]
    public IList<string>? Emails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary>
    [JsonPropertyName("secret")]
    public V1alpha1AccessControlPolicySpecOidcGoogleSecret? Secret { get; set; }

    /// <summary>Session holds session configuration.</summary>
    [JsonPropertyName("session")]
    public V1alpha1AccessControlPolicySpecOidcGoogleSession? Session { get; set; }

    /// <summary>StateCookie holds state cookie configuration.</summary>
    [JsonPropertyName("stateCookie")]
    public V1alpha1AccessControlPolicySpecOidcGoogleStateCookie? StateCookie { get; set; }
}

public partial class V1alpha1AccessControlPolicySpec
{
    /// <summary>AccessControlPolicyAPIKey configure an APIKey control policy.</summary>
    [JsonPropertyName("apiKey")]
    public V1alpha1AccessControlPolicySpecApiKey? ApiKey { get; set; }

    /// <summary>AccessControlPolicyBasicAuth holds the HTTP basic authentication configuration.</summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1AccessControlPolicySpecBasicAuth? BasicAuth { get; set; }

    /// <summary>AccessControlPolicyJWT configures a JWT access control policy.</summary>
    [JsonPropertyName("jwt")]
    public V1alpha1AccessControlPolicySpecJwt? Jwt { get; set; }

    /// <summary>AccessControlOAuthIntro configures an OAuth 2.0 Token Introspection access control policy.</summary>
    [JsonPropertyName("oAuthIntro")]
    public V1alpha1AccessControlPolicySpecOAuthIntro? OAuthIntro { get; set; }

    /// <summary>AccessControlPolicyOIDC holds the OIDC authentication configuration.</summary>
    [JsonPropertyName("oidc")]
    public V1alpha1AccessControlPolicySpecOidc? Oidc { get; set; }

    /// <summary>AccessControlPolicyOIDCGoogle holds the Google OIDC authentication configuration.</summary>
    [JsonPropertyName("oidcGoogle")]
    public V1alpha1AccessControlPolicySpecOidcGoogle? OidcGoogle { get; set; }
}

public partial class V1alpha1AccessControlPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("specHash")]
    public string? SpecHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessControlPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccessControlPolicySpec>, IStatus<V1alpha1AccessControlPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessControlPolicy";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "accesscontrolpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessControlPolicySpec configures an access control policy.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AccessControlPolicySpec? Spec { get; set; }

    /// <summary>The current status of this access control policy.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AccessControlPolicyStatus? Status { get; set; }
}