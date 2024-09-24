using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryreservation.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1BigQueryReservationCapacityCommitmentSpecProjectRef
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
public partial class V1alpha1BigQueryReservationCapacityCommitmentSpec
{
    /// <summary>Immutable. The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Immutable. If true, fail the request if another project in the organization has a capacity commitment.</summary>
    [JsonPropertyName("enforceSingleAdminProjectPerOrg")]
    public string? EnforceSingleAdminProjectPerOrg { get; set; }

    /// <summary>Immutable. The geographic location where the transfer config should reside. Examples: US, EU, asia-northeast1. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan.</summary>
    [JsonPropertyName("plan")]
    public string Plan { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryReservationCapacityCommitmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable some commitment plans.</summary>
    [JsonPropertyName("renewalPlan")]
    public string? RenewalPlan { get; set; }

    /// <summary>Immutable. Optional. The capacityCommitmentId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Number of slots in this commitment.</summary>
    [JsonPropertyName("slotCount")]
    public int SlotCount { get; set; }
}

/// <summary></summary>
public partial class V1alpha1BigQueryReservationCapacityCommitmentStatusConditions
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
public partial class V1alpha1BigQueryReservationCapacityCommitmentStatus
{
    /// <summary>The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.</summary>
    [JsonPropertyName("commitmentEndTime")]
    public string? CommitmentEndTime { get; set; }

    /// <summary>The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.</summary>
    [JsonPropertyName("commitmentStartTime")]
    public string? CommitmentStartTime { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryReservationCapacityCommitmentStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>State of the commitment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1BigQueryReservationCapacityCommitment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryReservationCapacityCommitmentSpec>, IStatus<V1alpha1BigQueryReservationCapacityCommitmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationCapacityCommitment";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationcapacitycommitments";
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
    public V1alpha1BigQueryReservationCapacityCommitmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryReservationCapacityCommitmentStatus? Status { get; set; }
}