using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryreservation.cnrm.cloud.google.com;
/// <summary>The configuration parameters for the auto scaling feature.</summary>
public partial class V1alpha1BigQueryReservationReservationSpecAutoscale
{
    /// <summary>The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots].</summary>
    [JsonPropertyName("currentSlots")]
    public int? CurrentSlots { get; set; }

    /// <summary>Number of slots to be scaled when needed.</summary>
    [JsonPropertyName("maxSlots")]
    public int? MaxSlots { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1BigQueryReservationReservationSpecProjectRef
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
public partial class V1alpha1BigQueryReservationReservationSpec
{
    /// <summary>The configuration parameters for the auto scaling feature.</summary>
    [JsonPropertyName("autoscale")]
    public V1alpha1BigQueryReservationReservationSpecAutoscale? Autoscale { get; set; }

    /// <summary>Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.</summary>
    [JsonPropertyName("concurrency")]
    public int? Concurrency { get; set; }

    /// <summary>Immutable. The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>If false, any query using this reservation will use idle slots from other reservations within the same admin project. If true, a query using this reservation will execute with the slot capacity specified above at most.</summary>
    [JsonPropertyName("ignoreIdleSlots")]
    public bool? IgnoreIdleSlots { get; set; }

    /// <summary>Immutable. The geographic location where the transfer config should reside. Examples: US, EU, asia-northeast1. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Applicable only for reservations located within one of the BigQuery multi-regions (US or EU). If set to true, this reservation is placed in the organization's secondary region which is designated for disaster recovery purposes. If false, this reservation is placed in the organization's default region.</summary>
    [JsonPropertyName("multiRegionAuxiliary")]
    public bool? MultiRegionAuxiliary { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryReservationReservationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.</summary>
    [JsonPropertyName("slotCapacity")]
    public int SlotCapacity { get; set; }
}

/// <summary></summary>
public partial class V1alpha1BigQueryReservationReservationStatusConditions
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
public partial class V1alpha1BigQueryReservationReservationStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryReservationReservationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1BigQueryReservationReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryReservationReservationSpec>, IStatus<V1alpha1BigQueryReservationReservationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationReservation";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationreservations";
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
    public V1alpha1BigQueryReservationReservationSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryReservationReservationStatus? Status { get; set; }
}