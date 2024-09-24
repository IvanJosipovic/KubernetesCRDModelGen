using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.azure.upbound.io;
public enum V1beta1IOTSecurityDeviceGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderAllowRule
{
    /// <summary>Specifies which IP is not allowed to be connected to in current device group for inbound connection.</summary>
    [JsonPropertyName("connectionFromIpsNotAllowed")]
    public IList<string>? ConnectionFromIpsNotAllowed { get; set; }

    /// <summary>Specifies which IP is not allowed to be connected to in current device group for outbound connection.</summary>
    [JsonPropertyName("connectionToIpsNotAllowed")]
    public IList<string>? ConnectionToIpsNotAllowed { get; set; }

    /// <summary>Specifies which local user is not allowed to login in current device group.</summary>
    [JsonPropertyName("localUsersNotAllowed")]
    public IList<string>? LocalUsersNotAllowed { get; set; }

    /// <summary>Specifies which process is not allowed to be executed in current device group.</summary>
    [JsonPropertyName("processesNotAllowed")]
    public IList<string>? ProcessesNotAllowed { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate iothubId.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate iothubId.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProviderRangeRule
{
    /// <summary>Specifies the time range. represented in ISO 8601 duration format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The maximum threshold in the given time window.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum threshold in the given time window.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>The type of supported rule type. Possible Values are ActiveConnectionsNotInAllowedRange, AmqpC2DMessagesNotInAllowedRange, MqttC2DMessagesNotInAllowedRange, HttpC2DMessagesNotInAllowedRange, AmqpC2DRejectedMessagesNotInAllowedRange, MqttC2DRejectedMessagesNotInAllowedRange, HttpC2DRejectedMessagesNotInAllowedRange, AmqpD2CMessagesNotInAllowedRange, MqttD2CMessagesNotInAllowedRange, HttpD2CMessagesNotInAllowedRange, DirectMethodInvokesNotInAllowedRange, FailedLocalLoginsNotInAllowedRange, FileUploadsNotInAllowedRange, QueuePurgesNotInAllowedRange, TwinUpdatesNotInAllowedRange and UnauthorizedOperationsNotInAllowedRange.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecForProvider
{
    /// <summary>an allow_rule blocks as defined below.</summary>
    [JsonPropertyName("allowRule")]
    public IList<V1beta1IOTSecurityDeviceGroupSpecForProviderAllowRule>? AllowRule { get; set; }

    /// <summary>The ID of the IoT Hub which to link the Security Device Group to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("iothubId")]
    public string? IothubId { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate iothubId.</summary>
    [JsonPropertyName("iothubIdRef")]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdRef? IothubIdRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate iothubId.</summary>
    [JsonPropertyName("iothubIdSelector")]
    public V1beta1IOTSecurityDeviceGroupSpecForProviderIothubIdSelector? IothubIdSelector { get; set; }

    /// <summary>Specifies the name of the Device Security Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more range_rule blocks as defined below.</summary>
    [JsonPropertyName("rangeRule")]
    public IList<V1beta1IOTSecurityDeviceGroupSpecForProviderRangeRule>? RangeRule { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderAllowRule
{
    /// <summary>Specifies which IP is not allowed to be connected to in current device group for inbound connection.</summary>
    [JsonPropertyName("connectionFromIpsNotAllowed")]
    public IList<string>? ConnectionFromIpsNotAllowed { get; set; }

    /// <summary>Specifies which IP is not allowed to be connected to in current device group for outbound connection.</summary>
    [JsonPropertyName("connectionToIpsNotAllowed")]
    public IList<string>? ConnectionToIpsNotAllowed { get; set; }

    /// <summary>Specifies which local user is not allowed to login in current device group.</summary>
    [JsonPropertyName("localUsersNotAllowed")]
    public IList<string>? LocalUsersNotAllowed { get; set; }

    /// <summary>Specifies which process is not allowed to be executed in current device group.</summary>
    [JsonPropertyName("processesNotAllowed")]
    public IList<string>? ProcessesNotAllowed { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate iothubId.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate iothubId.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProviderRangeRule
{
    /// <summary>Specifies the time range. represented in ISO 8601 duration format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The maximum threshold in the given time window.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum threshold in the given time window.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>The type of supported rule type. Possible Values are ActiveConnectionsNotInAllowedRange, AmqpC2DMessagesNotInAllowedRange, MqttC2DMessagesNotInAllowedRange, HttpC2DMessagesNotInAllowedRange, AmqpC2DRejectedMessagesNotInAllowedRange, MqttC2DRejectedMessagesNotInAllowedRange, HttpC2DRejectedMessagesNotInAllowedRange, AmqpD2CMessagesNotInAllowedRange, MqttD2CMessagesNotInAllowedRange, HttpD2CMessagesNotInAllowedRange, DirectMethodInvokesNotInAllowedRange, FailedLocalLoginsNotInAllowedRange, FileUploadsNotInAllowedRange, QueuePurgesNotInAllowedRange, TwinUpdatesNotInAllowedRange and UnauthorizedOperationsNotInAllowedRange.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecInitProvider
{
    /// <summary>an allow_rule blocks as defined below.</summary>
    [JsonPropertyName("allowRule")]
    public IList<V1beta1IOTSecurityDeviceGroupSpecInitProviderAllowRule>? AllowRule { get; set; }

    /// <summary>The ID of the IoT Hub which to link the Security Device Group to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("iothubId")]
    public string? IothubId { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate iothubId.</summary>
    [JsonPropertyName("iothubIdRef")]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdRef? IothubIdRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate iothubId.</summary>
    [JsonPropertyName("iothubIdSelector")]
    public V1beta1IOTSecurityDeviceGroupSpecInitProviderIothubIdSelector? IothubIdSelector { get; set; }

    /// <summary>Specifies the name of the Device Security Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more range_rule blocks as defined below.</summary>
    [JsonPropertyName("rangeRule")]
    public IList<V1beta1IOTSecurityDeviceGroupSpecInitProviderRangeRule>? RangeRule { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecManagementPoliciesEnum
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

public enum V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IOTSecurityDeviceGroupSpec defines the desired state of IOTSecurityDeviceGroup</summary>
public partial class V1beta1IOTSecurityDeviceGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTSecurityDeviceGroupSpecDeletionPolicyEnum>))]
    public V1beta1IOTSecurityDeviceGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IOTSecurityDeviceGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IOTSecurityDeviceGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IOTSecurityDeviceGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IOTSecurityDeviceGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IOTSecurityDeviceGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IOTSecurityDeviceGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupStatusAtProviderAllowRule
{
    /// <summary>Specifies which IP is not allowed to be connected to in current device group for inbound connection.</summary>
    [JsonPropertyName("connectionFromIpsNotAllowed")]
    public IList<string>? ConnectionFromIpsNotAllowed { get; set; }

    /// <summary>Specifies which IP is not allowed to be connected to in current device group for outbound connection.</summary>
    [JsonPropertyName("connectionToIpsNotAllowed")]
    public IList<string>? ConnectionToIpsNotAllowed { get; set; }

    /// <summary>Specifies which local user is not allowed to login in current device group.</summary>
    [JsonPropertyName("localUsersNotAllowed")]
    public IList<string>? LocalUsersNotAllowed { get; set; }

    /// <summary>Specifies which process is not allowed to be executed in current device group.</summary>
    [JsonPropertyName("processesNotAllowed")]
    public IList<string>? ProcessesNotAllowed { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupStatusAtProviderRangeRule
{
    /// <summary>Specifies the time range. represented in ISO 8601 duration format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The maximum threshold in the given time window.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum threshold in the given time window.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>The type of supported rule type. Possible Values are ActiveConnectionsNotInAllowedRange, AmqpC2DMessagesNotInAllowedRange, MqttC2DMessagesNotInAllowedRange, HttpC2DMessagesNotInAllowedRange, AmqpC2DRejectedMessagesNotInAllowedRange, MqttC2DRejectedMessagesNotInAllowedRange, HttpC2DRejectedMessagesNotInAllowedRange, AmqpD2CMessagesNotInAllowedRange, MqttD2CMessagesNotInAllowedRange, HttpD2CMessagesNotInAllowedRange, DirectMethodInvokesNotInAllowedRange, FailedLocalLoginsNotInAllowedRange, FileUploadsNotInAllowedRange, QueuePurgesNotInAllowedRange, TwinUpdatesNotInAllowedRange and UnauthorizedOperationsNotInAllowedRange.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1IOTSecurityDeviceGroupStatusAtProvider
{
    /// <summary>an allow_rule blocks as defined below.</summary>
    [JsonPropertyName("allowRule")]
    public IList<V1beta1IOTSecurityDeviceGroupStatusAtProviderAllowRule>? AllowRule { get; set; }

    /// <summary>The ID of the Iot Security Device Group resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the IoT Hub which to link the Security Device Group to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("iothubId")]
    public string? IothubId { get; set; }

    /// <summary>Specifies the name of the Device Security Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more range_rule blocks as defined below.</summary>
    [JsonPropertyName("rangeRule")]
    public IList<V1beta1IOTSecurityDeviceGroupStatusAtProviderRangeRule>? RangeRule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1IOTSecurityDeviceGroupStatusConditions
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

/// <summary>IOTSecurityDeviceGroupStatus defines the observed state of IOTSecurityDeviceGroup.</summary>
public partial class V1beta1IOTSecurityDeviceGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IOTSecurityDeviceGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IOTSecurityDeviceGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>IOTSecurityDeviceGroup is the Schema for the IOTSecurityDeviceGroups API. Manages a Iot Security Device Group.</summary>
public partial class V1beta1IOTSecurityDeviceGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IOTSecurityDeviceGroupSpec>, IStatus<V1beta1IOTSecurityDeviceGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTSecurityDeviceGroup";
    public const string KubeGroup = "security.azure.upbound.io";
    public const string KubePluralName = "iotsecuritydevicegroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTSecurityDeviceGroupSpec defines the desired state of IOTSecurityDeviceGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1IOTSecurityDeviceGroupSpec Spec { get; set; }

    /// <summary>IOTSecurityDeviceGroupStatus defines the observed state of IOTSecurityDeviceGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1IOTSecurityDeviceGroupStatus? Status { get; set; }
}