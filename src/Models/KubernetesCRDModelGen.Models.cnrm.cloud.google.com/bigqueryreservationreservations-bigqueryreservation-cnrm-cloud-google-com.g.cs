using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryreservation.cnrm.cloud.google.com;
/// <summary>Optional. The configuration parameters for the auto scaling feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationSpecAutoscale
{
    /// <summary>Number of slots to be scaled when needed.</summary>
    [JsonPropertyName("maxSlots")]
    public long? MaxSlots { get; set; }
}

/// <summary>Optional. This field is only set for reservations using the managed disaster recovery feature. Users can set this to create a failover reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationSpecFailover
{
    /// <summary>Users can update this field to convert a non-failover reservation to a failover reservation (by setting a specific region value) or convert a failover reservation to a non-failover reservation (by removing spec.failover). However, changes from one region to another region will be ignored by the controller. Additionally, if the value of this field changes during manual failover by the API, the controller will not attempt to revert these changes.  Note: This field is only available for ENTERPRISE_PLUS edition reservations. Immutable.</summary>
    [JsonPropertyName("secondaryLocation")]
    public string SecondaryLocation { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationSpecProjectRef
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

/// <summary>BigQueryReservationReservationSpec defines the desired state of BigQueryReservationReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationSpec
{
    /// <summary>Optional. The configuration parameters for the auto scaling feature.</summary>
    [JsonPropertyName("autoscale")]
    public V1alpha1BigQueryReservationReservationSpecAutoscale? Autoscale { get; set; }

    /// <summary>Job concurrency target which sets a soft upper bound on the number of jobs that can run concurrently in this reservation. This is a soft target due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency target will be automatically computed by the system. NOTE: this field is exposed as target job concurrency in the Information Schema, DDL and BigQuery CLI.</summary>
    [JsonPropertyName("concurrency")]
    public long? Concurrency { get; set; }

    /// <summary>Immutable. Optional. Edition of the reservation. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Optional. This field is only set for reservations using the managed disaster recovery feature. Users can set this to create a failover reservation.</summary>
    [JsonPropertyName("failover")]
    public V1alpha1BigQueryReservationReservationSpecFailover? Failover { get; set; }

    /// <summary>If false, any query or pipeline job using this reservation will use idle slots from other reservations within the same admin project. If true, a query or pipeline job using this reservation will execute with the slot capacity specified in the slot_capacity field at most.</summary>
    [JsonPropertyName("ignoreIdleSlots")]
    public bool? IgnoreIdleSlots { get; set; }

    /// <summary>Immutable. You can configure spec.secondaryLocation to enable the reservation fail-over to a secondary location, in which case the primary location could be different from the spec.location.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryReservationReservationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The BigQuery Reservation ID used for resource creation or acquisition. It must only contain lower case alphanumeric characters or dashes. It must start with a letter and must not end with a dash. Its maximum length is 64 characters. For creation: If specified, this value is used as the Reservation ID. If not provided, a UUID will be generated and assigned as the Reservation ID. For acquisition: This field must be provided to identify the Reservation resource to acquire.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Baseline slots available to this reservation. A slot is a unit of  computational power in BigQuery, and serves as the unit of parallelism.   Queries using this reservation might use more slots during runtime if  ignore_idle_slots is set to false, or autoscaling is enabled.</summary>
    [JsonPropertyName("slotCapacity")]
    public long? SlotCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationStatusObservedStateAutoscale
{
    /// <summary>The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots]. Note: after users reduce max_slots, it may take a while before it can be propagated, so current_slots may stay in the original value and could be larger than max_slots for that brief period (less than one minute)</summary>
    [JsonPropertyName("currentSlots")]
    public long? CurrentSlots { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationStatusObservedStateFailover
{
    /// <summary>The location where the reservation was originally created. This is set only during the failover reservation's creation. All billing charges for the failover reservation will be applied to this location.</summary>
    [JsonPropertyName("originalPrimaryLocation")]
    public string? OriginalPrimaryLocation { get; set; }

    /// <summary>The current location of the reservation's primary replica. This field is only set for reservations using the managed disaster recovery feature.</summary>
    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    /// <summary>The current location of the reservation's secondary replica. This field is only set for reservations using the managed disaster recovery feature. Users can set this in create reservation calls to create a failover reservation or in update reservation calls to convert a non-failover reservation to a failover reservation(or vice versa).</summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationStatusObservedState
{
    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public V1alpha1BigQueryReservationReservationStatusObservedStateAutoscale? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failover")]
    public V1alpha1BigQueryReservationReservationStatusObservedStateFailover? Failover { get; set; }
}

/// <summary>BigQueryReservationReservationStatus defines the config connector machine state of BigQueryReservationReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationReservationStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryReservationReservationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryReservationReservation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryReservationReservationStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryReservationReservation is the Schema for the BigQueryReservationReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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

    /// <summary>BigQueryReservationReservationSpec defines the desired state of BigQueryReservationReservation</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigQueryReservationReservationSpec Spec { get; set; }

    /// <summary>BigQueryReservationReservationStatus defines the config connector machine state of BigQueryReservationReservation</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryReservationReservationStatus? Status { get; set; }
}

/// <summary>BigQueryReservationReservation is the Schema for the BigQueryReservationReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryReservationReservationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryReservationReservation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationReservationList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1BigQueryReservationReservation> Items { get; set; }
}