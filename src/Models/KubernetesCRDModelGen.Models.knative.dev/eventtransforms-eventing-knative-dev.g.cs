using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.knative.dev;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventTransformList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EventTransform>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventTransformList";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "eventtransforms";
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
    public IList<V1alpha1EventTransform> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpecJsonata
{
    /// <summary>Expression is the JSONata expression (https://jsonata.org/).</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpecReplyJsonata
{
    /// <summary>Expression is the JSONata expression (https://jsonata.org/).</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>Reply is the configuration on how to handle responses from Sink. It can only be set if Sink is set. Only one "type" can be used. The used type must match the top-level transformation, if you need to mix transformation types, use compositions and chain transformations together to achieve your desired outcome. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpecReply
{
    /// <summary></summary>
    [JsonPropertyName("jsonata")]
    public V1alpha1EventTransformSpecReplyJsonata? Jsonata { get; set; }

    /// <summary>Discard discards responses from Sink and return empty response body. When set to false, it returns the exact sink response body. When set to true, Discard is mutually exclusive with EventTransformations in the reply section, it can either be discarded or transformed. Default: false. </summary>
    [JsonPropertyName("discard")]
    public bool? Discard { get; set; }
}

/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpecSinkRef
{
    /// <summary>Address points to a specific Address Name.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Group of the API, without the version of the group. This can be used as an alternative to the APIVersion, and then resolved using ResolveGroup. Note: This API is EXPERIMENTAL and might break anytime. For more details: https://github.com/knative/eventing/issues/5086</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

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

/// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.  If not present, the transformation will send back the transformed event as response, this is useful to leverage the built-in Broker reply feature to re-publish a transformed event back to the broker. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpecSink
{
    /// <summary>CACerts are Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468. If set, these CAs are appended to the set of CAs provided by the Addressable target, if any.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience. This need only be set, if the target is not an Addressable and thus the Audience can't be received from the Addressable itself. In case the Addressable specifies an Audience too, the Destinations Audience takes preference.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1alpha1EventTransformSpecSinkRef? Ref { get; set; }

    /// <summary>URI can be an absolute URL(non-empty scheme and non-empty host) pointing to the target or a relative URI. Relative URIs will be resolved using the base URI retrieved from Ref.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Spec defines the desired state of the EventTransform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformSpec
{
    /// <summary></summary>
    [JsonPropertyName("jsonata")]
    public V1alpha1EventTransformSpecJsonata? Jsonata { get; set; }

    /// <summary>Reply is the configuration on how to handle responses from Sink. It can only be set if Sink is set. Only one "type" can be used. The used type must match the top-level transformation, if you need to mix transformation types, use compositions and chain transformations together to achieve your desired outcome. </summary>
    [JsonPropertyName("reply")]
    public V1alpha1EventTransformSpecReply? Reply { get; set; }

    /// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.  If not present, the transformation will send back the transformed event as response, this is useful to leverage the built-in Broker reply feature to re-publish a transformed event back to the broker. </summary>
    [JsonPropertyName("sink")]
    public V1alpha1EventTransformSpecSink? Sink { get; set; }
}

/// <summary>Address is a single Addressable address. If Addresses is present, Address will be ignored by clients.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusAddress
{
    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience for this address.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Name is the name of the address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusAddresses
{
    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience for this address.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Name is the name of the address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Auth defines the attributes that provide the generated service account name in the resource status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication. This list can have len() &gt; 1, when the component uses multiple identities (e.g. in case of a Parallel).</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusJsonataDeploymentConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>The last time this condition was updated.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string? LastUpdateTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type of deployment condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusJsonataDeployment
{
    /// <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary>
    [JsonPropertyName("availableReplicas")]
    public int? AvailableReplicas { get; set; }

    /// <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary>
    [JsonPropertyName("collisionCount")]
    public int? CollisionCount { get; set; }

    /// <summary>Represents the latest available observations of a deployment's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventTransformStatusJsonataDeploymentConditions>? Conditions { get; set; }

    /// <summary>The generation observed by the deployment controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>readyReplicas is the number of pods targeted by this Deployment with a Ready Condition.</summary>
    [JsonPropertyName("readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary>
    [JsonPropertyName("unavailableReplicas")]
    public int? UnavailableReplicas { get; set; }

    /// <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary>
    [JsonPropertyName("updatedReplicas")]
    public int? UpdatedReplicas { get; set; }
}

/// <summary>JsonataTransformationStatus is the status associated with JsonataEventTransformationSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatusJsonata
{
    /// <summary></summary>
    [JsonPropertyName("deployment")]
    public V1alpha1EventTransformStatusJsonataDeployment? Deployment { get; set; }
}

/// <summary>Status represents the current state of the EventTransform. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventTransformStatus
{
    /// <summary>Address is a single Addressable address. If Addresses is present, Address will be ignored by clients.</summary>
    [JsonPropertyName("address")]
    public V1alpha1EventTransformStatusAddress? Address { get; set; }

    /// <summary>Addresses is a list of addresses for different protocols (HTTP and HTTPS) If Addresses is present, Address must be ignored by clients.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1alpha1EventTransformStatusAddresses>? Addresses { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth defines the attributes that provide the generated service account name in the resource status.</summary>
    [JsonPropertyName("auth")]
    public V1alpha1EventTransformStatusAuth? Auth { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventTransformStatusConditions>? Conditions { get; set; }

    /// <summary>JsonataTransformationStatus is the status associated with JsonataEventTransformationSpec.</summary>
    [JsonPropertyName("jsonata")]
    public V1alpha1EventTransformStatusJsonata? Jsonata { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>SinkAudience is the OIDC audience of the sink.</summary>
    [JsonPropertyName("sinkAudience")]
    public string? SinkAudience { get; set; }

    /// <summary>SinkCACerts are Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("sinkCACerts")]
    public string? SinkCACerts { get; set; }

    /// <summary>SinkURI is the current active sink URI that has been configured for the Source.</summary>
    [JsonPropertyName("sinkUri")]
    public string? SinkUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventTransform : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventTransformSpec>, IStatus<V1alpha1EventTransformStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventTransform";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "eventtransforms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the EventTransform.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EventTransformSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the EventTransform. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventTransformStatus? Status { get; set; }
}