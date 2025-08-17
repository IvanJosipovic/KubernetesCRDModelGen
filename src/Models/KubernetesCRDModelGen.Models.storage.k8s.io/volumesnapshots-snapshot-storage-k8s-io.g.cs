using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.snapshot.storage.k8s.io;
#nullable enable
/// <summary>VolumeSnapshot is a user's request for either creating a point-in-time snapshot of a persistent volume, or binding to a pre-existing snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1VolumeSnapshot>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotList";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshots";
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
    public IList<V1VolumeSnapshot> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>source specifies where a snapshot will be created from. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotSpecSource
{
    /// <summary>persistentVolumeClaimName specifies the name of the PersistentVolumeClaim object representing the volume from which a snapshot should be created. This PVC is assumed to be in the same namespace as the VolumeSnapshot object. This field should be set if the snapshot does not exists, and needs to be created. This field is immutable.</summary>
    [JsonPropertyName("persistentVolumeClaimName")]
    public string? PersistentVolumeClaimName { get; set; }

    /// <summary>volumeSnapshotContentName specifies the name of a pre-existing VolumeSnapshotContent object representing an existing volume snapshot. This field should be set if the snapshot already exists and only needs a representation in Kubernetes. This field is immutable.</summary>
    [JsonPropertyName("volumeSnapshotContentName")]
    public string? VolumeSnapshotContentName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>spec defines the desired characteristics of a snapshot requested by a user. More info: https://kubernetes.io/docs/concepts/storage/volume-snapshots#volumesnapshots Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotSpec
{
    /// <summary>source specifies where a snapshot will be created from. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("source")]
    public V1VolumeSnapshotSpecSource Source { get; set; }

    /// <summary>VolumeSnapshotClassName is the name of the VolumeSnapshotClass requested by the VolumeSnapshot. VolumeSnapshotClassName may be left nil to indicate that the default SnapshotClass should be used. A given cluster may have multiple default Volume SnapshotClasses: one default per CSI Driver. If a VolumeSnapshot does not specify a SnapshotClass, VolumeSnapshotSource will be checked to figure out what the associated CSI Driver is, and the default VolumeSnapshotClass associated with that CSI Driver will be used. If more than one VolumeSnapshotClass exist for a given CSI Driver and more than one have been marked as default, CreateSnapshot will fail and generate an event. Empty string is not allowed for this field.</summary>
    [JsonPropertyName("volumeSnapshotClassName")]
    public string? VolumeSnapshotClassName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>error is the last observed error during snapshot creation, if any. This field could be helpful to upper level controllers(i.e., application controller) to decide whether they should continue on waiting for the snapshot to be created based on the type of error reported. The snapshot controller will keep retrying when an error occurs during the snapshot creation. Upon success, this error field will be cleared.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotStatusError
{
    /// <summary>message is a string detailing the encountered error during snapshot creation if specified. NOTE: message may be logged, and it should not contain sensitive information.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>time is the timestamp when the error was encountered.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>status represents the current information of a snapshot. Consumers must verify binding between VolumeSnapshot and VolumeSnapshotContent objects is successful (by validating that both VolumeSnapshot and VolumeSnapshotContent point at each other) before using this object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotStatus
{
    /// <summary>boundVolumeSnapshotContentName is the name of the VolumeSnapshotContent object to which this VolumeSnapshot object intends to bind to. If not specified, it indicates that the VolumeSnapshot object has not been successfully bound to a VolumeSnapshotContent object yet. NOTE: To avoid possible security issues, consumers must verify binding between VolumeSnapshot and VolumeSnapshotContent objects is successful (by validating that both VolumeSnapshot and VolumeSnapshotContent point at each other) before using this object.</summary>
    [JsonPropertyName("boundVolumeSnapshotContentName")]
    public string? BoundVolumeSnapshotContentName { get; set; }

    /// <summary>creationTime is the timestamp when the point-in-time snapshot is taken by the underlying storage system. In dynamic snapshot creation case, this field will be filled in by the snapshot controller with the "creation_time" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "creation_time" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it. If not specified, it may indicate that the creation time of the snapshot is unknown.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>error is the last observed error during snapshot creation, if any. This field could be helpful to upper level controllers(i.e., application controller) to decide whether they should continue on waiting for the snapshot to be created based on the type of error reported. The snapshot controller will keep retrying when an error occurs during the snapshot creation. Upon success, this error field will be cleared.</summary>
    [JsonPropertyName("error")]
    public V1VolumeSnapshotStatusError? Error { get; set; }

    /// <summary>readyToUse indicates if the snapshot is ready to be used to restore a volume. In dynamic snapshot creation case, this field will be filled in by the snapshot controller with the "ready_to_use" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "ready_to_use" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it, otherwise, this field will be set to "True". If not specified, it means the readiness of a snapshot is unknown.</summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }

    /// <summary>restoreSize represents the minimum size of volume required to create a volume from this snapshot. In dynamic snapshot creation case, this field will be filled in by the snapshot controller with the "size_bytes" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "size_bytes" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it. When restoring a volume from this snapshot, the size of the volume MUST NOT be smaller than the restoreSize if it is specified, otherwise the restoration will fail. If not specified, it indicates that the size is unknown.</summary>
    [JsonPropertyName("restoreSize")]
    public IntstrIntOrString? RestoreSize { get; set; }

    /// <summary>VolumeGroupSnapshotName is the name of the VolumeGroupSnapshot of which this VolumeSnapshot is a part of.</summary>
    [JsonPropertyName("volumeGroupSnapshotName")]
    public string? VolumeGroupSnapshotName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VolumeSnapshot is a user's request for either creating a point-in-time snapshot of a persistent volume, or binding to a pre-existing snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1VolumeSnapshotSpec>, IStatus<V1VolumeSnapshotStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshot";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>spec defines the desired characteristics of a snapshot requested by a user. More info: https://kubernetes.io/docs/concepts/storage/volume-snapshots#volumesnapshots Required.</summary>
    [JsonPropertyName("spec")]
    public V1VolumeSnapshotSpec Spec { get; set; }

    /// <summary>status represents the current information of a snapshot. Consumers must verify binding between VolumeSnapshot and VolumeSnapshotContent objects is successful (by validating that both VolumeSnapshot and VolumeSnapshotContent point at each other) before using this object.</summary>
    [JsonPropertyName("status")]
    public V1VolumeSnapshotStatus? Status { get; set; }
}
#nullable disable
