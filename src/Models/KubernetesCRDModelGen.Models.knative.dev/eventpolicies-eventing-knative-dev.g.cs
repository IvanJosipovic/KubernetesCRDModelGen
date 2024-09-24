using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.knative.dev;
public partial class V1alpha1EventPolicySpecFromRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ This is optional field, it gets defaulted to the object holding it if left out.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1EventPolicySpecFrom
{
    /// <summary>Ref contains a direct reference to a resource which is allowed to send events to the target.</summary>
    [JsonPropertyName("ref")]
    public V1alpha1EventPolicySpecFromRef? Ref { get; set; }

    /// <summary>Sub sets the OIDC identity name to be allowed to send events to the target. It is also possible to set a glob-like pattern to match any suffix.</summary>
    [JsonPropertyName("sub")]
    public string? Sub { get; set; }
}

public partial class V1alpha1EventPolicySpecToRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1alpha1EventPolicySpecToSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public partial class V1alpha1EventPolicySpecToSelector
{
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1EventPolicySpecToSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public JsonNode? MatchLabels { get; set; }
}

public partial class V1alpha1EventPolicySpecTo
{
    /// <summary>Ref contains the direct reference to a target</summary>
    [JsonPropertyName("ref")]
    public V1alpha1EventPolicySpecToRef? Ref { get; set; }

    /// <summary>Selector contains a selector to group targets</summary>
    [JsonPropertyName("selector")]
    public V1alpha1EventPolicySpecToSelector? Selector { get; set; }
}

public partial class V1alpha1EventPolicySpec
{
    /// <summary>From is the list of sources or oidc identities, which are allowed to send events to the targets (.spec.to).</summary>
    [JsonPropertyName("from")]
    public IList<V1alpha1EventPolicySpecFrom>? From { get; set; }

    /// <summary>To lists all resources for which this policy applies. Resources in this list must act like an ingress and have an audience. The resources are part of the same namespace as the EventPolicy. An empty list means it applies to all resources in the EventPolicies namespace</summary>
    [JsonPropertyName("to")]
    public IList<V1alpha1EventPolicySpecTo>? To { get; set; }
}

public partial class V1alpha1EventPolicyStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1alpha1EventPolicyStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>From is the list of resolved oidc identities from .spec.from</summary>
    [JsonPropertyName("from")]
    public IList<string>? From { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventPolicySpec>, IStatus<V1alpha1EventPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventPolicy";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "eventpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the EventPolicy.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EventPolicySpec? Spec { get; set; }

    /// <summary>Status represents the current state of the EventPolicy. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventPolicyStatus? Status { get; set; }
}