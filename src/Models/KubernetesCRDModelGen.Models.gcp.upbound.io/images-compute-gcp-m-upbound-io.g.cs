using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecForProviderImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecForProviderImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderRawDisk
{
    /// <summary>The format used to encode and transmit the block device, which should be TAR. This is just a container and transmission format and not a runtime format. Provided by the client when the disk image is created. Default value is TAR. Possible values are: TAR.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>An optional SHA1 checksum of the disk image before unpackaging. This is provided by the client when the disk image is created.</summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>The full Google Cloud Storage URL where disk storage is stored You must provide either this property or the sourceDisk property but not both.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderShieldedInstanceInitialStateDbs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderShieldedInstanceInitialStateKeks
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>The Platform Key (PK). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderShieldedInstanceInitialStatePk
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderShieldedInstanceInitialState
{
    /// <summary>The Key Database (db). Structure is documented below.</summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta1ImageSpecForProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>The forbidden key database (dbx). Structure is documented below.</summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta1ImageSpecForProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>The Key Exchange Key (KEK). Structure is documented below.</summary>
    [JsonPropertyName("keks")]
    public IList<V1beta1ImageSpecForProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>The Platform Key (PK). Structure is documented below.</summary>
    [JsonPropertyName("pk")]
    public V1beta1ImageSpecForProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecForProviderSourceDiskRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecForProviderSourceDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecForProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The name of the image family to which this image belongs. You can create disks by specifying an image family instead of a specific image name. The image family always returns its latest image that is not deprecated. The name of the image family must comply with RFC1035.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1ImageSpecForProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta1ImageSpecForProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>Labels to apply to this Image. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
    [JsonPropertyName("rawDisk")]
    public V1beta1ImageSpecForProviderRawDisk? RawDisk { get; set; }

    /// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta1ImageSpecForProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>The source disk to create this image based on. You must provide either this property or the rawDisk.source property but not both to create an image.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta1ImageSpecForProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ImageSpecForProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta1ImageSpecForProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>URL of the source image used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1ImageSpecForProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>URL of the source snapshot used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1ImageSpecForProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>Cloud Storage bucket storage location of the image (regional or multi-regional). Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecInitProviderImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecInitProviderImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderRawDisk
{
    /// <summary>The format used to encode and transmit the block device, which should be TAR. This is just a container and transmission format and not a runtime format. Provided by the client when the disk image is created. Default value is TAR. Possible values are: TAR.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>An optional SHA1 checksum of the disk image before unpackaging. This is provided by the client when the disk image is created.</summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>The full Google Cloud Storage URL where disk storage is stored You must provide either this property or the sourceDisk property but not both.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderShieldedInstanceInitialStateDbs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderShieldedInstanceInitialStateKeks
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>The Platform Key (PK). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderShieldedInstanceInitialStatePk
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderShieldedInstanceInitialState
{
    /// <summary>The Key Database (db). Structure is documented below.</summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta1ImageSpecInitProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>The forbidden key database (dbx). Structure is documented below.</summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta1ImageSpecInitProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>The Key Exchange Key (KEK). Structure is documented below.</summary>
    [JsonPropertyName("keks")]
    public IList<V1beta1ImageSpecInitProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>The Platform Key (PK). Structure is documented below.</summary>
    [JsonPropertyName("pk")]
    public V1beta1ImageSpecInitProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecInitProviderSourceDiskRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecInitProviderSourceDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The name of the image family to which this image belongs. You can create disks by specifying an image family instead of a specific image name. The image family always returns its latest image that is not deprecated. The name of the image family must comply with RFC1035.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1ImageSpecInitProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta1ImageSpecInitProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>Labels to apply to this Image. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
    [JsonPropertyName("rawDisk")]
    public V1beta1ImageSpecInitProviderRawDisk? RawDisk { get; set; }

    /// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta1ImageSpecInitProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>The source disk to create this image based on. You must provide either this property or the rawDisk.source property but not both to create an image.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta1ImageSpecInitProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ImageSpecInitProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta1ImageSpecInitProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>URL of the source image used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1ImageSpecInitProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>URL of the source snapshot used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1ImageSpecInitProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>Cloud Storage bucket storage location of the image (regional or multi-regional). Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ImageSpec defines the desired state of Image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ImageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ImageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ImageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ImageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderRawDisk
{
    /// <summary>The format used to encode and transmit the block device, which should be TAR. This is just a container and transmission format and not a runtime format. Provided by the client when the disk image is created. Default value is TAR. Possible values are: TAR.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>An optional SHA1 checksum of the disk image before unpackaging. This is provided by the client when the disk image is created.</summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>The full Google Cloud Storage URL where disk storage is stored You must provide either this property or the sourceDisk property but not both.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderShieldedInstanceInitialStateDbs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderShieldedInstanceInitialStateKeks
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>The Platform Key (PK). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderShieldedInstanceInitialStatePk
{
    /// <summary>The raw content in the secure keys file. A base64-encoded string.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderShieldedInstanceInitialState
{
    /// <summary>The Key Database (db). Structure is documented below.</summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta1ImageStatusAtProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>The forbidden key database (dbx). Structure is documented below.</summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta1ImageStatusAtProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>The Key Exchange Key (KEK). Structure is documented below.</summary>
    [JsonPropertyName("keks")]
    public IList<V1beta1ImageStatusAtProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>The Platform Key (PK). Structure is documented below.</summary>
    [JsonPropertyName("pk")]
    public V1beta1ImageStatusAtProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderSourceDiskEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key used to decrypt this resource. Also called KmsKeyName in the cloud console. Your project's Compute Engine System service account (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProvider
{
    /// <summary>Size of the image tar.gz archive stored in Google Cloud Storage (in bytes).</summary>
    [JsonPropertyName("archiveSizeBytes")]
    public double? ArchiveSizeBytes { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The name of the image family to which this image belongs. You can create disks by specifying an image family instead of a specific image name. The image family always returns its latest image that is not deprecated. The name of the image family must comply with RFC1035.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1ImageStatusAtProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/images/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Encrypts the image using a customer-supplied encryption key. After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image) Structure is documented below.</summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta1ImageStatusAtProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource. Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this Image. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The parameters of the raw disk image. Structure is documented below.</summary>
    [JsonPropertyName("rawDisk")]
    public V1beta1ImageStatusAtProviderRawDisk? RawDisk { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Set the secure boot keys of shielded instance. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta1ImageStatusAtProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>The source disk to create this image based on. You must provide either this property or the rawDisk.source property but not both to create an image.</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source disk. Required if the source disk is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta1ImageStatusAtProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>URL of the source image used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1ImageStatusAtProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>URL of the source snapshot used to create this image. In order to create an image, you must provide the full or partial URL of one of the following:</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1ImageStatusAtProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>Cloud Storage bucket storage location of the image (regional or multi-regional). Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusConditions
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

/// <summary>ImageStatus defines the observed state of Image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ImageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ImageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Image is the Schema for the Images API. Represents an Image resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Image : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImageSpec>, IStatus<V1beta1ImageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Image";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "images";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageSpec defines the desired state of Image</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImageSpec Spec { get; set; }

    /// <summary>ImageStatus defines the observed state of Image.</summary>
    [JsonPropertyName("status")]
    public V1beta1ImageStatus? Status { get; set; }
}

/// <summary>Image is the Schema for the Images API. Represents an Image resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Image>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "images";
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
    public IList<V1beta1Image> Items { get; set; }
}