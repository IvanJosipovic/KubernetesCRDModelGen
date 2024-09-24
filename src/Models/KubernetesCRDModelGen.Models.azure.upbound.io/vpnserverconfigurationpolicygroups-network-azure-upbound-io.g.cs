using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VPNServerConfigurationPolicyGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProviderPolicy
{
    /// <summary>The name of the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The attribute type of the VPN Server Configuration Policy member. Possible values are AADGroupId, CertificateGroupId and RadiusAzureGroupId.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the attribute that is used for the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecForProvider
{
    /// <summary>Is this a default VPN Server Configuration Policy Group? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>One or more policy blocks as documented below.</summary>
    [JsonPropertyName("policy")]
    public IList<V1beta1VPNServerConfigurationPolicyGroupSpecForProviderPolicy>? Policy { get; set; }

    /// <summary>The priority of this VPN Server Configuration Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the VPN Server Configuration that the VPN Server Configuration Policy Group belongs to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnServerConfigurationId")]
    public string? VpnServerConfigurationId { get; set; }

    /// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdRef")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdRef? VpnServerConfigurationIdRef { get; set; }

    /// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdSelector")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProviderVpnServerConfigurationIdSelector? VpnServerConfigurationIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecInitProviderPolicy
{
    /// <summary>The name of the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The attribute type of the VPN Server Configuration Policy member. Possible values are AADGroupId, CertificateGroupId and RadiusAzureGroupId.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the attribute that is used for the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecInitProvider
{
    /// <summary>Is this a default VPN Server Configuration Policy Group? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>One or more policy blocks as documented below.</summary>
    [JsonPropertyName("policy")]
    public IList<V1beta1VPNServerConfigurationPolicyGroupSpecInitProviderPolicy>? Policy { get; set; }

    /// <summary>The priority of this VPN Server Configuration Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecManagementPoliciesEnum
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

public enum V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPNServerConfigurationPolicyGroupSpec defines the desired state of VPNServerConfigurationPolicyGroup</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationPolicyGroupSpecDeletionPolicyEnum>))]
    public V1beta1VPNServerConfigurationPolicyGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPNServerConfigurationPolicyGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNServerConfigurationPolicyGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupStatusAtProviderPolicy
{
    /// <summary>The name of the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The attribute type of the VPN Server Configuration Policy member. Possible values are AADGroupId, CertificateGroupId and RadiusAzureGroupId.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the attribute that is used for the VPN Server Configuration Policy member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupStatusAtProvider
{
    /// <summary>The ID of the VPN Server Configuration Policy Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Is this a default VPN Server Configuration Policy Group? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>One or more policy blocks as documented below.</summary>
    [JsonPropertyName("policy")]
    public IList<V1beta1VPNServerConfigurationPolicyGroupStatusAtProviderPolicy>? Policy { get; set; }

    /// <summary>The priority of this VPN Server Configuration Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the VPN Server Configuration that the VPN Server Configuration Policy Group belongs to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnServerConfigurationId")]
    public string? VpnServerConfigurationId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupStatusConditions
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

/// <summary>VPNServerConfigurationPolicyGroupStatus defines the observed state of VPNServerConfigurationPolicyGroup.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNServerConfigurationPolicyGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNServerConfigurationPolicyGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VPNServerConfigurationPolicyGroup is the Schema for the VPNServerConfigurationPolicyGroups API. Manages a VPN Server Configuration Policy Group.</summary>
public partial class V1beta1VPNServerConfigurationPolicyGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNServerConfigurationPolicyGroupSpec>, IStatus<V1beta1VPNServerConfigurationPolicyGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNServerConfigurationPolicyGroup";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpnserverconfigurationpolicygroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNServerConfigurationPolicyGroupSpec defines the desired state of VPNServerConfigurationPolicyGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNServerConfigurationPolicyGroupSpec Spec { get; set; }

    /// <summary>VPNServerConfigurationPolicyGroupStatus defines the observed state of VPNServerConfigurationPolicyGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNServerConfigurationPolicyGroupStatus? Status { get; set; }
}