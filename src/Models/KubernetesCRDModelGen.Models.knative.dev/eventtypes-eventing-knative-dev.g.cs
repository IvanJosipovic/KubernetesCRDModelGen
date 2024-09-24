using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.knative.dev;
/// <summary>Reference a resource. For example, Broker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventTypeSpecReference
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

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ This is an optional field, it gets defaulted to the object holding it if left out.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Address points to a specific Address Name</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary>Spec defines the desired state of the EventType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventTypeSpec
{
    /// <summary></summary>
    [JsonPropertyName("broker")]
    public string? Broker { get; set; }

    /// <summary>Reference a resource. For example, Broker.</summary>
    [JsonPropertyName("reference")]
    public V1beta2EventTypeSpecReference? Reference { get; set; }

    /// <summary>Description is an optional field used to describe the EventType, in any meaningful way.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Schema is a URI, it represents the CloudEvents schemaurl extension attribute. It may be a JSON schema, a protobuf schema, etc. It is optional.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>SchemaData allows the CloudEvents schema to be stored directly in the EventType. Content is dependent on the encoding. Optional attribute. The contents are not validated or manipulated by the system.</summary>
    [JsonPropertyName("schemaData")]
    public string? SchemaData { get; set; }

    /// <summary>Source is a URI, it represents the CloudEvents source.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Type represents the CloudEvents type. It is authoritative.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventTypeStatusConditions
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

/// <summary>Status represents the current state of the EventType. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventTypeStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EventTypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EventType represents a type of event that can be consumed from a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EventType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EventTypeSpec>, IStatus<V1beta2EventTypeStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EventType";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "eventtypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the EventType.</summary>
    [JsonPropertyName("spec")]
    public V1beta2EventTypeSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the EventType. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1beta2EventTypeStatus? Status { get; set; }
}