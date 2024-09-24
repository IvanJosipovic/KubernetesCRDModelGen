using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.gcp.upbound.io;
public enum V1beta1CryptoKeySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CryptoKeySpecForProviderKeyRingRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolveEnum>))]
    public V1beta1CryptoKeySpecForProviderKeyRingRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CryptoKeySpecForProviderKeyRingRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeySpecForProviderKeyRingRefPolicy? Policy { get; set; }
}

public enum V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolutionEnum>))]
    public V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolveEnum>))]
    public V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CryptoKeySpecForProviderKeyRingSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeySpecForProviderKeyRingSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CryptoKeySpecForProviderVersionTemplate
{
    /// <summary>The algorithm to use when creating a version based on this template. See the algorithm reference for possible inputs.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The protection level to use when creating a version based on this template. Possible values include "SOFTWARE", "HSM", "EXTERNAL", "EXTERNAL_VPC". Defaults to "SOFTWARE".</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }
}

public partial class V1beta1CryptoKeySpecForProvider
{
    /// <summary>The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey. The resource name is in the format "projects//locations//ekmConnections/*" and only applies to "EXTERNAL_VPC" keys.</summary>
    [JsonPropertyName("cryptoKeyBackend")]
    public string? CryptoKeyBackend { get; set; }

    /// <summary>The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED. If not specified at creation time, the default duration is 24 hours.</summary>
    [JsonPropertyName("destroyScheduledDuration")]
    public string? DestroyScheduledDuration { get; set; }

    /// <summary>Whether this key may contain imported versions only.</summary>
    [JsonPropertyName("importOnly")]
    public bool? ImportOnly { get; set; }

    /// <summary>The KeyRing that this key belongs to. Format: 'projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}'.</summary>
    [JsonPropertyName("keyRing")]
    public string? KeyRing { get; set; }

    /// <summary>Reference to a KeyRing in kms to populate keyRing.</summary>
    [JsonPropertyName("keyRingRef")]
    public V1beta1CryptoKeySpecForProviderKeyRingRef? KeyRingRef { get; set; }

    /// <summary>Selector for a KeyRing in kms to populate keyRing.</summary>
    [JsonPropertyName("keyRingSelector")]
    public V1beta1CryptoKeySpecForProviderKeyRingSelector? KeyRingSelector { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The immutable purpose of this CryptoKey. See the purpose reference for possible inputs. Default value is "ENCRYPT_DECRYPT".</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Every time this period passes, generate a new CryptoKeyVersion and set it as the primary. The first rotation will take place after the specified period. The rotation period has the format of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than a day (ie, 86400).</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }

    /// <summary>If set to true, the request will create a CryptoKey without any CryptoKeyVersions. You must use the google_kms_key_ring_import_job resource to import the CryptoKeyVersion.</summary>
    [JsonPropertyName("skipInitialVersionCreation")]
    public bool? SkipInitialVersionCreation { get; set; }

    /// <summary>A template describing settings for new crypto key versions. Structure is documented below.</summary>
    [JsonPropertyName("versionTemplate")]
    public IList<V1beta1CryptoKeySpecForProviderVersionTemplate>? VersionTemplate { get; set; }
}

public partial class V1beta1CryptoKeySpecInitProviderVersionTemplate
{
    /// <summary>The algorithm to use when creating a version based on this template. See the algorithm reference for possible inputs.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The protection level to use when creating a version based on this template. Possible values include "SOFTWARE", "HSM", "EXTERNAL", "EXTERNAL_VPC". Defaults to "SOFTWARE".</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }
}

public partial class V1beta1CryptoKeySpecInitProvider
{
    /// <summary>The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey. The resource name is in the format "projects//locations//ekmConnections/*" and only applies to "EXTERNAL_VPC" keys.</summary>
    [JsonPropertyName("cryptoKeyBackend")]
    public string? CryptoKeyBackend { get; set; }

    /// <summary>The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED. If not specified at creation time, the default duration is 24 hours.</summary>
    [JsonPropertyName("destroyScheduledDuration")]
    public string? DestroyScheduledDuration { get; set; }

    /// <summary>Whether this key may contain imported versions only.</summary>
    [JsonPropertyName("importOnly")]
    public bool? ImportOnly { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The immutable purpose of this CryptoKey. See the purpose reference for possible inputs. Default value is "ENCRYPT_DECRYPT".</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Every time this period passes, generate a new CryptoKeyVersion and set it as the primary. The first rotation will take place after the specified period. The rotation period has the format of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than a day (ie, 86400).</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }

    /// <summary>If set to true, the request will create a CryptoKey without any CryptoKeyVersions. You must use the google_kms_key_ring_import_job resource to import the CryptoKeyVersion.</summary>
    [JsonPropertyName("skipInitialVersionCreation")]
    public bool? SkipInitialVersionCreation { get; set; }

    /// <summary>A template describing settings for new crypto key versions. Structure is documented below.</summary>
    [JsonPropertyName("versionTemplate")]
    public IList<V1beta1CryptoKeySpecInitProviderVersionTemplate>? VersionTemplate { get; set; }
}

public enum V1beta1CryptoKeySpecManagementPoliciesEnum
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

public enum V1beta1CryptoKeySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CryptoKeySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CryptoKeySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CryptoKeySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1CryptoKeySpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1CryptoKeySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CryptoKeySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CryptoKeySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1CryptoKeySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CryptoKeySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeySpecDeletionPolicyEnum>))]
    public V1beta1CryptoKeySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CryptoKeySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CryptoKeySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CryptoKeySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CryptoKeySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CryptoKeySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CryptoKeySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1CryptoKeyStatusAtProviderPrimary
{
    /// <summary>(Output) The resource name for this CryptoKeyVersion.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Output) The current state of the CryptoKeyVersion.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1CryptoKeyStatusAtProviderVersionTemplate
{
    /// <summary>The algorithm to use when creating a version based on this template. See the algorithm reference for possible inputs.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The protection level to use when creating a version based on this template. Possible values include "SOFTWARE", "HSM", "EXTERNAL", "EXTERNAL_VPC". Defaults to "SOFTWARE".</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }
}

public partial class V1beta1CryptoKeyStatusAtProvider
{
    /// <summary>The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey. The resource name is in the format "projects//locations//ekmConnections/*" and only applies to "EXTERNAL_VPC" keys.</summary>
    [JsonPropertyName("cryptoKeyBackend")]
    public string? CryptoKeyBackend { get; set; }

    /// <summary>The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED. If not specified at creation time, the default duration is 24 hours.</summary>
    [JsonPropertyName("destroyScheduledDuration")]
    public string? DestroyScheduledDuration { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format {{key_ring}}/cryptoKeys/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether this key may contain imported versions only.</summary>
    [JsonPropertyName("importOnly")]
    public bool? ImportOnly { get; set; }

    /// <summary>The KeyRing that this key belongs to. Format: 'projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}'.</summary>
    [JsonPropertyName("keyRing")]
    public string? KeyRing { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A copy of the primary CryptoKeyVersion that will be used by cryptoKeys.encrypt when this CryptoKey is given in EncryptRequest.name. Keys with purpose ENCRYPT_DECRYPT may have a primary. For other keys, this field will be unset. Structure is documented below.</summary>
    [JsonPropertyName("primary")]
    public IList<V1beta1CryptoKeyStatusAtProviderPrimary>? Primary { get; set; }

    /// <summary>The immutable purpose of this CryptoKey. See the purpose reference for possible inputs. Default value is "ENCRYPT_DECRYPT".</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Every time this period passes, generate a new CryptoKeyVersion and set it as the primary. The first rotation will take place after the specified period. The rotation period has the format of a decimal number with up to 9 fractional digits, followed by the letter s (seconds). It must be greater than a day (ie, 86400).</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }

    /// <summary>If set to true, the request will create a CryptoKey without any CryptoKeyVersions. You must use the google_kms_key_ring_import_job resource to import the CryptoKeyVersion.</summary>
    [JsonPropertyName("skipInitialVersionCreation")]
    public bool? SkipInitialVersionCreation { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>A template describing settings for new crypto key versions. Structure is documented below.</summary>
    [JsonPropertyName("versionTemplate")]
    public IList<V1beta1CryptoKeyStatusAtProviderVersionTemplate>? VersionTemplate { get; set; }
}

public partial class V1beta1CryptoKeyStatusConditions
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

public partial class V1beta1CryptoKeyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CryptoKeyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CryptoKeyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CryptoKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CryptoKeySpec>, IStatus<V1beta1CryptoKeyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CryptoKey";
    public const string KubeGroup = "kms.gcp.upbound.io";
    public const string KubePluralName = "cryptokeys";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CryptoKeySpec defines the desired state of CryptoKey</summary>
    [JsonPropertyName("spec")]
    public V1beta1CryptoKeySpec Spec { get; set; }

    /// <summary>CryptoKeyStatus defines the observed state of CryptoKey.</summary>
    [JsonPropertyName("status")]
    public V1beta1CryptoKeyStatus? Status { get; set; }
}