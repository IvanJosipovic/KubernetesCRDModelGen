using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
/// <summary>The Port on which the proxy should listen for incoming connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewaySpecServersPort
{
    /// <summary>Label assigned to the port.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A valid non-negative integer port number.</summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>The protocol exposed on the port.</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GatewaySpecServersTlsMaxProtocolVersionEnum
{
    [EnumMember(Value = "TLS_AUTO"), JsonStringEnumMemberName("TLS_AUTO")]
    /// <summary>TLS_AUTO</summary>
    TLSAUTO,
    [EnumMember(Value = "TLSV1_0"), JsonStringEnumMemberName("TLSV1_0")]
    /// <summary>TLSV1_0</summary>
    TLSV10,
    [EnumMember(Value = "TLSV1_1"), JsonStringEnumMemberName("TLSV1_1")]
    /// <summary>TLSV1_1</summary>
    TLSV11,
    [EnumMember(Value = "TLSV1_2"), JsonStringEnumMemberName("TLSV1_2")]
    /// <summary>TLSV1_2</summary>
    TLSV12,
    [EnumMember(Value = "TLSV1_3"), JsonStringEnumMemberName("TLSV1_3")]
    /// <summary>TLSV1_3</summary>
    TLSV13
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GatewaySpecServersTlsMinProtocolVersionEnum
{
    [EnumMember(Value = "TLS_AUTO"), JsonStringEnumMemberName("TLS_AUTO")]
    /// <summary>TLS_AUTO</summary>
    TLSAUTO,
    [EnumMember(Value = "TLSV1_0"), JsonStringEnumMemberName("TLSV1_0")]
    /// <summary>TLSV1_0</summary>
    TLSV10,
    [EnumMember(Value = "TLSV1_1"), JsonStringEnumMemberName("TLSV1_1")]
    /// <summary>TLSV1_1</summary>
    TLSV11,
    [EnumMember(Value = "TLSV1_2"), JsonStringEnumMemberName("TLSV1_2")]
    /// <summary>TLSV1_2</summary>
    TLSV12,
    [EnumMember(Value = "TLSV1_3"), JsonStringEnumMemberName("TLSV1_3")]
    /// <summary>TLSV1_3</summary>
    TLSV13
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GatewaySpecServersTlsModeEnum
{
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    /// <summary>PASSTHROUGH</summary>
    PASSTHROUGH,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    /// <summary>SIMPLE</summary>
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    /// <summary>MUTUAL</summary>
    MUTUAL,
    [EnumMember(Value = "AUTO_PASSTHROUGH"), JsonStringEnumMemberName("AUTO_PASSTHROUGH")]
    /// <summary>AUTO_PASSTHROUGH</summary>
    AUTOPASSTHROUGH,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    /// <summary>ISTIO_MUTUAL</summary>
    ISTIOMUTUAL,
    [EnumMember(Value = "OPTIONAL_MUTUAL"), JsonStringEnumMemberName("OPTIONAL_MUTUAL")]
    /// <summary>OPTIONAL_MUTUAL</summary>
    OPTIONALMUTUAL
}

/// <summary>Set of TLS related options that govern the server's behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewaySpecServersTls
{
    /// <summary>REQUIRED if mode is `MUTUAL` or `OPTIONAL_MUTUAL`.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented client side certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>Optional: If specified, only support the specified cipher list.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>For gateways running on Kubernetes, the name of the secret that holds the TLS certs including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>If set to true, the load balancer will send a 301 redirect for all http connections, asking the clients to use HTTPS.</summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>Optional: Maximum TLS protocol version.  Valid Options: TLS_AUTO, TLSV1_0, TLSV1_1, TLSV1_2, TLSV1_3</summary>
    [JsonPropertyName("maxProtocolVersion")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewaySpecServersTlsMaxProtocolVersionEnum>))]
    public V1beta1GatewaySpecServersTlsMaxProtocolVersionEnum? MaxProtocolVersion { get; set; }

    /// <summary>Optional: Minimum TLS protocol version.  Valid Options: TLS_AUTO, TLSV1_0, TLSV1_1, TLSV1_2, TLSV1_3</summary>
    [JsonPropertyName("minProtocolVersion")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewaySpecServersTlsMinProtocolVersionEnum>))]
    public V1beta1GatewaySpecServersTlsMinProtocolVersionEnum? MinProtocolVersion { get; set; }

    /// <summary>Optional: Indicates whether connections to this port should be secured using TLS.  Valid Options: PASSTHROUGH, SIMPLE, MUTUAL, AUTO_PASSTHROUGH, ISTIO_MUTUAL, OPTIONAL_MUTUAL</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewaySpecServersTlsModeEnum>))]
    public V1beta1GatewaySpecServersTlsModeEnum? Mode { get; set; }

    /// <summary>REQUIRED if mode is `SIMPLE` or `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>REQUIRED if mode is `SIMPLE` or `MUTUAL`.</summary>
    [JsonPropertyName("serverCertificate")]
    public string? ServerCertificate { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate presented by the client.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }

    /// <summary>An optional list of hex-encoded SHA-256 hashes of the authorized client certificates.</summary>
    [JsonPropertyName("verifyCertificateHash")]
    public IList<string>? VerifyCertificateHash { get; set; }

    /// <summary>An optional list of base64-encoded SHA-256 hashes of the SPKIs of authorized client certificates.</summary>
    [JsonPropertyName("verifyCertificateSpki")]
    public IList<string>? VerifyCertificateSpki { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewaySpecServers
{
    /// <summary>The ip or the Unix domain socket to which the listener should be bound to.</summary>
    [JsonPropertyName("bind")]
    public string? Bind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultEndpoint")]
    public string? DefaultEndpoint { get; set; }

    /// <summary>One or more hosts exposed by this gateway.</summary>
    [JsonPropertyName("hosts")]
    public IList<string> Hosts { get; set; }

    /// <summary>An optional name of the server, when set must be unique across all servers.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Port on which the proxy should listen for incoming connections.</summary>
    [JsonPropertyName("port")]
    public V1beta1GatewaySpecServersPort Port { get; set; }

    /// <summary>Set of TLS related options that govern the server's behavior.</summary>
    [JsonPropertyName("tls")]
    public V1beta1GatewaySpecServersTls? Tls { get; set; }
}

/// <summary>Configuration affecting edge load balancer. See more details at: https://istio.io/docs/reference/config/networking/gateway.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewaySpec
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which this gateway configuration should be applied.</summary>
    [JsonPropertyName("selector")]
    public IDictionary<string, string>? Selector { get; set; }

    /// <summary>A list of server specifications.</summary>
    [JsonPropertyName("servers")]
    public IList<V1beta1GatewaySpecServers>? Servers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Gateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GatewaySpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Gateway";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "gateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting edge load balancer. See more details at: https://istio.io/docs/reference/config/networking/gateway.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1GatewaySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}