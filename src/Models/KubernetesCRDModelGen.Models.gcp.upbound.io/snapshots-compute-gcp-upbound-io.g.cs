using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
#nullable enable
/// <summary>Snapshot is the Schema for the Snapshots API. Represents a Persistent Disk Snapshot resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Snapshot>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "snapshots";
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
    public IList<V1beta1Snapshot> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an encryption key stored in Google Cloud KMS, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSnapshotEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1SnapshotSpecForProviderSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an encryption key stored in Google Cloud KMS, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1SnapshotSpecForProviderSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1SnapshotSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1SnapshotSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecForProviderSourceDiskRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecForProviderSourceDiskSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProvider
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035. This is an uncommon option only for advanced service owners who needs to create separate snapshot chains, for example, for chargeback tracking.  When you describe your snapshot resource, this field is visible only if it has a non-empty value.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Labels to apply to this Snapshot. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Encrypts the snapshot using a customer-supplied encryption key. After you encrypt a snapshot using a customer-supplied key, you must provide the same key if you use the snapshot later. For example, you must provide the encryption key when you create a disk from the encrypted snapshot in a future request. Customer-supplied encryption keys do not protect access to metadata of the snapshot. If you do not provide an encryption key when creating the snapshot, then the snapshot will be encrypted using an automatically generated key and you do not need to provide a key to use the snapshot later. Structure is documented below.</summary>
    [JsonPropertyName("snapshotEncryptionKey")]
    public IList<V1beta1SnapshotSpecForProviderSnapshotEncryptionKey>? SnapshotEncryptionKey { get; set; }

    /// <summary>A reference to the disk used to create this snapshot.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public IList<V1beta1SnapshotSpecForProviderSourceDiskEncryptionKey>? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1SnapshotSpecForProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta1SnapshotSpecForProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>Cloud Storage bucket storage location of the snapshot (regional or multi-regional).</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>A reference to the zone where the disk is hosted.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an encryption key stored in Google Cloud KMS, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSnapshotEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1SnapshotSpecInitProviderSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an encryption key stored in Google Cloud KMS, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1SnapshotSpecInitProviderSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecInitProviderSourceDiskRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecInitProviderSourceDiskSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProvider
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035. This is an uncommon option only for advanced service owners who needs to create separate snapshot chains, for example, for chargeback tracking.  When you describe your snapshot resource, this field is visible only if it has a non-empty value.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Labels to apply to this Snapshot. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Encrypts the snapshot using a customer-supplied encryption key. After you encrypt a snapshot using a customer-supplied key, you must provide the same key if you use the snapshot later. For example, you must provide the encryption key when you create a disk from the encrypted snapshot in a future request. Customer-supplied encryption keys do not protect access to metadata of the snapshot. If you do not provide an encryption key when creating the snapshot, then the snapshot will be encrypted using an automatically generated key and you do not need to provide a key to use the snapshot later. Structure is documented below.</summary>
    [JsonPropertyName("snapshotEncryptionKey")]
    public IList<V1beta1SnapshotSpecInitProviderSnapshotEncryptionKey>? SnapshotEncryptionKey { get; set; }

    /// <summary>A reference to the disk used to create this snapshot.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public IList<V1beta1SnapshotSpecInitProviderSourceDiskEncryptionKey>? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1SnapshotSpecInitProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta1SnapshotSpecInitProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>Cloud Storage bucket storage location of the snapshot (regional or multi-regional).</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>A reference to the zone where the disk is hosted.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SnapshotSpec defines the desired state of Snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SnapshotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SnapshotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SnapshotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SnapshotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProviderSnapshotEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>(Output) The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProvider
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035. This is an uncommon option only for advanced service owners who needs to create separate snapshot chains, for example, for chargeback tracking.  When you describe your snapshot resource, this field is visible only if it has a non-empty value.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the snapshot, specified in GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/snapshots/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource. Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this Snapshot. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A list of public visible licenses that apply to this snapshot. This can be because the original image had licenses attached (such as a Windows image).  snapshotEncryptionKey nested object Encrypts the snapshot using a customer-supplied encryption key.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Encrypts the snapshot using a customer-supplied encryption key. After you encrypt a snapshot using a customer-supplied key, you must provide the same key if you use the snapshot later. For example, you must provide the encryption key when you create a disk from the encrypted snapshot in a future request. Customer-supplied encryption keys do not protect access to metadata of the snapshot. If you do not provide an encryption key when creating the snapshot, then the snapshot will be encrypted using an automatically generated key and you do not need to provide a key to use the snapshot later. Structure is documented below.</summary>
    [JsonPropertyName("snapshotEncryptionKey")]
    public IList<V1beta1SnapshotStatusAtProviderSnapshotEncryptionKey>? SnapshotEncryptionKey { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("snapshotId")]
    public double? SnapshotId { get; set; }

    /// <summary>A reference to the disk used to create this snapshot.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public IList<V1beta1SnapshotStatusAtProviderSourceDiskEncryptionKey>? SourceDiskEncryptionKey { get; set; }

    /// <summary>A size of the storage used by the snapshot. As snapshots share storage, this number is expected to change with snapshot creation/deletion.</summary>
    [JsonPropertyName("storageBytes")]
    public double? StorageBytes { get; set; }

    /// <summary>Cloud Storage bucket storage location of the snapshot (regional or multi-regional).</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>A reference to the zone where the disk is hosted.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SnapshotStatus defines the observed state of Snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SnapshotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Snapshot is the Schema for the Snapshots API. Represents a Persistent Disk Snapshot resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SnapshotSpec>, IStatus<V1beta1SnapshotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "snapshots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SnapshotSpec defines the desired state of Snapshot</summary>
    [JsonPropertyName("spec")]
    public V1beta1SnapshotSpec Spec { get; set; }

    /// <summary>SnapshotStatus defines the observed state of Snapshot.</summary>
    [JsonPropertyName("status")]
    public V1beta1SnapshotStatus? Status { get; set; }
}
#nullable disable
