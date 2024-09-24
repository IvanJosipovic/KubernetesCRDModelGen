using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.gcp.upbound.io;
public enum V1beta1LiteTopicSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecForProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecForProviderPartitionConfig
{
    /// <summary>The capacity configuration. Structure is documented below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1LiteTopicSpecForProviderPartitionConfigCapacity>? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

public enum V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
public partial class V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicy? Policy { get; set; }
}

public enum V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
public partial class V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecForProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic's throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }

    /// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationRef")]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationRef? ThroughputReservationRef { get; set; }

    /// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationSelector")]
    public V1beta1LiteTopicSpecForProviderReservationConfigThroughputReservationSelector? ThroughputReservationSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecForProviderRetentionConfig
{
    /// <summary>The provisioned storage, in bytes, per partition. If the number of bytes stored in any of the topic's partitions grows beyond this value, older messages will be dropped to make room for newer ones, regardless of the value of period.</summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>How long a published message is retained. If unset, messages will be retained as long as the bytes retained for each partition is below perPartitionBytes. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecForProvider
{
    /// <summary>The settings for this topic's partitions. Structure is documented below.</summary>
    [JsonPropertyName("partitionConfig")]
    public IList<V1beta1LiteTopicSpecForProviderPartitionConfig>? PartitionConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for this topic's Reservation usage. Structure is documented below.</summary>
    [JsonPropertyName("reservationConfig")]
    public IList<V1beta1LiteTopicSpecForProviderReservationConfig>? ReservationConfig { get; set; }

    /// <summary>The settings for a topic's message retention. Structure is documented below.</summary>
    [JsonPropertyName("retentionConfig")]
    public IList<V1beta1LiteTopicSpecForProviderRetentionConfig>? RetentionConfig { get; set; }

    /// <summary>The zone of the pubsub lite topic.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecInitProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecInitProviderPartitionConfig
{
    /// <summary>The capacity configuration. Structure is documented below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1LiteTopicSpecInitProviderPartitionConfigCapacity>? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

public enum V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
public partial class V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicy? Policy { get; set; }
}

public enum V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
public partial class V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecInitProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic's throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }

    /// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationRef")]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationRef? ThroughputReservationRef { get; set; }

    /// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationSelector")]
    public V1beta1LiteTopicSpecInitProviderReservationConfigThroughputReservationSelector? ThroughputReservationSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicSpecInitProviderRetentionConfig
{
    /// <summary>The provisioned storage, in bytes, per partition. If the number of bytes stored in any of the topic's partitions grows beyond this value, older messages will be dropped to make room for newer ones, regardless of the value of period.</summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>How long a published message is retained. If unset, messages will be retained as long as the bytes retained for each partition is below perPartitionBytes. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1LiteTopicSpecInitProvider
{
    /// <summary>The settings for this topic's partitions. Structure is documented below.</summary>
    [JsonPropertyName("partitionConfig")]
    public IList<V1beta1LiteTopicSpecInitProviderPartitionConfig>? PartitionConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for this topic's Reservation usage. Structure is documented below.</summary>
    [JsonPropertyName("reservationConfig")]
    public IList<V1beta1LiteTopicSpecInitProviderReservationConfig>? ReservationConfig { get; set; }

    /// <summary>The settings for a topic's message retention. Structure is documented below.</summary>
    [JsonPropertyName("retentionConfig")]
    public IList<V1beta1LiteTopicSpecInitProviderRetentionConfig>? RetentionConfig { get; set; }
}

public enum V1beta1LiteTopicSpecManagementPoliciesEnum
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

public enum V1beta1LiteTopicSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LiteTopicSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1LiteTopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1LiteTopicSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LiteTopicSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LiteTopicSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LiteTopicSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1LiteTopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LiteTopicSpec defines the desired state of LiteTopic</summary>
public partial class V1beta1LiteTopicSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiteTopicSpecDeletionPolicyEnum>))]
    public V1beta1LiteTopicSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LiteTopicSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LiteTopicSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LiteTopicSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LiteTopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LiteTopicSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LiteTopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicStatusAtProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicStatusAtProviderPartitionConfig
{
    /// <summary>The capacity configuration. Structure is documented below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1LiteTopicStatusAtProviderPartitionConfigCapacity>? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicStatusAtProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic's throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicStatusAtProviderRetentionConfig
{
    /// <summary>The provisioned storage, in bytes, per partition. If the number of bytes stored in any of the topic's partitions grows beyond this value, older messages will be dropped to make room for newer ones, regardless of the value of period.</summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>How long a published message is retained. If unset, messages will be retained as long as the bytes retained for each partition is below perPartitionBytes. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary></summary>
public partial class V1beta1LiteTopicStatusAtProvider
{
    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{zone}}/topics/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The settings for this topic's partitions. Structure is documented below.</summary>
    [JsonPropertyName("partitionConfig")]
    public IList<V1beta1LiteTopicStatusAtProviderPartitionConfig>? PartitionConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for this topic's Reservation usage. Structure is documented below.</summary>
    [JsonPropertyName("reservationConfig")]
    public IList<V1beta1LiteTopicStatusAtProviderReservationConfig>? ReservationConfig { get; set; }

    /// <summary>The settings for a topic's message retention. Structure is documented below.</summary>
    [JsonPropertyName("retentionConfig")]
    public IList<V1beta1LiteTopicStatusAtProviderRetentionConfig>? RetentionConfig { get; set; }

    /// <summary>The zone of the pubsub lite topic.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1LiteTopicStatusConditions
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

/// <summary>LiteTopicStatus defines the observed state of LiteTopic.</summary>
public partial class V1beta1LiteTopicStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LiteTopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LiteTopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>LiteTopic is the Schema for the LiteTopics API. A named resource to which messages are sent by publishers.</summary>
public partial class V1beta1LiteTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LiteTopicSpec>, IStatus<V1beta1LiteTopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LiteTopic";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "litetopics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LiteTopicSpec defines the desired state of LiteTopic</summary>
    [JsonPropertyName("spec")]
    public V1beta1LiteTopicSpec Spec { get; set; }

    /// <summary>LiteTopicStatus defines the observed state of LiteTopic.</summary>
    [JsonPropertyName("status")]
    public V1beta1LiteTopicStatus? Status { get; set; }
}