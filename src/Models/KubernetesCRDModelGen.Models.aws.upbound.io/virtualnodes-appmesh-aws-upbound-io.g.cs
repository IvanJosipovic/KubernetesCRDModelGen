using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecForProviderMeshNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderMeshNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecForProviderMeshNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicy>? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendVirtualService>? VirtualService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp
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
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerHealthCheck
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

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetectionBaseEjectionDuration>? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetectionInterval>? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value. Minimum value of 0. Maximum value of 100.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerPortMapping
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
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpcIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpcPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttpIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttpPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2Idle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2PerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutTcpIdle>? Idle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeoutTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListenerTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerOutlierDetection>? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTimeout>? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormatJson
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
public partial class V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>Name of the AWS Cloud Map namespace to use. Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMap>? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecServiceDiscoveryDns>? Dns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecLogging>? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public IList<V1beta1VirtualNodeSpecForProviderSpecServiceDiscovery>? ServiceDiscovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1VirtualNodeSpecForProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1VirtualNodeSpecForProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualNodeSpecForProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecInitProviderMeshNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderMeshNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecInitProviderMeshNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicy>? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendVirtualService>? VirtualService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerHealthCheck
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

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetectionBaseEjectionDuration>? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetectionInterval>? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value. Minimum value of 0. Maximum value of 100.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerPortMapping
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttpIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttpPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2Idle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2PerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutTcpIdle>? Idle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeoutTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateFile
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListenerTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerOutlierDetection>? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTimeout>? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormatJson
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
public partial class V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>Name of the AWS Cloud Map namespace to use. Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMap>? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscoveryDns>? Dns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecLogging>? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpecServiceDiscovery>? ServiceDiscovery { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1VirtualNodeSpecInitProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1VirtualNodeSpecInitProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualNodeSpecInitProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualNodeSpec defines the desired state of VirtualNode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNodeSpecDeletionPolicyEnum>))]
    public V1beta1VirtualNodeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualNodeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualNodeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualNodeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualNodeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualNodeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualNodeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicy>? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendVirtualService>? VirtualService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate>? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicy>? ClientPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerHealthCheck
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

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetectionBaseEjectionDuration>? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetectionInterval>? Interval { get; set; }

    /// <summary>Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value. Minimum value of 0. Maximum value of 100.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerPortMapping
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttpIdle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttpPerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2Idle>? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2PerRequest>? PerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutTcpIdle>? Idle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutGrpc>? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeoutTcp>? Tcp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateFile
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateAcm>? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificateSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN's match.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch>? Match { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustFile>? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustSds>? Sds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidationTrust>? Trust { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListenerTls
{
    /// <summary>Virtual node's client's Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsCertificate>? Certificate { get; set; }

    /// <summary>Listener's TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTlsValidation>? Validation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerConnectionPool>? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerHealthCheck>? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerOutlierDetection>? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerPortMapping>? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTimeout>? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListenerTls>? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormatJson
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
public partial class V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormat>? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLogFile>? File { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecLoggingAccessLog>? AccessLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>Name of the AWS Cloud Map namespace to use. Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecServiceDiscoveryAwsCloudMap>? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecServiceDiscoveryDns>? Dns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecBackendDefaults>? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecLogging>? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpecServiceDiscovery>? ServiceDiscovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusAtProvider
{
    /// <summary>ARN of the virtual node.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the virtual node.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the virtual node.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the virtual node.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualNodeStatusAtProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatusConditions
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

/// <summary>VirtualNodeStatus defines the observed state of VirtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNodeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualNodeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualNodeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualNode is the Schema for the VirtualNodes API. Provides an AWS App Mesh virtual node resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualNode : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualNodeSpec>, IStatus<V1beta1VirtualNodeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualNode";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualnodes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNodeSpec defines the desired state of VirtualNode</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualNodeSpec Spec { get; set; }

    /// <summary>VirtualNodeStatus defines the observed state of VirtualNode.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualNodeStatus? Status { get; set; }
}