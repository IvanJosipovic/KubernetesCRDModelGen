using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.gcp.upbound.io;
public enum V1beta1AttestorSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum>))]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum>))]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicy? Policy { get; set; }
}

public enum V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum>))]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum>))]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in publicKeyPem (i.e. this algorithm must match that of the public key).</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>ASCII-armored representation of a PGP public key, as the entire output by the command gpg --export --armor foo@example.com (either LF or CRLF line endings). When using this field, id should be left blank. The BinAuthz API handlers will calculate the ID and fill it in automatically. BinAuthz computes this ID as the OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If id is provided by the caller, it will be overwritten by the API-calculated ID.</summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The ID of this public key. Signatures verified by BinAuthz must include the ID of the public key that can be used to verify them, and that ID must match the contents of this field exactly. Additional restrictions on this field can be imposed based on which public key type is encapsulated. See the documentation on publicKey cases below for details.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A raw PKIX SubjectPublicKeyInfo format public key. NOTE: id may be explicitly provided by the caller when using this type of public key, but it MUST be a valid RFC3986 URI. If id is left blank, a default one will be computed based on the digest of the DER encoding of the public key. Structure is documented below.</summary>
    [JsonPropertyName("pkixPublicKey")]
    public IList<V1beta1AttestorSpecForProviderAttestationAuthorityNotePublicKeysPkixPublicKey>? PkixPublicKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecForProviderAttestationAuthorityNote
{
    /// <summary>The resource name of a ATTESTATION_AUTHORITY Note, created by the user. If the Note is in a different project from the Attestor, it should be specified in the format projects/*/notes/* (or the legacy providers/*/notes/*). This field may not be updated. An attestation by this attestor is stored as a Container Analysis ATTESTATION_AUTHORITY Occurrence that names a container image and that links to this Note.</summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceRef")]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRef? NoteReferenceRef { get; set; }

    /// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceSelector")]
    public V1beta1AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelector? NoteReferenceSelector { get; set; }

    /// <summary>Public keys that verify attestations signed by this attestor. This field may be updated. If this field is non-empty, one of the specified public keys must verify that an attestation was signed by this attestor for the image specified in the admission request. If this field is empty, this attestor always returns that no valid attestations exist. Structure is documented below.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta1AttestorSpecForProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecForProvider
{
    /// <summary>A Container Analysis ATTESTATION_AUTHORITY Note, created by the user. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public IList<V1beta1AttestorSpecForProviderAttestationAuthorityNote>? AttestationAuthorityNote { get; set; }

    /// <summary>A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum>))]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum>))]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicy? Policy { get; set; }
}

public enum V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum>))]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum>))]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in publicKeyPem (i.e. this algorithm must match that of the public key).</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>ASCII-armored representation of a PGP public key, as the entire output by the command gpg --export --armor foo@example.com (either LF or CRLF line endings). When using this field, id should be left blank. The BinAuthz API handlers will calculate the ID and fill it in automatically. BinAuthz computes this ID as the OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If id is provided by the caller, it will be overwritten by the API-calculated ID.</summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The ID of this public key. Signatures verified by BinAuthz must include the ID of the public key that can be used to verify them, and that ID must match the contents of this field exactly. Additional restrictions on this field can be imposed based on which public key type is encapsulated. See the documentation on publicKey cases below for details.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A raw PKIX SubjectPublicKeyInfo format public key. NOTE: id may be explicitly provided by the caller when using this type of public key, but it MUST be a valid RFC3986 URI. If id is left blank, a default one will be computed based on the digest of the DER encoding of the public key. Structure is documented below.</summary>
    [JsonPropertyName("pkixPublicKey")]
    public IList<V1beta1AttestorSpecInitProviderAttestationAuthorityNotePublicKeysPkixPublicKey>? PkixPublicKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorSpecInitProviderAttestationAuthorityNote
{
    /// <summary>The resource name of a ATTESTATION_AUTHORITY Note, created by the user. If the Note is in a different project from the Attestor, it should be specified in the format projects/*/notes/* (or the legacy providers/*/notes/*). This field may not be updated. An attestation by this attestor is stored as a Container Analysis ATTESTATION_AUTHORITY Occurrence that names a container image and that links to this Note.</summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceRef")]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRef? NoteReferenceRef { get; set; }

    /// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceSelector")]
    public V1beta1AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelector? NoteReferenceSelector { get; set; }

    /// <summary>Public keys that verify attestations signed by this attestor. This field may be updated. If this field is non-empty, one of the specified public keys must verify that an attestation was signed by this attestor for the image specified in the admission request. If this field is empty, this attestor always returns that no valid attestations exist. Structure is documented below.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta1AttestorSpecInitProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AttestorSpecInitProvider
{
    /// <summary>A Container Analysis ATTESTATION_AUTHORITY Note, created by the user. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public IList<V1beta1AttestorSpecInitProviderAttestationAuthorityNote>? AttestationAuthorityNote { get; set; }

    /// <summary>A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1AttestorSpecManagementPoliciesEnum
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

public enum V1beta1AttestorSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttestorSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AttestorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AttestorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AttestorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AttestorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttestorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AttestorSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AttestorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AttestorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AttestorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AttestorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AttestorSpec defines the desired state of Attestor</summary>
public partial class V1beta1AttestorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttestorSpecDeletionPolicyEnum>))]
    public V1beta1AttestorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AttestorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AttestorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AttestorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AttestorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AttestorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AttestorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorStatusAtProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in publicKeyPem (i.e. this algorithm must match that of the public key).</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorStatusAtProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>ASCII-armored representation of a PGP public key, as the entire output by the command gpg --export --armor foo@example.com (either LF or CRLF line endings). When using this field, id should be left blank. The BinAuthz API handlers will calculate the ID and fill it in automatically. BinAuthz computes this ID as the OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If id is provided by the caller, it will be overwritten by the API-calculated ID.</summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The ID of this public key. Signatures verified by BinAuthz must include the ID of the public key that can be used to verify them, and that ID must match the contents of this field exactly. Additional restrictions on this field can be imposed based on which public key type is encapsulated. See the documentation on publicKey cases below for details.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A raw PKIX SubjectPublicKeyInfo format public key. NOTE: id may be explicitly provided by the caller when using this type of public key, but it MUST be a valid RFC3986 URI. If id is left blank, a default one will be computed based on the digest of the DER encoding of the public key. Structure is documented below.</summary>
    [JsonPropertyName("pkixPublicKey")]
    public IList<V1beta1AttestorStatusAtProviderAttestationAuthorityNotePublicKeysPkixPublicKey>? PkixPublicKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorStatusAtProviderAttestationAuthorityNote
{
    /// <summary>(Output) This field will contain the service account email address that this Attestor will use as the principal when querying Container Analysis. Attestor administrators must grant this service account the IAM role needed to read attestations from the noteReference in Container Analysis (containeranalysis.notes.occurrences.viewer). This email address is fixed for the lifetime of the Attestor, but callers should not make any other assumptions about the service account email; future versions may use an email based on a different naming pattern.</summary>
    [JsonPropertyName("delegationServiceAccountEmail")]
    public string? DelegationServiceAccountEmail { get; set; }

    /// <summary>The resource name of a ATTESTATION_AUTHORITY Note, created by the user. If the Note is in a different project from the Attestor, it should be specified in the format projects/*/notes/* (or the legacy providers/*/notes/*). This field may not be updated. An attestation by this attestor is stored as a Container Analysis ATTESTATION_AUTHORITY Occurrence that names a container image and that links to this Note.</summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>Public keys that verify attestations signed by this attestor. This field may be updated. If this field is non-empty, one of the specified public keys must verify that an attestation was signed by this attestor for the image specified in the admission request. If this field is empty, this attestor always returns that no valid attestations exist. Structure is documented below.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta1AttestorStatusAtProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttestorStatusAtProvider
{
    /// <summary>A Container Analysis ATTESTATION_AUTHORITY Note, created by the user. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public IList<V1beta1AttestorStatusAtProviderAttestationAuthorityNote>? AttestationAuthorityNote { get; set; }

    /// <summary>A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/attestors/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AttestorStatusConditions
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

/// <summary>AttestorStatus defines the observed state of Attestor.</summary>
public partial class V1beta1AttestorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AttestorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AttestorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Attestor is the Schema for the Attestors API. An attestor that attests to container image artifacts.</summary>
public partial class V1beta1Attestor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AttestorSpec>, IStatus<V1beta1AttestorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Attestor";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "attestors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AttestorSpec defines the desired state of Attestor</summary>
    [JsonPropertyName("spec")]
    public V1beta1AttestorSpec Spec { get; set; }

    /// <summary>AttestorStatus defines the observed state of Attestor.</summary>
    [JsonPropertyName("status")]
    public V1beta1AttestorStatus? Status { get; set; }
}