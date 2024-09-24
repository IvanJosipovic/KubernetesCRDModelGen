using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.messaging.knative.dev;
/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpecReplyRef
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

/// <summary>Reply specifies (optionally) how to handle events returned from the Subscriber target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpecReply
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1SubscriptionSpecReplyRef? Ref { get; set; }

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

/// <summary>Subscriber is reference to (optional) function for processing events. Events from the Channel will be delivered here and replies are sent to a Destination as specified by the Reply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpecSubscriber
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public JsonNode? Ref { get; set; }

    /// <summary>URI can be an absolute URL(non-empty scheme and non-empty host) pointing to the target or a relative URI. Relative URIs will be resolved using the base URI retrieved from Ref.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format that the subscription trusts when sending events to the sink.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience. This only needs to be set if the target is not an Addressable and thus the Audience can't be received from the target itself. If specified, it takes precedence over the target's Audience.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpec
{
    /// <summary>Reference to a channel that will be used to create the subscription. You can specify only the following fields of the KReference: kind, apiVersion, name and namespace. The resource pointed by this KReference must meet the contract to the ChannelableSpec duck type. If the resource does not meet this contract it will be reflected in the Subscription's status.  This field is immutable. We have no good answer on what happens to the events that are currently in the channel being consumed from and what the semantics there should be. For now, you can always delete the Subscription and recreate it to point to a different channel, giving the user more control over what semantics should be used (drain the channel first, possibly have events dropped, etc.)</summary>
    [JsonPropertyName("channel")]
    public JsonNode? Channel { get; set; }

    /// <summary>Delivery configuration</summary>
    [JsonPropertyName("delivery")]
    public JsonNode? Delivery { get; set; }

    /// <summary>Reply specifies (optionally) how to handle events returned from the Subscriber target.</summary>
    [JsonPropertyName("reply")]
    public V1SubscriptionSpecReply? Reply { get; set; }

    /// <summary>Subscriber is reference to (optional) function for processing events. Events from the Channel will be delivered here and replies are sent to a Destination as specified by the Reply.</summary>
    [JsonPropertyName("subscriber")]
    public V1SubscriptionSpecSubscriber? Subscriber { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatusAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatusConditions
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

/// <summary>PhysicalSubscription is the fully resolved values that this Subscription represents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatusPhysicalSubscription
{
    /// <summary>ReplyURI is the fully resolved URI for the spec.delivery.deadLetterSink.</summary>
    [JsonPropertyName("deadLetterSinkUri")]
    public string? DeadLetterSinkUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("deadLetterSinkCACerts")]
    public string? DeadLetterSinkCACerts { get; set; }

    /// <summary>OIDC audience of the dead letter sink.</summary>
    [JsonPropertyName("deadLetterSinkAudience")]
    public string? DeadLetterSinkAudience { get; set; }

    /// <summary>ReplyURI is the fully resolved URI for the spec.reply.</summary>
    [JsonPropertyName("replyUri")]
    public string? ReplyUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("replyCACerts")]
    public string? ReplyCACerts { get; set; }

    /// <summary>ReplyAudience is the OIDC audience for the replyUri.</summary>
    [JsonPropertyName("replyAudience")]
    public string? ReplyAudience { get; set; }

    /// <summary>SubscriberURI is the fully resolved URI for spec.subscriber.</summary>
    [JsonPropertyName("subscriberUri")]
    public string? SubscriberUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("subscriberCACerts")]
    public string? SubscriberCACerts { get; set; }

    /// <summary>SubscriberAudience is the OIDC audience for the subscriberUri.</summary>
    [JsonPropertyName("subscriberAudience")]
    public string? SubscriberAudience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1SubscriptionStatusAuth? Auth { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1SubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>PhysicalSubscription is the fully resolved values that this Subscription represents.</summary>
    [JsonPropertyName("physicalSubscription")]
    public V1SubscriptionStatusPhysicalSubscription? PhysicalSubscription { get; set; }
}

/// <summary>Subscription routes events received on a Channel to a DNS name and corresponds to the subscriptions.channels.knative.dev CRD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1SubscriptionSpec>, IStatus<V1SubscriptionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "messaging.knative.dev";
    public const string KubePluralName = "subscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1SubscriptionSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1SubscriptionStatus? Status { get; set; }
}