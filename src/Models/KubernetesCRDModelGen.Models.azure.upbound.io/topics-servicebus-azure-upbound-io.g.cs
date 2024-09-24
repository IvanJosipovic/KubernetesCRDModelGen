using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
public enum V1beta1TopicSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TopicSpecForProviderNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1TopicSpecForProviderNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TopicSpecForProviderNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TopicSpecForProviderNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1TopicSpecForProviderNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TopicSpecForProviderNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderNamespaceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TopicSpecForProvider
{
    /// <summary>The ISO 8601 timespan duration of the idle interval after which the Topic is automatically deleted, minimum of 5 minutes.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>The ISO 8601 timespan duration of TTL of messages sent to this topic if no TTL value is set on the message itself.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The ISO 8601 timespan duration during which duplicates can be detected. Defaults to 10 minutes. (PT10M)</summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>Boolean flag which controls if server-side batched operations are enabled.</summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary>Boolean flag which controls whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.</summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary>Boolean flag which controls whether to enable the topic to be partitioned across multiple message brokers. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary>Integer value which controls the maximum size of a message allowed on the topic for Premium SKU. For supported values see the "Large messages support" section of this document.</summary>
    [JsonPropertyName("maxMessageSizeInKilobytes")]
    public double? MaxMessageSizeInKilobytes { get; set; }

    /// <summary>Integer value which controls the size of memory allocated for the topic. For supported values see the "Queue/topic size" section of this document.</summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public double? MaxSizeInMegabytes { get; set; }

    /// <summary>The ID of the ServiceBus Namespace to create this topic in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1TopicSpecForProviderNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1TopicSpecForProviderNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>Boolean flag which controls whether the Topic requires duplicate detection. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary>The Status of the Service Bus Topic. Acceptable values are Active or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Boolean flag which controls whether the Topic supports ordering.</summary>
    [JsonPropertyName("supportOrdering")]
    public bool? SupportOrdering { get; set; }
}

public partial class V1beta1TopicSpecInitProvider
{
    /// <summary>The ISO 8601 timespan duration of the idle interval after which the Topic is automatically deleted, minimum of 5 minutes.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>The ISO 8601 timespan duration of TTL of messages sent to this topic if no TTL value is set on the message itself.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The ISO 8601 timespan duration during which duplicates can be detected. Defaults to 10 minutes. (PT10M)</summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>Boolean flag which controls if server-side batched operations are enabled.</summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary>Boolean flag which controls whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.</summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary>Boolean flag which controls whether to enable the topic to be partitioned across multiple message brokers. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary>Integer value which controls the maximum size of a message allowed on the topic for Premium SKU. For supported values see the "Large messages support" section of this document.</summary>
    [JsonPropertyName("maxMessageSizeInKilobytes")]
    public double? MaxMessageSizeInKilobytes { get; set; }

    /// <summary>Integer value which controls the size of memory allocated for the topic. For supported values see the "Queue/topic size" section of this document.</summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public double? MaxSizeInMegabytes { get; set; }

    /// <summary>Boolean flag which controls whether the Topic requires duplicate detection. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary>The Status of the Service Bus Topic. Acceptable values are Active or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Boolean flag which controls whether the Topic supports ordering.</summary>
    [JsonPropertyName("supportOrdering")]
    public bool? SupportOrdering { get; set; }
}

public enum V1beta1TopicSpecManagementPoliciesEnum
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

public enum V1beta1TopicSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TopicSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TopicSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TopicSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TopicSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TopicSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TopicSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TopicSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TopicSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TopicSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TopicSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TopicSpecDeletionPolicyEnum>))]
    public V1beta1TopicSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TopicSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TopicSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TopicSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TopicSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TopicStatusAtProvider
{
    /// <summary>The ISO 8601 timespan duration of the idle interval after which the Topic is automatically deleted, minimum of 5 minutes.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>The ISO 8601 timespan duration of TTL of messages sent to this topic if no TTL value is set on the message itself.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The ISO 8601 timespan duration during which duplicates can be detected. Defaults to 10 minutes. (PT10M)</summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>Boolean flag which controls if server-side batched operations are enabled.</summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary>Boolean flag which controls whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.</summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary>Boolean flag which controls whether to enable the topic to be partitioned across multiple message brokers. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary>The ServiceBus Topic ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Integer value which controls the maximum size of a message allowed on the topic for Premium SKU. For supported values see the "Large messages support" section of this document.</summary>
    [JsonPropertyName("maxMessageSizeInKilobytes")]
    public double? MaxMessageSizeInKilobytes { get; set; }

    /// <summary>Integer value which controls the size of memory allocated for the topic. For supported values see the "Queue/topic size" section of this document.</summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public double? MaxSizeInMegabytes { get; set; }

    /// <summary>The ID of the ServiceBus Namespace to create this topic in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Boolean flag which controls whether the Topic requires duplicate detection. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary>The Status of the Service Bus Topic. Acceptable values are Active or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Boolean flag which controls whether the Topic supports ordering.</summary>
    [JsonPropertyName("supportOrdering")]
    public bool? SupportOrdering { get; set; }
}

public partial class V1beta1TopicStatusConditions
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

public partial class V1beta1TopicStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Topic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TopicSpec>, IStatus<V1beta1TopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "topics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicSpec defines the desired state of Topic</summary>
    [JsonPropertyName("spec")]
    public V1beta1TopicSpec Spec { get; set; }

    /// <summary>TopicStatus defines the observed state of Topic.</summary>
    [JsonPropertyName("status")]
    public V1beta1TopicStatus? Status { get; set; }
}