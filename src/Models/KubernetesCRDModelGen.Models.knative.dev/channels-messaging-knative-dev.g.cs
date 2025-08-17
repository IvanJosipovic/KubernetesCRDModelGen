using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.messaging.knative.dev;
#nullable enable
/// <summary>Channel represents a generic Channel. It is normally used when we want a Channel, but do not need a specific Channel implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ChannelList : IKubernetesObject<V1ListMeta>, IItems<V1Channel>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ChannelList";
    public const string KubeGroup = "messaging.knative.dev";
    public const string KubePluralName = "channels";
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
    public IList<V1Channel> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ChannelTemplate specifies which Channel CRD to use to create the CRD Channel backing this Channel. This is immutable after creation. Normally this is set by the Channel defaulter, not directly by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelSpecChannelTemplate
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
#nullable disable

#nullable enable
/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelSpecSubscribersAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelSpecSubscribers
{
    /// <summary>DeliverySpec contains options controlling the event delivery</summary>
    [JsonPropertyName("delivery")]
    public JsonNode? Delivery { get; set; }

    /// <summary>Generation of the origin of the subscriber with uid:UID.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>The name of the subscription</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ReplyURI is the endpoint for the reply</summary>
    [JsonPropertyName("replyUri")]
    public string? ReplyUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("replyCACerts")]
    public string? ReplyCACerts { get; set; }

    /// <summary>ReplyAudience is the OIDC audience for the replyUri.</summary>
    [JsonPropertyName("replyAudience")]
    public string? ReplyAudience { get; set; }

    /// <summary>SubscriberURI is the endpoint for the subscriber</summary>
    [JsonPropertyName("subscriberUri")]
    public string? SubscriberUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("subscriberCACerts")]
    public string? SubscriberCACerts { get; set; }

    /// <summary>SubscriberAudience is the OIDC audience for the subscriberUri.</summary>
    [JsonPropertyName("subscriberAudience")]
    public string? SubscriberAudience { get; set; }

    /// <summary>UID is used to understand the origin of the subscriber.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1ChannelSpecSubscribersAuth? Auth { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Spec defines the desired state of the Channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelSpec
{
    /// <summary>ChannelTemplate specifies which Channel CRD to use to create the CRD Channel backing this Channel. This is immutable after creation. Normally this is set by the Channel defaulter, not directly by the user.</summary>
    [JsonPropertyName("channelTemplate")]
    public V1ChannelSpecChannelTemplate? ChannelTemplate { get; set; }

    /// <summary>DeliverySpec contains the default delivery spec for each subscription to this Channelable. Each subscription delivery spec, if any, overrides this global delivery spec.</summary>
    [JsonPropertyName("delivery")]
    public JsonNode? Delivery { get; set; }

    /// <summary>This is the list of subscriptions for this subscribable.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1ChannelSpecSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Channel is Addressable. It exposes the endpoint as an URI to get events delivered into the Channel mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusAddress
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusAddresses
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
#nullable disable

#nullable enable
/// <summary>Channel is an KReference to the Channel CRD backing this Channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusChannel
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusPolicies
{
    /// <summary>The API version of the applied EventPolicy. This indicates, which version of EventPolicy is supported by the resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The name of the applied EventPolicy</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusConditions
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
#nullable disable

#nullable enable
/// <summary>DeadLetterChannel is a KReference and is set by the channel when it supports native error handling via a channel Failed messages are delivered here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusDeadLetterChannel
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
#nullable disable

#nullable enable
/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusSubscribersAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatusSubscribers
{
    /// <summary>A human readable message indicating details of Ready status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Generation of the origin of the subscriber with uid:UID.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Status of the subscriber.</summary>
    [JsonPropertyName("ready")]
    public string? Ready { get; set; }

    /// <summary>UID is used to understand the origin of the subscriber.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1ChannelStatusSubscribersAuth? Auth { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Status represents the current state of the Channel. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChannelStatus
{
    /// <summary>Channel is Addressable. It exposes the endpoint as an URI to get events delivered into the Channel mesh.</summary>
    [JsonPropertyName("address")]
    public V1ChannelStatusAddress? Address { get; set; }

    /// <summary>Channel is Addressable. It exposes the endpoints as URIs to get events delivered into the Channel mesh.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1ChannelStatusAddresses>? Addresses { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Channel is an KReference to the Channel CRD backing this Channel.</summary>
    [JsonPropertyName("channel")]
    public V1ChannelStatusChannel? Channel { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<V1ChannelStatusPolicies>? Policies { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ChannelStatusConditions>? Conditions { get; set; }

    /// <summary>DeadLetterChannel is a KReference and is set by the channel when it supports native error handling via a channel Failed messages are delivered here.</summary>
    [JsonPropertyName("deadLetterChannel")]
    public V1ChannelStatusDeadLetterChannel? DeadLetterChannel { get; set; }

    /// <summary>DeadLetterSinkURI is the resolved URI of the dead letter sink that will be used as a fallback when not specified by Triggers.</summary>
    [JsonPropertyName("deadLetterSinkUri")]
    public string? DeadLetterSinkUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("deadLetterSinkCACerts")]
    public string? DeadLetterSinkCACerts { get; set; }

    /// <summary>OIDC audience of the dead letter sink.</summary>
    [JsonPropertyName("deadLetterSinkAudience")]
    public string? DeadLetterSinkAudience { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>This is the list of subscription's statuses for this channel.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1ChannelStatusSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Channel represents a generic Channel. It is normally used when we want a Channel, but do not need a specific Channel implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Channel : IKubernetesObject<V1ObjectMeta>, ISpec<V1ChannelSpec>, IStatus<V1ChannelStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Channel";
    public const string KubeGroup = "messaging.knative.dev";
    public const string KubePluralName = "channels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the Channel.</summary>
    [JsonPropertyName("spec")]
    public V1ChannelSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the Channel. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1ChannelStatus? Status { get; set; }
}
#nullable disable
