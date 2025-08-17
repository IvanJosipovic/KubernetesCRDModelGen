using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signer.aws.m.upbound.io;
#nullable enable
/// <summary>SigningProfile is the Schema for the SigningProfiles API. Creates a Signer Signing Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SigningProfileList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SigningProfile>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SigningProfileList";
    public const string KubeGroup = "signer.aws.m.upbound.io";
    public const string KubePluralName = "signingprofiles";
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
    public IList<V1beta1SigningProfile> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecForProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecForProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecForProvider
{
    /// <summary>The ID of the platform that is used by the target signing profile.</summary>
    [JsonPropertyName("platformId")]
    public string? PlatformId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public V1beta1SigningProfileSpecForProviderSignatureValidityPeriod? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public V1beta1SigningProfileSpecForProviderSigningMaterial? SigningMaterial { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecInitProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecInitProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecInitProvider
{
    /// <summary>The ID of the platform that is used by the target signing profile.</summary>
    [JsonPropertyName("platformId")]
    public string? PlatformId { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public V1beta1SigningProfileSpecInitProviderSignatureValidityPeriod? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public V1beta1SigningProfileSpecInitProviderSigningMaterial? SigningMaterial { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SigningProfileSpec defines the desired state of SigningProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SigningProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SigningProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SigningProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SigningProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatusAtProviderRevocationRecord
{
    /// <summary>The time when revocation becomes effective.</summary>
    [JsonPropertyName("revocationEffectiveFrom")]
    public string? RevocationEffectiveFrom { get; set; }

    /// <summary>The time when the signing profile was revoked.</summary>
    [JsonPropertyName("revokedAt")]
    public string? RevokedAt { get; set; }

    /// <summary>The identity of the revoker.</summary>
    [JsonPropertyName("revokedBy")]
    public string? RevokedBy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatusAtProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatusAtProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) for the signing profile.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable name for the signing platform associated with the signing profile.</summary>
    [JsonPropertyName("platformDisplayName")]
    public string? PlatformDisplayName { get; set; }

    /// <summary>The ID of the platform that is used by the target signing profile.</summary>
    [JsonPropertyName("platformId")]
    public string? PlatformId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Revocation information for a signing profile. See revocation_record Block below for details.</summary>
    [JsonPropertyName("revocationRecord")]
    public IList<V1beta1SigningProfileStatusAtProviderRevocationRecord>? RevocationRecord { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public V1beta1SigningProfileStatusAtProviderSignatureValidityPeriod? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public V1beta1SigningProfileStatusAtProviderSigningMaterial? SigningMaterial { get; set; }

    /// <summary>The status of the target signing profile.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The current version of the signing profile.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The signing profile ARN, including the profile version.</summary>
    [JsonPropertyName("versionArn")]
    public string? VersionArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatusConditions
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
#nullable disable

#nullable enable
/// <summary>SigningProfileStatus defines the observed state of SigningProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SigningProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SigningProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SigningProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SigningProfile is the Schema for the SigningProfiles API. Creates a Signer Signing Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SigningProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SigningProfileSpec>, IStatus<V1beta1SigningProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SigningProfile";
    public const string KubeGroup = "signer.aws.m.upbound.io";
    public const string KubePluralName = "signingprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SigningProfileSpec defines the desired state of SigningProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1SigningProfileSpec Spec { get; set; }

    /// <summary>SigningProfileStatus defines the observed state of SigningProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1SigningProfileStatus? Status { get; set; }
}
#nullable disable
