using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
/// <summary>VMwareEngineNetwork is the Schema for the VMwareEngineNetwork API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineNetworkList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VMwareEngineNetwork>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineNetworkList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareenginenetworks";
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
    public IList<V1alpha1VMwareEngineNetwork> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkSpecProjectRef
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

/// <summary>VMwareEngineNetworkSpec defines the desired state of VMwareEngineNetwork</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkSpec
{
    /// <summary>User-provided description for this VMware Engine network.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Checksum that may be sent on update and delete requests to ensure that the user-provided value is up to date before the server processes a request. The server computes checksums based on the value of other fields in the request.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VMwareEngineNetworkSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VMwareEngineNetwork name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. VMware Engine network type.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkStatusObservedStateVpcNetworks
{
    /// <summary>Output only. The relative resource name of the service VPC network this VMware Engine network is attached to. For example: `projects/123123/global/networks/my-network`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Output only. Type of VPC network (INTRANET, INTERNET, or GOOGLE_CLOUD)</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. State of the VMware Engine network.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. VMware Engine service VPC networks that provide connectivity from a private cloud to customer projects, the internet, and other Google Cloud services.</summary>
    [JsonPropertyName("vpcNetworks")]
    public IList<V1alpha1VMwareEngineNetworkStatusObservedStateVpcNetworks>? VpcNetworks { get; set; }
}

/// <summary>VMwareEngineNetworkStatus defines the config connector machine state of VMwareEngineNetwork</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VMwareEngineNetworkStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEngineNetwork resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VMwareEngineNetworkStatusObservedState? ObservedState { get; set; }
}

/// <summary>VMwareEngineNetwork is the Schema for the VMwareEngineNetwork API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineNetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VMwareEngineNetworkSpec>, IStatus<V1alpha1VMwareEngineNetworkStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineNetwork";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareenginenetworks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEngineNetworkSpec defines the desired state of VMwareEngineNetwork</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VMwareEngineNetworkSpec Spec { get; set; }

    /// <summary>VMwareEngineNetworkStatus defines the config connector machine state of VMwareEngineNetwork</summary>
    [JsonPropertyName("status")]
    public V1alpha1VMwareEngineNetworkStatus? Status { get; set; }
}