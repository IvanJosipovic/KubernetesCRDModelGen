using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
#nullable enable
/// <summary>DataprocNodeGroup is the Schema for the DataprocNodeGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocNodeGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataprocNodeGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocNodeGroupList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocnodegroups";
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
    public IList<V1alpha1DataprocNodeGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to  expose to this instance. See  [Compute Engine  AcceleratorTypes](https://cloud.google.com/compute/docs/reference/v1/acceleratorTypes).   Examples:   * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/[zone]/acceleratorTypes/nvidia-tesla-t4`  * `projects/[project_id]/zones/[zone]/acceleratorTypes/nvidia-tesla-t4`  * `nvidia-tesla-t4`   **Auto Zone Exception**: If you are using the Dataproc  [Auto Zone  Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement)  feature, you must use the short name of the accelerator type  resource, for example, `nvidia-tesla-t4`.</summary>
    [JsonPropertyName("acceleratorTypeURI")]
    public string? AcceleratorTypeURI { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigDiskConfig
{
    /// <summary>Optional. Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. Note: This field is only supported if boot_disk_type is hyperdisk-balanced.</summary>
    [JsonPropertyName("bootDiskProvisionedIOPs")]
    public long? BootDiskProvisionedIOPs { get; set; }

    /// <summary>Optional. Indicates how much throughput to provision for the disk. This sets the number of throughput mb per second that the disk can handle. Values must be greater than or equal to 1. Note: This field is only supported if boot_disk_type is hyperdisk-balanced.</summary>
    [JsonPropertyName("bootDiskProvisionedThroughput")]
    public long? BootDiskProvisionedThroughput { get; set; }

    /// <summary>Optional. Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGB")]
    public int? BootDiskSizeGB { get; set; }

    /// <summary>Optional. Type of the boot disk (default is "pd-standard"). Valid values: "pd-balanced" (Persistent Disk Balanced Solid State Drive), "pd-ssd" (Persistent Disk Solid State Drive), or "pd-standard" (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See [local SSD performance](https://cloud.google.com/compute/docs/disks/local-ssd#performance).</summary>
    [JsonPropertyName("localSSDInterface")]
    public string? LocalSSDInterface { get; set; }

    /// <summary>Optional. Number of attached SSDs, from 0 to 8 (default is 0).  If SSDs are not attached, the boot disk is used to store runtime logs and  [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data.  If one or more SSDs are attached, this runtime bulk  data is spread across them, and the boot disk contains only basic  config and installed binaries.   Note: Local SSD options may vary by machine type and number of vCPUs  selected.</summary>
    [JsonPropertyName("numLocalSSDs")]
    public int? NumLocalSSDs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Optional. Full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Optional. Preference of this instance selection. Lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Defines how the Group selects the provisioning model to ensure required reliability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>Optional. The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standard_capacity_base, then it will start using standard_capacity_percent_above_base to mix Spot with Standard VMs. eg. If 15 instances are requested and standard_capacity_base is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public int? StandardCapacityBase { get; set; }

    /// <summary>Optional. The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standard_capacity_base. eg. If 15 instances are requested and standard_capacity_base is 5 and standard_capacity_percent_above_base is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public int? StandardCapacityPercentAboveBase { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicy
{
    /// <summary>Optional. List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary>Optional. Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicyProvisioningModelMix? ProvisioningModelMix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration to handle the startup of instances during cluster create and update process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfigStartupConfig
{
    /// <summary>Optional. The config setting to enable cluster creation/ updation to be successful only after required_registration_fraction of instances are up and running. This configuration is applicable to only secondary workers for now. The cluster will fail if required_registration_fraction of instances are not available. This will include instance creation, agent registration, and service registration (if enabled).</summary>
    [JsonPropertyName("requiredRegistrationFraction")]
    public double? RequiredRegistrationFraction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The node group instance group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecNodeGroupConfig
{
    /// <summary>Optional. The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1alpha1DataprocNodeGroupSpecNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Optional. Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1alpha1DataprocNodeGroupSpecNodeGroupConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Optional. The Compute Engine image resource used for cluster instances.   The URI can represent an image or image family.   Image examples:   * `https://www.googleapis.com/compute/v1/projects/[project_id]/global/images/[image-id]`  * `projects/[project_id]/global/images/[image-id]`  * `image-id`   Image family examples. Dataproc will use the most recent  image from the family:   * `https://www.googleapis.com/compute/v1/projects/[project_id]/global/images/family/[custom-image-family-name]`  * `projects/[project_id]/global/images/family/[custom-image-family-name]`   If the URI is unspecified, it will be inferred from  `SoftwareConfig.image_version` or the system default.</summary>
    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    /// <summary>Optional. Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1alpha1DataprocNodeGroupSpecNodeGroupConfigInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>Optional. The Compute Engine machine type used for cluster instances.   A full URL, partial URI, or short name are valid. Examples:   * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/[zone]/machineTypes/n1-standard-2`  * `projects/[project_id]/zones/[zone]/machineTypes/n1-standard-2`  * `n1-standard-2`   **Auto Zone Exception**: If you are using the Dataproc  [Auto Zone  Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement)  feature, you must use the short name of the machine type  resource, for example, `n1-standard-2`.</summary>
    [JsonPropertyName("machineTypeURI")]
    public string? MachineTypeURI { get; set; }

    /// <summary>Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCPUPlatform")]
    public string? MinCPUPlatform { get; set; }

    /// <summary>Optional. The minimum number of primary worker instances to create.  If `min_num_instances` is set, cluster creation will succeed if  the number of primary workers created is at least equal to the  `min_num_instances` number.   Example: Cluster creation request with `num_instances` = `5` and  `min_num_instances` = `3`:   *  If 4 VMs are created and 1 instance fails,     the failed VM is deleted. The cluster is     resized to 4 instances and placed in a `RUNNING` state.  *  If 2 instances are created and 3 instances fail,     the cluster in placed in an `ERROR` state. The failed VMs     are not deleted.</summary>
    [JsonPropertyName("minNumInstances")]
    public int? MinNumInstances { get; set; }

    /// <summary>Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.</summary>
    [JsonPropertyName("numInstances")]
    public int? NumInstances { get; set; }

    /// <summary>Optional. Specifies the preemptibility of the instance group.   The default value for master and worker groups is  `NON_PREEMPTIBLE`. This default cannot be changed.   The default value for secondary instances is  `PREEMPTIBLE`.</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }

    /// <summary>Optional. Configuration to handle the startup of instances during cluster create and update process.</summary>
    [JsonPropertyName("startupConfig")]
    public V1alpha1DataprocNodeGroupSpecNodeGroupConfigStartupConfig? StartupConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpecProjectRef
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
/// <summary>DataprocNodeGroupSpec defines the desired state of DataprocNodeGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupSpec
{
    /// <summary>Optional. Node group labels.   * Label **keys** must consist of from 1 to 63 characters and conform to    [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt).  * Label **values** can be empty. If specified, they must consist of from    1 to 63 characters and conform to [RFC 1035]    (https://www.ietf.org/rfc/rfc1035.txt).  * The node group must have no more than 32 labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public V1alpha1DataprocNodeGroupSpecNodeGroupConfig? NodeGroupConfig { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataprocNodeGroupSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The DataprocNodeGroup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Node group roles.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusConditions
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
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceFlexibilityPolicyInstanceSelectionResults
{
}
#nullable disable

#nullable enable
/// <summary>Optional. Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceFlexibilityPolicy
{
    /// <summary>Output only. A list of instance selection results in the group.</summary>
    [JsonPropertyName("instanceSelectionResults")]
    public IList<V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceFlexibilityPolicyInstanceSelectionResults>? InstanceSelectionResults { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceReferences
{
    /// <summary>The unique identifier of the Compute Engine instance.</summary>
    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }

    /// <summary>The user-friendly name of the Compute Engine instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>The public ECIES key used for sharing data with this instance.</summary>
    [JsonPropertyName("publicEciesKey")]
    public string? PublicEciesKey { get; set; }

    /// <summary>The public RSA key used for sharing data with this instance.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigManagedGroupConfig
{
}
#nullable disable

#nullable enable
/// <summary>Optional. The node group instance group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfig
{
    /// <summary>Optional. Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. List of references to Compute Engine instances.</summary>
    [JsonPropertyName("instanceReferences")]
    public IList<V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigInstanceReferences>? InstanceReferences { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfigManagedGroupConfig? ManagedGroupConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatusObservedState
{
    /// <summary>Optional. The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public V1alpha1DataprocNodeGroupStatusObservedStateNodeGroupConfig? NodeGroupConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataprocNodeGroupStatus defines the config connector machine state of DataprocNodeGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocNodeGroupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataprocNodeGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocNodeGroup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataprocNodeGroupStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataprocNodeGroup is the Schema for the DataprocNodeGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocNodeGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataprocNodeGroupSpec>, IStatus<V1alpha1DataprocNodeGroupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocNodeGroup";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocnodegroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocNodeGroupSpec defines the desired state of DataprocNodeGroup</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataprocNodeGroupSpec Spec { get; set; }

    /// <summary>DataprocNodeGroupStatus defines the config connector machine state of DataprocNodeGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocNodeGroupStatus? Status { get; set; }
}
#nullable disable
