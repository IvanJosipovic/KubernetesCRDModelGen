using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>RegionDisk is the Schema for the RegionDisks API. Persistent disks are durable storage devices that function similarly to the physical disks in a desktop or a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionDiskList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionDisk>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionDiskList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regiondisks";
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
    public IList<V1beta1RegionDisk> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelector
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
    public V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>A nested object resource. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelector? DiskSelector { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderDiskEncryptionKeyRawKeySecretRef
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
public partial class V1beta1RegionDiskSpecForProviderDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1RegionDiskSpecForProviderDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1RegionDiskSpecForProviderDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderSnapshotRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderSnapshotRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskSpecForProviderSnapshotRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderSnapshotSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderSnapshotSelector
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
    public V1beta1RegionDiskSpecForProviderSnapshotSelectorPolicy? Policy { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProviderSourceSnapshotEncryptionKey
{
    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecForProvider
{
    /// <summary>The access mode of the disk. For example:</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>A nested object resource. Structure is documented below.</summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta1RegionDiskSpecForProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>If set to true, a snapshot of the disk will be created before it is destroyed. If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation. The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm</summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that's created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1RegionDiskSpecForProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable disks. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1RegionDiskSpecForProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>Physical block size of the persistent disk, in bytes. If not present in a request, a default value is used. Currently supported sizes are 4096 and 16384, other sizes may be added in the future. If an unsupported value is requested, the error message will list the supported values for the caller's project.</summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>Size of the persistent disk, specified in GB. You can specify this field when creating a persistent disk using the sourceImage or sourceSnapshot parameter, or specify it alone to create an empty persistent disk. If you specify this field along with sourceImage or sourceSnapshot, the value of sizeGb must not be less than the size of the sourceImage or the size of the snapshot.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The source snapshot used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotRef")]
    public V1beta1RegionDiskSpecForProviderSnapshotRef? SnapshotRef { get; set; }

    /// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotSelector")]
    public V1beta1RegionDiskSpecForProviderSnapshotSelector? SnapshotSelector { get; set; }

    /// <summary>The source disk used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1RegionDiskSpecForProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>URL of the disk type resource describing which disk type to use to create the disk. Provide this when creating the disk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelector
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
    public V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>A nested object resource. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelector? DiskSelector { get; set; }
}

/// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderDiskEncryptionKeyRawKeySecretRef
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
public partial class V1beta1RegionDiskSpecInitProviderDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1RegionDiskSpecInitProviderDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. You can provide either the rawKey or the rsaEncryptedKey. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1RegionDiskSpecInitProviderDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderSnapshotRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderSnapshotRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskSpecInitProviderSnapshotRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderSnapshotSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderSnapshotSelector
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
    public V1beta1RegionDiskSpecInitProviderSnapshotSelectorPolicy? Policy { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProviderSourceSnapshotEncryptionKey
{
    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecInitProvider
{
    /// <summary>The access mode of the disk. For example:</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>A nested object resource. Structure is documented below.</summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta1RegionDiskSpecInitProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>If set to true, a snapshot of the disk will be created before it is destroyed. If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation. The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm</summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that's created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1RegionDiskSpecInitProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable disks. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1RegionDiskSpecInitProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>Physical block size of the persistent disk, in bytes. If not present in a request, a default value is used. Currently supported sizes are 4096 and 16384, other sizes may be added in the future. If an unsupported value is requested, the error message will list the supported values for the caller's project.</summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>Size of the persistent disk, specified in GB. You can specify this field when creating a persistent disk using the sourceImage or sourceSnapshot parameter, or specify it alone to create an empty persistent disk. If you specify this field along with sourceImage or sourceSnapshot, the value of sizeGb must not be less than the size of the sourceImage or the size of the snapshot.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The source snapshot used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotRef")]
    public V1beta1RegionDiskSpecInitProviderSnapshotRef? SnapshotRef { get; set; }

    /// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotSelector")]
    public V1beta1RegionDiskSpecInitProviderSnapshotSelector? SnapshotSelector { get; set; }

    /// <summary>The source disk used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1RegionDiskSpecInitProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>URL of the disk type resource describing which disk type to use to create the disk. Provide this when creating the disk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpecProviderConfigRef
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
public partial class V1beta1RegionDiskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RegionDiskSpec defines the desired state of RegionDisk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionDiskSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionDiskSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionDiskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionDiskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A nested object resource. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusAtProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }
}

/// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusAtProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Output) The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusAtProviderGuestOsFeatures
{
    /// <summary>The type of supported feature. Read Enabling guest operating system features to see a list of available options. Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusAtProviderSourceSnapshotEncryptionKey
{
    /// <summary>Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.</summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }

    /// <summary>(Output) The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusAtProvider
{
    /// <summary>The access mode of the disk. For example:</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>A nested object resource. Structure is documented below.</summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta1RegionDiskStatusAtProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>If set to true, a snapshot of the disk will be created before it is destroyed. If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation. The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm</summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that's created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encrypts the disk using a customer-supplied encryption key. After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot or an image, or to attach the disk to a virtual machine). Customer-supplied encryption keys do not protect access to metadata of the disk. If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later. Structure is documented below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1RegionDiskStatusAtProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("diskId")]
    public string? DiskId { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable disks. Structure is documented below.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1RegionDiskStatusAtProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/disks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Last attach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastAttachTimestamp")]
    public string? LastAttachTimestamp { get; set; }

    /// <summary>Last detach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastDetachTimestamp")]
    public string? LastDetachTimestamp { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>Physical block size of the persistent disk, in bytes. If not present in a request, a default value is used. Currently supported sizes are 4096 and 16384, other sizes may be added in the future. If an unsupported value is requested, the error message will list the supported values for the caller's project.</summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Size of the persistent disk, specified in GB. You can specify this field when creating a persistent disk using the sourceImage or sourceSnapshot parameter, or specify it alone to create an empty persistent disk. If you specify this field along with sourceImage or sourceSnapshot, the value of sizeGb must not be less than the size of the sourceImage or the size of the snapshot.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The source snapshot used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>The source disk used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>The ID value of the disk used to create this image. This value may be used to determine whether the image was taken from the current or a previous instance of a given disk name.</summary>
    [JsonPropertyName("sourceDiskId")]
    public string? SourceDiskId { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key. Structure is documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1RegionDiskStatusAtProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The unique ID of the snapshot used to create this disk. This value identifies the exact snapshot that was used to create this persistent disk. For example, if you created the persistent disk from a snapshot that was later deleted and recreated under the same name, the source snapshot ID would identify the exact version of the snapshot that was used.</summary>
    [JsonPropertyName("sourceSnapshotId")]
    public string? SourceSnapshotId { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>URL of the disk type resource describing which disk type to use to create the disk. Provide this when creating the disk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Links to the users of the disk (attached instances) in form: project/zones/zone/instances/instance</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatusConditions
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

/// <summary>RegionDiskStatus defines the observed state of RegionDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionDiskStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionDiskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionDiskStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionDisk is the Schema for the RegionDisks API. Persistent disks are durable storage devices that function similarly to the physical disks in a desktop or a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionDisk : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionDiskSpec>, IStatus<V1beta1RegionDiskStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionDisk";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regiondisks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionDiskSpec defines the desired state of RegionDisk</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionDiskSpec Spec { get; set; }

    /// <summary>RegionDiskStatus defines the observed state of RegionDisk.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionDiskStatus? Status { get; set; }
}