using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a servicebus.azure.com/Namespace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20211101.NamespacesQueue_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxMessageSizeInKilobytes")]
    public int? MaxMessageSizeInKilobytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public int? MaxSizeInMegabytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a servicebus.azure.com/Namespace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211101storageNamespacesQueueSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20211101.MessageCountDetails_STATUS Message Count Details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueStatusCountDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeMessageCount")]
    public int? ActiveMessageCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deadLetterMessageCount")]
    public int? DeadLetterMessageCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheduledMessageCount")]
    public int? ScheduledMessageCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transferDeadLetterMessageCount")]
    public int? TransferDeadLetterMessageCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transferMessageCount")]
    public int? TransferMessageCount { get; set; }
}

/// <summary>Storage version of v1api20211101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20211101.NamespacesQueue_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesQueueStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessedAt")]
    public string? AccessedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageNamespacesQueueStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20211101.MessageCountDetails_STATUS Message Count Details.</summary>
    [JsonPropertyName("countDetails")]
    public V1api20211101storageNamespacesQueueStatusCountDetails? CountDetails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxMessageSizeInKilobytes")]
    public int? MaxMessageSizeInKilobytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public int? MaxSizeInMegabytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messageCount")]
    public int? MessageCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sizeInBytes")]
    public int? SizeInBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Storage version of v1api20211101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211101storageNamespacesQueueStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>Storage version of v1api20211101.NamespacesQueue Generator information: - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/Queue.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageNamespacesQueue : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageNamespacesQueueSpec>, IStatus<V1api20211101storageNamespacesQueueStatus>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "NamespacesQueue";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacesqueues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.NamespacesQueue_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageNamespacesQueueSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.NamespacesQueue_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageNamespacesQueueStatus? Status { get; set; }
}