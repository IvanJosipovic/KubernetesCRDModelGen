using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.upbound.io;
public enum V1beta1WebPubsubHubSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandlerAuth
{
    /// <summary>Specify the identity ID of the target resource.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate managedIdentityId.</summary>
    [JsonPropertyName("managedIdentityIdRef")]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdRef? ManagedIdentityIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate managedIdentityId.</summary>
    [JsonPropertyName("managedIdentityIdSelector")]
    public V1beta1WebPubsubHubSpecForProviderEventHandlerAuthManagedIdentityIdSelector? ManagedIdentityIdSelector { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventHandler
{
    /// <summary>An auth block as defined below.</summary>
    [JsonPropertyName("auth")]
    public IList<V1beta1WebPubsubHubSpecForProviderEventHandlerAuth>? Auth { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connect, connected and disconnected.</summary>
    [JsonPropertyName("systemEvents")]
    public IList<string>? SystemEvents { get; set; }

    /// <summary>The Event Handler URL Template. Two predefined parameters {hub} and {event} are available to use in the template. The value of the EventHandler URL is dynamically calculated when the client request comes in. Example: http://example.com/api/{hub}/{event}.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }

    /// <summary>Specifies the matching event names. There are 3 kind of patterns supported: * * matches any event name * , Combine multiple events with , for example event1,event2, it matches event event1 and event2 * The single event name, for example event1, it matches event1.</summary>
    [JsonPropertyName("userEventPattern")]
    public string? UserEventPattern { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderEventListener
{
    /// <summary>Specifies the event hub name to receive the events.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the event hub namespace name to receive the events.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameRef")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameRef? EventhubNamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameSelector")]
    public V1beta1WebPubsubHubSpecForProviderEventListenerEventhubNamespaceNameSelector? EventhubNamespaceNameSelector { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connected and disconnected.</summary>
    [JsonPropertyName("systemEventNameFilter")]
    public IList<string>? SystemEventNameFilter { get; set; }

    /// <summary>Specifies the list of matching user event names. ["*"] can be used to match all events.</summary>
    [JsonPropertyName("userEventNameFilter")]
    public IList<string>? UserEventNameFilter { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderWebPubsubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecForProvider
{
    /// <summary>Is anonymous connections are allowed for this hub? Defaults to false. Possible values are true, false.</summary>
    [JsonPropertyName("anonymousConnectionsEnabled")]
    public bool? AnonymousConnectionsEnabled { get; set; }

    /// <summary>An event_handler block as defined below.</summary>
    [JsonPropertyName("eventHandler")]
    public IList<V1beta1WebPubsubHubSpecForProviderEventHandler>? EventHandler { get; set; }

    /// <summary>An event_listener block as defined below.</summary>
    [JsonPropertyName("eventListener")]
    public IList<V1beta1WebPubsubHubSpecForProviderEventListener>? EventListener { get; set; }

    /// <summary>The name of the Web Pubsub hub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the id of the Web Pubsub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }

    /// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdRef")]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdRef? WebPubsubIdRef { get; set; }

    /// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdSelector")]
    public V1beta1WebPubsubHubSpecForProviderWebPubsubIdSelector? WebPubsubIdSelector { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandlerAuth
{
    /// <summary>Specify the identity ID of the target resource.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate managedIdentityId.</summary>
    [JsonPropertyName("managedIdentityIdRef")]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdRef? ManagedIdentityIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate managedIdentityId.</summary>
    [JsonPropertyName("managedIdentityIdSelector")]
    public V1beta1WebPubsubHubSpecInitProviderEventHandlerAuthManagedIdentityIdSelector? ManagedIdentityIdSelector { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventHandler
{
    /// <summary>An auth block as defined below.</summary>
    [JsonPropertyName("auth")]
    public IList<V1beta1WebPubsubHubSpecInitProviderEventHandlerAuth>? Auth { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connect, connected and disconnected.</summary>
    [JsonPropertyName("systemEvents")]
    public IList<string>? SystemEvents { get; set; }

    /// <summary>The Event Handler URL Template. Two predefined parameters {hub} and {event} are available to use in the template. The value of the EventHandler URL is dynamically calculated when the client request comes in. Example: http://example.com/api/{hub}/{event}.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }

    /// <summary>Specifies the matching event names. There are 3 kind of patterns supported: * * matches any event name * , Combine multiple events with , for example event1,event2, it matches event event1 and event2 * The single event name, for example event1, it matches event1.</summary>
    [JsonPropertyName("userEventPattern")]
    public string? UserEventPattern { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderEventListener
{
    /// <summary>Specifies the event hub name to receive the events.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the event hub namespace name to receive the events.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameRef")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameRef? EventhubNamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameSelector")]
    public V1beta1WebPubsubHubSpecInitProviderEventListenerEventhubNamespaceNameSelector? EventhubNamespaceNameSelector { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connected and disconnected.</summary>
    [JsonPropertyName("systemEventNameFilter")]
    public IList<string>? SystemEventNameFilter { get; set; }

    /// <summary>Specifies the list of matching user event names. ["*"] can be used to match all events.</summary>
    [JsonPropertyName("userEventNameFilter")]
    public IList<string>? UserEventNameFilter { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecInitProvider
{
    /// <summary>Is anonymous connections are allowed for this hub? Defaults to false. Possible values are true, false.</summary>
    [JsonPropertyName("anonymousConnectionsEnabled")]
    public bool? AnonymousConnectionsEnabled { get; set; }

    /// <summary>An event_handler block as defined below.</summary>
    [JsonPropertyName("eventHandler")]
    public IList<V1beta1WebPubsubHubSpecInitProviderEventHandler>? EventHandler { get; set; }

    /// <summary>An event_listener block as defined below.</summary>
    [JsonPropertyName("eventListener")]
    public IList<V1beta1WebPubsubHubSpecInitProviderEventListener>? EventListener { get; set; }

    /// <summary>The name of the Web Pubsub hub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the id of the Web Pubsub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }

    /// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdRef")]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdRef? WebPubsubIdRef { get; set; }

    /// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdSelector")]
    public V1beta1WebPubsubHubSpecInitProviderWebPubsubIdSelector? WebPubsubIdSelector { get; set; }
}

public enum V1beta1WebPubsubHubSpecManagementPoliciesEnum
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

public enum V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1WebPubsubHubSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1WebPubsubHubSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1WebPubsubHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WebPubsubHubSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebPubsubHubSpecDeletionPolicyEnum>))]
    public V1beta1WebPubsubHubSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebPubsubHubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebPubsubHubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WebPubsubHubSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebPubsubHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WebPubsubHubSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebPubsubHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1WebPubsubHubStatusAtProviderEventHandlerAuth
{
    /// <summary>Specify the identity ID of the target resource.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

public partial class V1beta1WebPubsubHubStatusAtProviderEventHandler
{
    /// <summary>An auth block as defined below.</summary>
    [JsonPropertyName("auth")]
    public IList<V1beta1WebPubsubHubStatusAtProviderEventHandlerAuth>? Auth { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connect, connected and disconnected.</summary>
    [JsonPropertyName("systemEvents")]
    public IList<string>? SystemEvents { get; set; }

    /// <summary>The Event Handler URL Template. Two predefined parameters {hub} and {event} are available to use in the template. The value of the EventHandler URL is dynamically calculated when the client request comes in. Example: http://example.com/api/{hub}/{event}.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }

    /// <summary>Specifies the matching event names. There are 3 kind of patterns supported: * * matches any event name * , Combine multiple events with , for example event1,event2, it matches event event1 and event2 * The single event name, for example event1, it matches event1.</summary>
    [JsonPropertyName("userEventPattern")]
    public string? UserEventPattern { get; set; }
}

public partial class V1beta1WebPubsubHubStatusAtProviderEventListener
{
    /// <summary>Specifies the event hub name to receive the events.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Specifies the event hub namespace name to receive the events.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>Specifies the list of system events. Supported values are connected and disconnected.</summary>
    [JsonPropertyName("systemEventNameFilter")]
    public IList<string>? SystemEventNameFilter { get; set; }

    /// <summary>Specifies the list of matching user event names. ["*"] can be used to match all events.</summary>
    [JsonPropertyName("userEventNameFilter")]
    public IList<string>? UserEventNameFilter { get; set; }
}

public partial class V1beta1WebPubsubHubStatusAtProvider
{
    /// <summary>Is anonymous connections are allowed for this hub? Defaults to false. Possible values are true, false.</summary>
    [JsonPropertyName("anonymousConnectionsEnabled")]
    public bool? AnonymousConnectionsEnabled { get; set; }

    /// <summary>An event_handler block as defined below.</summary>
    [JsonPropertyName("eventHandler")]
    public IList<V1beta1WebPubsubHubStatusAtProviderEventHandler>? EventHandler { get; set; }

    /// <summary>An event_listener block as defined below.</summary>
    [JsonPropertyName("eventListener")]
    public IList<V1beta1WebPubsubHubStatusAtProviderEventListener>? EventListener { get; set; }

    /// <summary>The ID of the Web Pubsub Hub resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Web Pubsub hub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the id of the Web Pubsub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }
}

public partial class V1beta1WebPubsubHubStatusConditions
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

public partial class V1beta1WebPubsubHubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebPubsubHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebPubsubHubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebPubsubHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebPubsubHubSpec>, IStatus<V1beta1WebPubsubHubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebPubsubHub";
    public const string KubeGroup = "signalrservice.azure.upbound.io";
    public const string KubePluralName = "webpubsubhubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebPubsubHubSpec defines the desired state of WebPubsubHub</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebPubsubHubSpec Spec { get; set; }

    /// <summary>WebPubsubHubStatus defines the observed state of WebPubsubHub.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebPubsubHubStatus? Status { get; set; }
}