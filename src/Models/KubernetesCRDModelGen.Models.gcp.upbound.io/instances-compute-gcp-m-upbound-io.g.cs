using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
#nullable enable
/// <summary>Instance is the Schema for the Instances API. Manages a VM instance resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Instance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "instances";
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
    public IList<V1beta1Instance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization  enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAttachedDiskDiskEncryptionKeyRawSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAttachedDiskDiskEncryptionKeyRsaSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAttachedDisk
{
    /// <summary>Name with which the attached disk will be accessible under /dev/disk/by-id/google-*</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRawSecretRef")]
    public V1beta1InstanceSpecForProviderAttachedDiskDiskEncryptionKeyRawSecretRef? DiskEncryptionKeyRawSecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRsaSecretRef")]
    public V1beta1InstanceSpecForProviderAttachedDiskDiskEncryptionKeyRsaSecretRef? DiskEncryptionKeyRsaSecretRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>Either "READ_ONLY" or "READ_WRITE", defaults to "READ_WRITE" If you have a persistent disk with data that you want to share between multiple instances, detach it from any read-write instances and attach it to one or more instances in read-only mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the disk to attach to this instance.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskDiskEncryptionKeyRawSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskDiskEncryptionKeyRsaSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageRefPolicy
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
/// <summary>Reference to a Image in compute to populate image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageSelectorPolicy
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
/// <summary>Selector for a Image in compute to populate image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageSelector
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
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDiskInitializeParams
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether this disk is using confidential compute mode. Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. If referred by family, the images names must include the family name. If they don't, use the google_compute_image data source. For instance, the image centos-6-v20180104 includes its family name centos-6. These images can be referred by family name here.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Reference to a Image in compute to populate image.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageRef? ImageRef { get; set; }

    /// <summary>Selector for a Image in compute to populate image.</summary>
    [JsonPropertyName("imageSelector")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsImageSelector? ImageSelector { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>Indicates how much throughput to provision for the disk. This sets the number of throughput mb per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of throughput every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The snapshot from which to initialize this disk. To create a disk with a snapshot that you created, specify the snapshot name in the following format: global/snapshots/my-backup</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The URL or the name of the storage pool in which the new disk is created. For example:</summary>
    [JsonPropertyName("storagePool")]
    public string? StoragePool { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The boot disk for the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderBootDisk
{
    /// <summary>Whether the disk will be auto-deleted when the instance is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRawSecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskDiskEncryptionKeyRawSecretRef? DiskEncryptionKeyRawSecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw</summary>
    [JsonPropertyName("diskEncryptionKeyRsaSecretRef")]
    public V1beta1InstanceSpecForProviderBootDiskDiskEncryptionKeyRsaSecretRef? DiskEncryptionKeyRsaSecretRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public V1beta1InstanceSpecForProviderBootDiskInitializeParams? InitializeParams { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the existing disk (such as those managed by google_compute_disk) or disk image. To create an instance from a snapshot, first create a google_compute_disk from a snapshot and reference it here.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt the data on this instance.</summary>
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
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceAccessConfig
{
    /// <summary>If the instance has an access config, either the given external ip (in the nat_ip field) or the ephemeral (generated) ip (if you didn't provide one).</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. This range may be a single IP address (e.g. 10.2.3.4), a netmask (e.g. /24) or a CIDR format string (e.g. 10.1.2.0/24).</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. To use a static external IP address, it must be unused and in the same region as the instance's zone. If not specified, Google Cloud will automatically assign an external IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary>The prefix length of the external IPv6 range.</summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>A unique name for the resource, required by GCE. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkRefPolicy
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
/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkSelectorPolicy
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
/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkSelector
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
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkRefPolicy
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
/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy
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
/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet. Omit to ensure that the instance is not accessible from the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceSpecForProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceSpecForProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceSpecForProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, IDPF, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>The name or self_link of the subnetwork to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork. The subnetwork must exist in the same region this instance will be created in. If the network resource is in legacy mode, do not specify this field. If the network is in auto subnet mode, specifying the subnetwork is optional. If the network is in custom subnet mode, specifying the subnetwork is required.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The project in which the subnetwork belongs. If the subnetwork is a self_link, this field is set to the project defined in the subnetwork self_link. If the subnetwork is a name and this field is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional instance parameters. .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderParams
{
    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceSpecForProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderScheduling
{
    /// <summary>Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user). Defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public V1beta1InstanceSpecForProviderSchedulingLocalSsdRecoveryTimeout? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceSpecForProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary>The minimum number of virtual CPUs this instance will consume when running on a sole-tenant node.</summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceSpecForProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Describes maintenance behavior for the instance. Can be MIGRATE or TERMINATE, for more info, read here.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceSpecForProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Specifies if the instance is preemptible. If this field is set to true, then automatic_restart must be set to false.  Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderScratchDisk
{
    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderServiceAccountEmailRefPolicy
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
/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderServiceAccountEmailSelectorPolicy
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
/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderServiceAccountEmailSelector
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
    public V1beta1InstanceSpecForProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderServiceAccount
{
    /// <summary>The service account e-mail address. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta1InstanceSpecForProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta1InstanceSpecForProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceSpecForProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>If you try to update a property that requires stopping the instance without setting this field, the update will fail.</summary>
    [JsonPropertyName("allowStoppingForUpdate")]
    public bool? AllowStoppingForUpdate { get; set; }

    /// <summary>Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("attachedDisk")]
    public IList<V1beta1InstanceSpecForProviderAttachedDisk>? AttachedDisk { get; set; }

    /// <summary>The boot disk for the instance. Structure is documented below.</summary>
    [JsonPropertyName("bootDisk")]
    public V1beta1InstanceSpecForProviderBootDisk? BootDisk { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceSpecForProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Enable deletion protection on this instance. Defaults to false. Note: you must disable deletion protection before removing the resource (e.g.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired status of the instance. Either "RUNNING", "SUSPENDED" or "TERMINATED".</summary>
    [JsonPropertyName("desiredStatus")]
    public string? DesiredStatus { get; set; }

    /// <summary>Enable Virtual Displays on this instance. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableDisplay")]
    public bool? EnableDisplay { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: GPU accelerators can only be used with on_host_maintenance option set to TERMINATE. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceSpecForProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
    [JsonPropertyName("instanceEncryptionKey")]
    public V1beta1InstanceSpecForProviderInstanceEncryptionKey? InstanceEncryptionKey { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within the instance. Ssh keys attached in the Cloud Console will be removed. Add them to your config in order to keep them attached to your instance. A list of predefined metadata keys (e.g. ssh-keys) can be found here</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, except this one forces the instance to be recreated (thus re-running the script) if it is changed. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.  Users are free to use either mechanism - the only distinction is that this separate attribute will cause a recreate on modification.  On import, metadata_startup_script will not be set - if you choose to specify it you will see a diff immediately after import causing a destroy/recreate operation.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Networks to attach to the instance. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceSpecForProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Additional instance parameters. .</summary>
    [JsonPropertyName("params")]
    public V1beta1InstanceSpecForProviderParams? Params { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceSpecForProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceSpecForProviderScheduling? Scheduling { get; set; }

    /// <summary>Scratch disks to attach to the instance. This can be specified multiple times for multiple scratch disks. Structure is documented below.</summary>
    [JsonPropertyName("scratchDisk")]
    public IList<V1beta1InstanceSpecForProviderScratchDisk>? ScratchDisk { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceSpecForProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceSpecForProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>A list of network tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone that the machine should be created in. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization  enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAttachedDiskDiskEncryptionKeyRawSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAttachedDiskDiskEncryptionKeyRsaSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAttachedDisk
{
    /// <summary>Name with which the attached disk will be accessible under /dev/disk/by-id/google-*</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRawSecretRef")]
    public V1beta1InstanceSpecInitProviderAttachedDiskDiskEncryptionKeyRawSecretRef? DiskEncryptionKeyRawSecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRsaSecretRef")]
    public V1beta1InstanceSpecInitProviderAttachedDiskDiskEncryptionKeyRsaSecretRef? DiskEncryptionKeyRsaSecretRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>Either "READ_ONLY" or "READ_WRITE", defaults to "READ_WRITE" If you have a persistent disk with data that you want to share between multiple instances, detach it from any read-write instances and attach it to one or more instances in read-only mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the disk to attach to this instance.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskDiskEncryptionKeyRawSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskDiskEncryptionKeyRsaSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageRefPolicy
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
/// <summary>Reference to a Image in compute to populate image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageSelectorPolicy
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
/// <summary>Selector for a Image in compute to populate image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageSelector
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
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDiskInitializeParams
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether this disk is using confidential compute mode. Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. If referred by family, the images names must include the family name. If they don't, use the google_compute_image data source. For instance, the image centos-6-v20180104 includes its family name centos-6. These images can be referred by family name here.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Reference to a Image in compute to populate image.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageRef? ImageRef { get; set; }

    /// <summary>Selector for a Image in compute to populate image.</summary>
    [JsonPropertyName("imageSelector")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsImageSelector? ImageSelector { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>Indicates how much throughput to provision for the disk. This sets the number of throughput mb per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of throughput every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The snapshot from which to initialize this disk. To create a disk with a snapshot that you created, specify the snapshot name in the following format: global/snapshots/my-backup</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The URL or the name of the storage pool in which the new disk is created. For example:</summary>
    [JsonPropertyName("storagePool")]
    public string? StoragePool { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The boot disk for the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderBootDisk
{
    /// <summary>Whether the disk will be auto-deleted when the instance is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRawSecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskDiskEncryptionKeyRawSecretRef? DiskEncryptionKeyRawSecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw</summary>
    [JsonPropertyName("diskEncryptionKeyRsaSecretRef")]
    public V1beta1InstanceSpecInitProviderBootDiskDiskEncryptionKeyRsaSecretRef? DiskEncryptionKeyRsaSecretRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public V1beta1InstanceSpecInitProviderBootDiskInitializeParams? InitializeParams { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the existing disk (such as those managed by google_compute_disk) or disk image. To create an instance from a snapshot, first create a google_compute_disk from a snapshot and reference it here.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt the data on this instance.</summary>
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
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceAccessConfig
{
    /// <summary>If the instance has an access config, either the given external ip (in the nat_ip field) or the ephemeral (generated) ip (if you didn't provide one).</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. This range may be a single IP address (e.g. 10.2.3.4), a netmask (e.g. /24) or a CIDR format string (e.g. 10.1.2.0/24).</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. To use a static external IP address, it must be unused and in the same region as the instance's zone. If not specified, Google Cloud will automatically assign an external IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary>The prefix length of the external IPv6 range.</summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>A unique name for the resource, required by GCE. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkRefPolicy
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
/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkSelectorPolicy
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
/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkSelector
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
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkRefPolicy
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
/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy
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
/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet. Omit to ensure that the instance is not accessible from the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceSpecInitProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceSpecInitProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceSpecInitProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, IDPF, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>The name or self_link of the subnetwork to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork. The subnetwork must exist in the same region this instance will be created in. If the network resource is in legacy mode, do not specify this field. If the network is in auto subnet mode, specifying the subnetwork is optional. If the network is in custom subnet mode, specifying the subnetwork is required.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The project in which the subnetwork belongs. If the subnetwork is a self_link, this field is set to the project defined in the subnetwork self_link. If the subnetwork is a name and this field is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional instance parameters. .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderParams
{
    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceSpecInitProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderScheduling
{
    /// <summary>Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user). Defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public V1beta1InstanceSpecInitProviderSchedulingLocalSsdRecoveryTimeout? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceSpecInitProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary>The minimum number of virtual CPUs this instance will consume when running on a sole-tenant node.</summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceSpecInitProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Describes maintenance behavior for the instance. Can be MIGRATE or TERMINATE, for more info, read here.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceSpecInitProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Specifies if the instance is preemptible. If this field is set to true, then automatic_restart must be set to false.  Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderScratchDisk
{
    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderServiceAccountEmailRefPolicy
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
/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderServiceAccountEmailSelectorPolicy
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
/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderServiceAccountEmailSelector
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
    public V1beta1InstanceSpecInitProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderServiceAccount
{
    /// <summary>The service account e-mail address. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta1InstanceSpecInitProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta1InstanceSpecInitProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceSpecInitProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>If you try to update a property that requires stopping the instance without setting this field, the update will fail.</summary>
    [JsonPropertyName("allowStoppingForUpdate")]
    public bool? AllowStoppingForUpdate { get; set; }

    /// <summary>Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("attachedDisk")]
    public IList<V1beta1InstanceSpecInitProviderAttachedDisk>? AttachedDisk { get; set; }

    /// <summary>The boot disk for the instance. Structure is documented below.</summary>
    [JsonPropertyName("bootDisk")]
    public V1beta1InstanceSpecInitProviderBootDisk? BootDisk { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceSpecInitProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Enable deletion protection on this instance. Defaults to false. Note: you must disable deletion protection before removing the resource (e.g.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired status of the instance. Either "RUNNING", "SUSPENDED" or "TERMINATED".</summary>
    [JsonPropertyName("desiredStatus")]
    public string? DesiredStatus { get; set; }

    /// <summary>Enable Virtual Displays on this instance. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableDisplay")]
    public bool? EnableDisplay { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: GPU accelerators can only be used with on_host_maintenance option set to TERMINATE. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceSpecInitProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
    [JsonPropertyName("instanceEncryptionKey")]
    public V1beta1InstanceSpecInitProviderInstanceEncryptionKey? InstanceEncryptionKey { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within the instance. Ssh keys attached in the Cloud Console will be removed. Add them to your config in order to keep them attached to your instance. A list of predefined metadata keys (e.g. ssh-keys) can be found here</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, except this one forces the instance to be recreated (thus re-running the script) if it is changed. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.  Users are free to use either mechanism - the only distinction is that this separate attribute will cause a recreate on modification.  On import, metadata_startup_script will not be set - if you choose to specify it you will see a diff immediately after import causing a destroy/recreate operation.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Networks to attach to the instance. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceSpecInitProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Additional instance parameters. .</summary>
    [JsonPropertyName("params")]
    public V1beta1InstanceSpecInitProviderParams? Params { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceSpecInitProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceSpecInitProviderScheduling? Scheduling { get; set; }

    /// <summary>Scratch disks to attach to the instance. This can be specified multiple times for multiple scratch disks. Structure is documented below.</summary>
    [JsonPropertyName("scratchDisk")]
    public IList<V1beta1InstanceSpecInitProviderScratchDisk>? ScratchDisk { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceSpecInitProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceSpecInitProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>A list of network tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization  enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAttachedDisk
{
    /// <summary>Name with which the attached disk will be accessible under /dev/disk/by-id/google-*</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) that protects this resource.</summary>
    [JsonPropertyName("diskEncryptionKeySha256")]
    public string? DiskEncryptionKeySha256 { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>Either "READ_ONLY" or "READ_WRITE", defaults to "READ_WRITE" If you have a persistent disk with data that you want to share between multiple instances, detach it from any read-write instances and attach it to one or more instances in read-only mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the disk to attach to this instance.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderBootDiskInitializeParamsSourceImageEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to decrypt the given image. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderBootDiskInitializeParams
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether this disk is using confidential compute mode. Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. If referred by family, the images names must include the family name. If they don't, use the google_compute_image data source. For instance, the image centos-6-v20180104 includes its family name centos-6. These images can be referred by family name here.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>Indicates how much throughput to provision for the disk. This sets the number of throughput mb per second that the disk can handle. For more details,see the Hyperdisk documentation. Note: Updating currently is only supported for hyperdisk skus via disk update api/gcloud without the need to delete and recreate the disk, hyperdisk allows for an update of throughput every 4 hours. To update your hyperdisk more frequently, you'll need to manually delete and recreate it.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The snapshot from which to initialize this disk. To create a disk with a snapshot that you created, specify the snapshot name in the following format: global/snapshots/my-backup</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Encryption key used to decrypt the given image. Structure is documented below.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceStatusAtProviderBootDiskInitializeParamsSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Encryption key used to decrypt the given snapshot. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceStatusAtProviderBootDiskInitializeParamsSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The URL or the name of the storage pool in which the new disk is created. For example:</summary>
    [JsonPropertyName("storagePool")]
    public string? StoragePool { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The boot disk for the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderBootDisk
{
    /// <summary>Whether the disk will be auto-deleted when the instance is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) that protects this resource.</summary>
    [JsonPropertyName("diskEncryptionKeySha256")]
    public string? DiskEncryptionKeySha256 { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("diskEncryptionServiceAccount")]
    public string? DiskEncryptionServiceAccount { get; set; }

    /// <summary>boolean field that determines whether to force attach the regional disk even if it's currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.</summary>
    [JsonPropertyName("forceAttach")]
    public bool? ForceAttach { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Parameters for a new disk that will be created alongside the new instance. Either initialize_params or source must be set. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public V1beta1InstanceStatusAtProviderBootDiskInitializeParams? InitializeParams { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name or self_link of the existing disk (such as those managed by google_compute_disk) or disk image. To create an instance from a snapshot, first create a google_compute_disk from a snapshot and reference it here.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderInstanceEncryptionKey
{
    /// <summary>The self_link of the encryption key that is stored in Google Cloud KMS to encrypt the data on this instance.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkInterfaceAccessConfig
{
    /// <summary>If the instance has an access config, either the given external ip (in the nat_ip field) or the ephemeral (generated) ip (if you didn't provide one).</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. This range may be a single IP address (e.g. 10.2.3.4), a netmask (e.g. /24) or a CIDR format string (e.g. 10.1.2.0/24).</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. To use a static external IP address, it must be unused and in the same region as the instance's zone. If not specified, Google Cloud will automatically assign an external IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary>The prefix length of the external IPv6 range.</summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>A unique name for the resource, required by GCE. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges..</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet. Omit to ensure that the instance is not accessible from the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceStatusAtProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceStatusAtProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceStatusAtProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary>One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>A unique name for the resource, required by GCE. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, IDPF, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>The name or self_link of the subnetwork to attach this interface to. Either network or subnetwork must be provided. If network isn't provided it will be inferred from the subnetwork. The subnetwork must exist in the same region this instance will be created in. If the network resource is in legacy mode, do not specify this field. If the network is in auto subnet mode, specifying the subnetwork is optional. If the network is in custom subnet mode, specifying the subnetwork is required.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The project in which the subnetwork belongs. If the subnetwork is a self_link, this field is set to the project defined in the subnetwork self_link. If the subnetwork is a name and this field is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }
}
#nullable disable

#nullable enable
/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional instance parameters. .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderParams
{
    /// <summary>A tag is a key-value pair that can be attached to a Google Cloud resource. You can use tags to conditionally allow or deny policies based on whether a resource has a specific tag. This value is not returned by the API.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceStatusAtProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderScheduling
{
    /// <summary>Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user). Defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public V1beta1InstanceStatusAtProviderSchedulingLocalSsdRecoveryTimeout? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceStatusAtProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary>The minimum number of virtual CPUs this instance will consume when running on a sole-tenant node.</summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceStatusAtProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Describes maintenance behavior for the instance. Can be MIGRATE or TERMINATE, for more info, read here.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceStatusAtProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Specifies if the instance is preemptible. If this field is set to true, then automatic_restart must be set to false.  Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderScratchDisk
{
    /// <summary>Name with which attached disk will be accessible. On the instance, this device will be /dev/disk/by-id/google-{{device_name}}.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The disk interface to use for attaching this disk; either SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderServiceAccount
{
    /// <summary>The service account e-mail address. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading  on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceStatusAtProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>If you try to update a property that requires stopping the instance without setting this field, the update will fail.</summary>
    [JsonPropertyName("allowStoppingForUpdate")]
    public bool? AllowStoppingForUpdate { get; set; }

    /// <summary>Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("attachedDisk")]
    public IList<V1beta1InstanceStatusAtProviderAttachedDisk>? AttachedDisk { get; set; }

    /// <summary>The boot disk for the instance. Structure is documented below.</summary>
    [JsonPropertyName("bootDisk")]
    public V1beta1InstanceStatusAtProviderBootDisk? BootDisk { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceStatusAtProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>The CPU platform used by this instance.</summary>
    [JsonPropertyName("cpuPlatform")]
    public string? CpuPlatform { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The current status of the instance. This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED. For more information about the status of the instance, see Instance life cycle.</summary>
    [JsonPropertyName("currentStatus")]
    public string? CurrentStatus { get; set; }

    /// <summary>Enable deletion protection on this instance. Defaults to false. Note: you must disable deletion protection before removing the resource (e.g.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired status of the instance. Either "RUNNING", "SUSPENDED" or "TERMINATED".</summary>
    [JsonPropertyName("desiredStatus")]
    public string? DesiredStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Enable Virtual Displays on this instance. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("enableDisplay")]
    public bool? EnableDisplay { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: GPU accelerators can only be used with on_host_maintenance option set to TERMINATE. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceStatusAtProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for data encryption on the instance with encryption keys. Structure is documented below.</summary>
    [JsonPropertyName("instanceEncryptionKey")]
    public V1beta1InstanceStatusAtProviderInstanceEncryptionKey? InstanceEncryptionKey { get; set; }

    /// <summary>The server-assigned unique identifier of this instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>The unique fingerprint of the labels.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>A map of key/value label pairs to assign to the instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field 'effective_labels' for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within the instance. Ssh keys attached in the Cloud Console will be removed. Add them to your config in order to keep them attached to your instance. A list of predefined metadata keys (e.g. ssh-keys) can be found here</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The unique fingerprint of the metadata.</summary>
    [JsonPropertyName("metadataFingerprint")]
    public string? MetadataFingerprint { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, except this one forces the instance to be recreated (thus re-running the script) if it is changed. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.  Users are free to use either mechanism - the only distinction is that this separate attribute will cause a recreate on modification.  On import, metadata_startup_script will not be set - if you choose to specify it you will see a diff immediately after import causing a destroy/recreate operation.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Networks to attach to the instance. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceStatusAtProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Additional instance parameters. .</summary>
    [JsonPropertyName("params")]
    public V1beta1InstanceStatusAtProviderParams? Params { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceStatusAtProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceStatusAtProviderScheduling? Scheduling { get; set; }

    /// <summary>Scratch disks to attach to the instance. This can be specified multiple times for multiple scratch disks. Structure is documented below.</summary>
    [JsonPropertyName("scratchDisk")]
    public IList<V1beta1InstanceStatusAtProviderScratchDisk>? ScratchDisk { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceStatusAtProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here. Note: allow_stopping_for_update must be set to true or your instance must have a desired_status of TERMINATED in order to update this field.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceStatusAtProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>A list of network tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The unique fingerprint of the tags.</summary>
    [JsonPropertyName("tagsFingerprint")]
    public string? TagsFingerprint { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The zone that the machine should be created in. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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
/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Instance is the Schema for the Instances API. Manages a VM instance resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}
#nullable disable
