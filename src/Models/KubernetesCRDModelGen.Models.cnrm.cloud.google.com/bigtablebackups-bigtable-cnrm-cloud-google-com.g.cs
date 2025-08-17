using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
#nullable enable
/// <summary>BigtableBackup is the Schema for the BigtableBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableBackupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigtableBackup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableBackupList";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtablebackups";
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
    public IList<V1alpha1BigtableBackup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterRef defines the resource reference to BigtableCluster, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupSpecClusterRef
{
    /// <summary>A reference to an externally managed BigtableCluster resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupSpecSourceTableRef
{
    /// <summary>A reference to an externally managed BigtableTable resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableBackupSpec defines the desired state of BigtableBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupSpec
{
    /// <summary>Indicates the backup type of the backup.</summary>
    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    /// <summary>ClusterRef defines the resource reference to BigtableCluster, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1BigtableBackupSpecClusterRef ClusterRef { get; set; }

    /// <summary>Required. The expiration time of the backup.  When creating a backup or updating its `expire_time`, the value must be  greater than the backup creation time by:  - At least 6 hours  - At most 90 days   Once the `expire_time` has passed, Cloud Bigtable will delete the backup.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The time at which the hot backup will be converted to a standard backup.  Once the `hot_to_standard_time` has passed, Cloud Bigtable will convert the  hot backup to a standard backup. This value must be greater than the backup  creation time by:  - At least 24 hours   This field only applies for hot backups. When creating or updating a  standard backup, attempting to set this field will fail the request.</summary>
    [JsonPropertyName("hotToStandardTime")]
    public string? HotToStandardTime { get; set; }

    /// <summary>The BigtableBackup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.</summary>
    [JsonPropertyName("sourceTableRef")]
    public V1alpha1BigtableBackupSpecSourceTableRef? SourceTableRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatusObservedStateEncryptionInfoEncryptionStatusDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized  protocol buffer message. This string must contain at least  one "/" character. The last segment of the URL's path must represent  the fully qualified name of the type (as in  `path/google.protobuf.Duration`). The name should be in a canonical form  (e.g., leading "." is not accepted).   In practice, teams usually precompile into the binary all types that they  expect it to use in the context of Any. However, for URLs which use the  scheme `http`, `https`, or no scheme, one can optionally set up a type  server that maps type URLs to message definitions as follows:   * If no scheme is provided, `https` is assumed.  * An HTTP GET on the URL must yield a [google.protobuf.Type][]    value in binary format, or produce an error.  * Applications are allowed to cache lookup results based on the    URL, or have them precompiled into a binary to avoid any    lookup. Therefore, binary compatibility needs to be preserved    on changes to types. (Use versioned type names to manage    breaking changes.)   Note: this functionality is not currently available in the official  protobuf release, and it is not used for type URLs beginning with  type.googleapis.com.   Schemes other than `http`, `https` (or the empty scheme) might be  used with implementation specific semantics.</summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The status of encrypt/decrypt calls on underlying data for this resource. Regardless of status, the existing data is always encrypted at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatusObservedStateEncryptionInfoEncryptionStatus
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1BigtableBackupStatusObservedStateEncryptionInfoEncryptionStatusDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The encryption information for the backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatusObservedStateEncryptionInfo
{
    /// <summary>Output only. The status of encrypt/decrypt calls on underlying data for this resource. Regardless of status, the existing data is always encrypted at rest.</summary>
    [JsonPropertyName("encryptionStatus")]
    public V1alpha1BigtableBackupStatusObservedStateEncryptionInfoEncryptionStatus? EncryptionStatus { get; set; }

    /// <summary>Output only. The type of encryption used to protect this resource.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. The version of the Cloud KMS key specified in the parent cluster that is in use for the data underlying this table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatusObservedState
{
    /// <summary>Output only. The encryption information for the backup.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1alpha1BigtableBackupStatusObservedStateEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Output only. `end_time` is the time that the backup was finished. The row data in the backup will be no newer than this timestamp.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. Size of the backup in bytes.</summary>
    [JsonPropertyName("sizeBytes")]
    public long? SizeBytes { get; set; }

    /// <summary>Output only. Name of the backup from which this backup was copied. If a backup is not created by copying a backup, this field will be empty. Values are of the form: projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/backups/&lt;backup&gt;</summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }

    /// <summary>Output only. `start_time` is the time that the backup was started (i.e. approximately the time the [CreateBackup][google.bigtable.admin.v2.BigtableTableAdmin.CreateBackup] request is received).  The row data in this backup will be no older than this timestamp.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. The current state of the backup.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableBackupStatus defines the config connector machine state of BigtableBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableBackupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigtableBackupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigtableBackup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigtableBackupStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableBackup is the Schema for the BigtableBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigtableBackupSpec>, IStatus<V1alpha1BigtableBackupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableBackup";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtablebackups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableBackupSpec defines the desired state of BigtableBackup</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigtableBackupSpec Spec { get; set; }

    /// <summary>BigtableBackupStatus defines the config connector machine state of BigtableBackup</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigtableBackupStatus? Status { get; set; }
}
#nullable disable
