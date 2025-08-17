using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.essentialcontacts.cnrm.cloud.google.com;
#nullable enable
/// <summary>EssentialContactsContact is the Schema for the EssentialContactsContact API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EssentialContactsContactList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EssentialContactsContact>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EssentialContactsContactList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1EssentialContactsContact> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactSpecFolderRef
{
    /// <summary>The 'name' field of a folder, when not managed by Config Connector. This field must be set when 'name' field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The 'name' field of a 'Folder' resource. This field must be set when 'external' field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The 'namespace' field of a 'Folder' resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactSpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>EssentialContactsContactSpec defines the desired state of EssentialContactsContact</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactSpec
{
    /// <summary>Required. The email address to send notifications to. The email address does not need to be a Google Account.</summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1EssentialContactsContactSpecFolderRef? FolderRef { get; set; }

    /// <summary>Required. The preferred language for notifications, as a ISO 639-1 language code. See [Supported languages](https://cloud.google.com/resource-manager/docs/managing-notification-contacts#supported-languages) for a list of supported languages.</summary>
    [JsonPropertyName("languageTag")]
    public string LanguageTag { get; set; }

    /// <summary>Required. The categories of notifications that the contact will receive communications for.</summary>
    [JsonPropertyName("notificationCategorySubscriptions")]
    public IList<string> NotificationCategorySubscriptions { get; set; }

    /// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1EssentialContactsContactSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1EssentialContactsContactSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The EssentialContactsContact name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The last time the validation_state was updated, either manually or automatically. A contact is considered stale if its validation state was updated more than 1 year ago.</summary>
    [JsonPropertyName("validateTime")]
    public string? ValidateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactStatusObservedState
{
    /// <summary>Output only. The validity of the contact. A contact is considered valid if it is the correct recipient for notifications for a particular resource.</summary>
    [JsonPropertyName("validationState")]
    public string? ValidationState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EssentialContactsContactStatus defines the config connector machine state of EssentialContactsContact</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EssentialContactsContactStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EssentialContactsContactStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the EssentialContactsContact resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1EssentialContactsContactStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EssentialContactsContact is the Schema for the EssentialContactsContact API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>EssentialContactsContactSpec defines the desired state of EssentialContactsContact</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EssentialContactsContactSpec Spec { get; set; }

    /// <summary>EssentialContactsContactStatus defines the config connector machine state of EssentialContactsContact</summary>
    [JsonPropertyName("status")]
    public V1alpha1EssentialContactsContactStatus? Status { get; set; }
}
#nullable disable
