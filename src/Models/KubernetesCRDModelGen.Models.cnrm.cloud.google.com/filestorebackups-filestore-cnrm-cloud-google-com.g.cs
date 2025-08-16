using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.filestore.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FilestoreBackupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FilestoreBackup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FilestoreBackupList";
    public const string KubeGroup = "filestore.cnrm.cloud.google.com";
    public const string KubePluralName = "filestorebackups";
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
    public IList<V1beta1FilestoreBackup> Items { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilestoreBackupSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilestoreBackupSpecSourceInstanceRef
{
    /// <summary>The resource name of the source Cloud Filestore instance, in the format projects/{project_number}/locations/{location_id}/instances/{instance_id}, used to create this backup.  Allowed value: The Google Cloud resource name of a `FilestoreInstance` resource (format: `projects/{{project}}/locations/{{location}}/instances/{{name}}`).</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilestoreBackupSpec
{
    /// <summary>A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1FilestoreBackupSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Name of the file share in the source Cloud Filestore instance that the backup is created from.</summary>
    [JsonPropertyName("sourceFileShare")]
    public string SourceFileShare { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("sourceInstanceRef")]
    public V1beta1FilestoreBackupSpecSourceInstanceRef SourceInstanceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilestoreBackupStatusConditions
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
public partial class V1beta1FilestoreBackupStatus
{
    /// <summary>Output only. Capacity of the source file share when the backup was created.</summary>
    [JsonPropertyName("capacityGb")]
    public long? CapacityGb { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FilestoreBackupStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when the backup was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Amount of bytes that will be downloaded if the backup is restored. This may be different than storage bytes, since sequential backups of the same disk will share storage.</summary>
    [JsonPropertyName("downloadBytes")]
    public long? DownloadBytes { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The service tier of the source Cloud Filestore instance that this backup is created from. Possible values: TIER_UNSPECIFIED, STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD</summary>
    [JsonPropertyName("sourceInstanceTier")]
    public string? SourceInstanceTier { get; set; }

    /// <summary>Output only. The backup state. Possible values: STATE_UNSPECIFIED, CREATING, READY, REPAIRING, DELETING, ERROR, RESTORING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The size of the storage used by the backup. As backups share storage, this number is expected to change with backup creation/deletion.</summary>
    [JsonPropertyName("storageBytes")]
    public long? StorageBytes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FilestoreBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FilestoreBackupSpec>, IStatus<V1beta1FilestoreBackupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FilestoreBackup";
    public const string KubeGroup = "filestore.cnrm.cloud.google.com";
    public const string KubePluralName = "filestorebackups";
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
    public V1beta1FilestoreBackupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1FilestoreBackupStatus? Status { get; set; }
}