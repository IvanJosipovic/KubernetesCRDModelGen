using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.cnrm.cloud.google.com;
/// <summary>KMSImportJob is the Schema for the KMSImportJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSImportJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1KMSImportJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSImportJobList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmsimportjobs";
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
    public IList<V1alpha1KMSImportJob> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobSpecKmsKeyRingRef
{
    /// <summary> If provided must be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `KMSKeyRing` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `KMSKeyRing` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>KMSImportJobSpec defines the desired state of KMSImportJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobSpec
{
    /// <summary>Required. Immutable. The wrapping method to be used for incoming key material.</summary>
    [JsonPropertyName("importMethod")]
    public string ImportMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyRingRef")]
    public V1alpha1KMSImportJobSpecKmsKeyRingRef KmsKeyRingRef { get; set; }

    /// <summary>Required. Immutable. The protection level of the [ImportJob][google.cloud.kms.v1.ImportJob]. This must match the [protection_level][google.cloud.kms.v1.CryptoKeyVersionTemplate.protection_level] of the [version_template][google.cloud.kms.v1.CryptoKey.version_template] on the [CryptoKey][google.cloud.kms.v1.CryptoKey] you attempt to import into.</summary>
    [JsonPropertyName("protectionLevel")]
    public string ProtectionLevel { get; set; }

    /// <summary>The KMSImportJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatusConditions
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

/// <summary>Output only. The certificate chains needed to validate the attestation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatusObservedStateAttestationCertChains
{
    /// <summary>Cavium certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("caviumCerts")]
    public IList<string>? CaviumCerts { get; set; }

    /// <summary>Google card certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googleCardCerts")]
    public IList<string>? GoogleCardCerts { get; set; }

    /// <summary>Google partition certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googlePartitionCerts")]
    public IList<string>? GooglePartitionCerts { get; set; }
}

/// <summary>Output only. Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen [ImportMethod][google.cloud.kms.v1.ImportJob.ImportMethod] is one with a protection level of [HSM][google.cloud.kms.v1.ProtectionLevel.HSM].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatusObservedStateAttestation
{
    /// <summary>Output only. The certificate chains needed to validate the attestation</summary>
    [JsonPropertyName("certChains")]
    public V1alpha1KMSImportJobStatusObservedStateAttestationCertChains? CertChains { get; set; }

    /// <summary>Output only. The attestation data provided by the HSM when the key operation was performed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Output only. The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>Output only. The public key with which to wrap key material prior to import. Only returned if [state][google.cloud.kms.v1.ImportJob.state] is [ACTIVE][google.cloud.kms.v1.ImportJob.ImportJobState.ACTIVE].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatusObservedStatePublicKey
{
    /// <summary>The public key, encoded in PEM format. For more information, see the [RFC 7468](https://tools.ietf.org/html/rfc7468) sections for [General Considerations](https://tools.ietf.org/html/rfc7468#section-2) and [Textual Encoding of Subject Public Key Info] (https://tools.ietf.org/html/rfc7468#section-13).</summary>
    [JsonPropertyName("pem")]
    public string? Pem { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatusObservedState
{
    /// <summary>Output only. Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen [ImportMethod][google.cloud.kms.v1.ImportJob.ImportMethod] is one with a protection level of [HSM][google.cloud.kms.v1.ProtectionLevel.HSM].</summary>
    [JsonPropertyName("attestation")]
    public V1alpha1KMSImportJobStatusObservedStateAttestation? Attestation { get; set; }

    /// <summary>Output only. The time at which this [ImportJob][google.cloud.kms.v1.ImportJob] was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time this [ImportJob][google.cloud.kms.v1.ImportJob] expired. Only present if [state][google.cloud.kms.v1.ImportJob.state] is [EXPIRED][google.cloud.kms.v1.ImportJob.ImportJobState.EXPIRED].</summary>
    [JsonPropertyName("expireEventTime")]
    public string? ExpireEventTime { get; set; }

    /// <summary>Output only. The time at which this [ImportJob][google.cloud.kms.v1.ImportJob] is scheduled for expiration and can no longer be used to import key material.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The time this [ImportJob][google.cloud.kms.v1.ImportJob]'s key material was generated.</summary>
    [JsonPropertyName("generateTime")]
    public string? GenerateTime { get; set; }

    /// <summary>Output only. The public key with which to wrap key material prior to import. Only returned if [state][google.cloud.kms.v1.ImportJob.state] is [ACTIVE][google.cloud.kms.v1.ImportJob.ImportJobState.ACTIVE].</summary>
    [JsonPropertyName("publicKey")]
    public V1alpha1KMSImportJobStatusObservedStatePublicKey? PublicKey { get; set; }

    /// <summary>Output only. The current state of the [ImportJob][google.cloud.kms.v1.ImportJob], indicating if it can be used.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>KMSImportJobStatus defines the config connector machine state of KMSImportJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSImportJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KMSImportJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the KMSImportJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1KMSImportJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>KMSImportJob is the Schema for the KMSImportJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSImportJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KMSImportJobSpec>, IStatus<V1alpha1KMSImportJobStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSImportJob";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmsimportjobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KMSImportJobSpec defines the desired state of KMSImportJob</summary>
    [JsonPropertyName("spec")]
    public V1alpha1KMSImportJobSpec Spec { get; set; }

    /// <summary>KMSImportJobStatus defines the config connector machine state of KMSImportJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1KMSImportJobStatus? Status { get; set; }
}