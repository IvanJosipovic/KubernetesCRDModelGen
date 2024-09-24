using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesGuestAccelerators
{
    /// <summary>Immutable. The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int AcceleratorCount { get; set; }

    /// <summary>Immutable. The full or partial URL of the accelerator type to attach to this instance. For example: 'projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100'  If you are creating an instance template, specify only the accelerator name.</summary>
    [JsonPropertyName("acceleratorType")]
    public string AcceleratorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesLocalSsds
{
    /// <summary>Immutable. The size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int DiskSizeGb { get; set; }

    /// <summary>Immutable. The disk interface to use for attaching this disk. Default value: "SCSI" Possible values: ["SCSI", "NVME"].</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>Immutable. The instance properties for the reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstanceProperties
{
    /// <summary>Immutable. Guest accelerator type and count.</summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>Immutable. The amount of local ssd to reserve with each instance. This reserves disks of type 'local-ssd'.</summary>
    [JsonPropertyName("localSsds")]
    public IList<V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>Immutable. The name of the machine type to reserve.</summary>
    [JsonPropertyName("machineType")]
    public string MachineType { get; set; }

    /// <summary>Immutable. The minimum CPU platform for the reservation. For example, '"Intel Skylake"'. See the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones) for information on available CPU platforms.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }
}

/// <summary>Reservation for instances with specific machine shapes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservation
{
    /// <summary>The number of resources that are allocated.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>How many instances are in use.</summary>
    [JsonPropertyName("inUseCount")]
    public int? InUseCount { get; set; }

    /// <summary>Immutable. The instance properties for the reservation.</summary>
    [JsonPropertyName("instanceProperties")]
    public V1beta1ComputeReservationSpecSpecificReservationInstanceProperties InstanceProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Reservation for instances with specific machine shapes.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ComputeReservationSpecSpecificReservation SpecificReservation { get; set; }

    /// <summary>Immutable. When set to true, only VMs that target this reservation by name can consume this reservation. Otherwise, it can be consumed by VMs with affinity for any reservation. Defaults to false.</summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }

    /// <summary>Immutable. The zone where the reservation is made.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationStatusConditions
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
public partial class V1beta1ComputeReservationStatus
{
    /// <summary>Full or partial URL to a parent commitment. This field displays for reservations that are tied to a commitment.</summary>
    [JsonPropertyName("commitment")]
    public string? Commitment { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeReservationStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The status of the reservation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeReservationSpec>, IStatus<V1beta1ComputeReservationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeReservation";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computereservations";
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
    public V1beta1ComputeReservationSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeReservationStatus? Status { get; set; }
}