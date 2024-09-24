using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.timeseriesinsights.azure.upbound.io;
public enum V1beta1EventSourceEventHubSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the EventHub.</summary>
public partial class V1beta1EventSourceEventHubSpecForProviderSharedAccessKeySecretRef
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
public partial class V1beta1EventSourceEventHubSpecForProvider
{
    /// <summary>Specifies the name of the EventHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Reference to a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameRef")]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameRef? ConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameSelector")]
    public V1beta1EventSourceEventHubSpecForProviderConsumerGroupNameSelector? ConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the id of the IoT Time Series Insights Environment that the Event Source should be associated with. Changing this forces a new resource to created.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>Reference to a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
    [JsonPropertyName("environmentIdRef")]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdRef? EnvironmentIdRef { get; set; }

    /// <summary>Selector for a Gen2Environment in timeseriesinsights to populate environmentId.</summary>
    [JsonPropertyName("environmentIdSelector")]
    public V1beta1EventSourceEventHubSpecForProviderEnvironmentIdSelector? EnvironmentIdSelector { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdRef")]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdRef? EventSourceResourceIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdSelector")]
    public V1beta1EventSourceEventHubSpecForProviderEventSourceResourceIdSelector? EventSourceResourceIdSelector { get; set; }

    /// <summary>Specifies the name of the EventHub which will be associated with this resource.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1EventSourceEventHubSpecForProviderEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the EventHub Namespace name.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1EventSourceEventHubSpecForProviderNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the EventHub.</summary>
    [JsonPropertyName("sharedAccessKeyName")]
    public string? SharedAccessKeyName { get; set; }

    /// <summary>Reference to a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
    [JsonPropertyName("sharedAccessKeyNameRef")]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameRef? SharedAccessKeyNameRef { get; set; }

    /// <summary>Selector for a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
    [JsonPropertyName("sharedAccessKeyNameSelector")]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeyNameSelector? SharedAccessKeyNameSelector { get; set; }

    /// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the EventHub.</summary>
    [JsonPropertyName("sharedAccessKeySecretRef")]
    public V1beta1EventSourceEventHubSpecForProviderSharedAccessKeySecretRef? SharedAccessKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the value that will be used as the event source's timestamp. This value defaults to the event creation time.</summary>
    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventSourceResourceId.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the EventHub.</summary>
public partial class V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeySecretRef
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
public partial class V1beta1EventSourceEventHubSpecInitProvider
{
    /// <summary>Specifies the name of the EventHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Reference to a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameRef")]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameRef? ConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a ConsumerGroup in eventhub to populate consumerGroupName.</summary>
    [JsonPropertyName("consumerGroupNameSelector")]
    public V1beta1EventSourceEventHubSpecInitProviderConsumerGroupNameSelector? ConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdRef")]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdRef? EventSourceResourceIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventSourceResourceId.</summary>
    [JsonPropertyName("eventSourceResourceIdSelector")]
    public V1beta1EventSourceEventHubSpecInitProviderEventSourceResourceIdSelector? EventSourceResourceIdSelector { get; set; }

    /// <summary>Specifies the name of the EventHub which will be associated with this resource.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1EventSourceEventHubSpecInitProviderEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the EventHub Namespace name.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1EventSourceEventHubSpecInitProviderNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the EventHub.</summary>
    [JsonPropertyName("sharedAccessKeyName")]
    public string? SharedAccessKeyName { get; set; }

    /// <summary>Reference to a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
    [JsonPropertyName("sharedAccessKeyNameRef")]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameRef? SharedAccessKeyNameRef { get; set; }

    /// <summary>Selector for a AuthorizationRule in eventhub to populate sharedAccessKeyName.</summary>
    [JsonPropertyName("sharedAccessKeyNameSelector")]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeyNameSelector? SharedAccessKeyNameSelector { get; set; }

    /// <summary>Specifies the value of the Shared Access Policy key that grants the Time Series Insights service read access to the EventHub.</summary>
    [JsonPropertyName("sharedAccessKeySecretRef")]
    public V1beta1EventSourceEventHubSpecInitProviderSharedAccessKeySecretRef SharedAccessKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the value that will be used as the event source's timestamp. This value defaults to the event creation time.</summary>
    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}

public enum V1beta1EventSourceEventHubSpecManagementPoliciesEnum
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

public enum V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1EventSourceEventHubSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1EventSourceEventHubSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EventSourceEventHubSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1EventSourceEventHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EventSourceEventHubSpec defines the desired state of EventSourceEventHub</summary>
public partial class V1beta1EventSourceEventHubSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceEventHubSpecDeletionPolicyEnum>))]
    public V1beta1EventSourceEventHubSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventSourceEventHubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventSourceEventHubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventSourceEventHubSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventSourceEventHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EventSourceEventHubSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventSourceEventHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1EventSourceEventHubStatusAtProvider
{
    /// <summary>Specifies the name of the EventHub Consumer Group that holds the partitions from which events will be read.</summary>
    [JsonPropertyName("consumerGroupName")]
    public string? ConsumerGroupName { get; set; }

    /// <summary>Specifies the id of the IoT Time Series Insights Environment that the Event Source should be associated with. Changing this forces a new resource to created.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>Specifies the resource id where events will be coming from.</summary>
    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    /// <summary>Specifies the name of the EventHub which will be associated with this resource.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>The ID of the IoT Time Series Insights EventHub Event Source.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the EventHub Namespace name.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Specifies the name of the Shared Access key that grants the Event Source access to the EventHub.</summary>
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
public partial class V1beta1EventSourceEventHubStatusConditions
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

/// <summary>EventSourceEventHubStatus defines the observed state of EventSourceEventHub.</summary>
public partial class V1beta1EventSourceEventHubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventSourceEventHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventSourceEventHubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>EventSourceEventHub is the Schema for the EventSourceEventHubs API. Manages an Azure IoT Time Series Insights EventHub Event Source.</summary>
public partial class V1beta1EventSourceEventHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventSourceEventHubSpec>, IStatus<V1beta1EventSourceEventHubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSourceEventHub";
    public const string KubeGroup = "timeseriesinsights.azure.upbound.io";
    public const string KubePluralName = "eventsourceeventhubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSourceEventHubSpec defines the desired state of EventSourceEventHub</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventSourceEventHubSpec Spec { get; set; }

    /// <summary>EventSourceEventHubStatus defines the observed state of EventSourceEventHub.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventSourceEventHubStatus? Status { get; set; }
}