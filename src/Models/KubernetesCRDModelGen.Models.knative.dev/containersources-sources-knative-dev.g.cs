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
public partial class V1ContainerSourceSpecCeOverrides
{
    /// <summary>Extensions specify what attribute are added or overridden on the outbound event. Each `Extensions` key-value pair are set on the event as an attribute extension independently.</summary>
    [JsonPropertyName("extensions")]
    public JsonNode? Extensions { get; set; }
}

/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ContainerSourceSpecSinkRef
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
public partial class V1ContainerSourceSpecSink
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1ContainerSourceSpecSinkRef? Ref { get; set; }

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
public partial class V1ContainerSourceSpec
{
    /// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
    [JsonPropertyName("ceOverrides")]
    public V1ContainerSourceSpecCeOverrides? CeOverrides { get; set; }

    /// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
    [JsonPropertyName("sink")]
    public V1ContainerSourceSpecSink? Sink { get; set; }

    /// <summary>A template in the shape of `Deployment.spec.template` to be used for this ContainerSource. More info: https://kubernetes.io/docs/concepts/workloads/controllers/deployment/</summary>
    [JsonPropertyName("template")]
    public JsonNode? Template { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ContainerSourceStatusAuth
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
public partial class V1ContainerSourceStatusCeAttributes
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
public partial class V1ContainerSourceStatusConditions
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
public partial class V1ContainerSourceStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1ContainerSourceStatusAuth? Auth { get; set; }

    /// <summary>CloudEventAttributes are the specific attributes that the Source uses as part of its CloudEvents.</summary>
    [JsonPropertyName("ceAttributes")]
    public IList<V1ContainerSourceStatusCeAttributes>? CeAttributes { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ContainerSourceStatusConditions>? Conditions { get; set; }

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
}

/// <summary>ContainerSource is an event source that starts a container image which generates events under certain situations and sends messages to a sink URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ContainerSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1ContainerSourceSpec>, IStatus<V1ContainerSourceStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ContainerSource";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "containersources";
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
    public V1ContainerSourceSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1ContainerSourceStatus? Status { get; set; }
}

/// <summary>ContainerSource is an event source that starts a container image which generates events under certain situations and sends messages to a sink URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ContainerSourceList : IKubernetesObject<V1ListMeta>, IItems<V1ContainerSource>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ContainerSourceList";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "containersources";
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
    public IList<V1ContainerSource> Items { get; set; }
}