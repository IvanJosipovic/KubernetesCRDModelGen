using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Manages a Cloud Dataproc cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. Please set a number greater than 0. Node Group must have at least 1 instance.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig>? NodeGroupConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigEndpointConfig
{
    /// <summary>The flag to enable http access to specific ports on the cluster from external sources (aka Component Gateway). Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicy
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
/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy
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
/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigConfidentialInstanceConfig>? ConfidentialInstanceConfig { get; set; }

    /// <summary>By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. If set to true, all instances in the cluster will only have internal IP addresses. Note: Private Google Access (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster will be launched in.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>A map of the Compute Engine metadata entries to add to all instances (see Project and instance metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to the cluster will be part of. Conflicts with subnetwork. If neither is specified, this defaults to the "default" network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the service_account specified. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork the cluster will be part of. Conflicts with network.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The list of instance tags applied to instances in the cluster. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The GCP zone where your data is stored and used (i.e. where the master and the worker nodes will be created in). If region is set to 'global' (default) then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement to determine this automatically for you. Note: This setting additionally determines and restricts which computing resources are available for use with other configs such as cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigInitializationAction
{
    /// <summary>The script to be executed during initialization of the cluster. The script must be a GCS file with a gs:// prefix.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The maximum duration (in seconds) which script is allowed to take to execute its action. GCP will default to a predetermined computed value if not set (currently 300).</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the master. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. If not specified, GCP will default to a predetermined computed value (currently 1).</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix>? ProvisioningModelMix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy>? InstanceFlexibilityPolicy { get; set; }

    /// <summary>Specifies the number of preemptible nodes to create. Defaults to 0.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE Accepted values are:</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificated, the password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigSecurityConfig
{
    /// <summary>Kerberos Configuration</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigSoftwareConfig
{
    /// <summary>The Cloud Dataproc image version to use for the cluster - this controls the sets of software versions installed onto the nodes when you create clusters. If not specified, defaults to the latest version. For a list of valid versions see Cloud Dataproc versions</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A list of override and additional properties (key/value pairs) used to modify various aspects of the common configuration files used when creating a cluster. For a list of valid properties please see Cluster properties</summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the worker nodes. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>Specifies the number of worker nodes to create. If not specified, GCP will default to a predetermined computed value (currently 2). There is currently a beta feature which allows you to run a Single Node Cluster. In order to take advantage of this you need to set "dataproc:dataproc.allow.zero.workers" = "true" in cluster_config.software_config.properties</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterConfig
{
    /// <summary>The autoscaling policy config associated with the cluster. Note that once set, if autoscaling_config is the only field set in cluster_config, it can only be removed by setting policy_uri = "", rather than removing the whole block. Structure defined below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times. Structure defined below.</summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigDataprocMetricConfig>? DataprocMetricConfig { get; set; }

    /// <summary>The Customer managed encryption keys settings for the cluster. Structure defined below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The config settings for port access on the cluster. Structure defined below.</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>Common config settings for resources of Google Compute Engine cluster instances, applicable to all instances in the cluster. Structure defined below.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. You can specify multiple versions of these. Structure defined below.</summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>The settings for auto deletion cluster schedule. Structure defined below.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the master instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the additional instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigPreemptibleWorkerConfig>? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster. Structure defined below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don't explicitly specify a temp_bucket then GCP will auto create / assign one for you.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Google Compute Engine config settings for the worker instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>The number of local SSD disks to attach to the node, which is limited by the maximum number of disks allowable per zone.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Whether the nodes are created as preemptible VM instances. Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>The autoscaler configuration for this node pool. The autoscaler is enabled only when a valid configuration is present.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling>? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig>? Config { get; set; }

    /// <summary>The list of Compute Engine zones where node pool nodes associated with a Dataproc on GKE virtual cluster will be located.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>(Input only) The configuration for the GKE node pool. If specified, Dataproc attempts to create a node pool with the specified shape. If one with the same name already exists, it is verified against all specified fields. If a field differs, the virtual cluster creation will fail.</summary>
    [JsonPropertyName("nodePoolConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig>? NodePoolConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster (the GKE cluster can be zonal or regional)</summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget. Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.</summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>The components that should be installed in this Dataproc cluster. The key must be a string from the KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.</summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>The properties to set on daemon config files. Property keys are specified in prefix:property format, for example spark:spark.kubernetes.container.image.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig>? GkeClusterConfig { get; set; }

    /// <summary>A namespace within the Kubernetes cluster to deploy into. If this namespace does not exist, it is created. If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it. If not specified, the name of the Dataproc Cluster is used.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig>? KubernetesSoftwareConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualClusterConfig
{
    /// <summary>Configuration of auxiliary services used by this cluster. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfig>? AuxiliaryServicesConfig { get; set; }

    /// <summary>The configuration for running the Dataproc cluster on Kubernetes. Structure defined below.</summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfig>? KubernetesClusterConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Allows you to configure various aspects of the cluster. Structure defined below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1ClusterSpecForProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>Does not affect auto scaling decomissioning from an autoscaling policy. Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress. Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs). Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of Duration). Only supported on Dataproc image versions 1.2 and higher. For more context see the docs</summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the cluster, unique within the project and zone.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the cluster and associated nodes will be created in. Defaults to global.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Allows you to configure a virtual Dataproc on GKE cluster. Structure defined below.</summary>
    [JsonPropertyName("virtualClusterConfig")]
    public IList<V1beta1ClusterSpecForProviderVirtualClusterConfig>? VirtualClusterConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. Please set a number greater than 0. Node Group must have at least 1 instance.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig>? NodeGroupConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigEndpointConfig
{
    /// <summary>The flag to enable http access to specific ports on the cluster from external sources (aka Component Gateway). Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicy
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
/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy
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
/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigConfidentialInstanceConfig>? ConfidentialInstanceConfig { get; set; }

    /// <summary>By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. If set to true, all instances in the cluster will only have internal IP addresses. Note: Private Google Access (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster will be launched in.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>A map of the Compute Engine metadata entries to add to all instances (see Project and instance metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to the cluster will be part of. Conflicts with subnetwork. If neither is specified, this defaults to the "default" network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the service_account specified. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork the cluster will be part of. Conflicts with network.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The list of instance tags applied to instances in the cluster. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The GCP zone where your data is stored and used (i.e. where the master and the worker nodes will be created in). If region is set to 'global' (default) then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement to determine this automatically for you. Note: This setting additionally determines and restricts which computing resources are available for use with other configs such as cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigInitializationAction
{
    /// <summary>The script to be executed during initialization of the cluster. The script must be a GCS file with a gs:// prefix.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The maximum duration (in seconds) which script is allowed to take to execute its action. GCP will default to a predetermined computed value if not set (currently 300).</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the master. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. If not specified, GCP will default to a predetermined computed value (currently 1).</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix>? ProvisioningModelMix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy>? InstanceFlexibilityPolicy { get; set; }

    /// <summary>Specifies the number of preemptible nodes to create. Defaults to 0.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE Accepted values are:</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificated, the password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigSecurityConfig
{
    /// <summary>Kerberos Configuration</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigSoftwareConfig
{
    /// <summary>The Cloud Dataproc image version to use for the cluster - this controls the sets of software versions installed onto the nodes when you create clusters. If not specified, defaults to the latest version. For a list of valid versions see Cloud Dataproc versions</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A list of override and additional properties (key/value pairs) used to modify various aspects of the common configuration files used when creating a cluster. For a list of valid properties please see Cluster properties</summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the worker nodes. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>Specifies the number of worker nodes to create. If not specified, GCP will default to a predetermined computed value (currently 2). There is currently a beta feature which allows you to run a Single Node Cluster. In order to take advantage of this you need to set "dataproc:dataproc.allow.zero.workers" = "true" in cluster_config.software_config.properties</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterConfig
{
    /// <summary>The autoscaling policy config associated with the cluster. Note that once set, if autoscaling_config is the only field set in cluster_config, it can only be removed by setting policy_uri = "", rather than removing the whole block. Structure defined below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times. Structure defined below.</summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigDataprocMetricConfig>? DataprocMetricConfig { get; set; }

    /// <summary>The Customer managed encryption keys settings for the cluster. Structure defined below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The config settings for port access on the cluster. Structure defined below.</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>Common config settings for resources of Google Compute Engine cluster instances, applicable to all instances in the cluster. Structure defined below.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. You can specify multiple versions of these. Structure defined below.</summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>The settings for auto deletion cluster schedule. Structure defined below.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the master instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the additional instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfig>? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster. Structure defined below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don't explicitly specify a temp_bucket then GCP will auto create / assign one for you.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Google Compute Engine config settings for the worker instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>The number of local SSD disks to attach to the node, which is limited by the maximum number of disks allowable per zone.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Whether the nodes are created as preemptible VM instances. Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>The autoscaler configuration for this node pool. The autoscaler is enabled only when a valid configuration is present.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling>? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig>? Config { get; set; }

    /// <summary>The list of Compute Engine zones where node pool nodes associated with a Dataproc on GKE virtual cluster will be located.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>(Input only) The configuration for the GKE node pool. If specified, Dataproc attempts to create a node pool with the specified shape. If one with the same name already exists, it is verified against all specified fields. If a field differs, the virtual cluster creation will fail.</summary>
    [JsonPropertyName("nodePoolConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig>? NodePoolConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster (the GKE cluster can be zonal or regional)</summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget. Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.</summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>The components that should be installed in this Dataproc cluster. The key must be a string from the KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.</summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>The properties to set on daemon config files. Property keys are specified in prefix:property format, for example spark:spark.kubernetes.container.image.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig>? GkeClusterConfig { get; set; }

    /// <summary>A namespace within the Kubernetes cluster to deploy into. If this namespace does not exist, it is created. If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it. If not specified, the name of the Dataproc Cluster is used.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig>? KubernetesSoftwareConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualClusterConfig
{
    /// <summary>Configuration of auxiliary services used by this cluster. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfig>? AuxiliaryServicesConfig { get; set; }

    /// <summary>The configuration for running the Dataproc cluster on Kubernetes. Structure defined below.</summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfig>? KubernetesClusterConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Allows you to configure various aspects of the cluster. Structure defined below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1ClusterSpecInitProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>Does not affect auto scaling decomissioning from an autoscaling policy. Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress. Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs). Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of Duration). Only supported on Dataproc image versions 1.2 and higher. For more context see the docs</summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the cluster, unique within the project and zone.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the cluster and associated nodes will be created in. Defaults to global.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Allows you to configure a virtual Dataproc on GKE cluster. Structure defined below.</summary>
    [JsonPropertyName("virtualClusterConfig")]
    public IList<V1beta1ClusterSpecInitProviderVirtualClusterConfig>? VirtualClusterConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
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
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
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
/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>List of worker instance names which have been assigned to the cluster.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. Please set a number greater than 0. Node Group must have at least 1 instance.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>The name of the cluster, unique within the project and zone.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig>? NodeGroupConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigEndpointConfig
{
    /// <summary>The flag to enable http access to specific ports on the cluster from external sources (aka Component Gateway). Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }

    /// <summary>The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.</summary>
    [JsonPropertyName("httpPorts")]
    public IDictionary<string, string>? HttpPorts { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigConfidentialInstanceConfig>? ConfidentialInstanceConfig { get; set; }

    /// <summary>By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. If set to true, all instances in the cluster will only have internal IP addresses. Note: Private Google Access (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster will be launched in.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>A map of the Compute Engine metadata entries to add to all instances (see Project and instance metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to the cluster will be part of. Conflicts with subnetwork. If neither is specified, this defaults to the "default" network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the service_account specified. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork the cluster will be part of. Conflicts with network.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The list of instance tags applied to instances in the cluster. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The GCP zone where your data is stored and used (i.e. where the master and the worker nodes will be created in). If region is set to 'global' (default) then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement to determine this automatically for you. Note: This setting additionally determines and restricts which computing resources are available for use with other configs such as cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigInitializationAction
{
    /// <summary>The script to be executed during initialization of the cluster. The script must be a GCS file with a gs:// prefix.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The maximum duration (in seconds) which script is allowed to take to execute its action. GCP will default to a predetermined computed value if not set (currently 300).</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }

    /// <summary>Time when the cluster became idle (most recent job finished) and became eligible for deletion due to idleness.</summary>
    [JsonPropertyName("idleStartTime")]
    public string? IdleStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>List of worker instance names which have been assigned to the cluster.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the master. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Specifies the number of master nodes to create. If not specified, GCP will default to a predetermined computed value (currently 1).</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionResults
{
    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceSelectionResults")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionResults>? InstanceSelectionResults { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix>? ProvisioningModelMix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy>? InstanceFlexibilityPolicy { get; set; }

    /// <summary>List of worker instance names which have been assigned to the cluster.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Specifies the number of preemptible nodes to create. Defaults to 0.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE Accepted values are:</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificated, the password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigSecurityConfig
{
    /// <summary>Kerberos Configuration</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigSoftwareConfig
{
    /// <summary>The Cloud Dataproc image version to use for the cluster - this controls the sets of software versions installed onto the nodes when you create clusters. If not specified, defaults to the latest version. For a list of valid versions see Cloud Dataproc versions</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A list of override and additional properties (key/value pairs) used to modify various aspects of the common configuration files used when creating a cluster. For a list of valid properties please see Cluster properties</summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }

    /// <summary>The properties to set on daemon config files. Property keys are specified in prefix:property format, for example spark:spark.kubernetes.container.image.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size of the primary disk attached to each node, specified in GB. The primary disk contains the boot volume and system libraries, and the smallest allowed disk size is 10GB. GCP will default to a predetermined computed value if not set (currently 500GB). Note: If SSDs are not attached, it also contains the HDFS data blocks and Hadoop working directories.</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>The disk type of the primary disk attached to each node. One of "pd-ssd" or "pd-standard". Defaults to "pd-standard".</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See local SSD performance.</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each master cluster node. Defaults to 0.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The URI for the image to use for this worker.  See the guide for more information.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>List of worker instance names which have been assigned to the cluster.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>The name of a Google Compute Engine machine type to create for the worker nodes. If not specified, GCP will default to a predetermined computed value (currently n1-standard-4).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The name of a minimum generation of CPU family for the master. If not specified, GCP will default to a predetermined computed value for each zone. See the guide for details about which CPU families are available (and defaulted) for each zone.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>Specifies the number of worker nodes to create. If not specified, GCP will default to a predetermined computed value (currently 2). There is currently a beta feature which allows you to run a Single Node Cluster. In order to take advantage of this you need to set "dataproc:dataproc.allow.zero.workers" = "true" in cluster_config.software_config.properties</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterConfig
{
    /// <summary>The autoscaling policy config associated with the cluster. Note that once set, if autoscaling_config is the only field set in cluster_config, it can only be removed by setting policy_uri = "", rather than removing the whole block. Structure defined below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>The name of the cloud storage bucket ultimately used to house the staging data for the cluster. If staging_bucket is specified, it will contain this value, otherwise it will be the auto generated name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times. Structure defined below.</summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigDataprocMetricConfig>? DataprocMetricConfig { get; set; }

    /// <summary>The Customer managed encryption keys settings for the cluster. Structure defined below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The config settings for port access on the cluster. Structure defined below.</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>Common config settings for resources of Google Compute Engine cluster instances, applicable to all instances in the cluster. Structure defined below.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. You can specify multiple versions of these. Structure defined below.</summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>The settings for auto deletion cluster schedule. Structure defined below.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the master instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Google Compute Engine config settings for the additional instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfig>? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster. Structure defined below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don't explicitly specify a temp_bucket then GCP will auto create / assign one for you.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Google Compute Engine config settings for the worker instances in a cluster. Structure defined below.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>The config setting for metastore service with the cluster. Structure defined below.</summary>
    [JsonPropertyName("metastoreConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig>? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>The number of local SSD disks to attach to the node, which is limited by the maximum number of disks allowable per zone.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell" or "Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Whether the nodes are created as preemptible VM instances. Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>The autoscaler configuration for this node pool. The autoscaler is enabled only when a valid configuration is present.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling>? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig>? Config { get; set; }

    /// <summary>The list of Compute Engine zones where node pool nodes associated with a Dataproc on GKE virtual cluster will be located.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>(Input only) The configuration for the GKE node pool. If specified, Dataproc attempts to create a node pool with the specified shape. If one with the same name already exists, it is verified against all specified fields. If a field differs, the virtual cluster creation will fail.</summary>
    [JsonPropertyName("nodePoolConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig>? NodePoolConfig { get; set; }

    /// <summary>The roles associated with the GKE node pool. One of "DEFAULT", "CONTROLLER", "SPARK_DRIVER" or "SPARK_EXECUTOR".</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster (the GKE cluster can be zonal or regional)</summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget. Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.</summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>The components that should be installed in this Dataproc cluster. The key must be a string from the KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.</summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>The properties to set on daemon config files. Property keys are specified in prefix:property format, for example spark:spark.kubernetes.container.image.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig>? GkeClusterConfig { get; set; }

    /// <summary>A namespace within the Kubernetes cluster to deploy into. If this namespace does not exist, it is created. If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it. If not specified, the name of the Dataproc Cluster is used.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig>? KubernetesSoftwareConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualClusterConfig
{
    /// <summary>Configuration of auxiliary services used by this cluster. Structure defined below.</summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfig>? AuxiliaryServicesConfig { get; set; }

    /// <summary>The configuration for running the Dataproc cluster on Kubernetes. Structure defined below.</summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfig>? KubernetesClusterConfig { get; set; }

    /// <summary>The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don't explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Allows you to configure various aspects of the cluster. Structure defined below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1ClusterStatusAtProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>(Computed) The list of labels (key/value pairs) to be applied to instances in the cluster. GCP generates some itself including goog-dataproc-cluster-name which is the name of the cluster.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Does not affect auto scaling decomissioning from an autoscaling policy. Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress. Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs). Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of Duration). Only supported on Dataproc image versions 1.2 and higher. For more context see the docs</summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the cluster, unique within the project and zone.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the cluster and associated nodes will be created in. Defaults to global.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Allows you to configure a virtual Dataproc on GKE cluster. Structure defined below.</summary>
    [JsonPropertyName("virtualClusterConfig")]
    public IList<V1beta1ClusterStatusAtProviderVirtualClusterConfig>? VirtualClusterConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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
/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Manages a Cloud Dataproc cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}
#nullable disable
