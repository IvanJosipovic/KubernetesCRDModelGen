using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sqs.aws.upbound.io;
#nullable enable
/// <summary>Queue is the Schema for the Queues API. Provides a SQS resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QueueList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Queue>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QueueList";
    public const string KubeGroup = "sqs.aws.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1Queue> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProvider
{
    /// <summary>Enables content-based deduplication for FIFO queues. For more information, see the related documentation.</summary>
    [JsonPropertyName("contentBasedDeduplication")]
    public bool? ContentBasedDeduplication { get; set; }

    /// <summary>Specifies whether message deduplication occurs at the message group or queue level. Valid values are messageGroup and queue (default).</summary>
    [JsonPropertyName("deduplicationScope")]
    public string? DeduplicationScope { get; set; }

    /// <summary>Time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 seconds.</summary>
    [JsonPropertyName("delaySeconds")]
    public double? DelaySeconds { get; set; }

    /// <summary>Boolean designating a FIFO queue. If not set, it defaults to false making it standard.</summary>
    [JsonPropertyName("fifoQueue")]
    public bool? FifoQueue { get; set; }

    /// <summary>Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are perQueue (default) and perMessageGroupId.</summary>
    [JsonPropertyName("fifoThroughputLimit")]
    public string? FifoThroughputLimit { get; set; }

    /// <summary>Length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling AWS KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). The default is 300 (5 minutes).</summary>
    [JsonPropertyName("kmsDataKeyReusePeriodSeconds")]
    public double? KmsDataKeyReusePeriodSeconds { get; set; }

    /// <summary>ID of an AWS-managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see Key Terms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</summary>
    [JsonPropertyName("maxMessageSize")]
    public double? MaxMessageSize { get; set; }

    /// <summary>Number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</summary>
    [JsonPropertyName("messageRetentionSeconds")]
    public double? MessageRetentionSeconds { get; set; }

    /// <summary>Name of the queue. Queue names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 80 characters long. For a FIFO (first-in-first-out) queue, the name must end with the .fifo suffix. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON policy for the SQS queue. It is preferred to use the aws_sqs_queue_policy resource instead.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Time for which a ReceiveMessage call will wait for a message to arrive (long polling) before returning. An integer from 0 to 20 (seconds). The default for this attribute is 0, meaning that the call will return immediately.</summary>
    [JsonPropertyName("receiveWaitTimeSeconds")]
    public double? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue redrive permission, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_allow_policy resource instead.</summary>
    [JsonPropertyName("redriveAllowPolicy")]
    public string? RedriveAllowPolicy { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_policy resource instead. Note: when specifying maxReceiveCount, you must specify it as an integer (5), and not a string ("5").</summary>
    [JsonPropertyName("redrivePolicy")]
    public string? RedrivePolicy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Boolean to enable server-side encryption (SSE) of message content with SQS-owned encryption keys. See Encryption at rest.</summary>
    [JsonPropertyName("sqsManagedSseEnabled")]
    public bool? SqsManagedSseEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see AWS docs.</summary>
    [JsonPropertyName("visibilityTimeoutSeconds")]
    public double? VisibilityTimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProvider
{
    /// <summary>Enables content-based deduplication for FIFO queues. For more information, see the related documentation.</summary>
    [JsonPropertyName("contentBasedDeduplication")]
    public bool? ContentBasedDeduplication { get; set; }

    /// <summary>Specifies whether message deduplication occurs at the message group or queue level. Valid values are messageGroup and queue (default).</summary>
    [JsonPropertyName("deduplicationScope")]
    public string? DeduplicationScope { get; set; }

    /// <summary>Time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 seconds.</summary>
    [JsonPropertyName("delaySeconds")]
    public double? DelaySeconds { get; set; }

    /// <summary>Boolean designating a FIFO queue. If not set, it defaults to false making it standard.</summary>
    [JsonPropertyName("fifoQueue")]
    public bool? FifoQueue { get; set; }

    /// <summary>Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are perQueue (default) and perMessageGroupId.</summary>
    [JsonPropertyName("fifoThroughputLimit")]
    public string? FifoThroughputLimit { get; set; }

    /// <summary>Length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling AWS KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). The default is 300 (5 minutes).</summary>
    [JsonPropertyName("kmsDataKeyReusePeriodSeconds")]
    public double? KmsDataKeyReusePeriodSeconds { get; set; }

    /// <summary>ID of an AWS-managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see Key Terms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</summary>
    [JsonPropertyName("maxMessageSize")]
    public double? MaxMessageSize { get; set; }

    /// <summary>Number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</summary>
    [JsonPropertyName("messageRetentionSeconds")]
    public double? MessageRetentionSeconds { get; set; }

    /// <summary>Name of the queue. Queue names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 80 characters long. For a FIFO (first-in-first-out) queue, the name must end with the .fifo suffix. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON policy for the SQS queue. It is preferred to use the aws_sqs_queue_policy resource instead.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Time for which a ReceiveMessage call will wait for a message to arrive (long polling) before returning. An integer from 0 to 20 (seconds). The default for this attribute is 0, meaning that the call will return immediately.</summary>
    [JsonPropertyName("receiveWaitTimeSeconds")]
    public double? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue redrive permission, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_allow_policy resource instead.</summary>
    [JsonPropertyName("redriveAllowPolicy")]
    public string? RedriveAllowPolicy { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_policy resource instead. Note: when specifying maxReceiveCount, you must specify it as an integer (5), and not a string ("5").</summary>
    [JsonPropertyName("redrivePolicy")]
    public string? RedrivePolicy { get; set; }

    /// <summary>Boolean to enable server-side encryption (SSE) of message content with SQS-owned encryption keys. See Encryption at rest.</summary>
    [JsonPropertyName("sqsManagedSseEnabled")]
    public bool? SqsManagedSseEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see AWS docs.</summary>
    [JsonPropertyName("visibilityTimeoutSeconds")]
    public double? VisibilityTimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>QueueSpec defines the desired state of Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1QueueSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1QueueSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1QueueSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1QueueSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProvider
{
    /// <summary>ARN of the SQS queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Enables content-based deduplication for FIFO queues. For more information, see the related documentation.</summary>
    [JsonPropertyName("contentBasedDeduplication")]
    public bool? ContentBasedDeduplication { get; set; }

    /// <summary>Specifies whether message deduplication occurs at the message group or queue level. Valid values are messageGroup and queue (default).</summary>
    [JsonPropertyName("deduplicationScope")]
    public string? DeduplicationScope { get; set; }

    /// <summary>Time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 seconds.</summary>
    [JsonPropertyName("delaySeconds")]
    public double? DelaySeconds { get; set; }

    /// <summary>Boolean designating a FIFO queue. If not set, it defaults to false making it standard.</summary>
    [JsonPropertyName("fifoQueue")]
    public bool? FifoQueue { get; set; }

    /// <summary>Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are perQueue (default) and perMessageGroupId.</summary>
    [JsonPropertyName("fifoThroughputLimit")]
    public string? FifoThroughputLimit { get; set; }

    /// <summary>URL for the created Amazon SQS queue.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling AWS KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). The default is 300 (5 minutes).</summary>
    [JsonPropertyName("kmsDataKeyReusePeriodSeconds")]
    public double? KmsDataKeyReusePeriodSeconds { get; set; }

    /// <summary>ID of an AWS-managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see Key Terms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</summary>
    [JsonPropertyName("maxMessageSize")]
    public double? MaxMessageSize { get; set; }

    /// <summary>Number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</summary>
    [JsonPropertyName("messageRetentionSeconds")]
    public double? MessageRetentionSeconds { get; set; }

    /// <summary>Name of the queue. Queue names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 80 characters long. For a FIFO (first-in-first-out) queue, the name must end with the .fifo suffix. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON policy for the SQS queue. It is preferred to use the aws_sqs_queue_policy resource instead.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Time for which a ReceiveMessage call will wait for a message to arrive (long polling) before returning. An integer from 0 to 20 (seconds). The default for this attribute is 0, meaning that the call will return immediately.</summary>
    [JsonPropertyName("receiveWaitTimeSeconds")]
    public double? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue redrive permission, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_allow_policy resource instead.</summary>
    [JsonPropertyName("redriveAllowPolicy")]
    public string? RedriveAllowPolicy { get; set; }

    /// <summary>JSON policy to set up the Dead Letter Queue, see AWS docs. It is preferred to use the aws_sqs_queue_redrive_policy resource instead. Note: when specifying maxReceiveCount, you must specify it as an integer (5), and not a string ("5").</summary>
    [JsonPropertyName("redrivePolicy")]
    public string? RedrivePolicy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Boolean to enable server-side encryption (SSE) of message content with SQS-owned encryption keys. See Encryption at rest.</summary>
    [JsonPropertyName("sqsManagedSseEnabled")]
    public bool? SqsManagedSseEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Same as id: The URL for the created Amazon SQS queue.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see AWS docs.</summary>
    [JsonPropertyName("visibilityTimeoutSeconds")]
    public double? VisibilityTimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusConditions
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
#nullable disable

#nullable enable
/// <summary>QueueStatus defines the observed state of Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1QueueStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1QueueStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Queue is the Schema for the Queues API. Provides a SQS resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Queue : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1QueueSpec>, IStatus<V1beta1QueueStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Queue";
    public const string KubeGroup = "sqs.aws.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QueueSpec defines the desired state of Queue</summary>
    [JsonPropertyName("spec")]
    public V1beta1QueueSpec Spec { get; set; }

    /// <summary>QueueStatus defines the observed state of Queue.</summary>
    [JsonPropertyName("status")]
    public V1beta1QueueStatus? Status { get; set; }
}
#nullable disable
