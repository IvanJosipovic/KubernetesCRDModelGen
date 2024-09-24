using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signer.aws.upbound.io;
public enum V1beta1SigningProfileSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1SigningProfileSpecForProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1SigningProfileSpecForProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1SigningProfileSpecForProvider
{
    /// <summary>The ID of the platform that is used by the target signing profile.</summary>
    [JsonPropertyName("platformId")]
    public string? PlatformId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public IList<V1beta1SigningProfileSpecForProviderSignatureValidityPeriod>? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public IList<V1beta1SigningProfileSpecForProviderSigningMaterial>? SigningMaterial { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1SigningProfileSpecInitProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1SigningProfileSpecInitProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SigningProfileSpecInitProvider
{
    /// <summary>The ID of the platform that is used by the target signing profile.</summary>
    [JsonPropertyName("platformId")]
    public string? PlatformId { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public IList<V1beta1SigningProfileSpecInitProviderSignatureValidityPeriod>? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public IList<V1beta1SigningProfileSpecInitProviderSigningMaterial>? SigningMaterial { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1SigningProfileSpecManagementPoliciesEnum
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

public enum V1beta1SigningProfileSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SigningProfileSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SigningProfileSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SigningProfileSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SigningProfileSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SigningProfileSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SigningProfileSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SigningProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SigningProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SigningProfileSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SigningProfileSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SigningProfileSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SigningProfileSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SigningProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SigningProfileSpec defines the desired state of SigningProfile</summary>
public partial class V1beta1SigningProfileSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SigningProfileSpecDeletionPolicyEnum>))]
    public V1beta1SigningProfileSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SigningProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SigningProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SigningProfileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SigningProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SigningProfileSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SigningProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
public partial class V1beta1SigningProfileStatusAtProviderSignatureValidityPeriod
{
    /// <summary>The time unit for signature validity. Valid values: DAYS, MONTHS, YEARS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The numerical value of the time unit for signature validity.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1SigningProfileStatusAtProviderSigningMaterial
{
    /// <summary>The Amazon Resource Name (ARN) of the certificates that is used to sign your code.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary></summary>
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

    /// <summary>Revocation information for a signing profile. See revocation_record Block below for details.</summary>
    [JsonPropertyName("revocationRecord")]
    public IList<V1beta1SigningProfileStatusAtProviderRevocationRecord>? RevocationRecord { get; set; }

    /// <summary>The validity period for a signing job. See signature_validity_period Block below for details.</summary>
    [JsonPropertyName("signatureValidityPeriod")]
    public IList<V1beta1SigningProfileStatusAtProviderSignatureValidityPeriod>? SignatureValidityPeriod { get; set; }

    /// <summary>The AWS Certificate Manager certificate that will be used to sign code with the new signing profile. See signing_material Block below for details.</summary>
    [JsonPropertyName("signingMaterial")]
    public IList<V1beta1SigningProfileStatusAtProviderSigningMaterial>? SigningMaterial { get; set; }

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

/// <summary>A Condition that may apply to a resource.</summary>
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

/// <summary>SigningProfileStatus defines the observed state of SigningProfile.</summary>
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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SigningProfile is the Schema for the SigningProfiles API. Creates a Signer Signing Profile.</summary>
public partial class V1beta1SigningProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SigningProfileSpec>, IStatus<V1beta1SigningProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SigningProfile";
    public const string KubeGroup = "signer.aws.upbound.io";
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