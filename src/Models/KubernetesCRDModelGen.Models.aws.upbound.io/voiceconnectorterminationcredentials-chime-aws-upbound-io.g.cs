using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.chime.aws.upbound.io;
public enum V1beta1VoiceConnectorTerminationCredentialsSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>RFC2617 compliant password associated with the SIP credentials.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderCredentialsPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderCredentials
{
    /// <summary>RFC2617 compliant password associated with the SIP credentials.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderCredentialsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>RFC2617 compliant username associated with the SIP credentials.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VoiceConnector in chime to populate voiceConnectorId.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VoiceConnector in chime to populate voiceConnectorId.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecForProvider
{
    /// <summary>List of termination SIP credentials.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1VoiceConnectorTerminationCredentialsSpecForProviderCredentials>? Credentials { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Amazon Chime Voice Connector ID.</summary>
    [JsonPropertyName("voiceConnectorId")]
    public string? VoiceConnectorId { get; set; }

    /// <summary>Reference to a VoiceConnector in chime to populate voiceConnectorId.</summary>
    [JsonPropertyName("voiceConnectorIdRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdRef? VoiceConnectorIdRef { get; set; }

    /// <summary>Selector for a VoiceConnector in chime to populate voiceConnectorId.</summary>
    [JsonPropertyName("voiceConnectorIdSelector")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProviderVoiceConnectorIdSelector? VoiceConnectorIdSelector { get; set; }
}

/// <summary>RFC2617 compliant password associated with the SIP credentials.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderCredentialsPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderCredentials
{
    /// <summary>RFC2617 compliant password associated with the SIP credentials.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderCredentialsPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>RFC2617 compliant username associated with the SIP credentials.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VoiceConnector in chime to populate voiceConnectorId.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VoiceConnector in chime to populate voiceConnectorId.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecInitProvider
{
    /// <summary>List of termination SIP credentials.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderCredentials>? Credentials { get; set; }

    /// <summary>Amazon Chime Voice Connector ID.</summary>
    [JsonPropertyName("voiceConnectorId")]
    public string? VoiceConnectorId { get; set; }

    /// <summary>Reference to a VoiceConnector in chime to populate voiceConnectorId.</summary>
    [JsonPropertyName("voiceConnectorIdRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdRef? VoiceConnectorIdRef { get; set; }

    /// <summary>Selector for a VoiceConnector in chime to populate voiceConnectorId.</summary>
    [JsonPropertyName("voiceConnectorIdSelector")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProviderVoiceConnectorIdSelector? VoiceConnectorIdSelector { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecManagementPoliciesEnum
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

public enum V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VoiceConnectorTerminationCredentialsSpec defines the desired state of VoiceConnectorTerminationCredentials</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VoiceConnectorTerminationCredentialsSpecDeletionPolicyEnum>))]
    public V1beta1VoiceConnectorTerminationCredentialsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VoiceConnectorTerminationCredentialsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VoiceConnectorTerminationCredentialsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsStatusAtProviderCredentials
{
    /// <summary>RFC2617 compliant username associated with the SIP credentials.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsStatusAtProvider
{
    /// <summary>List of termination SIP credentials.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1VoiceConnectorTerminationCredentialsStatusAtProviderCredentials>? Credentials { get; set; }

    /// <summary>Amazon Chime Voice Connector ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amazon Chime Voice Connector ID.</summary>
    [JsonPropertyName("voiceConnectorId")]
    public string? VoiceConnectorId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsStatusConditions
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

/// <summary>VoiceConnectorTerminationCredentialsStatus defines the observed state of VoiceConnectorTerminationCredentials.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentialsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VoiceConnectorTerminationCredentialsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VoiceConnectorTerminationCredentialsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VoiceConnectorTerminationCredentials is the Schema for the VoiceConnectorTerminationCredentialss API. Adds termination SIP credentials for the specified Amazon Chime Voice Connector.</summary>
public partial class V1beta1VoiceConnectorTerminationCredentials : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VoiceConnectorTerminationCredentialsSpec>, IStatus<V1beta1VoiceConnectorTerminationCredentialsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VoiceConnectorTerminationCredentials";
    public const string KubeGroup = "chime.aws.upbound.io";
    public const string KubePluralName = "voiceconnectorterminationcredentials";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VoiceConnectorTerminationCredentialsSpec defines the desired state of VoiceConnectorTerminationCredentials</summary>
    [JsonPropertyName("spec")]
    public V1beta1VoiceConnectorTerminationCredentialsSpec Spec { get; set; }

    /// <summary>VoiceConnectorTerminationCredentialsStatus defines the observed state of VoiceConnectorTerminationCredentials.</summary>
    [JsonPropertyName("status")]
    public V1beta1VoiceConnectorTerminationCredentialsStatus? Status { get; set; }
}