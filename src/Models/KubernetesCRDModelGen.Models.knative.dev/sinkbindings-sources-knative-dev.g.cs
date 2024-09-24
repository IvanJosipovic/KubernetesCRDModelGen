using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sources.knative.dev;
/// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecCeOverrides
{
    /// <summary>Extensions specify what attribute are added or overridden on the outbound event. Each `Extensions` key-value pair are set on the event as an attribute extension independently.</summary>
    [JsonPropertyName("extensions")]
    public JsonNode? Extensions { get; set; }
}

/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecSinkRef
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

/// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecSink
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1SinkBindingSpecSinkRef? Ref { get; set; }

    /// <summary>URI can be an absolute URL(non-empty scheme and non-empty host) pointing to the target or a relative URI. Relative URIs will be resolved using the base URI retrieved from Ref.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience. This only needs to be set if the target is not an Addressable and thus the Audience can't be received from the target itself. If specified, it takes precedence over the target's Audience.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecSubjectSelectorMatchExpressions
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

/// <summary>Selector of the referents. Mutually exclusive with Name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecSubjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1SinkBindingSpecSubjectSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public JsonNode? MatchLabels { get; set; }
}

/// <summary>Subject references the resource(s) whose "runtime contract" should be augmented by Binding implementations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpecSubject
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. Mutually exclusive with Selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Selector of the referents. Mutually exclusive with Name.</summary>
    [JsonPropertyName("selector")]
    public V1SinkBindingSpecSubjectSelector? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingSpec
{
    /// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
    [JsonPropertyName("ceOverrides")]
    public V1SinkBindingSpecCeOverrides? CeOverrides { get; set; }

    /// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
    [JsonPropertyName("sink")]
    public V1SinkBindingSpecSink? Sink { get; set; }

    /// <summary>Subject references the resource(s) whose "runtime contract" should be augmented by Binding implementations.</summary>
    [JsonPropertyName("subject")]
    public V1SinkBindingSpecSubject? Subject { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingStatusAuth
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
public partial class V1SinkBindingStatusCeAttributes
{
    /// <summary>Source is the CloudEvents source attribute.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Type refers to the CloudEvent type attribute.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SinkBindingStatusConditions
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
public partial class V1SinkBindingStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1SinkBindingStatusAuth? Auth { get; set; }

    /// <summary>CloudEventAttributes are the specific attributes that the Source uses as part of its CloudEvents.</summary>
    [JsonPropertyName("ceAttributes")]
    public IList<V1SinkBindingStatusCeAttributes>? CeAttributes { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1SinkBindingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>SinkURI is the current active sink URI that has been configured for the Source.</summary>
    [JsonPropertyName("sinkUri")]
    public string? SinkUri { get; set; }

    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("sinkCACerts")]
    public string? SinkCACerts { get; set; }

    /// <summary>Audience is the OIDC audience of the sink.</summary>
    [JsonPropertyName("sinkAudience")]
    public string? SinkAudience { get; set; }

    /// <summary>Name of the secret with the OIDC token for the sink.</summary>
    [JsonPropertyName("oidcTokenSecretName")]
    public string? OidcTokenSecretName { get; set; }
}

/// <summary>SinkBinding describes a Binding that is also a Source. The `sink` (from the Source duck) is resolved to a URL and then projected into the `subject` by augmenting the runtime contract of the referenced containers to have a `K_SINK` environment variable holding the endpoint to which to send cloud events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SinkBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1SinkBindingSpec>, IStatus<V1SinkBindingStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SinkBinding";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "sinkbindings";
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
    public V1SinkBindingSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1SinkBindingStatus? Status { get; set; }
}