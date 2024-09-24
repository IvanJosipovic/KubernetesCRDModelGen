using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
public partial class V1alpha1AlloyDBBackupSpecClusterNameRef
{
    /// <summary>Allowed value: The `name` field of an `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1AlloyDBBackupSpecEncryptionConfig
{
    /// <summary>Immutable. The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public partial class V1alpha1AlloyDBBackupSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1AlloyDBBackupSpec
{
    /// <summary>The full resource name of the backup source cluster (e.g., projects/{project}/locations/{location}/clusters/{clusterId}).</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1alpha1AlloyDBBackupSpecClusterNameRef ClusterNameRef { get; set; }

    /// <summary>Immutable. User-provided description of the backup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1AlloyDBBackupSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Immutable. The location where the alloydb backup should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AlloyDBBackupSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The backupId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1AlloyDBBackupStatusConditions
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

public partial class V1alpha1AlloyDBBackupStatusEncryptionInfo
{
    /// <summary>Output only. Type of encryption.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. Cloud KMS key versions that are being used to protect the database or the backup.</summary>
    [JsonPropertyName("kmsKeyVersions")]
    public IList<string>? KmsKeyVersions { get; set; }
}

public partial class V1alpha1AlloyDBBackupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AlloyDBBackupStatusConditions>? Conditions { get; set; }

    /// <summary>Time the Backup was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>EncryptionInfo describes the encryption information of a cluster or a backup.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1alpha1AlloyDBBackupStatusEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>A hash of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The name of the backup resource with the format: * projects/{project}/locations/{region}/backups/{backupId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>If true, indicates that the service is actively updating the resource. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the backup.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and it is retained until it is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Time the Backup was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AlloyDBBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AlloyDBBackupSpec>, IStatus<V1alpha1AlloyDBBackupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AlloyDBBackup";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbbackups";
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
    public V1alpha1AlloyDBBackupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AlloyDBBackupStatus? Status { get; set; }
}