using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>Reference to parent Apigee Organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeEndpointAttachmentSpecOrganizationRef
{
    /// <summary>A reference to an externally managed ApigeeOrganization resource. Should be in the format "organizations/{{organizationID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ApigeeOrganization resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ApigeeOrganization resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to the ServiceAttachment for the EndpointAttachment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeEndpointAttachmentSpecServiceAttachmentRef
{
    /// <summary>The ComputeServiceAttachment selflink in the form "projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ApigeeEndpointAttachmentSpec defines the desired state of ApigeeEndpointAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeEndpointAttachmentSpec
{
    /// <summary>Required. Location of the endpoint attachment.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to parent Apigee Organization.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1ApigeeEndpointAttachmentSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>The ApigeeEndpointAttachment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Reference to the ServiceAttachment for the EndpointAttachment.</summary>
    [JsonPropertyName("serviceAttachmentRef")]
    public V1beta1ApigeeEndpointAttachmentSpecServiceAttachmentRef? ServiceAttachmentRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeEndpointAttachmentStatusConditions
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
public partial class V1beta1ApigeeEndpointAttachmentStatusObservedState
{
    /// <summary>Output only. State of the endpoint attachment connection to the service attachment.</summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>Output only. Host that can be used in either the HTTP target endpoint directly or as the host in target server.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Output only. State of the endpoint attachment. Values other than `ACTIVE` mean the resource is not ready to use.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ApigeeEndpointAttachmentStatus defines the config connector machine state of ApigeeEndpointAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeEndpointAttachmentStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApigeeEndpointAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApigeeEndpointAttachment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ApigeeEndpointAttachmentStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApigeeEndpointAttachment is the Schema for the ApigeeEndpointAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeEndpointAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApigeeEndpointAttachmentSpec>, IStatus<V1beta1ApigeeEndpointAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeEndpointAttachment";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeendpointattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApigeeEndpointAttachmentSpec defines the desired state of ApigeeEndpointAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApigeeEndpointAttachmentSpec Spec { get; set; }

    /// <summary>ApigeeEndpointAttachmentStatus defines the config connector machine state of ApigeeEndpointAttachment</summary>
    [JsonPropertyName("status")]
    public V1beta1ApigeeEndpointAttachmentStatus? Status { get; set; }
}

/// <summary>ApigeeEndpointAttachment is the Schema for the ApigeeEndpointAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeEndpointAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApigeeEndpointAttachment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeEndpointAttachmentList";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeendpointattachments";
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
    public IList<V1beta1ApigeeEndpointAttachment> Items { get; set; }
}