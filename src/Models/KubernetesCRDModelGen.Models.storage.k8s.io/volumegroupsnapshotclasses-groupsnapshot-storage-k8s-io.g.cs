using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groupsnapshot.storage.k8s.io;
/// <summary>VolumeGroupSnapshotClass specifies parameters that a underlying storage system uses when creating a volume group snapshot. A specific VolumeGroupSnapshotClass is used by specifying its name in a VolumeGroupSnapshot object. VolumeGroupSnapshotClasses are non-namespaced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VolumeGroupSnapshotClassList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VolumeGroupSnapshotClass>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VolumeGroupSnapshotClassList";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshotclasses";
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
    public IList<V1beta1VolumeGroupSnapshotClass> Items { get; set; }
}

/// <summary>VolumeGroupSnapshotClass specifies parameters that a underlying storage system uses when creating a volume group snapshot. A specific VolumeGroupSnapshotClass is used by specifying its name in a VolumeGroupSnapshot object. VolumeGroupSnapshotClasses are non-namespaced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VolumeGroupSnapshotClass : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VolumeGroupSnapshotClass";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshotclasses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeletionPolicy determines whether a VolumeGroupSnapshotContent created through the VolumeGroupSnapshotClass should be deleted when its bound VolumeGroupSnapshot is deleted. Supported values are "Retain" and "Delete". "Retain" means that the VolumeGroupSnapshotContent and its physical group snapshot on underlying storage system are kept. "Delete" means that the VolumeGroupSnapshotContent and its physical group snapshot on underlying storage system are deleted. Required.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string DeletionPolicy { get; set; }

    /// <summary>Driver is the name of the storage driver expected to handle this VolumeGroupSnapshotClass. Required.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>Parameters is a key-value map with storage driver specific parameters for creating group snapshots. These values are opaque to Kubernetes and are passed directly to the driver.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}