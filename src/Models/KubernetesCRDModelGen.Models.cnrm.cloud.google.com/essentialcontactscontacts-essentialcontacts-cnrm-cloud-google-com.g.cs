using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.essentialcontacts.cnrm.cloud.google.com;
public partial class V1alpha1EssentialContactsContactSpec
{
    /// <summary>Immutable. The email address to send notifications to. This does not need to be a Google account.</summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.</summary>
    [JsonPropertyName("languageTag")]
    public string LanguageTag { get; set; }

    /// <summary>The categories of notifications that the contact will receive communications for.</summary>
    [JsonPropertyName("notificationCategorySubscriptions")]
    public IList<string> NotificationCategorySubscriptions { get; set; }

    /// <summary>Immutable. The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}.</summary>
    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1EssentialContactsContactStatusConditions
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

public partial class V1alpha1EssentialContactsContactStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EssentialContactsContactStatusConditions>? Conditions { get; set; }

    /// <summary>The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EssentialContactsContact : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EssentialContactsContactSpec>, IStatus<V1alpha1EssentialContactsContactStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EssentialContactsContact";
    public const string KubeGroup = "essentialcontacts.cnrm.cloud.google.com";
    public const string KubePluralName = "essentialcontactscontacts";
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
    public V1alpha1EssentialContactsContactSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1EssentialContactsContactStatus? Status { get; set; }
}