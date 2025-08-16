using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudids.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIDSEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudIDSEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIDSEndpointList";
    public const string KubeGroup = "cloudids.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidsendpoints";
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
    public IList<V1alpha1CloudIDSEndpoint> Items { get; set; }
}

/// <summary>Immutable. Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like "src-net") or the full URL to the network (like "projects/{project_id}/global/networks/src-net").</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointSpecNetworkRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointSpec
{
    /// <summary>Immutable. An optional description of the endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location for the endpoint.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like "src-net") or the full URL to the network (like "projects/{project_id}/global/networks/src-net").</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1CloudIDSEndpointSpecNetworkRef NetworkRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudIDSEndpointSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The minimum alert severity level that is reported by the endpoint. Possible values: ["INFORMATIONAL", "LOW", "MEDIUM", "HIGH", "CRITICAL"].</summary>
    [JsonPropertyName("severity")]
    public string Severity { get; set; }

    /// <summary>Configuration for threat IDs excluded from generating alerts. Limit: 99 IDs.</summary>
    [JsonPropertyName("threatExceptions")]
    public IList<string>? ThreatExceptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointStatusObservedState
{
    /// <summary>Creation timestamp in RFC 3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>URL of the endpoint's network address to which traffic is to be sent by Packet Mirroring.</summary>
    [JsonPropertyName("endpointForwardingRule")]
    public string? EndpointForwardingRule { get; set; }

    /// <summary>Internal IP address of the endpoint's network entry point.</summary>
    [JsonPropertyName("endpointIP")]
    public string? EndpointIP { get; set; }

    /// <summary>Last update timestamp in RFC 3339 text format.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIDSEndpointStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudIDSEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudIDSEndpointStatusObservedState? ObservedState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIDSEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudIDSEndpointSpec>, IStatus<V1alpha1CloudIDSEndpointStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIDSEndpoint";
    public const string KubeGroup = "cloudids.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidsendpoints";
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
    public V1alpha1CloudIDSEndpointSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudIDSEndpointStatus? Status { get; set; }
}