using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyKmsKeyServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKeyValueFrom? ValueFrom { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSnapshotEncryptionKey
{
    /// <summary>The encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }

    /// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKeyRawKey? RawKey { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyKmsKeyServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKeyValueFrom? ValueFrom { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskEncryptionKey
{
    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }

    /// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public V1beta1ComputeSnapshotSpecSourceDiskEncryptionKeyRawKey? RawKey { get; set; }
}

public partial class V1beta1ComputeSnapshotSpecSourceDiskRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeDisk` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeSnapshotSpec
{
    /// <summary>Immutable. Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035. This is an uncommon option only for advanced service owners who needs to create separate snapshot chains, for example, for chargeback tracking.  When you describe your snapshot resource, this field is visible only if it has a non-empty value.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Encrypts the snapshot using a customer-supplied encryption key.  After you encrypt a snapshot using a customer-supplied key, you must provide the same key if you use the snapshot later. For example, you must provide the encryption key when you create a disk from the encrypted snapshot in a future request.  Customer-supplied encryption keys do not protect access to metadata of the snapshot.  If you do not provide an encryption key when creating the snapshot, then the snapshot will be encrypted using an automatically generated key and you do not need to provide a key to use the snapshot later.</summary>
    [JsonPropertyName("snapshotEncryptionKey")]
    public V1beta1ComputeSnapshotSpecSnapshotEncryptionKey? SnapshotEncryptionKey { get; set; }

    /// <summary>Immutable. The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta1ComputeSnapshotSpecSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>A reference to the disk used to create this snapshot.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ComputeSnapshotSpecSourceDiskRef SourceDiskRef { get; set; }

    /// <summary>Immutable. Cloud Storage bucket storage location of the snapshot (regional or multi-regional).</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>Immutable. A reference to the zone where the disk is hosted.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1ComputeSnapshotStatusConditions
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

public partial class V1beta1ComputeSnapshotStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Size of the snapshot, specified in GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource. Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>A list of public visible licenses that apply to this snapshot. This can be because the original image had licenses attached (such as a Windows image).  snapshotEncryptionKey nested object Encrypts the snapshot using a customer-supplied encryption key.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("snapshotId")]
    public int? SnapshotId { get; set; }

    /// <summary>A size of the storage used by the snapshot. As snapshots share storage, this number is expected to change with snapshot creation/deletion.</summary>
    [JsonPropertyName("storageBytes")]
    public int? StorageBytes { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSnapshotSpec>, IStatus<V1beta1ComputeSnapshotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSnapshot";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesnapshots";
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
    public V1beta1ComputeSnapshotSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSnapshotStatus? Status { get; set; }
}