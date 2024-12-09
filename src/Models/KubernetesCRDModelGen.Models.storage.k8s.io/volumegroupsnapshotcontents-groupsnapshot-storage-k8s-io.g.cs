using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groupsnapshot.storage.k8s.io;
/// <summary>GroupSnapshotHandles specifies the CSI "group_snapshot_id" of a pre-existing group snapshot and a list of CSI "snapshot_id" of pre-existing snapshots on the underlying storage system for which a Kubernetes object representation was (or should be) created. This field is immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentSpecSourceGroupSnapshotHandles
{
    /// <summary>VolumeGroupSnapshotHandle specifies the CSI "group_snapshot_id" of a pre-existing group snapshot on the underlying storage system for which a Kubernetes object representation was (or should be) created. This field is immutable. Required.</summary>
    [JsonPropertyName("volumeGroupSnapshotHandle")]
    public string VolumeGroupSnapshotHandle { get; set; }

    /// <summary>VolumeSnapshotHandles is a list of CSI "snapshot_id" of pre-existing snapshots on the underlying storage system for which Kubernetes objects representation were (or should be) created. This field is immutable. Required.</summary>
    [JsonPropertyName("volumeSnapshotHandles")]
    public IList<string> VolumeSnapshotHandles { get; set; }
}

/// <summary>Source specifies whether the snapshot is (or should be) dynamically provisioned or already exists, and just requires a Kubernetes object representation. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentSpecSource
{
    /// <summary>GroupSnapshotHandles specifies the CSI "group_snapshot_id" of a pre-existing group snapshot and a list of CSI "snapshot_id" of pre-existing snapshots on the underlying storage system for which a Kubernetes object representation was (or should be) created. This field is immutable.</summary>
    [JsonPropertyName("groupSnapshotHandles")]
    public V1beta1VolumeGroupSnapshotContentSpecSourceGroupSnapshotHandles? GroupSnapshotHandles { get; set; }

    /// <summary>VolumeHandles is a list of volume handles on the backend to be snapshotted together. It is specified for dynamic provisioning of the VolumeGroupSnapshot. This field is immutable.</summary>
    [JsonPropertyName("volumeHandles")]
    public IList<string>? VolumeHandles { get; set; }
}

/// <summary>VolumeGroupSnapshotRef specifies the VolumeGroupSnapshot object to which this VolumeGroupSnapshotContent object is bound. VolumeGroupSnapshot.Spec.VolumeGroupSnapshotContentName field must reference to this VolumeGroupSnapshotContent's name for the bidirectional binding to be valid. For a pre-existing VolumeGroupSnapshotContent object, name and namespace of the VolumeGroupSnapshot object MUST be provided for binding to happen. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentSpecVolumeGroupSnapshotRef
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

/// <summary>Spec defines properties of a VolumeGroupSnapshotContent created by the underlying storage system. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentSpec
{
    /// <summary>DeletionPolicy determines whether this VolumeGroupSnapshotContent and the physical group snapshot on the underlying storage system should be deleted when the bound VolumeGroupSnapshot is deleted. Supported values are "Retain" and "Delete". "Retain" means that the VolumeGroupSnapshotContent and its physical group snapshot on underlying storage system are kept. "Delete" means that the VolumeGroupSnapshotContent and its physical group snapshot on underlying storage system are deleted. For dynamically provisioned group snapshots, this field will automatically be filled in by the CSI snapshotter sidecar with the "DeletionPolicy" field defined in the corresponding VolumeGroupSnapshotClass. For pre-existing snapshots, users MUST specify this field when creating the VolumeGroupSnapshotContent object. Required.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string DeletionPolicy { get; set; }

    /// <summary>Driver is the name of the CSI driver used to create the physical group snapshot on the underlying storage system. This MUST be the same as the name returned by the CSI GetPluginName() call for that driver. Required.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>Source specifies whether the snapshot is (or should be) dynamically provisioned or already exists, and just requires a Kubernetes object representation. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("source")]
    public V1beta1VolumeGroupSnapshotContentSpecSource Source { get; set; }

    /// <summary>VolumeGroupSnapshotClassName is the name of the VolumeGroupSnapshotClass from which this group snapshot was (or will be) created. Note that after provisioning, the VolumeGroupSnapshotClass may be deleted or recreated with different set of values, and as such, should not be referenced post-snapshot creation. For dynamic provisioning, this field must be set. This field may be unset for pre-provisioned snapshots.</summary>
    [JsonPropertyName("volumeGroupSnapshotClassName")]
    public string? VolumeGroupSnapshotClassName { get; set; }

    /// <summary>VolumeGroupSnapshotRef specifies the VolumeGroupSnapshot object to which this VolumeGroupSnapshotContent object is bound. VolumeGroupSnapshot.Spec.VolumeGroupSnapshotContentName field must reference to this VolumeGroupSnapshotContent's name for the bidirectional binding to be valid. For a pre-existing VolumeGroupSnapshotContent object, name and namespace of the VolumeGroupSnapshot object MUST be provided for binding to happen. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("volumeGroupSnapshotRef")]
    public V1beta1VolumeGroupSnapshotContentSpecVolumeGroupSnapshotRef VolumeGroupSnapshotRef { get; set; }
}

/// <summary>Error is the last observed error during group snapshot creation, if any. Upon success after retry, this error field will be cleared.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentStatusError
{
    /// <summary>message is a string detailing the encountered error during snapshot creation if specified. NOTE: message may be logged, and it should not contain sensitive information.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>time is the timestamp when the error was encountered.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>VolumeSnapshotHandlePair defines a pair of a source volume handle and a snapshot handle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentStatusVolumeSnapshotHandlePairList
{
    /// <summary>SnapshotHandle is a unique id returned by the CSI driver to identify a volume snapshot on the storage system Required.</summary>
    [JsonPropertyName("snapshotHandle")]
    public string SnapshotHandle { get; set; }

    /// <summary>VolumeHandle is a unique id returned by the CSI driver to identify a volume on the storage system Required.</summary>
    [JsonPropertyName("volumeHandle")]
    public string VolumeHandle { get; set; }
}

/// <summary>status represents the current information of a group snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VolumeGroupSnapshotContentStatus
{
    /// <summary>CreationTime is the timestamp when the point-in-time group snapshot is taken by the underlying storage system. If not specified, it indicates the creation time is unknown. If not specified, it means the readiness of a group snapshot is unknown. The format of this field is a Unix nanoseconds time encoded as an int64. On Unix, the command date +%s%N returns the current time in nanoseconds since 1970-01-01 00:00:00 UTC. This field is the source for the CreationTime field in VolumeGroupSnapshotStatus</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>Error is the last observed error during group snapshot creation, if any. Upon success after retry, this error field will be cleared.</summary>
    [JsonPropertyName("error")]
    public V1beta1VolumeGroupSnapshotContentStatusError? Error { get; set; }

    /// <summary>ReadyToUse indicates if all the individual snapshots in the group are ready to be used to restore a group of volumes. ReadyToUse becomes true when ReadyToUse of all individual snapshots become true.</summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }

    /// <summary>VolumeGroupSnapshotHandle is a unique id returned by the CSI driver to identify the VolumeGroupSnapshot on the storage system. If a storage system does not provide such an id, the CSI driver can choose to return the VolumeGroupSnapshot name.</summary>
    [JsonPropertyName("volumeGroupSnapshotHandle")]
    public string? VolumeGroupSnapshotHandle { get; set; }

    /// <summary>VolumeSnapshotHandlePairList is a list of CSI "volume_id" and "snapshot_id" pair returned by the CSI driver to identify snapshots and their source volumes on the storage system.</summary>
    [JsonPropertyName("volumeSnapshotHandlePairList")]
    public IList<V1beta1VolumeGroupSnapshotContentStatusVolumeSnapshotHandlePairList>? VolumeSnapshotHandlePairList { get; set; }
}

/// <summary>VolumeGroupSnapshotContent represents the actual "on-disk" group snapshot object in the underlying storage system</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VolumeGroupSnapshotContent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VolumeGroupSnapshotContentSpec>, IStatus<V1beta1VolumeGroupSnapshotContentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VolumeGroupSnapshotContent";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshotcontents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines properties of a VolumeGroupSnapshotContent created by the underlying storage system. Required.</summary>
    [JsonPropertyName("spec")]
    public V1beta1VolumeGroupSnapshotContentSpec Spec { get; set; }

    /// <summary>status represents the current information of a group snapshot.</summary>
    [JsonPropertyName("status")]
    public V1beta1VolumeGroupSnapshotContentStatus? Status { get; set; }
}