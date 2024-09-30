using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>CrossNamespaceObjectReference contains enough information to let you locate the typed referenced object at cluster level</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecResources
{
    /// <summary>API version of the referent</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed. MatchLabels requires the name to be set to `*`.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Name of the referent If multiple resources are targeted `*` may be set.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SecretRef specifies the Secret containing the token used to validate the payload authenticity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverSpec
{
    /// <summary>Events specifies the list of event types to handle, e.g. 'push' for GitHub or 'Push Hook' for GitLab.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Interval at which to reconcile the Receiver with its Secret references.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>A list of resources to be notified about changes.</summary>
    [JsonPropertyName("resources")]
    public IList<V1ReceiverSpecResources> Resources { get; set; }

    /// <summary>SecretRef specifies the Secret containing the token used to validate the payload authenticity.</summary>
    [JsonPropertyName("secretRef")]
    public V1ReceiverSpecSecretRef SecretRef { get; set; }

    /// <summary>Suspend tells the controller to suspend subsequent events handling for this receiver.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Type of webhook sender, used to determine the validation procedure and payload deserialization.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ReceiverStatus
{
    /// <summary>Conditions holds the conditions for the Receiver.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ReceiverStatusConditions>? Conditions { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the Receiver object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>WebhookPath is the generated incoming webhook address in the format of '/hook/sha256sum(token+name+namespace)'.</summary>
    [JsonPropertyName("webhookPath")]
    public string? WebhookPath { get; set; }
}

/// <summary>Receiver is the Schema for the receivers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Receiver : IKubernetesObject<V1ObjectMeta>, ISpec<V1ReceiverSpec>, IStatus<V1ReceiverStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Receiver";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "receivers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReceiverSpec defines the desired state of the Receiver.</summary>
    [JsonPropertyName("spec")]
    public V1ReceiverSpec? Spec { get; set; }

    /// <summary>ReceiverStatus defines the observed state of the Receiver.</summary>
    [JsonPropertyName("status")]
    public V1ReceiverStatus? Status { get; set; }
}