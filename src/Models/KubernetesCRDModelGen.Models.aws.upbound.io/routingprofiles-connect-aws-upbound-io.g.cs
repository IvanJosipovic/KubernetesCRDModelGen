using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.connect.aws.upbound.io;
public enum V1beta2RoutingProfileSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in connect to populate defaultOutboundQueueId.</summary>
public partial class V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in connect to populate defaultOutboundQueueId.</summary>
public partial class V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
public partial class V1beta2RoutingProfileSpecForProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecForProviderInstanceIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
public partial class V1beta2RoutingProfileSpecForProviderInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecForProviderInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileSpecForProviderMediaConcurrencies
{
    /// <summary>Specifies the channels that agents can handle in the Contact Control Panel (CCP). Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the number of contacts an agent can have on a channel simultaneously. Valid Range for VOICE: Minimum value of 1. Maximum value of 1. Valid Range for CHAT: Minimum value of 1. Maximum value of 10. Valid Range for TASK: Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileSpecForProviderQueueConfigs
{
    /// <summary>Specifies the channels agents can handle in the Contact Control Panel (CCP) for this routing profile. Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the delay, in seconds, that a contact should be in the queue before they are routed to an available agent</summary>
    [JsonPropertyName("delay")]
    public double? Delay { get; set; }

    /// <summary>Specifies the order in which contacts are to be handled for the queue.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the identifier for the queue.</summary>
    [JsonPropertyName("queueId")]
    public string? QueueId { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileSpecForProvider
{
    /// <summary>Specifies the default outbound queue for the Routing Profile.</summary>
    [JsonPropertyName("defaultOutboundQueueId")]
    public string? DefaultOutboundQueueId { get; set; }

    /// <summary>Reference to a Queue in connect to populate defaultOutboundQueueId.</summary>
    [JsonPropertyName("defaultOutboundQueueIdRef")]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdRef? DefaultOutboundQueueIdRef { get; set; }

    /// <summary>Selector for a Queue in connect to populate defaultOutboundQueueId.</summary>
    [JsonPropertyName("defaultOutboundQueueIdSelector")]
    public V1beta2RoutingProfileSpecForProviderDefaultOutboundQueueIdSelector? DefaultOutboundQueueIdSelector { get; set; }

    /// <summary>Specifies the description of the Routing Profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2RoutingProfileSpecForProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2RoutingProfileSpecForProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>One or more media_concurrencies blocks that specify the channels that agents can handle in the Contact Control Panel (CCP) for this Routing Profile. The media_concurrencies block is documented below.</summary>
    [JsonPropertyName("mediaConcurrencies")]
    public IList<V1beta2RoutingProfileSpecForProviderMediaConcurrencies>? MediaConcurrencies { get; set; }

    /// <summary>Specifies the name of the Routing Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more queue_configs blocks that specify the inbound queues associated with the routing profile. If no queue is added, the agent only can make outbound calls. The queue_configs block is documented below.</summary>
    [JsonPropertyName("queueConfigs")]
    public IList<V1beta2RoutingProfileSpecForProviderQueueConfigs>? QueueConfigs { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in connect to populate defaultOutboundQueueId.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in connect to populate defaultOutboundQueueId.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
public partial class V1beta2RoutingProfileSpecInitProviderInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileSpecInitProviderMediaConcurrencies
{
    /// <summary>Specifies the channels that agents can handle in the Contact Control Panel (CCP). Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the number of contacts an agent can have on a channel simultaneously. Valid Range for VOICE: Minimum value of 1. Maximum value of 1. Valid Range for CHAT: Minimum value of 1. Maximum value of 10. Valid Range for TASK: Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileSpecInitProviderQueueConfigs
{
    /// <summary>Specifies the channels agents can handle in the Contact Control Panel (CCP) for this routing profile. Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the delay, in seconds, that a contact should be in the queue before they are routed to an available agent</summary>
    [JsonPropertyName("delay")]
    public double? Delay { get; set; }

    /// <summary>Specifies the order in which contacts are to be handled for the queue.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the identifier for the queue.</summary>
    [JsonPropertyName("queueId")]
    public string? QueueId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta2RoutingProfileSpecInitProvider
{
    /// <summary>Specifies the default outbound queue for the Routing Profile.</summary>
    [JsonPropertyName("defaultOutboundQueueId")]
    public string? DefaultOutboundQueueId { get; set; }

    /// <summary>Reference to a Queue in connect to populate defaultOutboundQueueId.</summary>
    [JsonPropertyName("defaultOutboundQueueIdRef")]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdRef? DefaultOutboundQueueIdRef { get; set; }

    /// <summary>Selector for a Queue in connect to populate defaultOutboundQueueId.</summary>
    [JsonPropertyName("defaultOutboundQueueIdSelector")]
    public V1beta2RoutingProfileSpecInitProviderDefaultOutboundQueueIdSelector? DefaultOutboundQueueIdSelector { get; set; }

    /// <summary>Specifies the description of the Routing Profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2RoutingProfileSpecInitProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>One or more media_concurrencies blocks that specify the channels that agents can handle in the Contact Control Panel (CCP) for this Routing Profile. The media_concurrencies block is documented below.</summary>
    [JsonPropertyName("mediaConcurrencies")]
    public IList<V1beta2RoutingProfileSpecInitProviderMediaConcurrencies>? MediaConcurrencies { get; set; }

    /// <summary>Specifies the name of the Routing Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more queue_configs blocks that specify the inbound queues associated with the routing profile. If no queue is added, the agent only can make outbound calls. The queue_configs block is documented below.</summary>
    [JsonPropertyName("queueConfigs")]
    public IList<V1beta2RoutingProfileSpecInitProviderQueueConfigs>? QueueConfigs { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta2RoutingProfileSpecManagementPoliciesEnum
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

public enum V1beta2RoutingProfileSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta2RoutingProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta2RoutingProfileSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta2RoutingProfileSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta2RoutingProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RoutingProfileSpec defines the desired state of RoutingProfile</summary>
public partial class V1beta2RoutingProfileSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RoutingProfileSpecDeletionPolicyEnum>))]
    public V1beta2RoutingProfileSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta2RoutingProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta2RoutingProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2RoutingProfileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RoutingProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta2RoutingProfileSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RoutingProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileStatusAtProviderMediaConcurrencies
{
    /// <summary>Specifies the channels that agents can handle in the Contact Control Panel (CCP). Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the number of contacts an agent can have on a channel simultaneously. Valid Range for VOICE: Minimum value of 1. Maximum value of 1. Valid Range for CHAT: Minimum value of 1. Maximum value of 10. Valid Range for TASK: Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileStatusAtProviderQueueConfigs
{
    /// <summary>Specifies the channels agents can handle in the Contact Control Panel (CCP) for this routing profile. Valid values are VOICE, CHAT, TASK.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Specifies the delay, in seconds, that a contact should be in the queue before they are routed to an available agent</summary>
    [JsonPropertyName("delay")]
    public double? Delay { get; set; }

    /// <summary>Specifies the order in which contacts are to be handled for the queue.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ARN for the queue.</summary>
    [JsonPropertyName("queueArn")]
    public string? QueueArn { get; set; }

    /// <summary>Specifies the identifier for the queue.</summary>
    [JsonPropertyName("queueId")]
    public string? QueueId { get; set; }

    /// <summary>Name for the queue.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary></summary>
public partial class V1beta2RoutingProfileStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Routing Profile.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies the default outbound queue for the Routing Profile.</summary>
    [JsonPropertyName("defaultOutboundQueueId")]
    public string? DefaultOutboundQueueId { get; set; }

    /// <summary>Specifies the description of the Routing Profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance and identifier of the Routing Profile separated by a colon (:).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>One or more media_concurrencies blocks that specify the channels that agents can handle in the Contact Control Panel (CCP) for this Routing Profile. The media_concurrencies block is documented below.</summary>
    [JsonPropertyName("mediaConcurrencies")]
    public IList<V1beta2RoutingProfileStatusAtProviderMediaConcurrencies>? MediaConcurrencies { get; set; }

    /// <summary>Specifies the name of the Routing Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more queue_configs blocks that specify the inbound queues associated with the routing profile. If no queue is added, the agent only can make outbound calls. The queue_configs block is documented below.</summary>
    [JsonPropertyName("queueConfigs")]
    public IList<V1beta2RoutingProfileStatusAtProviderQueueConfigs>? QueueConfigs { get; set; }

    /// <summary>The identifier for the Routing Profile.</summary>
    [JsonPropertyName("routingProfileId")]
    public string? RoutingProfileId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta2RoutingProfileStatusConditions
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

/// <summary>RoutingProfileStatus defines the observed state of RoutingProfile.</summary>
public partial class V1beta2RoutingProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta2RoutingProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RoutingProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RoutingProfile is the Schema for the RoutingProfiles API. Provides details about a specific Amazon Connect Routing Profile.</summary>
public partial class V1beta2RoutingProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RoutingProfileSpec>, IStatus<V1beta2RoutingProfileStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RoutingProfile";
    public const string KubeGroup = "connect.aws.upbound.io";
    public const string KubePluralName = "routingprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RoutingProfileSpec defines the desired state of RoutingProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta2RoutingProfileSpec Spec { get; set; }

    /// <summary>RoutingProfileStatus defines the observed state of RoutingProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta2RoutingProfileStatus? Status { get; set; }
}