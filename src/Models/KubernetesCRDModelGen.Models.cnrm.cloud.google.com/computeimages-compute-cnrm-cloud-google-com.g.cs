using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeImageSpecDiskRef
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

public partial class V1beta1ComputeImageSpecGuestOsFeatures
{
    /// <summary>Immutable. The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: ["MULTI_IP_SUBNET", "SECURE_BOOT", "SEV_CAPABLE", "UEFI_COMPATIBLE", "VIRTIO_SCSI_MULTIQUEUE", "WINDOWS", "GVNIC", "SEV_LIVE_MIGRATABLE", "SEV_SNP_CAPABLE", "SUSPEND_RESUME_COMPATIBLE", "TDX_CAPABLE"].</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1beta1ComputeImageSpecImageEncryptionKeyKmsKeySelfLinkRef
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

public partial class V1beta1ComputeImageSpecImageEncryptionKeyKmsKeyServiceAccountRef
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

public partial class V1beta1ComputeImageSpecImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLinkRef")]
    public V1beta1ComputeImageSpecImageEncryptionKeyKmsKeySelfLinkRef? KmsKeySelfLinkRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeImageSpecImageEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }
}

public partial class V1beta1ComputeImageSpecRawDisk
{
    /// <summary>Immutable. The format used to encode and transmit the block device, which should be TAR. This is just a container and transmission format and not a runtime format. Provided by the client when the disk image is created. Default value: "TAR" Possible values: ["TAR"].</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>Immutable. An optional SHA1 checksum of the disk image before unpackaging. This is provided by the client when the disk image is created.</summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>Immutable. The full Google Cloud Storage URL where disk storage is stored You must provide either this property or the sourceDisk property but not both.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

public partial class V1beta1ComputeImageSpecSourceImageRef
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

public partial class V1beta1ComputeImageSpecSourceSnapshotRef
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

public partial class V1beta1ComputeImageSpec
{
    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The source disk to create this image based on. You must provide either this property or the rawDisk.source property but not both to create an image.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1ComputeImageSpecDiskRef? DiskRef { get; set; }

    /// <summary>Immutable. Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>Immutable. The name of the image family to which this image belongs. You can create disks by specifying an image family instead of a specific image name. The image family always returns its latest image that is not deprecated. The name of the image family must comply with RFC1035.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Immutable. A list of features to enable on the guest operating system. Applicable only for bootable images.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta1ComputeImageSpecGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Immutable. Encrypts the image using a customer-supplied encryption key.  After you encrypt an image with a customer-supplied key, you must provide the same key if you use the image later (e.g. to create a disk from the image).</summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta1ComputeImageSpecImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>Immutable. Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>Immutable. The parameters of the raw disk image.</summary>
    [JsonPropertyName("rawDisk")]
    public V1beta1ComputeImageSpecRawDisk? RawDisk { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The source image used to create this image.</summary>
    [JsonPropertyName("sourceImageRef")]
    public V1beta1ComputeImageSpecSourceImageRef? SourceImageRef { get; set; }

    /// <summary>The source snapshot used to create this image.</summary>
    [JsonPropertyName("sourceSnapshotRef")]
    public V1beta1ComputeImageSpecSourceSnapshotRef? SourceSnapshotRef { get; set; }

    /// <summary>Immutable. Cloud Storage bucket storage location of the image (regional or multi-regional). Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images.</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

public partial class V1beta1ComputeImageStatusConditions
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

public partial class V1beta1ComputeImageStatus
{
    /// <summary>Size of the image tar.gz archive stored in Google Cloud Storage (in bytes).</summary>
    [JsonPropertyName("archiveSizeBytes")]
    public int? ArchiveSizeBytes { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeImageStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource. Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeImageSpec>, IStatus<V1beta1ComputeImageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeImage";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeimages";
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
    public V1beta1ComputeImageSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeImageStatus? Status { get; set; }
}