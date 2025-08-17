using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSKeyRingImportJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1KMSKeyRingImportJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSKeyRingImportJobList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmskeyringimportjobs";
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
    public IList<V1alpha1KMSKeyRingImportJob> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobSpec
{
    /// <summary>Immutable. It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}.</summary>
    [JsonPropertyName("importJobId")]
    public string ImportJobId { get; set; }

    /// <summary>Immutable. The wrapping method to be used for incoming key material. Possible values: ["RSA_OAEP_3072_SHA1_AES_256", "RSA_OAEP_4096_SHA1_AES_256"].</summary>
    [JsonPropertyName("importMethod")]
    public string ImportMethod { get; set; }

    /// <summary>Immutable. The KeyRing that this import job belongs to. Format: ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}''.</summary>
    [JsonPropertyName("keyRing")]
    public string KeyRing { get; set; }

    /// <summary>Immutable. The protection level of the ImportJob. This must match the protectionLevel of the versionTemplate on the CryptoKey you attempt to import into. Possible values: ["SOFTWARE", "HSM", "EXTERNAL"].</summary>
    [JsonPropertyName("protectionLevel")]
    public string ProtectionLevel { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatusAttestation
{
    /// <summary>The attestation data provided by the HSM when the key operation was performed. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatusPublicKey
{
    /// <summary>The public key, encoded in PEM format. For more information, see the RFC 7468 sections for General Considerations and Textual Encoding of Subject Public Key Info.</summary>
    [JsonPropertyName("pem")]
    public string? Pem { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatus
{
    /// <summary>Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen ImportMethod is one with a protection level of HSM.</summary>
    [JsonPropertyName("attestation")]
    public IList<V1alpha1KMSKeyRingImportJobStatusAttestation>? Attestation { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KMSKeyRingImportJobStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which this resource is scheduled for expiration and can no longer be used. This is in RFC3339 text format.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The public key with which to wrap key material prior to import. Only returned if state is 'ACTIVE'.</summary>
    [JsonPropertyName("publicKey")]
    public IList<V1alpha1KMSKeyRingImportJobStatusPublicKey>? PublicKey { get; set; }

    /// <summary>The current state of the ImportJob, indicating if it can be used.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSKeyRingImportJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KMSKeyRingImportJobSpec>, IStatus<V1alpha1KMSKeyRingImportJobStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSKeyRingImportJob";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmskeyringimportjobs";
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
    public V1alpha1KMSKeyRingImportJobSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1KMSKeyRingImportJobStatus? Status { get; set; }
}
#nullable disable
