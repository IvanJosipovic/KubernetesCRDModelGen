using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.gcp.upbound.io;
public enum V1beta1CryptoKeyVersionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate cryptoKey.</summary>
public partial class V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRefPolicy? Policy { get; set; }
}

public enum V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate cryptoKey.</summary>
public partial class V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionSpecForProviderExternalProtectionLevelOptions
{
    /// <summary>The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field instead of externalKeyUri when using an EkmConnection.</summary>
    [JsonPropertyName("ekmConnectionKeyPath")]
    public string? EkmConnectionKeyPath { get; set; }

    /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
    [JsonPropertyName("externalKeyUri")]
    public string? ExternalKeyUri { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionSpecForProvider
{
    /// <summary>The name of the cryptoKey associated with the CryptoKeyVersions. Format: 'projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}'</summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate cryptoKey.</summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeyRef? CryptoKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate cryptoKey.</summary>
    [JsonPropertyName("cryptoKeySelector")]
    public V1beta1CryptoKeyVersionSpecForProviderCryptoKeySelector? CryptoKeySelector { get; set; }

    /// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels. Structure is documented below.</summary>
    [JsonPropertyName("externalProtectionLevelOptions")]
    public IList<V1beta1CryptoKeyVersionSpecForProviderExternalProtectionLevelOptions>? ExternalProtectionLevelOptions { get; set; }

    /// <summary>The current state of the CryptoKeyVersion. Possible values are: PENDING_GENERATION, ENABLED, DISABLED, DESTROYED, DESTROY_SCHEDULED, PENDING_IMPORT, IMPORT_FAILED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public enum V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate cryptoKey.</summary>
public partial class V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRefPolicy? Policy { get; set; }
}

public enum V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate cryptoKey.</summary>
public partial class V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionSpecInitProviderExternalProtectionLevelOptions
{
    /// <summary>The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field instead of externalKeyUri when using an EkmConnection.</summary>
    [JsonPropertyName("ekmConnectionKeyPath")]
    public string? EkmConnectionKeyPath { get; set; }

    /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
    [JsonPropertyName("externalKeyUri")]
    public string? ExternalKeyUri { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1CryptoKeyVersionSpecInitProvider
{
    /// <summary>The name of the cryptoKey associated with the CryptoKeyVersions. Format: 'projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}'</summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate cryptoKey.</summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeyRef? CryptoKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate cryptoKey.</summary>
    [JsonPropertyName("cryptoKeySelector")]
    public V1beta1CryptoKeyVersionSpecInitProviderCryptoKeySelector? CryptoKeySelector { get; set; }

    /// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels. Structure is documented below.</summary>
    [JsonPropertyName("externalProtectionLevelOptions")]
    public IList<V1beta1CryptoKeyVersionSpecInitProviderExternalProtectionLevelOptions>? ExternalProtectionLevelOptions { get; set; }

    /// <summary>The current state of the CryptoKeyVersion. Possible values are: PENDING_GENERATION, ENABLED, DISABLED, DESTROYED, DESTROY_SCHEDULED, PENDING_IMPORT, IMPORT_FAILED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public enum V1beta1CryptoKeyVersionSpecManagementPoliciesEnum
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

public enum V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CryptoKeyVersionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1CryptoKeyVersionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CryptoKeyVersionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1CryptoKeyVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CryptoKeyVersionSpec defines the desired state of CryptoKeyVersion</summary>
public partial class V1beta1CryptoKeyVersionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CryptoKeyVersionSpecDeletionPolicyEnum>))]
    public V1beta1CryptoKeyVersionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CryptoKeyVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CryptoKeyVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CryptoKeyVersionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CryptoKeyVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CryptoKeyVersionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CryptoKeyVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionStatusAtProviderAttestationCertChains
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

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionStatusAtProviderAttestationExternalProtectionLevelOptions
{
    /// <summary>The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field instead of externalKeyUri when using an EkmConnection.</summary>
    [JsonPropertyName("ekmConnectionKeyPath")]
    public string? EkmConnectionKeyPath { get; set; }

    /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
    [JsonPropertyName("externalKeyUri")]
    public string? ExternalKeyUri { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionStatusAtProviderAttestation
{
    /// <summary>The certificate chains needed to validate the attestation Structure is documented below.</summary>
    [JsonPropertyName("certChains")]
    public IList<V1beta1CryptoKeyVersionStatusAtProviderAttestationCertChains>? CertChains { get; set; }

    /// <summary>(Output) The attestation data provided by the HSM when the key operation was performed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels. Structure is documented below.</summary>
    [JsonPropertyName("externalProtectionLevelOptions")]
    public IList<V1beta1CryptoKeyVersionStatusAtProviderAttestationExternalProtectionLevelOptions>? ExternalProtectionLevelOptions { get; set; }

    /// <summary>(Output) The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionStatusAtProviderExternalProtectionLevelOptions
{
    /// <summary>The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field instead of externalKeyUri when using an EkmConnection.</summary>
    [JsonPropertyName("ekmConnectionKeyPath")]
    public string? EkmConnectionKeyPath { get; set; }

    /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
    [JsonPropertyName("externalKeyUri")]
    public string? ExternalKeyUri { get; set; }
}

/// <summary></summary>
public partial class V1beta1CryptoKeyVersionStatusAtProvider
{
    /// <summary>The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only provided for key versions with protectionLevel HSM. Structure is documented below.</summary>
    [JsonPropertyName("attestation")]
    public IList<V1beta1CryptoKeyVersionStatusAtProviderAttestation>? Attestation { get; set; }

    /// <summary>The name of the cryptoKey associated with the CryptoKeyVersions. Format: 'projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}'</summary>
    [JsonPropertyName("cryptoKey")]
    public string? CryptoKey { get; set; }

    /// <summary>ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels. Structure is documented below.</summary>
    [JsonPropertyName("externalProtectionLevelOptions")]
    public IList<V1beta1CryptoKeyVersionStatusAtProviderExternalProtectionLevelOptions>? ExternalProtectionLevelOptions { get; set; }

    /// <summary>The time this CryptoKeyVersion key material was generated</summary>
    [JsonPropertyName("generateTime")]
    public string? GenerateTime { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name for this CryptoKeyVersion.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.</summary>
    [JsonPropertyName("protectionLevel")]
    public string? ProtectionLevel { get; set; }

    /// <summary>The current state of the CryptoKeyVersion. Possible values are: PENDING_GENERATION, ENABLED, DISABLED, DESTROYED, DESTROY_SCHEDULED, PENDING_IMPORT, IMPORT_FAILED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1CryptoKeyVersionStatusConditions
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

/// <summary>CryptoKeyVersionStatus defines the observed state of CryptoKeyVersion.</summary>
public partial class V1beta1CryptoKeyVersionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CryptoKeyVersionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CryptoKeyVersionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>CryptoKeyVersion is the Schema for the CryptoKeyVersions API. A</summary>
public partial class V1beta1CryptoKeyVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CryptoKeyVersionSpec>, IStatus<V1beta1CryptoKeyVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CryptoKeyVersion";
    public const string KubeGroup = "kms.gcp.upbound.io";
    public const string KubePluralName = "cryptokeyversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CryptoKeyVersionSpec defines the desired state of CryptoKeyVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1CryptoKeyVersionSpec Spec { get; set; }

    /// <summary>CryptoKeyVersionStatus defines the observed state of CryptoKeyVersion.</summary>
    [JsonPropertyName("status")]
    public V1beta1CryptoKeyVersionStatus? Status { get; set; }
}