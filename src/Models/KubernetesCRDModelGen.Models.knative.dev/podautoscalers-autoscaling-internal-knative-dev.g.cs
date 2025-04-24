using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.@internal.knative.dev;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscalerMetadata
{
}

/// <summary>ScaleTargetRef defines the /scale-able resource that this PodAutoscaler is responsible for quickly right-sizing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscalerSpecScaleTargetRef
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

/// <summary>Spec holds the desired state of the PodAutoscaler (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscalerSpec
{
    /// <summary>ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container of the Revision. Defaults to `0` which means unlimited concurrency.</summary>
    [JsonPropertyName("containerConcurrency")]
    public long? ContainerConcurrency { get; set; }

    /// <summary>The application-layer protocol. Matches `ProtocolType` inferred from the revision spec.</summary>
    [JsonPropertyName("protocolType")]
    public string ProtocolType { get; set; }

    /// <summary>Reachability specifies whether or not the `ScaleTargetRef` can be reached (ie. has a route). Defaults to `ReachabilityUnknown`</summary>
    [JsonPropertyName("reachability")]
    public string? Reachability { get; set; }

    /// <summary>ScaleTargetRef defines the /scale-able resource that this PodAutoscaler is responsible for quickly right-sizing.</summary>
    [JsonPropertyName("scaleTargetRef")]
    public PodAutoscalerSpecScaleTargetRef ScaleTargetRef { get; set; }
}

/// <summary>Condition defines a readiness condition for a Knative resource. See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscalerStatusConditions
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

/// <summary>Status communicates the observed state of the PodAutoscaler (from the controller).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscalerStatus
{
    /// <summary>ActualScale shows the actual number of replicas for the revision.</summary>
    [JsonPropertyName("actualScale")]
    public int? ActualScale { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<PodAutoscalerStatusConditions>? Conditions { get; set; }

    /// <summary>DesiredScale shows the current desired number of replicas for the revision.</summary>
    [JsonPropertyName("desiredScale")]
    public int? DesiredScale { get; set; }

    /// <summary>MetricsServiceName is the K8s Service name that provides revision metrics. The service is managed by the PA object.</summary>
    [JsonPropertyName("metricsServiceName")]
    public string MetricsServiceName { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ServiceName is the K8s Service name that serves the revision, scaled by this PA. The service is created and owned by the ServerlessService object owned by this PA.</summary>
    [JsonPropertyName("serviceName")]
    public string ServiceName { get; set; }
}

/// <summary>PodAutoscaler is a Knative abstraction that encapsulates the interface by which Knative components instantiate autoscalers.  This definition is an abstraction that may be backed by multiple definitions.  For more information, see the Knative Pluggability presentation: https://docs.google.com/presentation/d/19vW9HFZ6Puxt31biNZF3uLRejDmu82rxJIk1cWmxF7w/edit</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PodAutoscaler
{
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public PodAutoscalerMetadata? Metadata { get; set; }

    /// <summary>Spec holds the desired state of the PodAutoscaler (from the client).</summary>
    [JsonPropertyName("spec")]
    public PodAutoscalerSpec? Spec { get; set; }

    /// <summary>Status communicates the observed state of the PodAutoscaler (from the controller).</summary>
    [JsonPropertyName("status")]
    public PodAutoscalerStatus? Status { get; set; }
}