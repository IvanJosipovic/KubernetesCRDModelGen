using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Immutable. Primary disk for asynchronous disk replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecAsyncPrimaryDiskDiskRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeDisk` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. A nested object resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecAsyncPrimaryDisk
{
    /// <summary>Immutable. Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1ComputeDiskSpecAsyncPrimaryDiskDiskRef DiskRef { get; set; }
}

/// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyKmsKeyRef
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

/// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyKmsKeyServiceAccountRef
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

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRawKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRawKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRawKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRawKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRawKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Immutable. Encrypts the disk using a customer-supplied encryption key.  After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine).  Customer-supplied encryption keys do not protect access to metadata of the disk.  If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecDiskEncryptionKey
{
    /// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }

    /// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRawKey? RawKey { get; set; }

    /// <summary>Immutable. Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey.</summary>
    [JsonPropertyName("rsaEncryptedKey")]
    public V1beta1ComputeDiskSpecDiskEncryptionKeyRsaEncryptedKey? RsaEncryptedKey { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecGuestOsFeatures
{
    /// <summary>Immutable. The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: ["MULTI_IP_SUBNET", "SECURE_BOOT", "SEV_CAPABLE", "UEFI_COMPATIBLE", "VIRTIO_SCSI_MULTIQUEUE", "WINDOWS", "GVNIC", "SEV_LIVE_MIGRATABLE", "SEV_SNP_CAPABLE", "SUSPEND_RESUME_COMPATIBLE", "TDX_CAPABLE"].</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The image from which to initialize this disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecImageRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeImage` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecProjectRef
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

/// <summary>Resource policies applied to this disk for automatic snapshot creations. This field only applies for zonal compute disk resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecResourcePolicies
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeResourcePolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The source snapshot used to create this disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSnapshotRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSnapshot` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The source disk used to create this disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceDiskRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeDisk` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceImageEncryptionKeyKmsKeyRef
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

/// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceImageEncryptionKeyKmsKeyServiceAccountRef
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

/// <summary>Immutable. The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceImageEncryptionKey
{
    /// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeDiskSpecSourceImageEncryptionKeyKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeDiskSpecSourceImageEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }

    /// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

/// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceSnapshotEncryptionKeyKmsKeyRef
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

/// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceSnapshotEncryptionKeyKmsKeyServiceAccountRef
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

/// <summary>Immutable. The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpecSourceSnapshotEncryptionKey
{
    /// <summary>The encryption key used to encrypt the disk. Your project's Compute Engine System service account ('service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature. See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeDiskSpecSourceSnapshotEncryptionKeyKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The service account used for the encryption request for the given KMS key. If absent, the Compute Engine Service Agent service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeDiskSpecSourceSnapshotEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }

    /// <summary>Immutable. Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskSpec
{
    /// <summary>Immutable. A nested object resource.</summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta1ComputeDiskSpecAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Encrypts the disk using a customer-supplied encryption key.  After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine).  Customer-supplied encryption keys do not protect access to metadata of the disk.  If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1ComputeDiskSpecDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Immutable. Whether this disk is using confidential compute mode. Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }

    /// <summary>Immutable. A list of features to enable on the guest operating system. Applicable only for bootable disks.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1ComputeDiskSpecGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>The image from which to initialize this disk.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1ComputeDiskSpecImageRef? ImageRef { get; set; }

    /// <summary>DEPRECATED. `interface` is deprecated. This field is no longer used and can be safely removed from your configurations; disk interfaces are automatically determined on attachment. Immutable. Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Immutable. Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>Location represents the geographical location of the ComputeDisk. Specify a region name or a zone name. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Indicates whether or not the disk can be read/write attached to more than one instance.</summary>
    [JsonPropertyName("multiWriter")]
    public bool? MultiWriter { get; set; }

    /// <summary>Immutable. Physical block size of the persistent disk, in bytes. If not present in a request, a default value is used. Currently supported sizes are 4096 and 16384, other sizes may be added in the future. If an unsupported value is requested, the error message will list the supported values for the caller's project.</summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public int? PhysicalBlockSizeBytes { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ComputeDiskSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Indicates how many IOPS must be provisioned for the disk. Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedIops")]
    public int? ProvisionedIops { get; set; }

    /// <summary>Indicates how much Throughput must be provisioned for the disk. Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk allows for an update of Throughput every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public int? ProvisionedThroughput { get; set; }

    /// <summary>Immutable. URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<V1beta1ComputeDiskSpecResourcePolicies>? ResourcePolicies { get; set; }

    /// <summary>Size of the persistent disk, specified in GB. You can specify this field when creating a persistent disk using the 'image' or 'snapshot' parameter, or specify it alone to create an empty persistent disk.  If you specify this field along with 'image' or 'snapshot', the value must not be less than the size of the image or the size of the snapshot.  Upsizing the disk is mutable, but downsizing the disk requires re-creating the resource.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>The source snapshot used to create this disk.</summary>
    [JsonPropertyName("snapshotRef")]
    public V1beta1ComputeDiskSpecSnapshotRef? SnapshotRef { get; set; }

    /// <summary>The source disk used to create this disk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ComputeDiskSpecSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Immutable. The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1ComputeDiskSpecSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Immutable. The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1ComputeDiskSpecSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>Immutable. URL of the disk type resource describing which disk type to use to create the disk. Provide this when creating the disk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeDiskStatusConditions
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
public partial class V1beta1ComputeDiskStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeDiskStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Last attach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastAttachTimestamp")]
    public string? LastAttachTimestamp { get; set; }

    /// <summary>Last detach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastDetachTimestamp")]
    public string? LastDetachTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The ID value of the disk used to create this image. This value may be used to determine whether the image was taken from the current or a previous instance of a given disk name.</summary>
    [JsonPropertyName("sourceDiskId")]
    public string? SourceDiskId { get; set; }

    /// <summary>The ID value of the image used to create this disk. This value identifies the exact image that was used to create this persistent disk. For example, if you created the persistent disk from an image that was later deleted and recreated under the same name, the source image ID would identify the exact version of the image that was used.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>The unique ID of the snapshot used to create this disk. This value identifies the exact snapshot that was used to create this persistent disk. For example, if you created the persistent disk from a snapshot that was later deleted and recreated under the same name, the source snapshot ID would identify the exact version of the snapshot that was used.</summary>
    [JsonPropertyName("sourceSnapshotId")]
    public string? SourceSnapshotId { get; set; }

    /// <summary>Links to the users of the disk (attached instances) in form: project/zones/zone/instances/instance.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeDisk : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeDiskSpec>, IStatus<V1beta1ComputeDiskStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeDisk";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computedisks";
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
    public V1beta1ComputeDiskSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeDiskStatus? Status { get; set; }
}