using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>ForwardingTimeouts defines the timeouts for requests forwarded to the backend servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportSpecForwardingTimeouts
{
    /// <summary>DialTimeout is the amount of time to wait until a connection to a backend server can be established.</summary>
    [JsonPropertyName("dialTimeout")]
    public IntstrIntOrString? DialTimeout { get; set; }

    /// <summary>IdleConnTimeout is the maximum period for which an idle HTTP keep-alive connection will remain open before closing itself.</summary>
    [JsonPropertyName("idleConnTimeout")]
    public IntstrIntOrString? IdleConnTimeout { get; set; }

    /// <summary>PingTimeout is the timeout after which the HTTP/2 connection will be closed if a response to ping is not received.</summary>
    [JsonPropertyName("pingTimeout")]
    public IntstrIntOrString? PingTimeout { get; set; }

    /// <summary>ReadIdleTimeout is the timeout after which a health check using ping frame will be carried out if no frame is received on the HTTP/2 connection.</summary>
    [JsonPropertyName("readIdleTimeout")]
    public IntstrIntOrString? ReadIdleTimeout { get; set; }

    /// <summary>ResponseHeaderTimeout is the amount of time to wait for a server's response headers after fully writing the request (including its body, if any).</summary>
    [JsonPropertyName("responseHeaderTimeout")]
    public IntstrIntOrString? ResponseHeaderTimeout { get; set; }
}

/// <summary>RootCA defines a reference to a Secret or a ConfigMap that holds a CA certificate. If both a Secret and a ConfigMap reference are defined, the Secret reference takes precedence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportSpecRootCAs
{
    /// <summary>ConfigMap defines the name of a ConfigMap that holds a CA certificate. The referenced ConfigMap must contain a certificate under either a tls.ca or a ca.crt key.</summary>
    [JsonPropertyName("configMap")]
    public string? ConfigMap { get; set; }

    /// <summary>Secret defines the name of a Secret that holds a CA certificate. The referenced Secret must contain a certificate under either a tls.ca or a ca.crt key.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

/// <summary>Spiffe defines the SPIFFE configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportSpecSpiffe
{
    /// <summary>IDs defines the allowed SPIFFE IDs (takes precedence over the SPIFFE TrustDomain).</summary>
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }

    /// <summary>TrustDomain defines the allowed SPIFFE trust domain.</summary>
    [JsonPropertyName("trustDomain")]
    public string? TrustDomain { get; set; }
}

/// <summary>ServersTransportSpec defines the desired state of a ServersTransport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServersTransportSpec
{
    /// <summary>CertificatesSecrets defines a list of secret storing client certificates for mTLS.</summary>
    [JsonPropertyName("certificatesSecrets")]
    public IList<string>? CertificatesSecrets { get; set; }

    /// <summary>DisableHTTP2 disables HTTP/2 for connections with backend servers.</summary>
    [JsonPropertyName("disableHTTP2")]
    public bool? DisableHTTP2 { get; set; }

    /// <summary>ForwardingTimeouts defines the timeouts for requests forwarded to the backend servers.</summary>
    [JsonPropertyName("forwardingTimeouts")]
    public V1alpha1ServersTransportSpecForwardingTimeouts? ForwardingTimeouts { get; set; }

    /// <summary>InsecureSkipVerify disables SSL certificate verification.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>MaxIdleConnsPerHost controls the maximum idle (keep-alive) to keep per-host.</summary>
    [JsonPropertyName("maxIdleConnsPerHost")]
    public int? MaxIdleConnsPerHost { get; set; }

    /// <summary>PeerCertURI defines the peer cert URI used to match against SAN URI during the peer certificate verification.</summary>
    [JsonPropertyName("peerCertURI")]
    public string? PeerCertURI { get; set; }

    /// <summary>RootCAs defines a list of CA certificate Secrets or ConfigMaps used to validate server certificates.</summary>
    [JsonPropertyName("rootCAs")]
    public IList<V1alpha1ServersTransportSpecRootCAs>? RootCAs { get; set; }

    /// <summary>RootCAsSecrets defines a list of CA secret used to validate self-signed certificate. Deprecated: RootCAsSecrets is deprecated, please use the RootCAs option instead.</summary>
    [JsonPropertyName("rootCAsSecrets")]
    public IList<string>? RootCAsSecrets { get; set; }

    /// <summary>ServerName defines the server name used to contact the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>Spiffe defines the SPIFFE configuration.</summary>
    [JsonPropertyName("spiffe")]
    public V1alpha1ServersTransportSpecSpiffe? Spiffe { get; set; }
}

/// <summary>ServersTransport is the CRD implementation of a ServersTransport. If no serversTransport is specified, the default@internal will be used. The default@internal serversTransport is created from the static configuration. More info: https://doc.traefik.io/traefik/v3.4/routing/services/#serverstransport_1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServersTransport : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServersTransportSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServersTransport";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "serverstransports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServersTransportSpec defines the desired state of a ServersTransport.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServersTransportSpec Spec { get; set; }
}

/// <summary>ServersTransport is the CRD implementation of a ServersTransport. If no serversTransport is specified, the default@internal will be used. The default@internal serversTransport is created from the static configuration. More info: https://doc.traefik.io/traefik/v3.4/routing/services/#serverstransport_1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServersTransportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServersTransport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServersTransportList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "serverstransports";
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
    public IList<V1alpha1ServersTransport> Items { get; set; }
}