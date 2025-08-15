using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.cnrm.cloud.google.com;
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNoteNoteRef
{
    /// <summary>Required. The Drydock resource name of a Attestation. Authority Note, created by the user, in the format: `projects/*/notes/*`. This field may not be updated. An attestation by this attestor is stored as a Grafeas Attestation. Authority Occurrence that names a container image and that links to this Note. Grafeas is an external dependency.  Allowed value: The Google Cloud resource name of a `ContainerAnalysisNote` resource (format: `projects/{{project}}/notes/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A raw PKIX SubjectPublicKeyInfo format public key. NOTE: `id` may be explicitly provided by the caller when using this type of public key, but it MUST be a valid RFC3986 URI. If `id` is left blank, a default one will be computed based on the digest of the DER encoding of the public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNotePublicKeysPkixPublicKey
{
    /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in `public_key_pem` (i.e. this algorithm must match that of the public key). Possible values: SIGNATURE_ALGORITHM_UNSPECIFIED, RSA_PSS_2048_SHA256, RSA_PSS_3072_SHA256, RSA_PSS_4096_SHA256, RSA_PSS_4096_SHA512, RSA_SIGN_PKCS1_2048_SHA256, RSA_SIGN_PKCS1_3072_SHA256, RSA_SIGN_PKCS1_4096_SHA256, RSA_SIGN_PKCS1_4096_SHA512, ECDSA_P256_SHA256, EC_SIGN_P256_SHA256, ECDSA_P384_SHA384, EC_SIGN_P384_SHA384, ECDSA_P521_SHA512, EC_SIGN_P521_SHA512</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNotePublicKeys
{
    /// <summary>ASCII-armored representation of a PGP public key, as the entire output by the command `gpg --export --armor foo@example.com` (either LF or CRLF line endings). When using this field, `id` should be left blank. The BinAuthz API handlers will calculate the ID and fill it in automatically. BinAuthz computes this ID as the OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If `id` is provided by the caller, it will be overwritten by the API-calculated ID.</summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>Optional. A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The ID of this public key. Signatures verified by BinAuthz must include the ID of the public key that can be used to verify them, and that ID must match the contents of this field exactly. Additional restrictions on this field can be imposed based on which public key type is encapsulated. See the documentation on `public_key` cases below for details.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A raw PKIX SubjectPublicKeyInfo format public key. NOTE: `id` may be explicitly provided by the caller when using this type of public key, but it MUST be a valid RFC3986 URI. If `id` is left blank, a default one will be computed based on the digest of the DER encoding of the public key.</summary>
    [JsonPropertyName("pkixPublicKey")]
    public V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNotePublicKeysPkixPublicKey? PkixPublicKey { get; set; }
}

/// <summary>This specifies how an attestation will be read, and how it will be used during policy enforcement.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNote
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("noteRef")]
    public V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNoteNoteRef NoteRef { get; set; }

    /// <summary>Optional. Public keys that verify attestations signed by this attestor. This field may be updated. If this field is non-empty, one of the specified public keys must verify that an attestation was signed by this attestor for the image specified in the admission request. If this field is empty, this attestor always returns that no valid attestations exist.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNotePublicKeys>? PublicKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorSpec
{
    /// <summary>Optional. A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1BinaryAuthorizationAttestorSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>This specifies how an attestation will be read, and how it will be used during policy enforcement.</summary>
    [JsonPropertyName("userOwnedDrydockNote")]
    public V1beta1BinaryAuthorizationAttestorSpecUserOwnedDrydockNote? UserOwnedDrydockNote { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorStatusUserOwnedDrydockNote
{
    /// <summary>Output only. This field will contain the service account email address that this Attestor will use as the principal when querying Container Analysis. Attestor administrators must grant this service account the IAM role needed to read attestations from the in Container Analysis (`containeranalysis.notes.occurrences.viewer`). This email address is fixed for the lifetime of the Attestor, but callers should not make any other assumptions about the service account email; future versions may use an email based on a different naming pattern.</summary>
    [JsonPropertyName("delegationServiceAccountEmail")]
    public string? DelegationServiceAccountEmail { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationAttestorStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BinaryAuthorizationAttestorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Time when the attestor was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userOwnedDrydockNote")]
    public V1beta1BinaryAuthorizationAttestorStatusUserOwnedDrydockNote? UserOwnedDrydockNote { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BinaryAuthorizationAttestor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BinaryAuthorizationAttestorSpec>, IStatus<V1beta1BinaryAuthorizationAttestorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BinaryAuthorizationAttestor";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationattestors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1BinaryAuthorizationAttestorSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BinaryAuthorizationAttestorStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BinaryAuthorizationAttestorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BinaryAuthorizationAttestor>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BinaryAuthorizationAttestorList";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationattestors";
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
    public IList<V1beta1BinaryAuthorizationAttestor> Items { get; set; }
}