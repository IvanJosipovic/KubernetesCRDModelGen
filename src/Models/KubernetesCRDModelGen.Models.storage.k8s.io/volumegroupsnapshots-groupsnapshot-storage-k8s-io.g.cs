using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groupsnapshot.storage.k8s.io;
/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotSpecSourceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Selector is a label query over persistent volume claims that are to be grouped together for snapshotting. This labelSelector will be used to match the label added to a PVC. If the label is added or removed to a volume after a group snapshot is created, the existing group snapshots won't be modified. Once a VolumeGroupSnapshotContent is created and the sidecar starts to process it, the volume list will not change with retries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotSpecSourceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1VolumeGroupSnapshotSpecSourceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Source specifies where a group snapshot will be created from. This field is immutable after creation. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotSpecSource
{
    /// <summary>Selector is a label query over persistent volume claims that are to be grouped together for snapshotting. This labelSelector will be used to match the label added to a PVC. If the label is added or removed to a volume after a group snapshot is created, the existing group snapshots won't be modified. Once a VolumeGroupSnapshotContent is created and the sidecar starts to process it, the volume list will not change with retries.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1VolumeGroupSnapshotSpecSourceSelector? Selector { get; set; }

    /// <summary>VolumeGroupSnapshotContentName specifies the name of a pre-existing VolumeGroupSnapshotContent object representing an existing volume group snapshot. This field should be set if the volume group snapshot already exists and only needs a representation in Kubernetes. This field is immutable.</summary>
    [JsonPropertyName("volumeGroupSnapshotContentName")]
    public string? VolumeGroupSnapshotContentName { get; set; }
}

/// <summary>Spec defines the desired characteristics of a group snapshot requested by a user. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotSpec
{
    /// <summary>Source specifies where a group snapshot will be created from. This field is immutable after creation. Required.</summary>
    [JsonPropertyName("source")]
    public V1alpha1VolumeGroupSnapshotSpecSource Source { get; set; }

    /// <summary>VolumeGroupSnapshotClassName is the name of the VolumeGroupSnapshotClass requested by the VolumeGroupSnapshot. VolumeGroupSnapshotClassName may be left nil to indicate that the default class will be used. Empty string is not allowed for this field.</summary>
    [JsonPropertyName("volumeGroupSnapshotClassName")]
    public string? VolumeGroupSnapshotClassName { get; set; }
}

/// <summary>Error is the last observed error during group snapshot creation, if any. This field could be helpful to upper level controllers (i.e., application controller) to decide whether they should continue on waiting for the group snapshot to be created based on the type of error reported. The snapshot controller will keep retrying when an error occurs during the group snapshot creation. Upon success, this error field will be cleared.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotStatusError
{
    /// <summary>message is a string detailing the encountered error during snapshot creation if specified. NOTE: message may be logged, and it should not contain sensitive information.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>time is the timestamp when the error was encountered.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>PersistentVolumeClaimRef is a reference to the PVC this pair is referring to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefListPersistentVolumeClaimRef
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>VolumeSnapshotRef is a reference to the VolumeSnapshot this pair is referring to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefListVolumeSnapshotRef
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PVCVolumeSnapshotPair defines a pair of a PVC reference and a Volume Snapshot Reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefList
{
    /// <summary>PersistentVolumeClaimRef is a reference to the PVC this pair is referring to</summary>
    [JsonPropertyName("persistentVolumeClaimRef")]
    public V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefListPersistentVolumeClaimRef? PersistentVolumeClaimRef { get; set; }

    /// <summary>VolumeSnapshotRef is a reference to the VolumeSnapshot this pair is referring to</summary>
    [JsonPropertyName("volumeSnapshotRef")]
    public V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefListVolumeSnapshotRef? VolumeSnapshotRef { get; set; }
}

/// <summary>Status represents the current information of a group snapshot. Consumers must verify binding between VolumeGroupSnapshot and VolumeGroupSnapshotContent objects is successful (by validating that both VolumeGroupSnapshot and VolumeGroupSnapshotContent point to each other) before using this object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VolumeGroupSnapshotStatus
{
    /// <summary>BoundVolumeGroupSnapshotContentName is the name of the VolumeGroupSnapshotContent object to which this VolumeGroupSnapshot object intends to bind to. If not specified, it indicates that the VolumeGroupSnapshot object has not been successfully bound to a VolumeGroupSnapshotContent object yet. NOTE: To avoid possible security issues, consumers must verify binding between VolumeGroupSnapshot and VolumeGroupSnapshotContent objects is successful (by validating that both VolumeGroupSnapshot and VolumeGroupSnapshotContent point at each other) before using this object.</summary>
    [JsonPropertyName("boundVolumeGroupSnapshotContentName")]
    public string? BoundVolumeGroupSnapshotContentName { get; set; }

    /// <summary>CreationTime is the timestamp when the point-in-time group snapshot is taken by the underlying storage system. If not specified, it may indicate that the creation time of the group snapshot is unknown. The format of this field is a Unix nanoseconds time encoded as an int64. On Unix, the command date +%s%N returns the current time in nanoseconds since 1970-01-01 00:00:00 UTC.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>Error is the last observed error during group snapshot creation, if any. This field could be helpful to upper level controllers (i.e., application controller) to decide whether they should continue on waiting for the group snapshot to be created based on the type of error reported. The snapshot controller will keep retrying when an error occurs during the group snapshot creation. Upon success, this error field will be cleared.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VolumeGroupSnapshotStatusError? Error { get; set; }

    /// <summary>VolumeSnapshotRefList is the list of PVC and VolumeSnapshot pairs that is part of this group snapshot. The maximum number of allowed snapshots in the group is 100.</summary>
    [JsonPropertyName("pvcVolumeSnapshotRefList")]
    public IList<V1alpha1VolumeGroupSnapshotStatusPvcVolumeSnapshotRefList>? PvcVolumeSnapshotRefList { get; set; }

    /// <summary>ReadyToUse indicates if all the individual snapshots in the group are ready to be used to restore a group of volumes. ReadyToUse becomes true when ReadyToUse of all individual snapshots become true. If not specified, it means the readiness of a group snapshot is unknown.</summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }
}

/// <summary>VolumeGroupSnapshot is a user's request for creating either a point-in-time group snapshot or binding to a pre-existing group snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VolumeGroupSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VolumeGroupSnapshotSpec>, IStatus<V1alpha1VolumeGroupSnapshotStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VolumeGroupSnapshot";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired characteristics of a group snapshot requested by a user. Required.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VolumeGroupSnapshotSpec Spec { get; set; }

    /// <summary>Status represents the current information of a group snapshot. Consumers must verify binding between VolumeGroupSnapshot and VolumeGroupSnapshotContent objects is successful (by validating that both VolumeGroupSnapshot and VolumeGroupSnapshotContent point to each other) before using this object.</summary>
    [JsonPropertyName("status")]
    public V1alpha1VolumeGroupSnapshotStatus? Status { get; set; }
}