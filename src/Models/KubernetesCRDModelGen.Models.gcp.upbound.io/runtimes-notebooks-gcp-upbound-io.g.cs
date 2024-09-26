using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notebooks.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderAccessConfig
{
    /// <summary>The type of access mode this instance. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/reference/ rest/v1/projects.locations.runtimes#RuntimeAccessType.</summary>
    [JsonPropertyName("accessType")]
    public string? AccessType { get; set; }

    /// <summary>The owner of this runtime after creation. Format: alias@example.com. Currently supports one owner only.</summary>
    [JsonPropertyName("runtimeOwner")]
    public string? RuntimeOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderSoftwareConfigKernels
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderSoftwareConfig
{
    /// <summary>Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically choose from official GPU drivers.</summary>
    [JsonPropertyName("customGpuDriverPath")]
    public string? CustomGpuDriverPath { get; set; }

    /// <summary>Verifies core internal services are running. Default: True.</summary>
    [JsonPropertyName("enableHealthMonitoring")]
    public bool? EnableHealthMonitoring { get; set; }

    /// <summary>Runtime will automatically shutdown after idle_shutdown_time. Default: True</summary>
    [JsonPropertyName("idleShutdown")]
    public bool? IdleShutdown { get; set; }

    /// <summary>Time in minutes to wait before shuting down runtime. Default: 180 minutes</summary>
    [JsonPropertyName("idleShutdownTimeout")]
    public double? IdleShutdownTimeout { get; set; }

    /// <summary>Install Nvidia Driver automatically.</summary>
    [JsonPropertyName("installGpuDriver")]
    public bool? InstallGpuDriver { get; set; }

    /// <summary>Use a list of container images to use as Kernels in the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("kernels")]
    public IList<V1beta1RuntimeSpecForProviderSoftwareConfigKernels>? Kernels { get; set; }

    /// <summary>Cron expression in UTC timezone for schedule instance auto upgrade. Please follow the cron format.</summary>
    [JsonPropertyName("notebookUpgradeSchedule")]
    public string? NotebookUpgradeSchedule { get; set; }

    /// <summary>Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path (gs://path-to-file/file-name).</summary>
    [JsonPropertyName("postStartupScript")]
    public string? PostStartupScript { get; set; }

    /// <summary>Behavior for the post startup script. Possible values are: POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED, RUN_EVERY_START, DOWNLOAD_AND_RUN_EVERY_START.</summary>
    [JsonPropertyName("postStartupScriptBehavior")]
    public string? PostStartupScriptBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigAcceleratorConfig
{
    /// <summary>Count of cores of this accelerator.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigContainerImages
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams
{
    /// <summary>Provide this property when creating the disk.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the disk name. If not specified, the default is to use the name of the instance. If the disk with the instance name exists already in the given zone/region, a new name will be automatically generated.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB. If not specified, the disk will be the same size as the image (usually 10GB). If specified, the size must be equal to or larger than 10GB. Default 100 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The type of the boot disk attached to this runtime, defaults to standard persistent disk. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/ reference/rest/v1/projects.locations.runtimes#disktype</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigDataDisk
{
    /// <summary>Input only. Specifies the parameters for a new disk that will be created alongside the new instance. Use initialization parameters to create boot disks or local SSDs attached to the new instance. This property is mutually exclusive with the source property; you can only define one or the other, but not both. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams>? InitializeParams { get; set; }

    /// <summary>"Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI. For performance characteristics of SCSI over NVMe, see Local SSD performance. Valid values: * NVME * SCSI".</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies a valid partial or full URL to an existing Persistent Disk resource.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigEncryptionConfig
{
    /// <summary>The Cloud KMS resource identifier of the customer-managed encryption key used to protect a resource, such as a disks. It has the following format: projects/{PROJECT_ID}/locations/{REGION}/keyRings/ {KEY_RING_NAME}/cryptoKeys/{KEY_NAME}</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the boot integrity of the instance. The attestation is performed against the integrity policy baseline. This baseline is initially derived from the implicitly trusted boot image when the instance is created. Enabled by default.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether the instance has Secure Boot enabled.Secure Boot helps ensure that the system only runs authentic software by verifying the digital signature of all boot components, and halting the boot process if signature verification fails. Disabled by default.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfig
{
    /// <summary>The Compute Engine accelerator configuration for this runtime. Structure is documented below.</summary>
    [JsonPropertyName("acceleratorConfig")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigAcceleratorConfig>? AcceleratorConfig { get; set; }

    /// <summary>Use a list of container images to start the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("containerImages")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigContainerImages>? ContainerImages { get; set; }

    /// <summary>Data disk option configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigDataDisk>? DataDisk { get; set; }

    /// <summary>Encryption settings for virtual machine data disk. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>If true, runtime will only have internal IP addresses. By default, runtimes are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each vm. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Compute Engine machine type used for runtimes.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine metadata entries to add to virtual machine. (see [Project and instance metadata](https://cloud.google.com /compute/docs/storing-retrieving-metadata#project_and_instance _metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork. If neither network nor subnet is specified, the "default" network of the project is used, if it exists. A full URL or partial URI. Examples:</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet. Possible values are: UNSPECIFIED_NIC_TYPE, VIRTIO_NET, GVNIC.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Reserved IP Range name is used for VPC Peering. The subnetwork allocation will use the range name if it's assigned.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Shielded VM Instance configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network. A full URL or partial URI are valid. Examples:</summary>
    [JsonPropertyName("subnet")]
    public string? Subnet { get; set; }

    /// <summary>The Compute Engine tags to add to runtime (see [Tagging instances] (https://cloud.google.com/compute/docs/ label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProviderVirtualMachine
{
    /// <summary>Virtual Machine configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachineConfig")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachineVirtualMachineConfig>? VirtualMachineConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecForProvider
{
    /// <summary>The config settings for accessing runtime. Structure is documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1RuntimeSpecForProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A reference to the zone where the machine resides.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The config settings for software inside the runtime. Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1RuntimeSpecForProviderSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>Use a Compute Engine VM image to start the managed notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1RuntimeSpecForProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderAccessConfig
{
    /// <summary>The type of access mode this instance. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/reference/ rest/v1/projects.locations.runtimes#RuntimeAccessType.</summary>
    [JsonPropertyName("accessType")]
    public string? AccessType { get; set; }

    /// <summary>The owner of this runtime after creation. Format: alias@example.com. Currently supports one owner only.</summary>
    [JsonPropertyName("runtimeOwner")]
    public string? RuntimeOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderSoftwareConfigKernels
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderSoftwareConfig
{
    /// <summary>Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically choose from official GPU drivers.</summary>
    [JsonPropertyName("customGpuDriverPath")]
    public string? CustomGpuDriverPath { get; set; }

    /// <summary>Verifies core internal services are running. Default: True.</summary>
    [JsonPropertyName("enableHealthMonitoring")]
    public bool? EnableHealthMonitoring { get; set; }

    /// <summary>Runtime will automatically shutdown after idle_shutdown_time. Default: True</summary>
    [JsonPropertyName("idleShutdown")]
    public bool? IdleShutdown { get; set; }

    /// <summary>Time in minutes to wait before shuting down runtime. Default: 180 minutes</summary>
    [JsonPropertyName("idleShutdownTimeout")]
    public double? IdleShutdownTimeout { get; set; }

    /// <summary>Install Nvidia Driver automatically.</summary>
    [JsonPropertyName("installGpuDriver")]
    public bool? InstallGpuDriver { get; set; }

    /// <summary>Use a list of container images to use as Kernels in the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("kernels")]
    public IList<V1beta1RuntimeSpecInitProviderSoftwareConfigKernels>? Kernels { get; set; }

    /// <summary>Cron expression in UTC timezone for schedule instance auto upgrade. Please follow the cron format.</summary>
    [JsonPropertyName("notebookUpgradeSchedule")]
    public string? NotebookUpgradeSchedule { get; set; }

    /// <summary>Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path (gs://path-to-file/file-name).</summary>
    [JsonPropertyName("postStartupScript")]
    public string? PostStartupScript { get; set; }

    /// <summary>Behavior for the post startup script. Possible values are: POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED, RUN_EVERY_START, DOWNLOAD_AND_RUN_EVERY_START.</summary>
    [JsonPropertyName("postStartupScriptBehavior")]
    public string? PostStartupScriptBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigAcceleratorConfig
{
    /// <summary>Count of cores of this accelerator.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigContainerImages
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams
{
    /// <summary>Provide this property when creating the disk.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the disk name. If not specified, the default is to use the name of the instance. If the disk with the instance name exists already in the given zone/region, a new name will be automatically generated.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB. If not specified, the disk will be the same size as the image (usually 10GB). If specified, the size must be equal to or larger than 10GB. Default 100 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The type of the boot disk attached to this runtime, defaults to standard persistent disk. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/ reference/rest/v1/projects.locations.runtimes#disktype</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigDataDisk
{
    /// <summary>Input only. Specifies the parameters for a new disk that will be created alongside the new instance. Use initialization parameters to create boot disks or local SSDs attached to the new instance. This property is mutually exclusive with the source property; you can only define one or the other, but not both. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams>? InitializeParams { get; set; }

    /// <summary>"Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI. For performance characteristics of SCSI over NVMe, see Local SSD performance. Valid values: * NVME * SCSI".</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies a valid partial or full URL to an existing Persistent Disk resource.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigEncryptionConfig
{
    /// <summary>The Cloud KMS resource identifier of the customer-managed encryption key used to protect a resource, such as a disks. It has the following format: projects/{PROJECT_ID}/locations/{REGION}/keyRings/ {KEY_RING_NAME}/cryptoKeys/{KEY_NAME}</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the boot integrity of the instance. The attestation is performed against the integrity policy baseline. This baseline is initially derived from the implicitly trusted boot image when the instance is created. Enabled by default.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether the instance has Secure Boot enabled.Secure Boot helps ensure that the system only runs authentic software by verifying the digital signature of all boot components, and halting the boot process if signature verification fails. Disabled by default.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfig
{
    /// <summary>The Compute Engine accelerator configuration for this runtime. Structure is documented below.</summary>
    [JsonPropertyName("acceleratorConfig")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigAcceleratorConfig>? AcceleratorConfig { get; set; }

    /// <summary>Use a list of container images to start the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("containerImages")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigContainerImages>? ContainerImages { get; set; }

    /// <summary>Data disk option configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigDataDisk>? DataDisk { get; set; }

    /// <summary>Encryption settings for virtual machine data disk. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>If true, runtime will only have internal IP addresses. By default, runtimes are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each vm. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Compute Engine machine type used for runtimes.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine metadata entries to add to virtual machine. (see [Project and instance metadata](https://cloud.google.com /compute/docs/storing-retrieving-metadata#project_and_instance _metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork. If neither network nor subnet is specified, the "default" network of the project is used, if it exists. A full URL or partial URI. Examples:</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet. Possible values are: UNSPECIFIED_NIC_TYPE, VIRTIO_NET, GVNIC.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Reserved IP Range name is used for VPC Peering. The subnetwork allocation will use the range name if it's assigned.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Shielded VM Instance configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network. A full URL or partial URI are valid. Examples:</summary>
    [JsonPropertyName("subnet")]
    public string? Subnet { get; set; }

    /// <summary>The Compute Engine tags to add to runtime (see [Tagging instances] (https://cloud.google.com/compute/docs/ label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProviderVirtualMachine
{
    /// <summary>Virtual Machine configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachineConfig")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachineVirtualMachineConfig>? VirtualMachineConfig { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecInitProvider
{
    /// <summary>The config settings for accessing runtime. Structure is documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1RuntimeSpecInitProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The config settings for software inside the runtime. Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1RuntimeSpecInitProviderSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>Use a Compute Engine VM image to start the managed notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1RuntimeSpecInitProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuntimeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuntimeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RuntimeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RuntimeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RuntimeSpec defines the desired state of Runtime</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RuntimeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RuntimeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RuntimeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RuntimeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RuntimeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderAccessConfig
{
    /// <summary>The type of access mode this instance. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/reference/ rest/v1/projects.locations.runtimes#RuntimeAccessType.</summary>
    [JsonPropertyName("accessType")]
    public string? AccessType { get; set; }

    /// <summary>(Output) The proxy endpoint that is used to access the runtime.</summary>
    [JsonPropertyName("proxyUri")]
    public string? ProxyUri { get; set; }

    /// <summary>The owner of this runtime after creation. Format: alias@example.com. Currently supports one owner only.</summary>
    [JsonPropertyName("runtimeOwner")]
    public string? RuntimeOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderMetrics
{
    /// <summary>(Output) Contains runtime daemon metrics, such as OS and kernels and sessions stats.</summary>
    [JsonPropertyName("systemMetrics")]
    public IDictionary<string, string>? SystemMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderSoftwareConfigKernels
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderSoftwareConfig
{
    /// <summary>Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically choose from official GPU drivers.</summary>
    [JsonPropertyName("customGpuDriverPath")]
    public string? CustomGpuDriverPath { get; set; }

    /// <summary>Verifies core internal services are running. Default: True.</summary>
    [JsonPropertyName("enableHealthMonitoring")]
    public bool? EnableHealthMonitoring { get; set; }

    /// <summary>Runtime will automatically shutdown after idle_shutdown_time. Default: True</summary>
    [JsonPropertyName("idleShutdown")]
    public bool? IdleShutdown { get; set; }

    /// <summary>Time in minutes to wait before shuting down runtime. Default: 180 minutes</summary>
    [JsonPropertyName("idleShutdownTimeout")]
    public double? IdleShutdownTimeout { get; set; }

    /// <summary>Install Nvidia Driver automatically.</summary>
    [JsonPropertyName("installGpuDriver")]
    public bool? InstallGpuDriver { get; set; }

    /// <summary>Use a list of container images to use as Kernels in the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("kernels")]
    public IList<V1beta1RuntimeStatusAtProviderSoftwareConfigKernels>? Kernels { get; set; }

    /// <summary>Cron expression in UTC timezone for schedule instance auto upgrade. Please follow the cron format.</summary>
    [JsonPropertyName("notebookUpgradeSchedule")]
    public string? NotebookUpgradeSchedule { get; set; }

    /// <summary>Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path (gs://path-to-file/file-name).</summary>
    [JsonPropertyName("postStartupScript")]
    public string? PostStartupScript { get; set; }

    /// <summary>Behavior for the post startup script. Possible values are: POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED, RUN_EVERY_START, DOWNLOAD_AND_RUN_EVERY_START.</summary>
    [JsonPropertyName("postStartupScriptBehavior")]
    public string? PostStartupScriptBehavior { get; set; }

    /// <summary>(Output) Bool indicating whether an newer image is available in an image family.</summary>
    [JsonPropertyName("upgradeable")]
    public bool? Upgradeable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigAcceleratorConfig
{
    /// <summary>Count of cores of this accelerator.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigContainerImages
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams
{
    /// <summary>Provide this property when creating the disk.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the disk name. If not specified, the default is to use the name of the instance. If the disk with the instance name exists already in the given zone/region, a new name will be automatically generated.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB. If not specified, the disk will be the same size as the image (usually 10GB). If specified, the size must be equal to or larger than 10GB. Default 100 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The type of the boot disk attached to this runtime, defaults to standard persistent disk. For valid values, see https://cloud.google.com/vertex-ai/docs/workbench/ reference/rest/v1/projects.locations.runtimes#disktype</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigDataDisk
{
    /// <summary>(Output) Optional. Specifies whether the disk will be auto-deleted when the instance is deleted (but not when the disk is detached from the instance).</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>(Output) Optional. Indicates that this is a boot disk. The virtual machine will use the first partition of the disk for its root filesystem.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>(Output) Optional. Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-* tree of a Linux operating system running within the instance. This name can be used to reference the device for mounting, resizing, and so on, from within the instance. If not specified, the server chooses a default device name to apply to this disk, in the form persistent-disk-x, where x is a number assigned by Google Compute Engine. This field is only applicable for persistent disks.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>(Output) Indicates a list of features to enable on the guest operating system. Applicable only for bootable images. To see a list of available features, read https://cloud.google.com/compute/docs/ images/create-delete-deprecate-private-images#guest-os-features options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>(Output) Output only. A zero-based index to this disk, where 0 is reserved for the boot disk. If you have many disks attached to an instance, each disk would have a unique index number.</summary>
    [JsonPropertyName("index")]
    public double? Index { get; set; }

    /// <summary>Input only. Specifies the parameters for a new disk that will be created alongside the new instance. Use initialization parameters to create boot disks or local SSDs attached to the new instance. This property is mutually exclusive with the source property; you can only define one or the other, but not both. Structure is documented below.</summary>
    [JsonPropertyName("initializeParams")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigDataDiskInitializeParams>? InitializeParams { get; set; }

    /// <summary>"Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI. For performance characteristics of SCSI over NVMe, see Local SSD performance. Valid values: * NVME * SCSI".</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>(Output) Type of the resource. Always compute#attachedDisk for attached disks.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(Output) Output only. Any valid publicly visible licenses.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies a valid partial or full URL to an existing Persistent Disk resource.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigEncryptionConfig
{
    /// <summary>The Cloud KMS resource identifier of the customer-managed encryption key used to protect a resource, such as a disks. It has the following format: projects/{PROJECT_ID}/locations/{REGION}/keyRings/ {KEY_RING_NAME}/cryptoKeys/{KEY_NAME}</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the boot integrity of the instance. The attestation is performed against the integrity policy baseline. This baseline is initially derived from the implicitly trusted boot image when the instance is created. Enabled by default.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether the instance has Secure Boot enabled.Secure Boot helps ensure that the system only runs authentic software by verifying the digital signature of all boot components, and halting the boot process if signature verification fails. Disabled by default.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfig
{
    /// <summary>The Compute Engine accelerator configuration for this runtime. Structure is documented below.</summary>
    [JsonPropertyName("acceleratorConfig")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigAcceleratorConfig>? AcceleratorConfig { get; set; }

    /// <summary>Use a list of container images to start the notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("containerImages")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigContainerImages>? ContainerImages { get; set; }

    /// <summary>Data disk option configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigDataDisk>? DataDisk { get; set; }

    /// <summary>Encryption settings for virtual machine data disk. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>(Output) The Compute Engine guest attributes. (see [Project and instance guest attributes](https://cloud.google.com/compute/docs/ storing-retrieving-metadata#guest_attributes)).</summary>
    [JsonPropertyName("guestAttributes")]
    public IDictionary<string, string>? GuestAttributes { get; set; }

    /// <summary>If true, runtime will only have internal IP addresses. By default, runtimes are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each vm. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Compute Engine machine type used for runtimes.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine metadata entries to add to virtual machine. (see [Project and instance metadata](https://cloud.google.com /compute/docs/storing-retrieving-metadata#project_and_instance _metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork. If neither network nor subnet is specified, the "default" network of the project is used, if it exists. A full URL or partial URI. Examples:</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet. Possible values are: UNSPECIFIED_NIC_TYPE, VIRTIO_NET, GVNIC.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Reserved IP Range name is used for VPC Peering. The subnetwork allocation will use the range name if it's assigned.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Shielded VM Instance configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network. A full URL or partial URI are valid. Examples:</summary>
    [JsonPropertyName("subnet")]
    public string? Subnet { get; set; }

    /// <summary>The Compute Engine tags to add to runtime (see [Tagging instances] (https://cloud.google.com/compute/docs/ label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>(Output) The zone where the virtual machine is located.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProviderVirtualMachine
{
    /// <summary>(Output) The unique identifier of the Managed Compute Engine instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>(Output) The user-friendly name of the Managed Compute Engine instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Virtual Machine configuration settings. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachineConfig")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachineVirtualMachineConfig>? VirtualMachineConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusAtProvider
{
    /// <summary>The config settings for accessing runtime. Structure is documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1RuntimeStatusAtProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The health state of this runtime. For a list of possible output values, see https://cloud.google.com/vertex-ai/docs/workbench/ reference/rest/v1/projects.locations.runtimes#healthstate.</summary>
    [JsonPropertyName("healthState")]
    public string? HealthState { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/runtimes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The labels to associate with this runtime. Label keys must contain 1 to 63 characters, and must conform to [RFC 1035] (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035. No more than 32 labels can be associated with a cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A reference to the zone where the machine resides.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Contains Runtime daemon metrics such as Service status and JupyterLab status Structure is documented below.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1RuntimeStatusAtProviderMetrics>? Metrics { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The config settings for software inside the runtime. Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1RuntimeStatusAtProviderSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The state of this runtime.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Use a Compute Engine VM image to start the managed notebook instance. Structure is documented below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1RuntimeStatusAtProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatusConditions
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

/// <summary>RuntimeStatus defines the observed state of Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuntimeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RuntimeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RuntimeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Runtime is the Schema for the Runtimes API. A Cloud AI Platform Notebook runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Runtime : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RuntimeSpec>, IStatus<V1beta1RuntimeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Runtime";
    public const string KubeGroup = "notebooks.gcp.upbound.io";
    public const string KubePluralName = "runtimes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuntimeSpec defines the desired state of Runtime</summary>
    [JsonPropertyName("spec")]
    public V1beta1RuntimeSpec Spec { get; set; }

    /// <summary>RuntimeStatus defines the observed state of Runtime.</summary>
    [JsonPropertyName("status")]
    public V1beta1RuntimeStatus? Status { get; set; }
}