using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
public enum V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum
{
    [EnumMember(Value = "NoClientCert"), JsonStringEnumMemberName("NoClientCert")]
    /// <summary>NoClientCert</summary>
    NoClientCert,
    [EnumMember(Value = "RequestClientCert"), JsonStringEnumMemberName("RequestClientCert")]
    /// <summary>RequestClientCert</summary>
    RequestClientCert,
    [EnumMember(Value = "RequireAnyClientCert"), JsonStringEnumMemberName("RequireAnyClientCert")]
    /// <summary>RequireAnyClientCert</summary>
    RequireAnyClientCert,
    [EnumMember(Value = "VerifyClientCertIfGiven"), JsonStringEnumMemberName("VerifyClientCertIfGiven")]
    /// <summary>VerifyClientCertIfGiven</summary>
    VerifyClientCertIfGiven,
    [EnumMember(Value = "RequireAndVerifyClientCert"), JsonStringEnumMemberName("RequireAndVerifyClientCert")]
    /// <summary>RequireAndVerifyClientCert</summary>
    RequireAndVerifyClientCert
}

/// <summary>ClientAuth defines the server's policy for TLS Client Authentication.</summary>
public partial class V1alpha1TLSOptionSpecClientAuth
{
    /// <summary>ClientAuthType defines the client authentication type to apply.</summary>
    [JsonPropertyName("clientAuthType")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum>))]
    public V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum? ClientAuthType { get; set; }

    /// <summary>SecretNames defines the names of the referenced Kubernetes Secret storing certificate details.</summary>
    [JsonPropertyName("secretNames")]
    public IList<string>? SecretNames { get; set; }
}

/// <summary>TLSOptionSpec defines the desired state of a TLSOption.</summary>
public partial class V1alpha1TLSOptionSpec
{
    /// <summary>ALPNProtocols defines the list of supported application level protocols for the TLS handshake, in order of preference. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#alpn-protocols</summary>
    [JsonPropertyName("alpnProtocols")]
    public IList<string>? AlpnProtocols { get; set; }

    /// <summary>CipherSuites defines the list of supported cipher suites for TLS versions up to TLS 1.2. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#cipher-suites</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>ClientAuth defines the server's policy for TLS Client Authentication.</summary>
    [JsonPropertyName("clientAuth")]
    public V1alpha1TLSOptionSpecClientAuth? ClientAuth { get; set; }

    /// <summary>CurvePreferences defines the preferred elliptic curves in a specific order. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#curve-preferences</summary>
    [JsonPropertyName("curvePreferences")]
    public IList<string>? CurvePreferences { get; set; }

    /// <summary>MaxVersion defines the maximum TLS version that Traefik will accept. Possible values: VersionTLS10, VersionTLS11, VersionTLS12, VersionTLS13. Default: None.</summary>
    [JsonPropertyName("maxVersion")]
    public string? MaxVersion { get; set; }

    /// <summary>MinVersion defines the minimum TLS version that Traefik will accept. Possible values: VersionTLS10, VersionTLS11, VersionTLS12, VersionTLS13. Default: VersionTLS10.</summary>
    [JsonPropertyName("minVersion")]
    public string? MinVersion { get; set; }

    /// <summary>PreferServerCipherSuites defines whether the server chooses a cipher suite among his own instead of among the client's. It is enabled automatically when minVersion or maxVersion is set. Deprecated: https://github.com/golang/go/issues/45430</summary>
    [JsonPropertyName("preferServerCipherSuites")]
    public bool? PreferServerCipherSuites { get; set; }

    /// <summary>SniStrict defines whether Traefik allows connections from clients connections that do not specify a server_name extension.</summary>
    [JsonPropertyName("sniStrict")]
    public bool? SniStrict { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>TLSOption is the CRD implementation of a Traefik TLS Option, allowing to configure some parameters of the TLS connection. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#tls-options</summary>
public partial class V1alpha1TLSOption : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TLSOptionSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TLSOption";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "tlsoptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TLSOptionSpec defines the desired state of a TLSOption.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TLSOptionSpec Spec { get; set; }
}