using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.flows.knative.dev;
public partial class V1ParallelSpecChannelTemplate
{
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Spec defines the Spec to use for each channel created. Passed in verbatim to the Channel CRD as Spec section.</summary>
    [JsonPropertyName("spec")]
    public JsonNode? Spec { get; set; }
}

public partial class V1ParallelSpecReplyRef
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

public partial class V1ParallelSpecReply
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1ParallelSpecReplyRef? Ref { get; set; }

    /// <summary>URI can be an absolute URL(non-empty scheme and non-empty host) pointing to the target or a relative URI. Relative URIs will be resolved using the base URI retrieved from Ref.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience. This only needs to be set if the target is not an Addressable and thus the Audience can't be received from the target itself. If specified, it takes precedence over the target's Audience.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

public partial class V1ParallelSpec
{
    /// <summary>Branches is the list of Filter/Subscribers pairs.</summary>
    [JsonPropertyName("branches")]
    public IList<JsonNode>? Branches { get; set; }

    /// <summary>ChannelTemplate specifies which Channel CRD to use. If left unspecified, it is set to the default Channel CRD for the namespace (or cluster, in case there are no defaults for the namespace).</summary>
    [JsonPropertyName("channelTemplate")]
    public V1ParallelSpecChannelTemplate? ChannelTemplate { get; set; }

    /// <summary>Reply is a Reference to where the result of a case Subscriber gets sent to when the case does not have a Reply</summary>
    [JsonPropertyName("reply")]
    public V1ParallelSpecReply? Reply { get; set; }
}

public partial class V1ParallelStatusAddress
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

public partial class V1ParallelStatusAddresses
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

public partial class V1ParallelStatusAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}

public partial class V1ParallelStatusBranchStatusesFilterChannelStatusChannel
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

public partial class V1ParallelStatusBranchStatusesFilterChannelStatus
{
    /// <summary>Channel is the reference to the underlying channel.</summary>
    [JsonPropertyName("channel")]
    public V1ParallelStatusBranchStatusesFilterChannelStatusChannel? Channel { get; set; }

    /// <summary>ReadyCondition indicates whether the Channel is ready or not.</summary>
    [JsonPropertyName("ready")]
    public JsonNode? Ready { get; set; }
}

public partial class V1ParallelStatusBranchStatusesFilterSubscriptionStatusReady
{
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
    public string? Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1ParallelStatusBranchStatusesFilterSubscriptionStatusSubscription
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

public partial class V1ParallelStatusBranchStatusesFilterSubscriptionStatus
{
    /// <summary>ReadyCondition indicates whether the Subscription is ready or not.</summary>
    [JsonPropertyName("ready")]
    public V1ParallelStatusBranchStatusesFilterSubscriptionStatusReady? Ready { get; set; }

    /// <summary>Subscription is the reference to the underlying Subscription.</summary>
    [JsonPropertyName("subscription")]
    public V1ParallelStatusBranchStatusesFilterSubscriptionStatusSubscription? Subscription { get; set; }
}

public partial class V1ParallelStatusBranchStatusesSubscriberSubscriptionStatusReady
{
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
    public string? Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1ParallelStatusBranchStatusesSubscriberSubscriptionStatusSubscription
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

public partial class V1ParallelStatusBranchStatusesSubscriberSubscriptionStatus
{
    /// <summary>ReadyCondition indicates whether the Subscription is ready or not.</summary>
    [JsonPropertyName("ready")]
    public V1ParallelStatusBranchStatusesSubscriberSubscriptionStatusReady? Ready { get; set; }

    /// <summary>Subscription is the reference to the underlying Subscription.</summary>
    [JsonPropertyName("subscription")]
    public V1ParallelStatusBranchStatusesSubscriberSubscriptionStatusSubscription? Subscription { get; set; }
}

public partial class V1ParallelStatusBranchStatuses
{
    /// <summary>FilterChannelStatus corresponds to the filter channel status.</summary>
    [JsonPropertyName("filterChannelStatus")]
    public V1ParallelStatusBranchStatusesFilterChannelStatus? FilterChannelStatus { get; set; }

    /// <summary>FilterSubscriptionStatus corresponds to the filter subscription status.</summary>
    [JsonPropertyName("filterSubscriptionStatus")]
    public V1ParallelStatusBranchStatusesFilterSubscriptionStatus? FilterSubscriptionStatus { get; set; }

    /// <summary>SubscriptionStatus corresponds to the subscriber subscription status.</summary>
    [JsonPropertyName("subscriberSubscriptionStatus")]
    public V1ParallelStatusBranchStatusesSubscriberSubscriptionStatus? SubscriberSubscriptionStatus { get; set; }
}

public partial class V1ParallelStatusPolicies
{
    /// <summary>The API version of the applied EventPolicy. This indicates, which version of EventPolicy is supported by the resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The name of the applied EventPolicy</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1ParallelStatusConditions
{
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
    public string? Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1ParallelStatusIngressChannelStatusChannel
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

public partial class V1ParallelStatusIngressChannelStatus
{
    /// <summary>Channel is the reference to the underlying channel.</summary>
    [JsonPropertyName("channel")]
    public V1ParallelStatusIngressChannelStatusChannel? Channel { get; set; }

    /// <summary>ReadyCondition indicates whether the Channel is ready or not.</summary>
    [JsonPropertyName("ready")]
    public JsonNode? Ready { get; set; }
}

public partial class V1ParallelStatus
{
    /// <summary>Parallel is Addressable. It exposes the endpoint as an URI to get events delivered into the Parallel.</summary>
    [JsonPropertyName("address")]
    public V1ParallelStatusAddress? Address { get; set; }

    /// <summary>Parallel is Addressable. It exposes the endpoints as URIs to get events delivered into the Parallel.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1ParallelStatusAddresses>? Addresses { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1ParallelStatusAuth? Auth { get; set; }

    /// <summary>BranchStatuses is an array of corresponding to branch statuses. Matches the Spec.Branches array in the order.</summary>
    [JsonPropertyName("branchStatuses")]
    public IList<V1ParallelStatusBranchStatuses>? BranchStatuses { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<V1ParallelStatusPolicies>? Policies { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ParallelStatusConditions>? Conditions { get; set; }

    /// <summary>IngressChannelStatus corresponds to the ingress channel status.</summary>
    [JsonPropertyName("ingressChannelStatus")]
    public V1ParallelStatusIngressChannelStatus? IngressChannelStatus { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Parallel : IKubernetesObject<V1ObjectMeta>, ISpec<V1ParallelSpec>, IStatus<V1ParallelStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Parallel";
    public const string KubeGroup = "flows.knative.dev";
    public const string KubePluralName = "parallels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the Parallel.</summary>
    [JsonPropertyName("spec")]
    public V1ParallelSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the Parallel. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1ParallelStatus? Status { get; set; }
}