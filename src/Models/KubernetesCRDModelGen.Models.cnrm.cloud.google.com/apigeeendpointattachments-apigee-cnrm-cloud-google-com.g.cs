using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
public partial class V1alpha1ApigeeEndpointAttachmentSpec
{
    /// <summary>Immutable. Location of the endpoint attachment.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Apigee Organization associated with the Apigee instance, in the format 'organizations/{{org_name}}'.</summary>
    [JsonPropertyName("orgId")]
    public string OrgId { get; set; }

    /// <summary>Immutable. Optional. The endpointAttachmentId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Format: projects/*/regions/*/serviceAttachments/*.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string ServiceAttachment { get; set; }
}

public partial class V1alpha1ApigeeEndpointAttachmentStatusConditions
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

public partial class V1alpha1ApigeeEndpointAttachmentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApigeeEndpointAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>State of the endpoint attachment connection to the service attachment.</summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>Host that can be used in either HTTP Target Endpoint directly, or as the host in Target Server.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Name of the Endpoint Attachment in the following format: organizations/{organization}/endpointAttachments/{endpointAttachment}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeEndpointAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApigeeEndpointAttachmentSpec>, IStatus<V1alpha1ApigeeEndpointAttachmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
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

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApigeeEndpointAttachmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ApigeeEndpointAttachmentStatus? Status { get; set; }
}