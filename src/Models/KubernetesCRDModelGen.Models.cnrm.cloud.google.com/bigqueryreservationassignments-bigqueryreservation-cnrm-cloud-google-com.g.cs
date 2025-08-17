using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryreservation.cnrm.cloud.google.com;
#nullable enable
/// <summary>BigQueryReservationAssignment is the Schema for the BigQueryReservationAssignment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryReservationAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryReservationAssignment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationAssignmentList";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationassignments";
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
    public IList<V1alpha1BigQueryReservationAssignment> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpecAssigneeFolderRef
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
/// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpecAssigneeOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpecAssigneeProjectRef
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
/// <summary>Immutable. Required. The resource which will use the reservation. E.g. `projects/myproject`, `folders/123`, or `organizations/456`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpecAssignee
{
    /// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1BigQueryReservationAssignmentSpecAssigneeFolderRef? FolderRef { get; set; }

    /// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1BigQueryReservationAssignmentSpecAssigneeOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Exactly one of ProjectRef or FolderRef or OrganizationRef must be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryReservationAssignmentSpecAssigneeProjectRef? ProjectRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of reservation to create a new assignment in, or to move the assignment to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpecReservationRef
{
    /// <summary>A reference to an externally managed BigqueryReservation resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/reservations/{{reservationID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigqueryReservation resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigqueryReservation resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQueryReservationAssignmentSpec defines the desired state of BigQueryReservationAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentSpec
{
    /// <summary>Immutable. Required. The resource which will use the reservation. E.g. `projects/myproject`, `folders/123`, or `organizations/456`.</summary>
    [JsonPropertyName("assignee")]
    public V1alpha1BigQueryReservationAssignmentSpecAssignee Assignee { get; set; }

    /// <summary>Immutable. Which type of jobs will use the reservation.</summary>
    [JsonPropertyName("jobType")]
    public string JobType { get; set; }

    /// <summary>The name of reservation to create a new assignment in, or to move the assignment to.</summary>
    [JsonPropertyName("reservationRef")]
    public V1alpha1BigQueryReservationAssignmentSpecReservationRef ReservationRef { get; set; }

    /// <summary>Immutable. Optional. The BigQueryReservationAssignment ID used for resource creation or acquisition. Service-generated.Can be set only if resource acquisition . For acquisition: This field must be provided to identify the Reservation resource to acquire.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentStatusConditions
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
public partial class V1alpha1BigQueryReservationAssignmentStatusObservedState
{
    /// <summary>State of the assignment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQueryReservationAssignmentStatus defines the config connector machine state of BigQueryReservationAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationAssignmentStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryReservationAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigqueryReservationAssignment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryReservationAssignmentStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQueryReservationAssignment is the Schema for the BigQueryReservationAssignment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryReservationAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryReservationAssignmentSpec>, IStatus<V1alpha1BigQueryReservationAssignmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationAssignment";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryReservationAssignmentSpec defines the desired state of BigQueryReservationAssignment</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigQueryReservationAssignmentSpec Spec { get; set; }

    /// <summary>BigQueryReservationAssignmentStatus defines the config connector machine state of BigQueryReservationAssignment</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryReservationAssignmentStatus? Status { get; set; }
}
#nullable disable
