using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notebooks.cnrm.cloud.google.com;
/// <summary>NotebookInstance is the Schema for the NotebookInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotebookInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NotebookInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotebookInstanceList";
    public const string KubeGroup = "notebooks.cnrm.cloud.google.com";
    public const string KubePluralName = "notebookinstances";
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
    public IList<V1beta1NotebookInstance> Items { get; set; }
}

/// <summary>The hardware accelerator used on this instance. If you use accelerators, make sure that your configuration has [enough vCPUs and memory to support the `machine_type` you have selected](https://cloud.google.com/compute/docs/gpus/#gpus-list).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecAcceleratorConfig
{
    /// <summary>Count of cores of this accelerator.</summary>
    [JsonPropertyName("coreCount")]
    public long? CoreCount { get; set; }

    /// <summary>Type of this accelerator.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Use a container image to start the notebook instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecContainerImage
{
    /// <summary>Required. The path to the container image repository. For example: `gcr.io/{project_id}/{image_name}`</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Input only. The KMS key used to encrypt the disks, only applicable if disk_encryption is CMEK. Learn more about [using your own encryption keys](/kms/docs/quickstart).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the VPC that this instance is in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The optional reservation affinity. Setting this field will apply the specified [Zonal Compute Reservation](https://cloud.google.com/compute/docs/instances/reserving-zonal-resources) to this notebook instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecReservationAffinity
{
    /// <summary>Optional. Type of reservation to consume</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Optional. Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Optional. Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The service account on this instance, giving access to other Google  Cloud services.  You can use any service account within the same project, but you  must have the service account user permission to use the instance.   If not specified, the [Compute Engine default service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Shielded VM configuration. [Images using supported Shielded VM features](https://cloud.google.com/compute/docs/instances/modifying-shielded-vm).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has integrity monitoring enabled.   Enables monitoring and attestation of the boot integrity of the instance.  The attestation is performed against the integrity policy baseline. This  baseline is initially derived from the implicitly trusted boot image when  the instance is created. Enabled by default.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether the instance has Secure Boot enabled.   Secure Boot helps ensure that the system only runs authentic software by  verifying the digital signature of all boot components, and halting the  boot process if signature verification fails. Disabled by default.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}

/// <summary>The name of the subnet that this instance is in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecSubnetRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecUpgradeHistory
{
    /// <summary>Action. Rolloback or Upgrade.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The container image before this instance upgrade.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>The time that this instance upgrade history entry is created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The framework of this notebook instance.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>The snapshot of the boot disk of this notebook instance before upgrade.</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>The state of this instance upgrade history entry.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Target VM Image. Format: `ainotebooks-vm/project/image-name/name`.</summary>
    [JsonPropertyName("targetImage")]
    public string? TargetImage { get; set; }

    /// <summary>Target VM Version, like m63.</summary>
    [JsonPropertyName("targetVersion")]
    public string? TargetVersion { get; set; }

    /// <summary>The version of the notebook instance before this upgrade.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The VM image before this instance upgrade.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }
}

/// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpecVmImage
{
    /// <summary>Use this VM image family to find the image; the newest image in this family will be used.</summary>
    [JsonPropertyName("imageFamily")]
    public string? ImageFamily { get; set; }

    /// <summary>Use VM image name to find the image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Required. The name of the Google Cloud project that this VM image belongs to. Format: `{project_id}`</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>NotebookInstanceSpec defines the desired state of NotebookInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceSpec
{
    /// <summary>The hardware accelerator used on this instance. If you use accelerators, make sure that your configuration has [enough vCPUs and memory to support the `machine_type` you have selected](https://cloud.google.com/compute/docs/gpus/#gpus-list).</summary>
    [JsonPropertyName("acceleratorConfig")]
    public V1beta1NotebookInstanceSpecAcceleratorConfig? AcceleratorConfig { get; set; }

    /// <summary>Input only. The size of the boot disk in GB attached to this instance, up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB. If not specified, this defaults to 100.</summary>
    [JsonPropertyName("bootDiskSizeGB")]
    public long? BootDiskSizeGB { get; set; }

    /// <summary>Input only. The type of the boot disk attached to this instance, defaults to standard persistent disk (`PD_STANDARD`).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Flag to enable ip forwarding or not, default false/off. https://cloud.google.com/vpc/docs/using-routes#canipforward</summary>
    [JsonPropertyName("canIPForward")]
    public bool? CanIPForward { get; set; }

    /// <summary>Use a container image to start the notebook instance.</summary>
    [JsonPropertyName("containerImage")]
    public V1beta1NotebookInstanceSpecContainerImage? ContainerImage { get; set; }

    /// <summary>Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically choose from official GPU drivers.</summary>
    [JsonPropertyName("customGpuDriverPath")]
    public string? CustomGpuDriverPath { get; set; }

    /// <summary>Input only. The size of the data disk in GB attached to this instance, up to a maximum of 64000 GB (64 TB). You can choose the size of the data disk based on how big your notebooks and data are. If not specified, this defaults to 100.</summary>
    [JsonPropertyName("dataDiskSizeGB")]
    public long? DataDiskSizeGB { get; set; }

    /// <summary>Input only. The type of the data disk attached to this instance, defaults to standard persistent disk (`PD_STANDARD`).</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Input only. Disk encryption method used on the boot and data disks, defaults to GMEK.</summary>
    [JsonPropertyName("diskEncryption")]
    public string? DiskEncryption { get; set; }

    /// <summary>Whether the end user authorizes Google Cloud to install GPU driver on this instance. If this field is empty or set to false, the GPU driver won't be installed. Only applicable to instances with GPUs.</summary>
    [JsonPropertyName("installGpuDriver")]
    public bool? InstallGpuDriver { get; set; }

    /// <summary>Input only. The owner of this instance after creation. Format: `alias@example.com`   Currently supports one owner only. If not specified, all of the service  account users of your VM instance's service account can use  the instance.</summary>
    [JsonPropertyName("instanceOwners")]
    public IList<string>? InstanceOwners { get; set; }

    /// <summary>Input only. The KMS key used to encrypt the disks, only applicable if disk_encryption is CMEK. Learn more about [using your own encryption keys](/kms/docs/quickstart).</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1NotebookInstanceSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Labels to apply to this instance. These can be later modified by the setLabels method.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The [Compute Engine machine type](https://cloud.google.com/compute/docs/machine-types) of this instance.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Custom metadata to apply to this instance.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the VPC that this instance is in.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1NotebookInstanceSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>If true, the notebook instance will not register with the proxy.</summary>
    [JsonPropertyName("noProxyAccess")]
    public bool? NoProxyAccess { get; set; }

    /// <summary>If true, no public IP will be assigned to this instance.</summary>
    [JsonPropertyName("noPublicIP")]
    public bool? NoPublicIP { get; set; }

    /// <summary>Input only. If true, the data disk will not be auto deleted when deleting the instance.</summary>
    [JsonPropertyName("noRemoveDataDisk")]
    public bool? NoRemoveDataDisk { get; set; }

    /// <summary>Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path (`gs://path-to-file/file-name`).</summary>
    [JsonPropertyName("postStartupScript")]
    public string? PostStartupScript { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1NotebookInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. The optional reservation affinity. Setting this field will apply the specified [Zonal Compute Reservation](https://cloud.google.com/compute/docs/instances/reserving-zonal-resources) to this notebook instance.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1NotebookInstanceSpecReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The NotebookInstance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The service account on this instance, giving access to other Google  Cloud services.  You can use any service account within the same project, but you  must have the service account user permission to use the instance.   If not specified, the [Compute Engine default service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1NotebookInstanceSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. The URIs of service account scopes to be included in  Compute Engine instances.   If not specified, the following  [scopes](https://cloud.google.com/compute/docs/access/service-accounts#accesscopesiam)  are defined:   - https://www.googleapis.com/auth/cloud-platform   - https://www.googleapis.com/auth/userinfo.email  If not using default scopes, you need at least:     https://www.googleapis.com/auth/compute</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Optional. Shielded VM configuration. [Images using supported Shielded VM features](https://cloud.google.com/compute/docs/instances/modifying-shielded-vm).</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1NotebookInstanceSpecShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>The name of the subnet that this instance is in.</summary>
    [JsonPropertyName("subnetRef")]
    public V1beta1NotebookInstanceSpecSubnetRef? SubnetRef { get; set; }

    /// <summary>Optional. The Compute Engine tags to add to runtime (see [Tagging instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The upgrade history of this instance.</summary>
    [JsonPropertyName("upgradeHistory")]
    public IList<V1beta1NotebookInstanceSpecUpgradeHistory>? UpgradeHistory { get; set; }

    /// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
    [JsonPropertyName("vmImage")]
    public V1beta1NotebookInstanceSpecVmImage? VmImage { get; set; }

    /// <summary>Immutable. The location where the notebook instance should reside.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceStatusConditions
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
public partial class V1beta1NotebookInstanceStatusObservedStateDisksGuestOSFeatures
{
    /// <summary>The ID of a supported feature. Read  Enabling guest operating system  features to see a list of available options.  Valid values:   * `FEATURE_TYPE_UNSPECIFIED`  * `MULTI_IP_SUBNET`  * `SECURE_BOOT`  * `UEFI_COMPATIBLE`  * `VIRTIO_SCSI_MULTIQUEUE`  * `WINDOWS`</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceStatusObservedStateDisks
{
    /// <summary>Indicates whether the disk will be auto-deleted when the instance is deleted (but not when the disk is detached from the instance).</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk. The virtual machine will use the first partition of the disk for its root filesystem.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>Indicates a unique device name of your choice that is reflected into the  `/dev/disk/by-id/google-*` tree of a Linux operating system running  within the instance. This name can be used to reference the device for  mounting, resizing, and so on, from within the instance.   If not specified, the server chooses a default device name to apply to  this disk, in the form persistent-disk-x, where x is a number assigned by  Google Compute Engine.This field is only applicable for persistent disks.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Indicates the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGB")]
    public long? DiskSizeGB { get; set; }

    /// <summary>Indicates a list of features to enable on the guest operating system. Applicable only for bootable images. Read  Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOSFeatures")]
    public IList<V1beta1NotebookInstanceStatusObservedStateDisksGuestOSFeatures>? GuestOSFeatures { get; set; }

    /// <summary>A zero-based index to this disk, where 0 is reserved for the boot disk. If you have many disks attached to an instance, each disk would have a unique index number.</summary>
    [JsonPropertyName("index")]
    public long? Index { get; set; }

    /// <summary>Indicates the disk interface to use for attaching this disk, which is  either SCSI or NVME. The default is SCSI. Persistent disks must always  use SCSI and the request will fail if you attempt to attach a persistent  disk in any other format than SCSI. Local SSDs can use either NVME or  SCSI. For performance characteristics of SCSI over NVMe, see Local SSD  performance.  Valid values:   * `NVME`  * `SCSI`</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Type of the resource. Always compute#attachedDisk for attached disks.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>A list of publicly visible licenses. Reserved for Google's use. A License represents billing and aggregate usage data for public and marketplace images.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The mode in which to attach this disk, either `READ_WRITE` or  `READ_ONLY`. If not specified, the default is to attach the disk in  `READ_WRITE` mode. Valid values:   * `READ_ONLY`  * `READ_WRITE`</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Indicates a valid partial or full URL to an existing Persistent Disk resource.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Indicates the type of the disk, either `SCRATCH` or `PERSISTENT`.  Valid values:   * `PERSISTENT`  * `SCRATCH`</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceStatusObservedState
{
    /// <summary>Output only. Instance creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Email address of entity that sent original CreateInstance request.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. Attached disks to notebook instance.</summary>
    [JsonPropertyName("disks")]
    public IList<V1beta1NotebookInstanceStatusObservedStateDisks>? Disks { get; set; }

    /// <summary>Output only. The proxy endpoint that is used to access the Jupyter notebook.</summary>
    [JsonPropertyName("proxyURI")]
    public string? ProxyURI { get; set; }

    /// <summary>Output only. The state of this instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Instance update time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NotebookInstanceStatus defines the config connector machine state of NotebookInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotebookInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NotebookInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NotebookInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1NotebookInstanceStatusObservedState? ObservedState { get; set; }
}

/// <summary>NotebookInstance is the Schema for the NotebookInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotebookInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NotebookInstanceSpec>, IStatus<V1beta1NotebookInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotebookInstance";
    public const string KubeGroup = "notebooks.cnrm.cloud.google.com";
    public const string KubePluralName = "notebookinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotebookInstanceSpec defines the desired state of NotebookInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1NotebookInstanceSpec Spec { get; set; }

    /// <summary>NotebookInstanceStatus defines the config connector machine state of NotebookInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1NotebookInstanceStatus? Status { get; set; }
}