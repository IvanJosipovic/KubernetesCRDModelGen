using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.cnrm.cloud.google.com;
#nullable enable
/// <summary>BatchJob is the Schema for the BatchJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BatchJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BatchJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BatchJobList";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "batchjobs";
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
    public IList<V1alpha1BatchJob> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyAccelerators
{
    /// <summary>The number of accelerators of this type.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Optional. The NVIDIA GPU driver version that should be installed for this  type.   You can define the specific driver version such as "470.103.01",  following the driver version requirements in  https://cloud.google.com/compute/docs/gpus/install-drivers-gpu#minimum-driver.  Batch will install the specific accelerator driver if qualified.</summary>
    [JsonPropertyName("driverVersion")]
    public string? DriverVersion { get; set; }

    /// <summary>Deprecated: please use instances[0].install_gpu_drivers instead.</summary>
    [JsonPropertyName("installGpuDrivers")]
    public bool? InstallGpuDrivers { get; set; }

    /// <summary>The accelerator type. For example, "nvidia-tesla-t4". See `gcloud compute accelerator-types list`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>URL for a VM image to use as the data source for this disk.  For example, the following are all valid URLs:   * Specify the image by its family name:  projects/{project}/global/images/family/{image_family}  * Specify the image version:  projects/{project}/global/images/{image_version}   You can also use Batch customized image in short names.  The following image values are supported for a boot disk:   * `batch-debian`: use Batch Debian images.  * `batch-cos`: use Batch Container-Optimized images.  * `batch-hpc-rocky`: use Batch HPC Rocky Linux images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyBootDiskImageRef
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Boot disk to be created and attached to each VM by this InstancePolicy. Boot disk will be deleted when the VM is deleted. Batch API now only supports booting from image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyBootDisk
{
    /// <summary>Local SSDs are available through both "SCSI" and "NVMe" interfaces. If not indicated, "NVMe" will be the default one for local ssds. This field is ignored for persistent disks as the interface is chosen automatically. See https://cloud.google.com/compute/docs/disks/persistent-disks#choose_an_interface.</summary>
    [JsonPropertyName("diskInterface")]
    public string? DiskInterface { get; set; }

    /// <summary>URL for a VM image to use as the data source for this disk.  For example, the following are all valid URLs:   * Specify the image by its family name:  projects/{project}/global/images/family/{image_family}  * Specify the image version:  projects/{project}/global/images/{image_version}   You can also use Batch customized image in short names.  The following image values are supported for a boot disk:   * `batch-debian`: use Batch Debian images.  * `batch-cos`: use Batch Container-Optimized images.  * `batch-hpc-rocky`: use Batch HPC Rocky Linux images.</summary>
    [JsonPropertyName("imageRef")]
    public V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyBootDiskImageRef? ImageRef { get; set; }

    /// <summary>Disk size in GB.   **Non-Boot Disk**:  If the `type` specifies a persistent disk, this field  is ignored if `data_source` is set as `image` or `snapshot`.  If the `type` specifies a local SSD, this field should be a multiple of  375 GB, otherwise, the final size will be the next greater multiple of  375 GB.   **Boot Disk**:  Batch will calculate the boot disk size based on source  image and task requirements if you do not speicify the size.  If both this field and the `boot_disk_mib` field in task spec's  `compute_resource` are defined, Batch will only honor this field.  Also, this field should be no smaller than the source disk's  size when the `data_source` is set as `snapshot` or `image`.  For example, if you set an image as the `data_source` field and the  image's default disk size 30 GB, you can only use this field to make the  disk larger or equal to 30 GB.</summary>
    [JsonPropertyName("sizeGB")]
    public long? SizeGB { get; set; }

    /// <summary>Name of a snapshot used as the data source. Snapshot is not supported as boot disk now.</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Disk type as shown in `gcloud compute disk-types list`. For example, local SSD uses type "local-ssd". Persistent disks and boot disks use "pd-balanced", "pd-extreme", "pd-ssd" or "pd-standard". If not specified, "pd-standard" will be used as the default type for non-boot disks, "pd-balanced" will be used as the default type for boot disks.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>URL for a VM image to use as the data source for this disk.  For example, the following are all valid URLs:   * Specify the image by its family name:  projects/{project}/global/images/family/{image_family}  * Specify the image version:  projects/{project}/global/images/{image_version}   You can also use Batch customized image in short names.  The following image values are supported for a boot disk:   * `batch-debian`: use Batch Debian images.  * `batch-cos`: use Batch Container-Optimized images.  * `batch-hpc-rocky`: use Batch HPC Rocky Linux images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisksNewDiskImageRef
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisksNewDisk
{
    /// <summary>Local SSDs are available through both "SCSI" and "NVMe" interfaces. If not indicated, "NVMe" will be the default one for local ssds. This field is ignored for persistent disks as the interface is chosen automatically. See https://cloud.google.com/compute/docs/disks/persistent-disks#choose_an_interface.</summary>
    [JsonPropertyName("diskInterface")]
    public string? DiskInterface { get; set; }

    /// <summary>URL for a VM image to use as the data source for this disk.  For example, the following are all valid URLs:   * Specify the image by its family name:  projects/{project}/global/images/family/{image_family}  * Specify the image version:  projects/{project}/global/images/{image_version}   You can also use Batch customized image in short names.  The following image values are supported for a boot disk:   * `batch-debian`: use Batch Debian images.  * `batch-cos`: use Batch Container-Optimized images.  * `batch-hpc-rocky`: use Batch HPC Rocky Linux images.</summary>
    [JsonPropertyName("imageRef")]
    public V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisksNewDiskImageRef? ImageRef { get; set; }

    /// <summary>Disk size in GB.   **Non-Boot Disk**:  If the `type` specifies a persistent disk, this field  is ignored if `data_source` is set as `image` or `snapshot`.  If the `type` specifies a local SSD, this field should be a multiple of  375 GB, otherwise, the final size will be the next greater multiple of  375 GB.   **Boot Disk**:  Batch will calculate the boot disk size based on source  image and task requirements if you do not speicify the size.  If both this field and the `boot_disk_mib` field in task spec's  `compute_resource` are defined, Batch will only honor this field.  Also, this field should be no smaller than the source disk's  size when the `data_source` is set as `snapshot` or `image`.  For example, if you set an image as the `data_source` field and the  image's default disk size 30 GB, you can only use this field to make the  disk larger or equal to 30 GB.</summary>
    [JsonPropertyName("sizeGB")]
    public long? SizeGB { get; set; }

    /// <summary>Name of a snapshot used as the data source. Snapshot is not supported as boot disk now.</summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Disk type as shown in `gcloud compute disk-types list`. For example, local SSD uses type "local-ssd". Persistent disks and boot disks use "pd-balanced", "pd-extreme", "pd-ssd" or "pd-standard". If not specified, "pd-standard" will be used as the default type for non-boot disks, "pd-balanced" will be used as the default type for boot disks.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisks
{
    /// <summary>Device name that the guest operating system will see. It is used by Runnable.volumes field to mount disks. So please specify the device_name if you want Batch to help mount the disk, and it should match the device_name field in volumes.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Name of an existing PD.</summary>
    [JsonPropertyName("existingDisk")]
    public string? ExistingDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("newDisk")]
    public V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisksNewDisk? NewDisk { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstancePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstancesPolicy
{
    /// <summary>The accelerators attached to each VM instance.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyAccelerators>? Accelerators { get; set; }

    /// <summary>Boot disk to be created and attached to each VM by this InstancePolicy. Boot disk will be deleted when the VM is deleted. Batch API now only supports booting from image.</summary>
    [JsonPropertyName("bootDisk")]
    public V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyBootDisk? BootDisk { get; set; }

    /// <summary>Non-boot disks to be attached for each VM created by this InstancePolicy. New disks will be deleted when the VM is deleted. A non-boot disk is a disk that can be of a device with a file system or a raw storage drive that is not ready for data storage and accessing.</summary>
    [JsonPropertyName("disks")]
    public IList<V1alpha1BatchJobSpecAllocationPolicyInstancesPolicyDisks>? Disks { get; set; }

    /// <summary>The Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The minimum CPU platform. See https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform.</summary>
    [JsonPropertyName("minCPUPlatform")]
    public string? MinCPUPlatform { get; set; }

    /// <summary>The provisioning model.</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Optional. If not specified (default), VMs will consume any applicable reservation. If "NO_RESERVATION" is specified, VMs will not consume any reservation. Otherwise, if specified, VMs will consume only the specified reservation.</summary>
    [JsonPropertyName("reservation")]
    public string? Reservation { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyInstances
{
    /// <summary>Optional. Set this field to `true` if you want Batch to block  project-level SSH keys from accessing this job's VMs.  Alternatively, you  can configure the job to specify a VM instance template that blocks  project-level SSH keys. In either case, Batch blocks project-level SSH  keys while creating the VMs for this job.   Batch allows project-level SSH keys for a job's VMs only if all  the following are true:     SSH keys.   Notably, you can override this behavior by manually updating a VM to  block or allow project-level SSH keys. For more information about  blocking project-level SSH keys, see the Compute Engine documentation:  https://cloud.google.com/compute/docs/connect/restrict-ssh-keys#block-keys</summary>
    [JsonPropertyName("blockProjectSSHKeys")]
    public bool? BlockProjectSSHKeys { get; set; }

    /// <summary>Set this field true if you want Batch to help fetch drivers from a third  party location and install them for GPUs specified in  `policy.accelerators` or `instance_template` on your behalf. Default is  false.   For Container-Optimized Image cases, Batch will install the  accelerator driver following milestones of  https://cloud.google.com/container-optimized-os/docs/release-notes. For  non Container-Optimized Image cases, following  https://github.com/GoogleCloudPlatform/compute-gpu-installation/blob/main/linux/install_gpu_driver.py.</summary>
    [JsonPropertyName("installGpuDrivers")]
    public bool? InstallGpuDrivers { get; set; }

    /// <summary>Optional. Set this field true if you want Batch to install Ops Agent on your behalf. Default is false.</summary>
    [JsonPropertyName("installOpsAgent")]
    public bool? InstallOpsAgent { get; set; }

    /// <summary>Name of an instance template used to create VMs.  Named the field as 'instance_template' instead of 'template' to avoid  C++ keyword conflict.   Batch only supports global instance templates from the same project as  the job.  You can specify the global instance template as a full or partial URL.</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>InstancePolicy.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BatchJobSpecAllocationPolicyInstancesPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Location where compute resources should be allocated for the Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyLocation
{
    /// <summary>A list of allowed location names represented by internal URLs.   Each location can be a region or a zone.  Only one region or multiple zones in one region is supported now.  For example,  ["regions/us-central1"] allow VMs in any zones in region us-central1.  ["zones/us-central1-a", "zones/us-central1-c"] only allow VMs  in zones us-central1-a and us-central1-c.   Mixing locations from different regions would cause errors.  For example,  ["regions/us-central1", "zones/us-central1-a", "zones/us-central1-b",  "zones/us-west1-a"] contains locations from two distinct regions:  us-central1 and us-west1. This combination will trigger an error.</summary>
    [JsonPropertyName("allowedLocations")]
    public IList<string>? AllowedLocations { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The URL of an existing network resource.  You can specify the network as a full or partial URL.   For example, the following are all valid URLs:   * https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}  * projects/{project}/global/networks/{network}  * global/networks/{network}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfacesNetworkRef
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
#nullable disable

#nullable enable
/// <summary>The URL of an existing subnetwork resource in the network.  You can specify the subnetwork as a full or partial URL.   For example, the following are all valid URLs:   * https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetwork}  * projects/{project}/regions/{region}/subnetworks/{subnetwork}  * regions/{region}/subnetworks/{subnetwork}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfacesSubnetworkRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfaces
{
    /// <summary>The URL of an existing network resource.  You can specify the network as a full or partial URL.   For example, the following are all valid URLs:   * https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}  * projects/{project}/global/networks/{network}  * global/networks/{network}</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfacesNetworkRef? NetworkRef { get; set; }

    /// <summary>Default is false (with an external IP address). Required if no external public IP address is attached to the VM. If no external public IP address, additional configuration is required to allow the VM to access Google Services. See https://cloud.google.com/vpc/docs/configure-private-google-access and https://cloud.google.com/nat/docs/gce-example#create-nat for more information.</summary>
    [JsonPropertyName("noExternalIPAddress")]
    public bool? NoExternalIPAddress { get; set; }

    /// <summary>The URL of an existing subnetwork resource in the network.  You can specify the subnetwork as a full or partial URL.   For example, the following are all valid URLs:   * https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetwork}  * projects/{project}/regions/{region}/subnetworks/{subnetwork}  * regions/{region}/subnetworks/{subnetwork}</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfacesSubnetworkRef? SubnetworkRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The network policy.   If you define an instance template in the `InstancePolicyOrTemplate` field,  Batch will use the network settings in the instance template instead of  this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyNetwork
{
    /// <summary>Network configurations.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1alpha1BatchJobSpecAllocationPolicyNetworkNetworkInterfaces>? NetworkInterfaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The placement policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyPlacement
{
    /// <summary>UNSPECIFIED vs. COLLOCATED (default UNSPECIFIED). Use COLLOCATED when you want VMs to be located close to each other for low network latency between the VMs. No placement policy will be generated when collocation is UNSPECIFIED.</summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>When specified, causes the job to fail if more than max_distance logical switches are required between VMs. Batch uses the most compact possible placement of VMs even when max_distance is not specified. An explicit max_distance makes that level of compactness a strict requirement. Not yet implemented</summary>
    [JsonPropertyName("maxDistance")]
    public long? MaxDistance { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the service account for Batch-created VMs. If omitted, the [default  Compute Engine service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used. Must match the service account specified in any used instance  template configured in the Batch job.   Includes the following fields:   * email: The service account's email address. If not set, the default   Compute Engine service account is used.   * scopes: Additional OAuth scopes to grant the service account, beyond the   default cloud-platform scope. (list of strings)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicyServiceAccount
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
#nullable disable

#nullable enable
/// <summary>Compute resource allocation for all TaskGroups in the Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecAllocationPolicy
{
    /// <summary>Describe instances that can be created by this AllocationPolicy. Only instances[0] is supported now.</summary>
    [JsonPropertyName("instances")]
    public IList<V1alpha1BatchJobSpecAllocationPolicyInstances>? Instances { get; set; }

    /// <summary>Custom labels to apply to the job and all the Compute Engine resources  that both are created by this allocation policy and support labels.   Use labels to group and describe the resources they are applied to. Batch  automatically applies predefined labels and supports multiple `labels`  fields for each job, which each let you apply custom labels to various  resources. Label names that start with "goog-" or "google-" are  reserved for predefined labels. For more information about labels with  Batch, see  [Organize resources using  labels](https://cloud.google.com/batch/docs/organize-resources-using-labels).</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Location where compute resources should be allocated for the Job.</summary>
    [JsonPropertyName("location")]
    public V1alpha1BatchJobSpecAllocationPolicyLocation? Location { get; set; }

    /// <summary>The network policy.   If you define an instance template in the `InstancePolicyOrTemplate` field,  Batch will use the network settings in the instance template instead of  this field.</summary>
    [JsonPropertyName("network")]
    public V1alpha1BatchJobSpecAllocationPolicyNetwork? Network { get; set; }

    /// <summary>The placement policy.</summary>
    [JsonPropertyName("placement")]
    public V1alpha1BatchJobSpecAllocationPolicyPlacement? Placement { get; set; }

    /// <summary>Defines the service account for Batch-created VMs. If omitted, the [default  Compute Engine service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used. Must match the service account specified in any used instance  template configured in the Batch job.   Includes the following fields:   * email: The service account's email address. If not set, the default   Compute Engine service account is used.   * scopes: Additional OAuth scopes to grant the service account, beyond the   default cloud-platform scope. (list of strings)</summary>
    [JsonPropertyName("serviceAccount")]
    public V1alpha1BatchJobSpecAllocationPolicyServiceAccount? ServiceAccount { get; set; }

    /// <summary>Optional. Tags applied to the VM instances.   The tags identify valid sources or targets for network firewalls.  Each tag must be 1-63 characters long, and comply with  [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. When `destination` is set to `CLOUD_LOGGING`, you can optionally set this field to configure additional settings for Cloud Logging.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecLogsPolicyCloudLoggingOption
{
    /// <summary>Optional. Set this field to `true` to change the [monitored resource type](https://cloud.google.com/monitoring/api/resources) for Cloud Logging logs generated by this Batch job from the [`batch.googleapis.com/Job`](https://cloud.google.com/monitoring/api/resources#tag_batch.googleapis.com/Job) type to the formerly used [`generic_task`](https://cloud.google.com/monitoring/api/resources#tag_generic_task) type.</summary>
    [JsonPropertyName("useGenericTaskMonitoredResource")]
    public bool? UseGenericTaskMonitoredResource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Log preservation policy for the Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecLogsPolicy
{
    /// <summary>Optional. When `destination` is set to `CLOUD_LOGGING`, you can optionally set this field to configure additional settings for Cloud Logging.</summary>
    [JsonPropertyName("cloudLoggingOption")]
    public V1alpha1BatchJobSpecLogsPolicyCloudLoggingOption? CloudLoggingOption { get; set; }

    /// <summary>If and where logs should be saved.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>When `destination` is set to `PATH`, you must set this field to the path where you want logs to be saved. This path can point to a local directory on the VM or (if congifured) a directory under the mount path of any Cloud Storage bucket, network file system (NFS), or writable persistent disk that is mounted to the job. For example, if the job has a bucket with `mountPath` set to `/mnt/disks/my-bucket`, you can write logs to the root directory of the `remotePath` of that bucket by setting this field to `/mnt/disks/my-bucket/`.</summary>
    [JsonPropertyName("logsPath")]
    public string? LogsPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The attribute requirements of messages to be sent to this Pub/Sub topic. Without this field, no message will be sent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecNotificationsMessage
{
    /// <summary>The new job state.</summary>
    [JsonPropertyName("newJobState")]
    public string? NewJobState { get; set; }

    /// <summary>The new task state.</summary>
    [JsonPropertyName("newTaskState")]
    public string? NewTaskState { get; set; }

    /// <summary>The message type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Pub/Sub topic where notifications for the job, like state  changes, will be published. If undefined, no Pub/Sub notifications  are sent for this job.   Specify the topic using the following format:  `projects/{project}/topics/{topic}`.  Notably, if you want to specify a Pub/Sub topic that is in a  different project than the job, your administrator must grant your  project's Batch service agent permission to publish to that topic.   For more information about configuring Pub/Sub notifications for  a job, see  https://cloud.google.com/batch/docs/enable-notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecNotificationsPubsubTopicRef
{
    /// <summary>A reference to an externally managed PubSubTopic resource. Should be in the format "projects/{{projectID}}/topics/{{topicID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PubSubTopic resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PubSubTopic resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecNotifications
{
    /// <summary>The attribute requirements of messages to be sent to this Pub/Sub topic. Without this field, no message will be sent.</summary>
    [JsonPropertyName("message")]
    public V1alpha1BatchJobSpecNotificationsMessage? Message { get; set; }

    /// <summary>The Pub/Sub topic where notifications for the job, like state  changes, will be published. If undefined, no Pub/Sub notifications  are sent for this job.   Specify the topic using the following format:  `projects/{project}/topics/{topic}`.  Notably, if you want to specify a Pub/Sub topic that is in a  different project than the job, your administrator must grant your  project's Batch service agent permission to publish to that topic.   For more information about configuring Pub/Sub notifications for  a job, see  https://cloud.google.com/batch/docs/enable-notifications.</summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1alpha1BatchJobSpecNotificationsPubsubTopicRef? PubsubTopicRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskEnvironmentsEncryptedVariablesKmsKeyRef
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
#nullable disable

#nullable enable
/// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskEnvironmentsEncryptedVariables
{
    /// <summary>The value of the cipherText response from the `encrypt` method.</summary>
    [JsonPropertyName("cipherText")]
    public string? CipherText { get; set; }

    /// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BatchJobSpecTaskGroupsTaskEnvironmentsEncryptedVariablesKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskEnvironments
{
    /// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
    [JsonPropertyName("encryptedVariables")]
    public V1alpha1BatchJobSpecTaskGroupsTaskEnvironmentsEncryptedVariables? EncryptedVariables { get; set; }

    /// <summary>A map of environment variable names to Secret Manager secret names. The VM will access the named secrets to set the value of each environment variable.</summary>
    [JsonPropertyName("secretVariables")]
    public IDictionary<string, string>? SecretVariables { get; set; }

    /// <summary>A map of environment variable names to values.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComputeResource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecComputeResource
{
    /// <summary>Extra boot disk size in MiB for each task.</summary>
    [JsonPropertyName("bootDiskMiB")]
    public long? BootDiskMiB { get; set; }

    /// <summary>The milliCPU count.   `cpuMilli` defines the amount of CPU resources per task in milliCPU units.  For example, `1000` corresponds to 1 vCPU per task. If undefined, the  default value is `2000`.   If you also define the VM's machine type using the `machineType` in  [InstancePolicy](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicy)  field or inside the `instanceTemplate` in the  [InstancePolicyOrTemplate](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicyortemplate)  field, make sure the CPU resources for both fields are compatible with each  other and with how many tasks you want to allow to run on the same VM at  the same time.   For example, if you specify the `n2-standard-2` machine type, which has 2  vCPUs each, you are recommended to set `cpuMilli` no more than `2000`, or  you are recommended to run two tasks on the same VM if you set `cpuMilli`  to `1000` or less.</summary>
    [JsonPropertyName("cpuMilli")]
    public long? CpuMilli { get; set; }

    /// <summary>Memory in MiB.   `memoryMib` defines the amount of memory per task in MiB units.  If undefined, the default value is `2000`.  If you also define the VM's machine type using the `machineType` in  [InstancePolicy](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicy)  field or inside the `instanceTemplate` in the  [InstancePolicyOrTemplate](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicyortemplate)  field, make sure the memory resources for both fields are compatible with  each other and with how many tasks you want to allow to run on the same VM  at the same time.   For example, if you specify the `n2-standard-2` machine type, which has 8  GiB each, you are recommended to set `memoryMib` to no more than `8192`,  or you are recommended to run two tasks on the same VM if you set  `memoryMib` to `4096` or less.</summary>
    [JsonPropertyName("memoryMiB")]
    public long? MemoryMiB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironmentEncryptedVariablesKmsKeyRef
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
#nullable disable

#nullable enable
/// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironmentEncryptedVariables
{
    /// <summary>The value of the cipherText response from the `encrypt` method.</summary>
    [JsonPropertyName("cipherText")]
    public string? CipherText { get; set; }

    /// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironmentEncryptedVariablesKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Environment variables to set before running the Task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironment
{
    /// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
    [JsonPropertyName("encryptedVariables")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironmentEncryptedVariables? EncryptedVariables { get; set; }

    /// <summary>A map of environment variable names to Secret Manager secret names. The VM will access the named secrets to set the value of each environment variable.</summary>
    [JsonPropertyName("secretVariables")]
    public IDictionary<string, string>? SecretVariables { get; set; }

    /// <summary>A map of environment variable names to values.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Conditions that decide why a task failure is dealt with a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecLifecyclePoliciesActionCondition
{
    /// <summary>Exit codes of a task execution. If there are more than 1 exit codes, when task executes with any of the exit code in the list, the condition is met and the action will be executed.</summary>
    [JsonPropertyName("exitCodes")]
    public IList<int>? ExitCodes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecLifecyclePolicies
{
    /// <summary>Action to execute when ActionCondition is true. When RETRY_TASK is specified, we will retry failed tasks if we notice any exit code match and fail tasks if no match is found. Likewise, when FAIL_TASK is specified, we will fail tasks if we notice any exit code match and retry tasks if no match is found.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Conditions that decide why a task failure is dealt with a specific action.</summary>
    [JsonPropertyName("actionCondition")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecLifecyclePoliciesActionCondition? ActionCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Barrier runnable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesBarrier
{
    /// <summary>Barriers are identified by their index in runnable list. Names are not required, but if present should be an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Container runnable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesContainer
{
    /// <summary>If set to true, external network access to and from container will be blocked, containers that are with block_external_network as true can still communicate with each other, network cannot be specified in the `container.options` field.</summary>
    [JsonPropertyName("blockExternalNetwork")]
    public bool? BlockExternalNetwork { get; set; }

    /// <summary>Required for some container images. Overrides the `CMD` specified in the container. If there is an `ENTRYPOINT` (either in the container image or with the `entrypoint` field below) then these commands are appended as arguments to the `ENTRYPOINT`.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>Optional. If set to true, this container runnable uses Image streaming.   Use Image streaming to allow the runnable to initialize without  waiting for the entire container image to download, which can  significantly reduce startup time for large container images.   When `enableImageStreaming` is set to true, the container  runtime is [containerd](https://containerd.io/) instead of Docker.  Additionally, this container runnable only supports the following  `container` subfields: `imageUri`,  `commands[]`, `entrypoint`, and  `volumes[]`; any other `container` subfields are ignored.   For more information about the requirements and limitations for using  Image streaming with Batch, see the [`image-streaming`  sample on  GitHub](https://github.com/GoogleCloudPlatform/batch-samples/tree/main/api-samples/image-streaming).</summary>
    [JsonPropertyName("enableImageStreaming")]
    public bool? EnableImageStreaming { get; set; }

    /// <summary>Required for some container images. Overrides the `ENTRYPOINT` specified in the container.</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>Required. The URI to pull the container image from.</summary>
    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    /// <summary>Required for some container images. Arbitrary additional options to include in the `docker run` command when running this container&amp;mdash;for example, `--network host`. For the `--volume` option, use the `volumes` field for the container.</summary>
    [JsonPropertyName("options")]
    public string? Options { get; set; }

    /// <summary>Required if the container image is from a private Docker registry. The  username to login to the Docker registry that contains the image.   You can either specify the username directly by using plain text or  specify an encrypted username by using a Secret Manager secret:  `projects/*/secrets/*/versions/*`. However, using a secret is  recommended for enhanced security.   Caution: If you specify the username using plain text, you risk the  username being exposed to any users who can view the job or its logs.  To avoid this risk, specify a secret that contains the username instead.   Learn more about [Secret  Manager](https://cloud.google.com/secret-manager/docs/) and [using  Secret Manager with  Batch](https://cloud.google.com/batch/docs/create-run-job-secret-manager).</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Volumes to mount (bind mount) from the host machine files or directories  into the container, formatted to match `--volume` option for the  `docker run` command&amp;mdash;for example, `/foo:/bar` or `/foo:/bar:ro`.   If the `TaskSpec.Volumes` field is specified but this field is not, Batch  will mount each volume from the host machine to the container with the  same mount path by default. In this case, the default mount option for  containers will be read-only (`ro`) for existing persistent disks and  read-write (`rw`) for other volume types, regardless of the original  mount options specified in `TaskSpec.Volumes`. If you need different  mount settings, you can explicitly configure them in this field.</summary>
    [JsonPropertyName("volumes")]
    public IList<string>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironmentEncryptedVariablesKmsKeyRef
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
#nullable disable

#nullable enable
/// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironmentEncryptedVariables
{
    /// <summary>The value of the cipherText response from the `encrypt` method.</summary>
    [JsonPropertyName("cipherText")]
    public string? CipherText { get; set; }

    /// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironmentEncryptedVariablesKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Environment variables for this Runnable (overrides variables set for the whole Task or TaskGroup).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironment
{
    /// <summary>An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their values.</summary>
    [JsonPropertyName("encryptedVariables")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironmentEncryptedVariables? EncryptedVariables { get; set; }

    /// <summary>A map of environment variable names to Secret Manager secret names. The VM will access the named secrets to set the value of each environment variable.</summary>
    [JsonPropertyName("secretVariables")]
    public IDictionary<string, string>? SecretVariables { get; set; }

    /// <summary>A map of environment variable names to values.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Script runnable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesScript
{
    /// <summary>The path to a script file that is accessible from the host VM(s).   Unless the script file supports the default `#!/bin/sh` shell  interpreter, you must specify an interpreter by including a  [shebang line](https://en.wikipedia.org/wiki/Shebang_(Unix) as the  first line of the file. For example, to execute the script using bash,  include `#!/bin/bash` as the first line of the file. Alternatively,  to execute the script using Python3, include `#!/usr/bin/env python3`  as the first line of the file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The text for a script.   Unless the script text supports the default `#!/bin/sh` shell  interpreter, you must specify an interpreter by including a  [shebang line](https://en.wikipedia.org/wiki/Shebang_(Unix) at the  beginning of the text. For example, to execute the script using bash,  include `#!/bin/bash\n` at the beginning of the text. Alternatively,  to execute the script using Python3, include `#!/usr/bin/env python3\n`  at the beginning of the text.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnables
{
    /// <summary>By default, after a Runnable fails, no further Runnable are executed. This  flag indicates that this Runnable must be run even if the Task has already  failed. This is useful for Runnables that copy output files off of the VM  or for debugging.   The always_run flag does not override the Task's overall max_run_duration.  If the max_run_duration has expired then no further Runnables will execute,  not even always_run Runnables.</summary>
    [JsonPropertyName("alwaysRun")]
    public bool? AlwaysRun { get; set; }

    /// <summary>Normally, a runnable that doesn't exit causes its task to fail. However,  you can set this field to `true` to configure a background runnable.  Background runnables are allowed continue running in the background while  the task executes subsequent runnables. For example, background runnables  are useful for providing services to other runnables or providing  debugging-support tools like SSH servers.   Specifically, background runnables are killed automatically (if they have  not already exited) a short time after all foreground runnables have  completed. Even though this is likely to result in a non-zero exit status  for the background runnable, these automatic kills are not treated as task  failures.</summary>
    [JsonPropertyName("background")]
    public bool? Background { get; set; }

    /// <summary>Barrier runnable.</summary>
    [JsonPropertyName("barrier")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesBarrier? Barrier { get; set; }

    /// <summary>Container runnable.</summary>
    [JsonPropertyName("container")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesContainer? Container { get; set; }

    /// <summary>Optional. DisplayName is an optional field that can be provided by the caller. If provided, it will be used in logs and other outputs to identify the script, making it easier for users to understand the logs. If not provided the index of the runnable will be used for outputs.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Environment variables for this Runnable (overrides variables set for the whole Task or TaskGroup).</summary>
    [JsonPropertyName("environment")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesEnvironment? Environment { get; set; }

    /// <summary>Normally, a runnable that returns a non-zero exit status fails and causes the task to fail. However, you can set this field to `true` to allow the task to continue executing its other runnables even if this runnable fails.</summary>
    [JsonPropertyName("ignoreExitStatus")]
    public bool? IgnoreExitStatus { get; set; }

    /// <summary>Labels for this Runnable.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Script runnable.</summary>
    [JsonPropertyName("script")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnablesScript? Script { get; set; }

    /// <summary>Timeout for this Runnable.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Google Cloud Storage (GCS) volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumesGcs
{
    /// <summary>Remote path, either a bucket name or a subdirectory of a bucket, e.g.: bucket_name, bucket_name/subdirectory/</summary>
    [JsonPropertyName("remotePath")]
    public string? RemotePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Network File System (NFS) volume. For example, a Filestore file share.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumesNfs
{
    /// <summary>Remote source path exported from the NFS, e.g., "/share".</summary>
    [JsonPropertyName("remotePath")]
    public string? RemotePath { get; set; }

    /// <summary>The IP address of the NFS.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumes
{
    /// <summary>Device name of an attached disk volume, which should align with a device_name specified by job.allocation_policy.instances[0].policy.disks[i].device_name or defined by the given instance template in job.allocation_policy.instances[0].instance_template.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A Google Cloud Storage (GCS) volume.</summary>
    [JsonPropertyName("gcs")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumesGcs? Gcs { get; set; }

    /// <summary>Mount options vary based on the type of storage volume:   * For a Cloud Storage bucket, all the mount options provided  by    the [`gcsfuse` tool](https://cloud.google.com/storage/docs/gcsfuse-cli)    are supported.  * For an existing persistent disk, all mount options provided by the    [`mount` command](https://man7.org/linux/man-pages/man8/mount.8.html)    except writing are supported. This is due to restrictions of    [multi-writer    mode](https://cloud.google.com/compute/docs/disks/sharing-disks-between-vms).  * For any other disk or a Network File System (NFS), all the    mount options provided by the `mount` command are supported.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>The mount path for the volume, e.g. /mnt/disks/share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>A Network File System (NFS) volume. For example, a Filestore file share.</summary>
    [JsonPropertyName("nfs")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumesNfs? Nfs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Tasks in the group share the same task spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroupsTaskSpec
{
    /// <summary>ComputeResource requirements.</summary>
    [JsonPropertyName("computeResource")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecComputeResource? ComputeResource { get; set; }

    /// <summary>Environment variables to set before running the Task.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpecEnvironment? Environment { get; set; }

    /// <summary>Deprecated: please use environment(non-plural) instead.</summary>
    [JsonPropertyName("environments")]
    public IDictionary<string, string>? Environments { get; set; }

    /// <summary>Lifecycle management schema when any task in a task group is failed. Currently we only support one lifecycle policy. When the lifecycle policy condition is met, the action in the policy will execute. If task execution result does not meet with the defined lifecycle policy, we consider it as the default policy. Default policy means if the exit code is 0, exit task. If task ends with non-zero exit code, retry the task with max_retry_count.</summary>
    [JsonPropertyName("lifecyclePolicies")]
    public IList<V1alpha1BatchJobSpecTaskGroupsTaskSpecLifecyclePolicies>? LifecyclePolicies { get; set; }

    /// <summary>Maximum number of retries on failures. The default, 0, which means never retry. The valid value range is [0, 10].</summary>
    [JsonPropertyName("maxRetryCount")]
    public int? MaxRetryCount { get; set; }

    /// <summary>Maximum duration the task should run before being automatically retried (if enabled) or automatically failed. Format the value of this field as a time limit in seconds followed by `s`&amp;mdash;for example, `3600s` for 1 hour. The field accepts any value between 0 and the maximum listed for the `Duration` field type at https://protobuf.dev/reference/protobuf/google.protobuf/#duration; however, the actual maximum run time for a job will be limited to the maximum run time for a job listed at https://cloud.google.com/batch/quotas#max-job-duration.</summary>
    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    /// <summary>Required. The sequence of one or more runnables (executable scripts,  executable containers, and/or barriers) for each task in this task group to  run. Each task runs this list of runnables in order. For a task to succeed,  all of its script and container runnables each must meet at least one of  the following conditions:     `ignore_exit_status` subfield.</summary>
    [JsonPropertyName("runnables")]
    public IList<V1alpha1BatchJobSpecTaskGroupsTaskSpecRunnables>? Runnables { get; set; }

    /// <summary>Volumes to mount before running Tasks using this TaskSpec.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1BatchJobSpecTaskGroupsTaskSpecVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpecTaskGroups
{
    /// <summary>Max number of tasks that can run in parallel. Default to min(task_count, parallel tasks per job limit). See: [Job Limits](https://cloud.google.com/batch/quotas#job_limits). Field parallelism must be 1 if the scheduling_policy is IN_ORDER.</summary>
    [JsonPropertyName("parallelism")]
    public long? Parallelism { get; set; }

    /// <summary>When true, Batch will configure SSH to allow passwordless login between VMs running the Batch tasks in the same TaskGroup.</summary>
    [JsonPropertyName("permissiveSSH")]
    public bool? PermissiveSSH { get; set; }

    /// <summary>When true, Batch will populate a file with a list of all VMs assigned to the TaskGroup and set the BATCH_HOSTS_FILE environment variable to the path of that file. Defaults to false. The host file supports up to 1000 VMs.</summary>
    [JsonPropertyName("requireHostsFile")]
    public bool? RequireHostsFile { get; set; }

    /// <summary>Optional. If not set or set to false, Batch uses the root user to execute runnables. If set to true, Batch runs the runnables using a non-root user. Currently, the non-root user Batch used is generated by OS Login. For more information, see [About OS Login](https://cloud.google.com/compute/docs/oslogin).</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>Scheduling policy for Tasks in the TaskGroup. The default value is AS_SOON_AS_POSSIBLE.</summary>
    [JsonPropertyName("schedulingPolicy")]
    public string? SchedulingPolicy { get; set; }

    /// <summary>Number of Tasks in the TaskGroup. Default is 1.</summary>
    [JsonPropertyName("taskCount")]
    public long? TaskCount { get; set; }

    /// <summary>Max number of tasks that can be run on a VM at the same time. If not specified, the system will decide a value based on available compute resources on a VM and task requirements.</summary>
    [JsonPropertyName("taskCountPerNode")]
    public long? TaskCountPerNode { get; set; }

    /// <summary>An array of environment variable mappings, which are passed to Tasks with  matching indices. If task_environments is used then task_count should  not be specified in the request (and will be ignored). Task count will be  the length of task_environments.   Tasks get a BATCH_TASK_INDEX and BATCH_TASK_COUNT environment variable, in  addition to any environment variables set in task_environments, specifying  the number of Tasks in the Task's parent TaskGroup, and the specific Task's  index in the TaskGroup (0 through BATCH_TASK_COUNT - 1).</summary>
    [JsonPropertyName("taskEnvironments")]
    public IList<V1alpha1BatchJobSpecTaskGroupsTaskEnvironments>? TaskEnvironments { get; set; }

    /// <summary>Required. Tasks in the group share the same task spec.</summary>
    [JsonPropertyName("taskSpec")]
    public V1alpha1BatchJobSpecTaskGroupsTaskSpec? TaskSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchJobSpec defines the desired state of BatchJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobSpec
{
    /// <summary>Compute resource allocation for all TaskGroups in the Job.</summary>
    [JsonPropertyName("allocationPolicy")]
    public V1alpha1BatchJobSpecAllocationPolicy? AllocationPolicy { get; set; }

    /// <summary>Custom labels to apply to the job and any Cloud Logging  [LogEntry](https://cloud.google.com/logging/docs/reference/v2/rest/v2/LogEntry)  that it generates.   Use labels to group and describe the resources they are applied to. Batch  automatically applies predefined labels and supports multiple `labels`  fields for each job, which each let you apply custom labels to various  resources. Label names that start with "goog-" or "google-" are  reserved for predefined labels. For more information about labels with  Batch, see  [Organize resources using  labels](https://cloud.google.com/batch/docs/organize-resources-using-labels).</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Log preservation policy for the Job.</summary>
    [JsonPropertyName("logsPolicy")]
    public V1alpha1BatchJobSpecLogsPolicy? LogsPolicy { get; set; }

    /// <summary>Notification configurations.</summary>
    [JsonPropertyName("notifications")]
    public IList<V1alpha1BatchJobSpecNotifications>? Notifications { get; set; }

    /// <summary>Priority of the Job. The valid value range is [0, 100). Default value is 0. Higher value indicates higher priority. A job with higher priority value is more likely to run earlier if all other requirements are satisfied.</summary>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BatchJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BatchJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. TaskGroups in the Job. Only one TaskGroup is supported now.</summary>
    [JsonPropertyName("taskGroups")]
    public IList<V1alpha1BatchJobSpecTaskGroups>? TaskGroups { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Task Execution. This field is only defined for task-level status events where the task fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusObservedStateStatusStatusEventsTaskExecution
{
    /// <summary>The exit code of a finished task.   If the task succeeded, the exit code will be 0. If the task failed but not  due to the following reasons, the exit code will be 50000.   Otherwise, it can be from different sources:  * Batch known failures:  https://cloud.google.com/batch/docs/troubleshooting#reserved-exit-codes.  * Batch runnable execution failures; you can rely on Batch logs to further  diagnose: https://cloud.google.com/batch/docs/analyze-job-using-logs. If  there are multiple runnables failures, Batch only exposes the first error.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusObservedStateStatusStatusEvents
{
    /// <summary>Description of the event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time this event occurred.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Task Execution. This field is only defined for task-level status events where the task fails.</summary>
    [JsonPropertyName("taskExecution")]
    public V1alpha1BatchJobStatusObservedStateStatusStatusEventsTaskExecution? TaskExecution { get; set; }

    /// <summary>Task State. This field is only defined for task-level status events.</summary>
    [JsonPropertyName("taskState")]
    public string? TaskState { get; set; }

    /// <summary>Type of the event.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Job status. It is read only for users.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusObservedStateStatus
{
    /// <summary>The duration of time that the Job spent in status RUNNING.</summary>
    [JsonPropertyName("runDuration")]
    public string? RunDuration { get; set; }

    /// <summary>Job state</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Job status events</summary>
    [JsonPropertyName("statusEvents")]
    public IList<V1alpha1BatchJobStatusObservedStateStatusStatusEvents>? StatusEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusObservedStateTaskGroups
{
    /// <summary>Output only. TaskGroup name. The system generates this field based on parent Job name. For example: "projects/123456/locations/us-west1/jobs/job01/taskGroups/group01".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatusObservedState
{
    /// <summary>Output only. When the Job was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Job name. For example: "projects/123456/locations/us-central1/jobs/job01".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Job status. It is read only for users.</summary>
    [JsonPropertyName("status")]
    public V1alpha1BatchJobStatusObservedStateStatus? Status { get; set; }

    /// <summary>Required. TaskGroups in the Job. Only one TaskGroup is supported now.</summary>
    [JsonPropertyName("taskGroups")]
    public IList<V1alpha1BatchJobStatusObservedStateTaskGroups>? TaskGroups { get; set; }

    /// <summary>Output only. A system generated unique ID for the Job.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last time the Job was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchJobStatus defines the config connector machine state of BatchJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BatchJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BatchJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BatchJobStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchJob is the Schema for the BatchJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BatchJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BatchJobSpec>, IStatus<V1alpha1BatchJobStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BatchJob";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "batchjobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BatchJobSpec defines the desired state of BatchJob</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BatchJobSpec Spec { get; set; }

    /// <summary>BatchJobStatus defines the config connector machine state of BatchJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1BatchJobStatus? Status { get; set; }
}
#nullable disable
