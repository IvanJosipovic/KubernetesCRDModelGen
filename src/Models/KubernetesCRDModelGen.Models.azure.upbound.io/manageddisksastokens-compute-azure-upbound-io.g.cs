using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
public enum V1beta1ManagedDiskSASTokenSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecForProvider
{
    /// <summary>The level of access required on the disk. Supported are Read, Write. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>The duration for which the export should be allowed. Should be between 30 &amp; 4294967295 seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("durationInSeconds")]
    public double? DurationInSeconds { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be exported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdRef")]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdRef? ManagedDiskIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdSelector")]
    public V1beta1ManagedDiskSASTokenSpecForProviderManagedDiskIdSelector? ManagedDiskIdSelector { get; set; }
}

public enum V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecInitProvider
{
    /// <summary>The level of access required on the disk. Supported are Read, Write. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>The duration for which the export should be allowed. Should be between 30 &amp; 4294967295 seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("durationInSeconds")]
    public double? DurationInSeconds { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be exported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdRef")]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdRef? ManagedDiskIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdSelector")]
    public V1beta1ManagedDiskSASTokenSpecInitProviderManagedDiskIdSelector? ManagedDiskIdSelector { get; set; }
}

public enum V1beta1ManagedDiskSASTokenSpecManagementPoliciesEnum
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

public enum V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDiskSASTokenSpecDeletionPolicyEnum>))]
    public V1beta1ManagedDiskSASTokenSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagedDiskSASTokenSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagedDiskSASTokenSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ManagedDiskSASTokenSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagedDiskSASTokenSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ManagedDiskSASTokenSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagedDiskSASTokenSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenStatusAtProvider
{
    /// <summary>The level of access required on the disk. Supported are Read, Write. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>The duration for which the export should be allowed. Should be between 30 &amp; 4294967295 seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("durationInSeconds")]
    public double? DurationInSeconds { get; set; }

    /// <summary>The ID of the Disk Export resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be exported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }
}

public partial class V1beta1ManagedDiskSASTokenStatusConditions
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

public partial class V1beta1ManagedDiskSASTokenStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagedDiskSASTokenStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedDiskSASTokenStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedDiskSASToken : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedDiskSASTokenSpec>, IStatus<V1beta1ManagedDiskSASTokenStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedDiskSASToken";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "manageddisksastokens";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedDiskSASTokenSpec defines the desired state of ManagedDiskSASToken</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagedDiskSASTokenSpec Spec { get; set; }

    /// <summary>ManagedDiskSASTokenStatus defines the observed state of ManagedDiskSASToken.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedDiskSASTokenStatus? Status { get; set; }
}