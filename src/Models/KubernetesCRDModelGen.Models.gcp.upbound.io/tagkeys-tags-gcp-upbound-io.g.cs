using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tags.gcp.upbound.io;
public enum V1beta1TagKeySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1TagKeySpecForProvider
{
    /// <summary>User-assigned description of the TagKey. Must not exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input only. The resource name of the new TagKey's parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Optional. A purpose cannot be changed once set. A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values are: GCE_FIREWALL.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Optional. Purpose data cannot be changed once set. Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: network = "&lt;project-name&gt;/&lt;vpc-name&gt;".</summary>
    [JsonPropertyName("purposeData")]
    public IDictionary<string, string>? PurposeData { get; set; }

    /// <summary>Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }
}

public partial class V1beta1TagKeySpecInitProvider
{
    /// <summary>User-assigned description of the TagKey. Must not exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input only. The resource name of the new TagKey's parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Optional. A purpose cannot be changed once set. A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values are: GCE_FIREWALL.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Optional. Purpose data cannot be changed once set. Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: network = "&lt;project-name&gt;/&lt;vpc-name&gt;".</summary>
    [JsonPropertyName("purposeData")]
    public IDictionary<string, string>? PurposeData { get; set; }

    /// <summary>Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }
}

public enum V1beta1TagKeySpecManagementPoliciesEnum
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

public enum V1beta1TagKeySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagKeySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagKeySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagKeySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TagKeySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagKeySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TagKeySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagKeySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagKeySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagKeySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagKeySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TagKeySpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TagKeySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TagKeySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TagKeySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TagKeySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TagKeySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagKeySpecDeletionPolicyEnum>))]
    public V1beta1TagKeySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TagKeySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TagKeySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TagKeySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TagKeySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TagKeySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TagKeySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TagKeyStatusAtProvider
{
    /// <summary>Output only. Creation time. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>User-assigned description of the TagKey. Must not exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format tagKeys/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The generated numeric id for the TagKey.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Namespaced name of the TagKey.</summary>
    [JsonPropertyName("namespacedName")]
    public string? NamespacedName { get; set; }

    /// <summary>Input only. The resource name of the new TagKey's parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Optional. A purpose cannot be changed once set. A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values are: GCE_FIREWALL.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Optional. Purpose data cannot be changed once set. Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: network = "&lt;project-name&gt;/&lt;vpc-name&gt;".</summary>
    [JsonPropertyName("purposeData")]
    public IDictionary<string, string>? PurposeData { get; set; }

    /// <summary>Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>Output only. Update time. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

public partial class V1beta1TagKeyStatusConditions
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

public partial class V1beta1TagKeyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TagKeyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TagKeyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TagKeySpec>, IStatus<V1beta1TagKeyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagKey";
    public const string KubeGroup = "tags.gcp.upbound.io";
    public const string KubePluralName = "tagkeys";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TagKeySpec defines the desired state of TagKey</summary>
    [JsonPropertyName("spec")]
    public V1beta1TagKeySpec Spec { get; set; }

    /// <summary>TagKeyStatus defines the observed state of TagKey.</summary>
    [JsonPropertyName("status")]
    public V1beta1TagKeyStatus? Status { get; set; }
}