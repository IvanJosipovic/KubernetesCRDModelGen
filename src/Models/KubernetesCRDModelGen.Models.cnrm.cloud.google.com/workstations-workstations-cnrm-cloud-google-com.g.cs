using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workstations.cnrm.cloud.google.com;
#nullable enable
/// <summary>Workstation is the Schema for the Workstation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkstationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workstation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkstationList";
    public const string KubeGroup = "workstations.cnrm.cloud.google.com";
    public const string KubePluralName = "workstations";
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
    public IList<V1beta1Workstation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationSpecAnnotations
{
    /// <summary>Key for the annotation.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the annotation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationSpecLabels
{
    /// <summary>Key for the label.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the label.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parent is a reference to the parent WorkstationConfig for this Workstation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationSpecParentRef
{
    /// <summary>A reference to an externally managed WorkstationConfig resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/workstationClusters/{{workstationclusterID}}/workstationConfigs/{{workstationconfigID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a WorkstationConfig resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a WorkstationConfig resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WorkstationSpec defines the desired state of Workstation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationSpec
{
    /// <summary>Optional. Client-specified annotations.</summary>
    [JsonPropertyName("annotations")]
    public IList<V1beta1WorkstationSpecAnnotations>? Annotations { get; set; }

    /// <summary>Optional. Human-readable name for this workstation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. [Labels](https://cloud.google.com/workstations/docs/label-resources) that are applied to the workstation and that are also propagated to the underlying Compute Engine resources.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1WorkstationSpecLabels>? Labels { get; set; }

    /// <summary>Parent is a reference to the parent WorkstationConfig for this Workstation.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WorkstationSpecParentRef ParentRef { get; set; }

    /// <summary>The Workstation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationStatusObservedState
{
    /// <summary>Output only. Time when this workstation was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Time when this workstation was soft-deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. Checksum computed by the server. May be sent on update and delete requests to make sure that the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Host to which clients can send HTTPS traffic that will be received by the workstation. Authorized traffic will be received to the workstation as HTTP on port 80. To send traffic to a different port, clients may prefix the host with the destination port in the format `{port}-{host}`.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Output only. Time when this workstation was most recently successfully started, regardless of the workstation's initial state.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. Current state of the workstation.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. A system-assigned unique identifier for this workstation.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Time when this workstation was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WorkstationStatus defines the config connector machine state of Workstation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkstationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the Workstation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1WorkstationStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Workstation is the Schema for the Workstation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workstation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkstationSpec>, IStatus<V1beta1WorkstationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workstation";
    public const string KubeGroup = "workstations.cnrm.cloud.google.com";
    public const string KubePluralName = "workstations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkstationSpec defines the desired state of Workstation</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkstationSpec Spec { get; set; }

    /// <summary>WorkstationStatus defines the config connector machine state of Workstation</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkstationStatus? Status { get; set; }
}
#nullable disable
