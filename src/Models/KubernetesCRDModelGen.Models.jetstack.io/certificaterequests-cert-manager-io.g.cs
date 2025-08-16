using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certmanager.io;
/// <summary>A CertificateRequest is used to request a signed certificate from one of the configured issuers.  All fields within the CertificateRequest's `spec` are immutable after creation. A CertificateRequest will either succeed or fail, as denoted by its `Ready` status condition and its `status.failureTime` field.  A CertificateRequest is a one-shot resource, meaning it represents a single point in time request for a certificate and cannot be re-used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CertificateRequestList : IKubernetesObject<V1ListMeta>, IItems<V1CertificateRequest>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CertificateRequestList";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificaterequests";
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
    public IList<V1CertificateRequest> Items { get; set; }
}

/// <summary>Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace.  The `name` field of the reference must always be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestSpecIssuerRef
{
    /// <summary>Group of the resource being referred to.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind of the resource being referred to.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the resource being referred to.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specification of the desired state of the CertificateRequest resource. https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestSpec
{
    /// <summary>Requested 'duration' (i.e. lifetime) of the Certificate. Note that the issuer may choose to ignore the requested duration, just like any other requested attribute.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Extra contains extra attributes of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.</summary>
    [JsonPropertyName("extra")]
    public IDictionary<string, IList<string>>? Extra { get; set; }

    /// <summary>Groups contains group membership of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Requested basic constraints isCA value. Note that the issuer may choose to ignore the requested isCA value, just like any other requested attribute.  NOTE: If the CSR in the `Request` field has a BasicConstraints extension, it must have the same isCA value as specified here.  If true, this will automatically add the `cert sign` usage to the list of requested `usages`.</summary>
    [JsonPropertyName("isCA")]
    public bool? IsCA { get; set; }

    /// <summary>Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace.  The `name` field of the reference must always be specified.</summary>
    [JsonPropertyName("issuerRef")]
    public V1CertificateRequestSpecIssuerRef IssuerRef { get; set; }

    /// <summary>The PEM-encoded X.509 certificate signing request to be submitted to the issuer for signing.  If the CSR has a BasicConstraints extension, its isCA attribute must match the `isCA` value of this CertificateRequest. If the CSR has a KeyUsage extension, its key usages must match the key usages in the `usages` field of this CertificateRequest. If the CSR has a ExtKeyUsage extension, its extended key usages must match the extended key usages in the `usages` field of this CertificateRequest.</summary>
    [JsonPropertyName("request")]
    public string Request { get; set; }

    /// <summary>UID contains the uid of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Requested key usages and extended key usages.  NOTE: If the CSR in the `Request` field has uses the KeyUsage or ExtKeyUsage extension, these extensions must have the same values as specified here without any additional values.  If unset, defaults to `digital signature` and `key encipherment`.</summary>
    [JsonPropertyName("usages")]
    public IList<string>? Usages { get; set; }

    /// <summary>Username contains the name of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>CertificateRequestCondition contains condition information for a CertificateRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestStatusConditions
{
    /// <summary>LastTransitionTime is the timestamp corresponding to the last status change of this condition.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message is a human readable description of the details of the last transition, complementing reason.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Reason is a brief machine readable explanation for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of the condition, known values are (`Ready`, `InvalidRequest`, `Approved`, `Denied`).</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status of the CertificateRequest. This is set and managed automatically. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestStatus
{
    /// <summary>The PEM encoded X.509 certificate of the signer, also known as the CA (Certificate Authority). This is set on a best-effort basis by different issuers. If not set, the CA is assumed to be unknown/not available.</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

    /// <summary>The PEM encoded X.509 certificate resulting from the certificate signing request. If not set, the CertificateRequest has either not been completed or has failed. More information on failure can be found by checking the `conditions` field.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>List of status conditions to indicate the status of a CertificateRequest. Known condition types are `Ready`, `InvalidRequest`, `Approved` and `Denied`.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1CertificateRequestStatusConditions>? Conditions { get; set; }

    /// <summary>FailureTime stores the time that this CertificateRequest failed. This is used to influence garbage collection and back-off.</summary>
    [JsonPropertyName("failureTime")]
    public string? FailureTime { get; set; }
}

/// <summary>A CertificateRequest is used to request a signed certificate from one of the configured issuers.  All fields within the CertificateRequest's `spec` are immutable after creation. A CertificateRequest will either succeed or fail, as denoted by its `Ready` status condition and its `status.failureTime` field.  A CertificateRequest is a one-shot resource, meaning it represents a single point in time request for a certificate and cannot be re-used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CertificateRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1CertificateRequestSpec>, IStatus<V1CertificateRequestStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CertificateRequest";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificaterequests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired state of the CertificateRequest resource. https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1CertificateRequestSpec? Spec { get; set; }

    /// <summary>Status of the CertificateRequest. This is set and managed automatically. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1CertificateRequestStatus? Status { get; set; }
}