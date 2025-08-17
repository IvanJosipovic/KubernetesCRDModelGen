using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
#nullable enable
/// <summary>ServersTransportTCP is the CRD implementation of a TCPServersTransport. If no tcpServersTransport is specified, a default one named default@internal will be used. The default@internal tcpServersTransport can be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/services/#serverstransport_3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServersTransportTCPList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServersTransportTCP>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServersTransportTCPList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "serverstransporttcps";
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
    public IList<V1alpha1ServersTransportTCP> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RootCA defines a reference to a Secret or a ConfigMap that holds a CA certificate. If both a Secret and a ConfigMap reference are defined, the Secret reference takes precedence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportTCPSpecTlsRootCAs
{
    /// <summary>ConfigMap defines the name of a ConfigMap that holds a CA certificate. The referenced ConfigMap must contain a certificate under either a tls.ca or a ca.crt key.</summary>
    [JsonPropertyName("configMap")]
    public string? ConfigMap { get; set; }

    /// <summary>Secret defines the name of a Secret that holds a CA certificate. The referenced Secret must contain a certificate under either a tls.ca or a ca.crt key.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Spiffe defines the SPIFFE configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportTCPSpecTlsSpiffe
{
    /// <summary>IDs defines the allowed SPIFFE IDs (takes precedence over the SPIFFE TrustDomain).</summary>
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }

    /// <summary>TrustDomain defines the allowed SPIFFE trust domain.</summary>
    [JsonPropertyName("trustDomain")]
    public string? TrustDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TLS defines the TLS configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportTCPSpecTls
{
    /// <summary>CertificatesSecrets defines a list of secret storing client certificates for mTLS.</summary>
    [JsonPropertyName("certificatesSecrets")]
    public IList<string>? CertificatesSecrets { get; set; }

    /// <summary>InsecureSkipVerify disables TLS certificate verification.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>MaxIdleConnsPerHost controls the maximum idle (keep-alive) to keep per-host. PeerCertURI defines the peer cert URI used to match against SAN URI during the peer certificate verification.</summary>
    [JsonPropertyName("peerCertURI")]
    public string? PeerCertURI { get; set; }

    /// <summary>RootCAs defines a list of CA certificate Secrets or ConfigMaps used to validate server certificates.</summary>
    [JsonPropertyName("rootCAs")]
    public IList<V1alpha1ServersTransportTCPSpecTlsRootCAs>? RootCAs { get; set; }

    /// <summary>RootCAsSecrets defines a list of CA secret used to validate self-signed certificate. Deprecated: RootCAsSecrets is deprecated, please use the RootCAs option instead.</summary>
    [JsonPropertyName("rootCAsSecrets")]
    public IList<string>? RootCAsSecrets { get; set; }

    /// <summary>ServerName defines the server name used to contact the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>Spiffe defines the SPIFFE configuration.</summary>
    [JsonPropertyName("spiffe")]
    public V1alpha1ServersTransportTCPSpecTlsSpiffe? Spiffe { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServersTransportTCPSpec defines the desired state of a ServersTransportTCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportTCPSpec
{
    /// <summary>DialKeepAlive is the interval between keep-alive probes for an active network connection. If zero, keep-alive probes are sent with a default value (currently 15 seconds), if supported by the protocol and operating system. Network protocols or operating systems that do not support keep-alives ignore this field. If negative, keep-alive probes are disabled.</summary>
    [JsonPropertyName("dialKeepAlive")]
    public IntstrIntOrString? DialKeepAlive { get; set; }

    /// <summary>DialTimeout is the amount of time to wait until a connection to a backend server can be established.</summary>
    [JsonPropertyName("dialTimeout")]
    public IntstrIntOrString? DialTimeout { get; set; }

    /// <summary>TerminationDelay defines the delay to wait before fully terminating the connection, after one connected peer has closed its writing capability.</summary>
    [JsonPropertyName("terminationDelay")]
    public IntstrIntOrString? TerminationDelay { get; set; }

    /// <summary>TLS defines the TLS configuration</summary>
    [JsonPropertyName("tls")]
    public V1alpha1ServersTransportTCPSpecTls? Tls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServersTransportTCP is the CRD implementation of a TCPServersTransport. If no tcpServersTransport is specified, a default one named default@internal will be used. The default@internal tcpServersTransport can be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.5/routing/services/#serverstransport_3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServersTransportTCP : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServersTransportTCPSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServersTransportTCP";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "serverstransporttcps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServersTransportTCPSpec defines the desired state of a ServersTransportTCP.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServersTransportTCPSpec Spec { get; set; }
}
#nullable disable
