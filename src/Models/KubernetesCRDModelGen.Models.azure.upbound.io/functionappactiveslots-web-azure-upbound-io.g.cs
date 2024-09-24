using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
public enum V1beta1FunctionAppActiveSlotSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WindowsFunctionAppSlot in web to populate slotId.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRefPolicy? Policy { get; set; }
}

public enum V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WindowsFunctionAppSlot in web to populate slotId.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FunctionAppActiveSlotSpecForProvider
{
    /// <summary>The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to true. Changing this forces a new resource to be created. The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`.</summary>
    [JsonPropertyName("overwriteNetworkConfig")]
    public bool? OverwriteNetworkConfig { get; set; }

    /// <summary>The ID of the Slot to swap with Production. The ID of the Slot to swap with `Production`.</summary>
    [JsonPropertyName("slotId")]
    public string? SlotId { get; set; }

    /// <summary>Reference to a WindowsFunctionAppSlot in web to populate slotId.</summary>
    [JsonPropertyName("slotIdRef")]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdRef? SlotIdRef { get; set; }

    /// <summary>Selector for a WindowsFunctionAppSlot in web to populate slotId.</summary>
    [JsonPropertyName("slotIdSelector")]
    public V1beta1FunctionAppActiveSlotSpecForProviderSlotIdSelector? SlotIdSelector { get; set; }
}

public enum V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WindowsFunctionAppSlot in web to populate slotId.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRefPolicy? Policy { get; set; }
}

public enum V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WindowsFunctionAppSlot in web to populate slotId.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecInitProvider
{
    /// <summary>The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to true. Changing this forces a new resource to be created. The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`.</summary>
    [JsonPropertyName("overwriteNetworkConfig")]
    public bool? OverwriteNetworkConfig { get; set; }

    /// <summary>The ID of the Slot to swap with Production. The ID of the Slot to swap with `Production`.</summary>
    [JsonPropertyName("slotId")]
    public string? SlotId { get; set; }

    /// <summary>Reference to a WindowsFunctionAppSlot in web to populate slotId.</summary>
    [JsonPropertyName("slotIdRef")]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdRef? SlotIdRef { get; set; }

    /// <summary>Selector for a WindowsFunctionAppSlot in web to populate slotId.</summary>
    [JsonPropertyName("slotIdSelector")]
    public V1beta1FunctionAppActiveSlotSpecInitProviderSlotIdSelector? SlotIdSelector { get; set; }
}

public enum V1beta1FunctionAppActiveSlotSpecManagementPoliciesEnum
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

public enum V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1FunctionAppActiveSlotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionAppActiveSlotSpec defines the desired state of FunctionAppActiveSlot</summary>
public partial class V1beta1FunctionAppActiveSlotSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppActiveSlotSpecDeletionPolicyEnum>))]
    public V1beta1FunctionAppActiveSlotSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionAppActiveSlotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionAppActiveSlotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FunctionAppActiveSlotSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionAppActiveSlotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FunctionAppActiveSlotSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionAppActiveSlotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1FunctionAppActiveSlotStatusAtProvider
{
    /// <summary>The ID of the Function App Active Slot</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The timestamp of the last successful swap with Production The timestamp of the last successful swap with `Production`</summary>
    [JsonPropertyName("lastSuccessfulSwap")]
    public string? LastSuccessfulSwap { get; set; }

    /// <summary>The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to true. Changing this forces a new resource to be created. The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`.</summary>
    [JsonPropertyName("overwriteNetworkConfig")]
    public bool? OverwriteNetworkConfig { get; set; }

    /// <summary>The ID of the Slot to swap with Production. The ID of the Slot to swap with `Production`.</summary>
    [JsonPropertyName("slotId")]
    public string? SlotId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1FunctionAppActiveSlotStatusConditions
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

/// <summary>FunctionAppActiveSlotStatus defines the observed state of FunctionAppActiveSlot.</summary>
public partial class V1beta1FunctionAppActiveSlotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionAppActiveSlotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionAppActiveSlotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>FunctionAppActiveSlot is the Schema for the FunctionAppActiveSlots API. Manages a Function App Active Slot.</summary>
public partial class V1beta1FunctionAppActiveSlot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionAppActiveSlotSpec>, IStatus<V1beta1FunctionAppActiveSlotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionAppActiveSlot";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "functionappactiveslots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionAppActiveSlotSpec defines the desired state of FunctionAppActiveSlot</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionAppActiveSlotSpec Spec { get; set; }

    /// <summary>FunctionAppActiveSlotStatus defines the observed state of FunctionAppActiveSlot.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionAppActiveSlotStatus? Status { get; set; }
}