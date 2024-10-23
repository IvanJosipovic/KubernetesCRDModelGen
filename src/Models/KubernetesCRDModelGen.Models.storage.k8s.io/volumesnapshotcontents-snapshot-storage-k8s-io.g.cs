using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.snapshot.storage.k8s.io;
/// <summary>source specifies whether the snapshot is (or should be) dynamically provisioned or already exists, and just requires a Kubernetes object representation. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotContentSpecSource
{
    /// <summary>snapshotHandle specifies the CSI "snapshot_id" of a pre-existing snapshot on the underlying storage system for which a Kubernetes object representation was (or should be) created. This field is immutable.</summary>
    [JsonPropertyName("snapshotHandle")]
    public string? SnapshotHandle { get; set; }

    /// <summary>volumeHandle specifies the CSI "volume_id" of the volume from which a snapshot should be dynamically taken from. This field is immutable.</summary>
    [JsonPropertyName("volumeHandle")]
    public string? VolumeHandle { get; set; }
}

/// <summary>volumeSnapshotRef specifies the VolumeSnapshot object to which this VolumeSnapshotContent object is bound. VolumeSnapshot.Spec.VolumeSnapshotContentName field must reference to this VolumeSnapshotContent's name for the bidirectional binding to be valid. For a pre-existing VolumeSnapshotContent object, name and namespace of the VolumeSnapshot object MUST be provided for binding to happen. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotContentSpecVolumeSnapshotRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>spec defines properties of a VolumeSnapshotContent created by the underlying storage system. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotContentSpec
{
    /// <summary>deletionPolicy determines whether this VolumeSnapshotContent and its physical snapshot on the underlying storage system should be deleted when its bound VolumeSnapshot is deleted. Supported values are "Retain" and "Delete". "Retain" means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are kept. "Delete" means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are deleted. For dynamically provisioned snapshots, this field will automatically be filled in by the CSI snapshotter sidecar with the "DeletionPolicy" field defined in the corresponding VolumeSnapshotClass. For pre-existing snapshots, users MUST specify this field when creating the  VolumeSnapshotContent object. Required.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string DeletionPolicy { get; set; }

    /// <summary>driver is the name of the CSI driver used to create the physical snapshot on the underlying storage system. This MUST be the same as the name returned by the CSI GetPluginName() call for that driver. Required.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>source specifies whether the snapshot is (or should be) dynamically provisioned or already exists, and just requires a Kubernetes object representation. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("source")]
    public V1VolumeSnapshotContentSpecSource Source { get; set; }

    /// <summary>SourceVolumeMode is the mode of the volume whose snapshot is taken. Can be either “Filesystem” or “Block”. If not specified, it indicates the source volume's mode is unknown. This field is immutable. This field is an alpha field.</summary>
    [JsonPropertyName("sourceVolumeMode")]
    public string? SourceVolumeMode { get; set; }

    /// <summary>name of the VolumeSnapshotClass from which this snapshot was (or will be) created. Note that after provisioning, the VolumeSnapshotClass may be deleted or recreated with different set of values, and as such, should not be referenced post-snapshot creation.</summary>
    [JsonPropertyName("volumeSnapshotClassName")]
    public string? VolumeSnapshotClassName { get; set; }

    /// <summary>volumeSnapshotRef specifies the VolumeSnapshot object to which this VolumeSnapshotContent object is bound. VolumeSnapshot.Spec.VolumeSnapshotContentName field must reference to this VolumeSnapshotContent's name for the bidirectional binding to be valid. For a pre-existing VolumeSnapshotContent object, name and namespace of the VolumeSnapshot object MUST be provided for binding to happen. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("volumeSnapshotRef")]
    public V1VolumeSnapshotContentSpecVolumeSnapshotRef VolumeSnapshotRef { get; set; }
}

/// <summary>error is the last observed error during snapshot creation, if any. Upon success after retry, this error field will be cleared.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotContentStatusError
{
    /// <summary>message is a string detailing the encountered error during snapshot creation if specified. NOTE: message may be logged, and it should not contain sensitive information.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>time is the timestamp when the error was encountered.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>status represents the current information of a snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotContentStatus
{
    /// <summary>creationTime is the timestamp when the point-in-time snapshot is taken by the underlying storage system. In dynamic snapshot creation case, this field will be filled in by the CSI snapshotter sidecar with the "creation_time" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "creation_time" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it. If not specified, it indicates the creation time is unknown. The format of this field is a Unix nanoseconds time encoded as an int64. On Unix, the command `date +%s%N` returns the current time in nanoseconds since 1970-01-01 00:00:00 UTC.</summary>
    [JsonPropertyName("creationTime")]
    public long? CreationTime { get; set; }

    /// <summary>error is the last observed error during snapshot creation, if any. Upon success after retry, this error field will be cleared.</summary>
    [JsonPropertyName("error")]
    public V1VolumeSnapshotContentStatusError? Error { get; set; }

    /// <summary>readyToUse indicates if a snapshot is ready to be used to restore a volume. In dynamic snapshot creation case, this field will be filled in by the CSI snapshotter sidecar with the "ready_to_use" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "ready_to_use" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it, otherwise, this field will be set to "True". If not specified, it means the readiness of a snapshot is unknown.</summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }

    /// <summary>restoreSize represents the complete size of the snapshot in bytes. In dynamic snapshot creation case, this field will be filled in by the CSI snapshotter sidecar with the "size_bytes" value returned from CSI "CreateSnapshot" gRPC call. For a pre-existing snapshot, this field will be filled with the "size_bytes" value returned from the CSI "ListSnapshots" gRPC call if the driver supports it. When restoring a volume from this snapshot, the size of the volume MUST NOT be smaller than the restoreSize if it is specified, otherwise the restoration will fail. If not specified, it indicates that the size is unknown.</summary>
    [JsonPropertyName("restoreSize")]
    public long? RestoreSize { get; set; }

    /// <summary>snapshotHandle is the CSI "snapshot_id" of a snapshot on the underlying storage system. If not specified, it indicates that dynamic snapshot creation has either failed or it is still in progress.</summary>
    [JsonPropertyName("snapshotHandle")]
    public string? SnapshotHandle { get; set; }

    /// <summary>VolumeGroupSnapshotHandle is the CSI "group_snapshot_id" of a group snapshot on the underlying storage system.</summary>
    [JsonPropertyName("volumeGroupSnapshotHandle")]
    public string? VolumeGroupSnapshotHandle { get; set; }
}

/// <summary>VolumeSnapshotContent represents the actual "on-disk" snapshot object in the underlying storage system</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotContent : IKubernetesObject<V1ObjectMeta>, ISpec<V1VolumeSnapshotContentSpec>, IStatus<V1VolumeSnapshotContentStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotContent";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshotcontents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>spec defines properties of a VolumeSnapshotContent created by the underlying storage system. Required.</summary>
    [JsonPropertyName("spec")]
    public V1VolumeSnapshotContentSpec Spec { get; set; }

    /// <summary>status represents the current information of a snapshot.</summary>
    [JsonPropertyName("status")]
    public V1VolumeSnapshotContentStatus? Status { get; set; }
}