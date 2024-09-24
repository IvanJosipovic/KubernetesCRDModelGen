using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.timeseriesinsights.azure.upbound.io;
public enum V1beta1EventSourceIOTHubSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate iothubName.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderIothubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate iothubName.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderIothubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the IotHub.</summary>
public partial class V1beta1EventSourceIOTHubSpecForProviderSharedAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1EventSourceIOTHubSpecForProvider
{
    /// <summary>Specifies the name of the IotHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Reference to a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameRef")]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameRef? ConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameSelector")]
    public V1beta1EventSourceIOTHubSpecForProviderConsumerGroupNameSelector? ConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the id of the IoT Time Series Insights Environment that the Event Source should be associated with. Changing this forces a new resource to created.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>Reference to a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
    [JsonPropertyName("environmentIdRef")]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdRef? EnvironmentIdRef { get; set; }

    /// <summary>Selector for a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
    [JsonPropertyName("environmentIdSelector")]
    public V1beta1EventSourceIOTHubSpecForProviderEnvironmentIdSelector? EnvironmentIdSelector { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdRef")]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdRef? EventSourceResourceIdRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdSelector")]
    public V1beta1EventSourceIOTHubSpecForProviderEventSourceResourceIdSelector? EventSourceResourceIdSelector { get; set; }

    /// <summary>Specifies the name of the IotHub which will be associated with this resource.</summary>
    [JsonPropertyName("iothubName")]
    public string? IothubName { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameRef")]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameRef? IothubNameRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameSelector")]
    public V1beta1EventSourceIOTHubSpecForProviderIothubNameSelector? IothubNameSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the IotHub.</summary>
    [JsonPropertyName("sharedAccessKeyName")]
    public string? SharedAccessKeyName { get; set; }

    /// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the IotHub.</summary>
    [JsonPropertyName("sharedAccessKeySecretRef")]
    public V1beta1EventSourceIOTHubSpecForProviderSharedAccessKeySecretRef? SharedAccessKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the value that will be used as the event source's timestamp. This value defaults to the event creation time.</summary>
    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a IOTHub in devices to populate iothubName.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderIothubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a IOTHub in devices to populate iothubName.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the IotHub.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProviderSharedAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1EventSourceIOTHubSpecInitProvider
{
    /// <summary>Specifies the name of the IotHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Reference to a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameRef")]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameRef? ConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a IOTHubConsumerGroup in devices to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameSelector")]
    public V1beta1EventSourceIOTHubSpecInitProviderConsumerGroupNameSelector? ConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdRef")]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdRef? EventSourceResourceIdRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdSelector")]
    public V1beta1EventSourceIOTHubSpecInitProviderEventSourceResourceIdSelector? EventSourceResourceIdSelector { get; set; }

    /// <summary>Specifies the name of the IotHub which will be associated with this resource.</summary>
    [JsonPropertyName("iothubName")]
    public string? IothubName { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameRef")]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameRef? IothubNameRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameSelector")]
    public V1beta1EventSourceIOTHubSpecInitProviderIothubNameSelector? IothubNameSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the IotHub.</summary>
    [JsonPropertyName("sharedAccessKeyName")]
    public string? SharedAccessKeyName { get; set; }

    /// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the IotHub.</summary>
    [JsonPropertyName("sharedAccessKeySecretRef")]
    public V1beta1EventSourceIOTHubSpecInitProviderSharedAccessKeySecretRef SharedAccessKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the value that will be used as the event source's timestamp. This value defaults to the event creation time.</summary>
    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecManagementPoliciesEnum
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

public enum V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1EventSourceIOTHubSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EventSourceIOTHubSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1EventSourceIOTHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EventSourceIOTHubSpec defines the desired state of EventSourceIOTHub</summary>
public partial class V1beta1EventSourceIOTHubSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceIOTHubSpecDeletionPolicyEnum>))]
    public V1beta1EventSourceIOTHubSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventSourceIOTHubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventSourceIOTHubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventSourceIOTHubSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventSourceIOTHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EventSourceIOTHubSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventSourceIOTHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1EventSourceIOTHubStatusAtProvider
{
    /// <summary>Specifies the name of the IotHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Specifies the id of the IoT Time Series Insights Environment that the Event Source should be associated with. Changing this forces a new resource to created.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>The ID of the IoT Time Series Insights IoTHub Event Source.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the IotHub which will be associated with this resource.</summary>
    [JsonPropertyName("iothubName")]
    public string? IothubName { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the IotHub.</summary>
    [JsonPropertyName("sharedAccessKeyName")]
    public string? SharedAccessKeyName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the value that will be used as the event source's timestamp. This value defaults to the event creation time.</summary>
    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1EventSourceIOTHubStatusConditions
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

/// <summary>EventSourceIOTHubStatus defines the observed state of EventSourceIOTHub.</summary>
public partial class V1beta1EventSourceIOTHubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventSourceIOTHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventSourceIOTHubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>EventSourceIOTHub is the Schema for the EventSourceIOTHubs API. Manages an Azure IoT Time Series Insights IoTHub Event Source.</summary>
public partial class V1beta1EventSourceIOTHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventSourceIOTHubSpec>, IStatus<V1beta1EventSourceIOTHubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSourceIOTHub";
    public const string KubeGroup = "timeseriesinsights.azure.upbound.io";
    public const string KubePluralName = "eventsourceiothubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSourceIOTHubSpec defines the desired state of EventSourceIOTHub</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventSourceIOTHubSpec Spec { get; set; }

    /// <summary>EventSourceIOTHubStatus defines the observed state of EventSourceIOTHub.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventSourceIOTHubStatus? Status { get; set; }
}