using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.cnrm.cloud.google.com;
/// <summary>The KMSKeyRing that this key belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSCryptoKeySpecKeyRingRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSKeyRing` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A template describing settings for new crypto key versions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSCryptoKeySpecVersionTemplate
{
    /// <summary>The algorithm to use when creating a version based on this template. See the [algorithm reference](https://cloud.google.com/kms/docs/reference/rest/v1/CryptoKeyVersionAlgorithm) for possible inputs.</summary>
    [JsonPropertyName("algorithm")]
    public string Algorithm { get; set; }

    /// <summary>Immutable. The protection level to use when creating a version based on this template. Possible values include "SOFTWARE", "HSM", "EXTERNAL", "EXTERNAL_VPC". Defaults to "SOFTWARE".</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSCryptoKeySpec
{
    /// <summary>Immutable. The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED. If not specified at creation time, the default duration is 24 hours.</summary>
    [JsonPropertyName("destroyScheduledDuration")]
    public string? DestroyScheduledDuration { get; set; }

    /// <summary>Immutable. Whether this key may contain imported versions only.</summary>
    [JsonPropertyName("importOnly")]
    public bool? ImportOnly { get; set; }

    /// <summary>The KMSKeyRing that this key belongs to.</summary>
    [JsonPropertyName("keyRingRef")]
    public V1beta1KMSCryptoKeySpecKeyRingRef KeyRingRef { get; set; }

    /// <summary>Immutable. The immutable purpose of this CryptoKey. See the [purpose reference](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys#CryptoKeyPurpose) for possible inputs. Default value is "ENCRYPT_DECRYPT".</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Every time this period passes, generate a new CryptoKeyVersion and set it as the primary. The first rotation will take place after the specified period. The rotation period has the format of a decimal number with up to 9 fractional digits, followed by the letter 's' (seconds). It must be greater than a day (ie, 86400).</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }

    /// <summary>Immutable. If set to true, the request will create a CryptoKey without any CryptoKeyVersions. You must use the 'google_kms_key_ring_import_job' resource to import the CryptoKeyVersion.</summary>
    [JsonPropertyName("skipInitialVersionCreation")]
    public bool? SkipInitialVersionCreation { get; set; }

    /// <summary>A template describing settings for new crypto key versions.</summary>
    [JsonPropertyName("versionTemplate")]
    public V1beta1KMSCryptoKeySpecVersionTemplate? VersionTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSCryptoKeyStatusConditions
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
public partial class V1beta1KMSCryptoKeyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KMSCryptoKeyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The self link of the created key in the format projects/{project}/locations/{location}/keyRings/{keyRingName}/cryptoKeys/{name}.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KMSCryptoKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KMSCryptoKeySpec>, IStatus<V1beta1KMSCryptoKeyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KMSCryptoKey";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmscryptokeys";
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
    public V1beta1KMSCryptoKeySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1KMSCryptoKeyStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KMSCryptoKeyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KMSCryptoKey>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KMSCryptoKeyList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmscryptokeys";
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
    public IList<V1beta1KMSCryptoKey> Items { get; set; }
}