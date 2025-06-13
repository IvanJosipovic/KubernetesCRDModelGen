using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apphub.cnrm.cloud.google.com;
/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>AppHubDiscoveredServiceSpec defines the desired state of AppHubDiscoveredService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceSpec
{
    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AppHubDiscoveredServiceSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The AppHubDiscoveredService name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceStatusConditions
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

/// <summary>Output only. Properties of an underlying compute resource that can comprise a Service. These are immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceStatusObservedStateServiceProperties
{
    /// <summary>Output only. The service project identifier that the underlying cloud resource resides in.</summary>
    [JsonPropertyName("gcpProject")]
    public string? GcpProject { get; set; }

    /// <summary>Output only. The location that the underlying resource resides in, for example, us-west1.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Output only. The location that the underlying resource resides in if it is zonal, for example, us-west1-a).</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Output only. Reference to an underlying networking resource that can comprise a Service. These are immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceStatusObservedStateServiceReference
{
    /// <summary>Output only. The underlying resource URI (For example, URI of Forwarding Rule, URL Map, and Backend Service).</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceStatusObservedState
{
    /// <summary>Output only. Properties of an underlying compute resource that can comprise a Service. These are immutable.</summary>
    [JsonPropertyName("serviceProperties")]
    public V1alpha1AppHubDiscoveredServiceStatusObservedStateServiceProperties? ServiceProperties { get; set; }

    /// <summary>Output only. Reference to an underlying networking resource that can comprise a Service. These are immutable.</summary>
    [JsonPropertyName("serviceReference")]
    public V1alpha1AppHubDiscoveredServiceStatusObservedStateServiceReference? ServiceReference { get; set; }
}

/// <summary>AppHubDiscoveredServiceStatus defines the config connector machine state of AppHubDiscoveredService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredServiceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppHubDiscoveredServiceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AppHubDiscoveredService resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AppHubDiscoveredServiceStatusObservedState? ObservedState { get; set; }
}

/// <summary>AppHubDiscoveredService is the Schema for the AppHubDiscoveredService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubDiscoveredService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppHubDiscoveredServiceSpec>, IStatus<V1alpha1AppHubDiscoveredServiceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubDiscoveredService";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubdiscoveredservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppHubDiscoveredServiceSpec defines the desired state of AppHubDiscoveredService</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AppHubDiscoveredServiceSpec Spec { get; set; }

    /// <summary>AppHubDiscoveredServiceStatus defines the config connector machine state of AppHubDiscoveredService</summary>
    [JsonPropertyName("status")]
    public V1alpha1AppHubDiscoveredServiceStatus? Status { get; set; }
}

/// <summary>AppHubDiscoveredService is the Schema for the AppHubDiscoveredService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubDiscoveredServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppHubDiscoveredService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubDiscoveredServiceList";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubdiscoveredservices";
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
    public IList<V1alpha1AppHubDiscoveredService> Items { get; set; }
}