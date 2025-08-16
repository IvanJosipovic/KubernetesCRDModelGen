using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary>DatastreamRoute is the Schema for the DatastreamRoute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamRouteList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DatastreamRoute>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamRouteList";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamroutes";
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
    public IList<V1alpha1DatastreamRoute> Items { get; set; }
}

/// <summary>Required. The parent that owns the collection of Routes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamRouteSpecPrivateConnectionRef
{
    /// <summary>A reference to an externally managed DatastreamPrivateConnection resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/privateConnections/{{privateconnectionID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DatastreamPrivateConnection resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DatastreamPrivateConnection resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DatastreamRouteSpec defines the desired state of DatastreamRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamRouteSpec
{
    /// <summary>Required. Destination address for connection</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>Destination port for connection</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>Required. Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The parent that owns the collection of Routes.</summary>
    [JsonPropertyName("privateConnectionRef")]
    public V1alpha1DatastreamRouteSpecPrivateConnectionRef PrivateConnectionRef { get; set; }

    /// <summary>The DatastreamRoute name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamRouteStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamRouteStatusObservedState
{
    /// <summary>Output only. The create time of the resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The update time of the resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DatastreamRouteStatus defines the config connector machine state of DatastreamRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamRouteStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamRouteStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DatastreamRoute resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DatastreamRouteStatusObservedState? ObservedState { get; set; }
}

/// <summary>DatastreamRoute is the Schema for the DatastreamRoute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatastreamRouteSpec>, IStatus<V1alpha1DatastreamRouteStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamRoute";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatastreamRouteSpec defines the desired state of DatastreamRoute</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DatastreamRouteSpec Spec { get; set; }

    /// <summary>DatastreamRouteStatus defines the config connector machine state of DatastreamRoute</summary>
    [JsonPropertyName("status")]
    public V1alpha1DatastreamRouteStatus? Status { get; set; }
}