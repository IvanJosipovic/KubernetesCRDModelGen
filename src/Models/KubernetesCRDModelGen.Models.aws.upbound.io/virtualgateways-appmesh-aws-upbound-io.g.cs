using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
/// <summary>VirtualGateway is the Schema for the VirtualGateways API. Provides an AWS App Mesh virtual gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualGatewayList";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualgateways";
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
    public IList<V1beta1VirtualGateway> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelector? CertificateArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListenerTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpecLogging>? Logging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecForProvider
{
    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualGatewaySpecForProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelector? CertificateArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListenerTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpecLogging>? Logging { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualGatewaySpecInitProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualGatewaySpec defines the desired state of VirtualGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway's listener's Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListenerTls
{
    /// <summary>Virtual gateway's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpecLogging>? Logging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusAtProvider
{
    /// <summary>ARN of the virtual gateway.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the virtual gateway.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the virtual gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the virtual gateway.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualGatewayStatusAtProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatusConditions
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

/// <summary>VirtualGatewayStatus defines the observed state of VirtualGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualGateway is the Schema for the VirtualGateways API. Provides an AWS App Mesh virtual gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualGatewaySpec>, IStatus<V1beta1VirtualGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualGateway";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualgateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualGatewaySpec defines the desired state of VirtualGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualGatewaySpec Spec { get; set; }

    /// <summary>VirtualGatewayStatus defines the observed state of VirtualGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualGatewayStatus? Status { get; set; }
}