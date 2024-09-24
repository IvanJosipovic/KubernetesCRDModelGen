using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sinks.knative.dev;
/// <summary>Spec defines the desired state of the JobSink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkSpec
{
    /// <summary>Full Job resource object, see https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#job-v1-batch for more details.</summary>
    [JsonPropertyName("job")]
    public JsonNode? Job { get; set; }
}

/// <summary>JobSink is Addressable. It exposes the endpoint as an URI to schedule long running jobs when an even occurs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatusAddress
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatusAddresses
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatusJob
{
    /// <summary>Label selector for all scheduled jobs</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatusPolicies
{
    /// <summary>The API version of the applied EventPolicy. This indicates, which version of EventPolicy is supported by the resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The name of the applied EventPolicy</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatusConditions
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

/// <summary>Status represents the current state of the JobSink. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSinkStatus
{
    /// <summary>JobSink is Addressable. It exposes the endpoint as an URI to schedule long running jobs when an even occurs.</summary>
    [JsonPropertyName("address")]
    public V1alpha1JobSinkStatusAddress? Address { get; set; }

    /// <summary>JobSink is Addressable. It exposes the endpoint as an URI to schedule long running jobs when an even occurs.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1alpha1JobSinkStatusAddresses>? Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("job")]
    public V1alpha1JobSinkStatusJob? Job { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1JobSinkStatusPolicies>? Policies { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1JobSinkStatusConditions>? Conditions { get; set; }
}

/// <summary>JobSink triggers long-running jobs when an event occur.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1JobSink : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1JobSinkSpec>, IStatus<V1alpha1JobSinkStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "JobSink";
    public const string KubeGroup = "sinks.knative.dev";
    public const string KubePluralName = "jobsinks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the JobSink.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1JobSinkSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the JobSink. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1alpha1JobSinkStatus? Status { get; set; }
}