using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSCryptoKeyVersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1KMSCryptoKeyVersion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSCryptoKeyVersionList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmscryptokeyversions";
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
    public IList<V1alpha1KMSCryptoKeyVersion> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSCryptoKeyVersionSpec
{
    /// <summary>Immutable. The name of the cryptoKey associated with the CryptoKeyVersions. Format: ''projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}''.</summary>
    [JsonPropertyName("cryptoKey")]
    public string CryptoKey { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The current state of the CryptoKeyVersion. Possible values: ["PENDING_GENERATION", "ENABLED", "DISABLED", "DESTROYED", "DESTROY_SCHEDULED", "PENDING_IMPORT", "IMPORT_FAILED"].</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The certificate chains needed to validate the attestation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSCryptoKeyVersionStatusAttestationCertChains
{
    /// <summary>Cavium certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("caviumCerts")]
    public string? CaviumCerts { get; set; }

    /// <summary>Google card certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googleCardCerts")]
    public string? GoogleCardCerts { get; set; }

    /// <summary>Google partition certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googlePartitionCerts")]
    public string? GooglePartitionCerts { get; set; }
}

/// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSCryptoKeyVersionStatusAttestationExternalProtectionLevelOptions
{
    /// <summary>The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field instead of externalKeyUri when using an EkmConnection.</summary>
    [JsonPropertyName("ekmConnectionKeyPath")]
    public string? EkmConnectionKeyPath { get; set; }

    /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
    [JsonPropertyName("externalKeyUri")]
    public string? ExternalKeyUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSCryptoKeyVersionStatusAttestation
{
    /// <summary>The certificate chains needed to validate the attestation.</summary>
    [JsonPropertyName("certChains")]
    public V1alpha1KMSCryptoKeyVersionStatusAttestationCertChains? CertChains { get; set; }

    /// <summary>The attestation data provided by the HSM when the key operation was performed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels.</summary>
    [JsonPropertyName("externalProtectionLevelOptions")]
    public V1alpha1KMSCryptoKeyVersionStatusAttestationExternalProtectionLevelOptions? ExternalProtectionLevelOptions { get; set; }

    /// <summary>The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSCryptoKeyVersionStatusConditions
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
public partial class V1alpha1KMSCryptoKeyVersionStatus
{
    /// <summary>The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only provided for key versions with protectionLevel HSM.</summary>
    [JsonPropertyName("attestation")]
    public IList<V1alpha1KMSCryptoKeyVersionStatusAttestation>? Attestation { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KMSCryptoKeyVersionStatusConditions>? Conditions { get; set; }

    /// <summary>The time this CryptoKeyVersion key material was generated.</summary>
    [JsonPropertyName("generateTime")]
    public string? GenerateTime { get; set; }

    /// <summary>The resource name for this CryptoKeyVersion.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSCryptoKeyVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KMSCryptoKeyVersionSpec>, IStatus<V1alpha1KMSCryptoKeyVersionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSCryptoKeyVersion";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmscryptokeyversions";
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
    public V1alpha1KMSCryptoKeyVersionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1KMSCryptoKeyVersionStatus? Status { get; set; }
}