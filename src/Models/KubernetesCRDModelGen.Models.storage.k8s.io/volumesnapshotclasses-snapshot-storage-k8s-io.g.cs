using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.snapshot.storage.k8s.io;
/// <summary>VolumeSnapshotClass specifies parameters that a underlying storage system uses when creating a volume snapshot. A specific VolumeSnapshotClass is used by specifying its name in a VolumeSnapshot object. VolumeSnapshotClasses are non-namespaced</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotClassList : IKubernetesObject<V1ListMeta>, IItems<V1VolumeSnapshotClass>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotClassList";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshotclasses";
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
    public IList<V1VolumeSnapshotClass> Items { get; set; }
}

/// <summary>VolumeSnapshotClass specifies parameters that a underlying storage system uses when creating a volume snapshot. A specific VolumeSnapshotClass is used by specifying its name in a VolumeSnapshot object. VolumeSnapshotClasses are non-namespaced</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotClass : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotClass";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshotclasses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>deletionPolicy determines whether a VolumeSnapshotContent created through the VolumeSnapshotClass should be deleted when its bound VolumeSnapshot is deleted. Supported values are "Retain" and "Delete". "Retain" means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are kept. "Delete" means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are deleted. Required.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string DeletionPolicy { get; set; }

    /// <summary>driver is the name of the storage driver that handles this VolumeSnapshotClass. Required.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>parameters is a key-value map with storage driver specific parameters for creating snapshots. These values are opaque to Kubernetes.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}