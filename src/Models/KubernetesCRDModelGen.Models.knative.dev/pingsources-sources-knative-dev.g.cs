using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sources.knative.dev;
/// <summary>PingSource describes an event source with a fixed payload produced on a specified cron schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1PingSourceList : IKubernetesObject<V1ListMeta>, IItems<V1PingSource>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "PingSourceList";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "pingsources";
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
    public IList<V1PingSource> Items { get; set; }
}

/// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PingSourceSpecCeOverrides
{
    /// <summary>Extensions specify what attribute are added or overridden on the outbound event. Each `Extensions` key-value pair are set on the event as an attribute extension independently.</summary>
    [JsonPropertyName("extensions")]
    public JsonNode? Extensions { get; set; }
}

/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PingSourceSpecSinkRef
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
public partial class V1PingSourceSpecSink
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1PingSourceSpecSinkRef? Ref { get; set; }

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

/// <summary>PingSourceSpec defines the desired state of the PingSource (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PingSourceSpec
{
    /// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
    [JsonPropertyName("ceOverrides")]
    public V1PingSourceSpecCeOverrides? CeOverrides { get; set; }

    /// <summary>ContentType is the media type of `data` or `dataBase64`. Default is empty.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Data is data used as the body of the event posted to the sink. Default is empty. Mutually exclusive with `dataBase64`.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>DataBase64 is the base64-encoded string of the actual event's body posted to the sink. Default is empty. Mutually exclusive with `data`.</summary>
    [JsonPropertyName("dataBase64")]
    public string? DataBase64 { get; set; }

    /// <summary>Schedule is the cron schedule. Defaults to `* * * * *`.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
    [JsonPropertyName("sink")]
    public V1PingSourceSpecSink? Sink { get; set; }

    /// <summary>Timezone modifies the actual time relative to the specified timezone. Defaults to the system time zone. More general information about time zones: https://www.iana.org/time-zones List of valid timezone values: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PingSourceStatusAuth
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
public partial class V1PingSourceStatusCeAttributes
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
public partial class V1PingSourceStatusConditions
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

/// <summary>PingSourceStatus defines the observed state of PingSource (from the controller).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PingSourceStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1PingSourceStatusAuth? Auth { get; set; }

    /// <summary>CloudEventAttributes are the specific attributes that the Source uses as part of its CloudEvents.</summary>
    [JsonPropertyName("ceAttributes")]
    public IList<V1PingSourceStatusCeAttributes>? CeAttributes { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1PingSourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the "Generation" of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>SinkURI is the current active sink URI that has been configured for the Source.</summary>
    [JsonPropertyName("sinkUri")]
    public string? SinkUri { get; set; }

    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("sinkCACerts")]
    public string? SinkCACerts { get; set; }

    /// <summary>sinkAudience is the OIDC audience of the sink.</summary>
    [JsonPropertyName("sinkAudience")]
    public string? SinkAudience { get; set; }
}

/// <summary>PingSource describes an event source with a fixed payload produced on a specified cron schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1PingSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1PingSourceSpec>, IStatus<V1PingSourceStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "PingSource";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "pingsources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PingSourceSpec defines the desired state of the PingSource (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1PingSourceSpec? Spec { get; set; }

    /// <summary>PingSourceStatus defines the observed state of PingSource (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1PingSourceStatus? Status { get; set; }
}