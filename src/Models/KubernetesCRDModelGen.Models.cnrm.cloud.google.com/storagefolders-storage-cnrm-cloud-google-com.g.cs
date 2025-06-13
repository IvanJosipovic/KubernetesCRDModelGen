using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderSpecProjectRef
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

/// <summary>Required. The storage bucket where the folder will be created in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderSpecStoragebucketRef
{
    /// <summary>The StorageBucket selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>StorageFolderSpec defines the desired state of StorageFolder</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderSpec
{
    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1StorageFolderSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The StorageFolder name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The storage bucket where the folder will be created in.</summary>
    [JsonPropertyName("storagebucketRef")]
    public V1alpha1StorageFolderSpecStoragebucketRef? StoragebucketRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderStatusConditions
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

/// <summary>Output only. Only present if the folder is part of an ongoing RenameFolder operation. Contains information which can be used to query the operation status. The presence of this field also indicates all write operations are blocked for this folder, including folder, managed folder, and object operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderStatusObservedStatePendingRenameInfo
{
    /// <summary>Output only. The name of the rename operation.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderStatusObservedState
{
    /// <summary>Output only. The creation time of the folder.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The version of the metadata for this folder. Used for preconditions and for detecting changes in metadata.</summary>
    [JsonPropertyName("metageneration")]
    public long? Metageneration { get; set; }

    /// <summary>Output only. Only present if the folder is part of an ongoing RenameFolder operation. Contains information which can be used to query the operation status. The presence of this field also indicates all write operations are blocked for this folder, including folder, managed folder, and object operations.</summary>
    [JsonPropertyName("pendingRenameInfo")]
    public V1alpha1StorageFolderStatusObservedStatePendingRenameInfo? PendingRenameInfo { get; set; }

    /// <summary>Output only. The modification time of the folder.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>StorageFolderStatus defines the config connector machine state of StorageFolder</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StorageFolderStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StorageFolderStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the StorageFolder resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1StorageFolderStatusObservedState? ObservedState { get; set; }
}

/// <summary>StorageFolder is the Schema for the StorageFolder API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StorageFolder : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StorageFolderSpec>, IStatus<V1alpha1StorageFolderStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StorageFolder";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagefolders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageFolderSpec defines the desired state of StorageFolder</summary>
    [JsonPropertyName("spec")]
    public V1alpha1StorageFolderSpec Spec { get; set; }

    /// <summary>StorageFolderStatus defines the config connector machine state of StorageFolder</summary>
    [JsonPropertyName("status")]
    public V1alpha1StorageFolderStatus? Status { get; set; }
}

/// <summary>StorageFolder is the Schema for the StorageFolder API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StorageFolderList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1StorageFolder>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StorageFolderList";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagefolders";
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
    public IList<V1alpha1StorageFolder> Items { get; set; }
}