using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containeranalysis.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1alpha1ContainerAnalysisOccurrenceSpecAttestationSignatures
{
    /// <summary>The identifier for the public key that verifies this signature. MUST be an RFC3986 conformant URI. * When possible, the key id should be an immutable reference, such as a cryptographic digest. Examples of valid values:  * OpenPGP V4 public key fingerprint. See https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr   for more details on this scheme.     * 'openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA' * RFC6920 digest-named SubjectPublicKeyInfo (digest of the DER serialization):     * "ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU".</summary>
    [JsonPropertyName("publicKeyId")]
    public string PublicKeyId { get; set; }

    /// <summary>The content of the signature, an opaque bytestring. The payload that this signature verifies MUST be unambiguously provided with the Signature during verification. A wrapper message might provide the payload explicitly. Alternatively, a message might have a canonical serialization that can always be unambiguously computed to derive the payload.</summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary>Occurrence that represents a single "attestation". The authenticity of an attestation can be verified using the attached signature. If the verifier trusts the public key of the signer, then verifying the signature is sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is primarily useful for lookup (how to find this attestation if you already know the authority and artifact to be verified) and intent (for which authority this attestation was intended to sign.</summary>
public partial class V1alpha1ContainerAnalysisOccurrenceSpecAttestation
{
    /// <summary>The serialized payload that is verified by one or more signatures. A base64-encoded string.</summary>
    [JsonPropertyName("serializedPayload")]
    public string SerializedPayload { get; set; }

    /// <summary>One or more signatures over serializedPayload. Verifier implementations should consider this attestation message verified if at least one signature verifies serializedPayload. See Signature in common.proto for more details on signature structure and verification.</summary>
    [JsonPropertyName("signatures")]
    public IList<V1alpha1ContainerAnalysisOccurrenceSpecAttestationSignatures> Signatures { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1ContainerAnalysisOccurrenceSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ContainerAnalysisOccurrenceSpec
{
    /// <summary>Occurrence that represents a single "attestation". The authenticity of an attestation can be verified using the attached signature. If the verifier trusts the public key of the signer, then verifying the signature is sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is primarily useful for lookup (how to find this attestation if you already know the authority and artifact to be verified) and intent (for which authority this attestation was intended to sign.</summary>
    [JsonPropertyName("attestation")]
    public V1alpha1ContainerAnalysisOccurrenceSpecAttestation Attestation { get; set; }

    /// <summary>Immutable. The analysis note associated with this occurrence, in the form of projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a filter in list requests.</summary>
    [JsonPropertyName("noteName")]
    public string NoteName { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ContainerAnalysisOccurrenceSpecProjectRef ProjectRef { get; set; }

    /// <summary>A description of actions that can be taken to remedy the note.</summary>
    [JsonPropertyName("remediation")]
    public string? Remediation { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Required. Immutable. A URI that represents the resource for which the occurrence applies. For example, https://gcr.io/project/image@sha256:123abc for a Docker image.</summary>
    [JsonPropertyName("resourceUri")]
    public string ResourceUri { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ContainerAnalysisOccurrenceStatusConditions
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
public partial class V1alpha1ContainerAnalysisOccurrenceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ContainerAnalysisOccurrenceStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the repository was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The note kind which explicitly denotes which of the occurrence details are specified. This field can be used as a filter in list requests.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The name of the occurrence.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The time when the repository was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1ContainerAnalysisOccurrence : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ContainerAnalysisOccurrenceSpec>, IStatus<V1alpha1ContainerAnalysisOccurrenceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContainerAnalysisOccurrence";
    public const string KubeGroup = "containeranalysis.cnrm.cloud.google.com";
    public const string KubePluralName = "containeranalysisoccurrences";
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
    public V1alpha1ContainerAnalysisOccurrenceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ContainerAnalysisOccurrenceStatus? Status { get; set; }
}