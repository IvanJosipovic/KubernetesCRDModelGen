using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
/// <summary>The port associated with the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecEgressPort
{
    /// <summary>Label assigned to the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A valid non-negative integer port number.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>The protocol exposed on the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecEgress
{
    /// <summary>The IP(IPv4 or IPv6) or the Unix domain socket to which the listener should be bound to.</summary>
    [JsonPropertyName("bind")]
    public string? Bind { get; set; }

    /// <summary>When the bind address is an IP, the captureMode option dictates how traffic to the listener is expected to be captured (or not).  Valid Options: DEFAULT, IPTABLES, NONE</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }

    /// <summary>One or more service hosts exposed by the listener in `namespace/dnsName` format.</summary>
    [JsonPropertyName("hosts")]
    public IList<string> Hosts { get; set; }

    /// <summary>The port associated with the listener.</summary>
    [JsonPropertyName("port")]
    public V1beta1SidecarSpecEgressPort? Port { get; set; }
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecInboundConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecInboundConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecInboundConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1beta1SidecarSpecInboundConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary>Settings controlling the volume of connections Envoy will accept from the network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecInboundConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1SidecarSpecInboundConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1SidecarSpecInboundConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressConnectionPoolHttp
{
    /// <summary>Specify if http1.1 connection should be upgraded to http2 for the associated destination.  Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE</summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public string? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1beta1SidecarSpecIngressConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

/// <summary>Settings controlling the volume of connections Envoy will accept from the network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1beta1SidecarSpecIngressConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1beta1SidecarSpecIngressConnectionPoolTcp? Tcp { get; set; }
}

/// <summary>The port associated with the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressPort
{
    /// <summary>Label assigned to the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A valid non-negative integer port number.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>The protocol exposed on the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

/// <summary>Set of TLS related options that will enable TLS termination on the sidecar for requests originating from outside the mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecIngressTls
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
    public string? MaxProtocolVersion { get; set; }

    /// <summary>Optional: Minimum TLS protocol version.  Valid Options: TLS_AUTO, TLSV1_0, TLSV1_1, TLSV1_2, TLSV1_3</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>Optional: Indicates whether connections to this port should be secured using TLS.  Valid Options: PASSTHROUGH, SIMPLE, MUTUAL, AUTO_PASSTHROUGH, ISTIO_MUTUAL, OPTIONAL_MUTUAL</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

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
public partial class V1beta1SidecarSpecIngress
{
    /// <summary>The IP(IPv4 or IPv6) to which the listener should be bound.</summary>
    [JsonPropertyName("bind")]
    public string? Bind { get; set; }

    /// <summary>The captureMode option dictates how traffic to the listener is expected to be captured (or not).  Valid Options: DEFAULT, IPTABLES, NONE</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }

    /// <summary>Settings controlling the volume of connections Envoy will accept from the network.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta1SidecarSpecIngressConnectionPool? ConnectionPool { get; set; }

    /// <summary>The IP endpoint or Unix domain socket to which traffic should be forwarded to.</summary>
    [JsonPropertyName("defaultEndpoint")]
    public string? DefaultEndpoint { get; set; }

    /// <summary>The port associated with the listener.</summary>
    [JsonPropertyName("port")]
    public V1beta1SidecarSpecIngressPort Port { get; set; }

    /// <summary>Set of TLS related options that will enable TLS termination on the sidecar for requests originating from outside the mesh.</summary>
    [JsonPropertyName("tls")]
    public V1beta1SidecarSpecIngressTls? Tls { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecOutboundTrafficPolicyEgressProxyPort
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecOutboundTrafficPolicyEgressProxy
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1SidecarSpecOutboundTrafficPolicyEgressProxyPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

/// <summary>Configuration for the outbound traffic policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecOutboundTrafficPolicy
{
    /// <summary></summary>
    [JsonPropertyName("egressProxy")]
    public V1beta1SidecarSpecOutboundTrafficPolicyEgressProxy? EgressProxy { get; set; }

    /// <summary>  Valid Options: REGISTRY_ONLY, ALLOW_ANY</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this `Sidecar` configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Configuration affecting network reachability of a sidecar. See more details at: https://istio.io/docs/reference/config/networking/sidecar.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SidecarSpec
{
    /// <summary>Egress specifies the configuration of the sidecar for processing outbound traffic from the attached workload instance to other services in the mesh.</summary>
    [JsonPropertyName("egress")]
    public IList<V1beta1SidecarSpecEgress>? Egress { get; set; }

    /// <summary>Settings controlling the volume of connections Envoy will accept from the network.</summary>
    [JsonPropertyName("inboundConnectionPool")]
    public V1beta1SidecarSpecInboundConnectionPool? InboundConnectionPool { get; set; }

    /// <summary>Ingress specifies the configuration of the sidecar for processing inbound traffic to the attached workload instance.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1SidecarSpecIngress>? Ingress { get; set; }

    /// <summary>Configuration for the outbound traffic policy.</summary>
    [JsonPropertyName("outboundTrafficPolicy")]
    public V1beta1SidecarSpecOutboundTrafficPolicy? OutboundTrafficPolicy { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this `Sidecar` configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1beta1SidecarSpecWorkloadSelector? WorkloadSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Sidecar : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SidecarSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Sidecar";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "sidecars";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting network reachability of a sidecar. See more details at: https://istio.io/docs/reference/config/networking/sidecar.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1SidecarSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}