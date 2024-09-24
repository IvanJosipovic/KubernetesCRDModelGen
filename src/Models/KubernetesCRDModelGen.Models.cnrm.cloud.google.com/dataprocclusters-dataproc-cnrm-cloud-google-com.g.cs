using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigAutoscalingConfigPolicyRef
{
    /// <summary>Optional. The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]` * `projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]` Note that the policy must be in the same project and Dataproc region.  Allowed value: The Google Cloud resource name of a `DataprocAutoscalingPolicy` resource (format: `projects/{{project}}/locations/{{location}}/autoscalingPolicies/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigAutoscalingConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("policyRef")]
    public V1beta1DataprocClusterSpecConfigAutoscalingConfigPolicyRef? PolicyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigDataprocMetricConfigMetrics
{
    /// <summary>Immutable. Optional. Specify one or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course (for the `SPARK` metric source, any [Spark metric] (https://spark.apache.org/docs/latest/monitoring.html#metrics) can be specified). Provide metrics in the following format: `METRIC_SOURCE:INSTANCE:GROUP:METRIC` Use camelcase as appropriate. Examples: ``` yarn:ResourceManager:QueueMetrics:AppsCompleted spark:driver:DAGScheduler:job.allJobs sparkHistoryServer:JVM:Memory:NonHeapMemoryUsage.committed hiveserver2:JVM:Memory:NonHeapMemoryUsage.used ``` Notes: * Only the specified overridden metrics will be collected for the metric source. For example, if one or more `spark:executive` metrics are listed as metric overrides, other `SPARK` metrics will not be collected. The collection of the default metrics for other OSS metric sources is unaffected. For example, if both `SPARK` andd `YARN` metric sources are enabled, and overrides are provided for Spark metrics only, all default YARN metrics will be collected.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>Immutable. Required. Default metrics are collected unless `metricOverrides` are specified for the metric source (see [Available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) for more information). Possible values: METRIC_SOURCE_UNSPECIFIED, MONITORING_AGENT_DEFAULTS, HDFS, SPARK, YARN, SPARK_HISTORY_SERVER, HIVESERVER2</summary>
    [JsonPropertyName("metricSource")]
    public string MetricSource { get; set; }
}

/// <summary>Immutable. Optional. The config for Dataproc metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigDataprocMetricConfig
{
    /// <summary>Immutable. Required. Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1DataprocClusterSpecConfigDataprocMetricConfigMetrics> Metrics { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigEncryptionConfigGcePdKmsKeyRef
{
    /// <summary>Optional. The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.  Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigEncryptionConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("gcePdKmsKeyRef")]
    public V1beta1DataprocClusterSpecConfigEncryptionConfigGcePdKmsKeyRef? GcePdKmsKeyRef { get; set; }
}

/// <summary>Immutable. Optional. Port/endpoint configuration for this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigEndpointConfig
{
    /// <summary>Immutable. Optional. If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary>Immutable. Optional. Confidential Instance Config for clusters using [Confidential VMs](https://cloud.google.com/compute/confidential-vm/docs).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Immutable. Optional. Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigNetworkRef
{
    /// <summary>Optional. The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither `network_uri` nor `subnetwork_uri` is specified, the "default" network of the project is used, if it exists. Cannot be a "Custom Subnet Network" (see [Using Subnetworks](https://cloud.google.com/compute/docs/subnetworks) for more information). A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/global/default` * `projects/[project_id]/regions/global/default` * `default`  Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigNodeGroupAffinityNodeGroupRef
{
    /// <summary>Required. The URI of a sole-tenant [node group resource](https://cloud.google.com/compute/docs/reference/rest/v1/nodeGroups) that the cluster will be created on. A full URL, partial URI, or node group name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1` * `projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1` * `node-group-1`  Allowed value: The `selfLink` field of a `ComputeNodeGroup` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("nodeGroupRef")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigNodeGroupAffinityNodeGroupRef NodeGroupRef { get; set; }
}

/// <summary>Immutable. Optional. Reservation Affinity for consuming Zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigReservationAffinity
{
    /// <summary>Immutable. Optional. Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Immutable. Optional. Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Immutable. Optional. Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigServiceAccountRef
{
    /// <summary>Optional. The [Dataproc service account](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/service-accounts#service_accounts_in_dataproc) (also see [VM Data Plane identity](https://cloud.google.com/dataproc/docs/concepts/iam/dataproc-principals#vm_service_account_data_plane_identity)) used by Dataproc cluster VM instances to access Google Cloud Platform services. If not specified, the [Compute Engine default service account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.  Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Shielded Instance Config for clusters using [Compute Engine Shielded VMs](https://cloud.google.com/security/shielded-cloud/shielded-vm).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Immutable. Optional. Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Immutable. Optional. Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Immutable. Optional. Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfigSubnetworkRef
{
    /// <summary>Optional. The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/us-east1/subnetworks/sub0` * `projects/[project_id]/regions/us-east1/subnetworks/sub0` * `sub0`  Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The shared Compute Engine config settings for all instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigGceClusterConfig
{
    /// <summary>Immutable. Optional. Confidential Instance Config for clusters using [Confidential VMs](https://cloud.google.com/compute/confidential-vm/docs).</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Immutable. Optional. If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This `internal_ip_only` restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIPOnly")]
    public bool? InternalIPOnly { get; set; }

    /// <summary>Immutable. The Compute Engine metadata entries to add to all instances (see [Project and instance metadata](https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. Optional. Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>Immutable. Optional. The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIPv6GoogleAccess")]
    public string? PrivateIPv6GoogleAccess { get; set; }

    /// <summary>Immutable. Optional. Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Immutable. Optional. The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Immutable. Optional. Shielded Instance Config for clusters using [Compute Engine Shielded VMs](https://cloud.google.com/security/shielded-cloud/shielded-vm).</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Immutable. The Compute Engine tags to add to all instances (see [Tagging instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Immutable. Optional. The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/[zone]` * `projects/[project_id]/zones/[zone]` * `us-central1-f`</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigInitializationActions
{
    /// <summary>Immutable. Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string ExecutableFile { get; set; }

    /// <summary>Immutable. Optional. Amount of time executable has to complete. Default is 10 minutes (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary>Immutable. Optional. Lifecycle setting for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigLifecycleConfig
{
    /// <summary>Immutable. Optional. The time when cluster will be auto-deleted (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>Immutable. Optional. The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>Immutable. Optional. The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMasterConfigAccelerators
{
    /// <summary>Immutable. The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public long? AcceleratorCount { get; set; }

    /// <summary>Immutable. Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Immutable. Optional. Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMasterConfigDiskConfig
{
    /// <summary>Immutable. Optional. Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public long? BootDiskSizeGb { get; set; }

    /// <summary>Immutable. Optional. Type of the boot disk (default is "pd-standard"). Valid values: "pd-balanced" (Persistent Disk Balanced Solid State Drive), "pd-ssd" (Persistent Disk Solid State Drive), or "pd-standard" (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Immutable. Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See [local SSD performance](https://cloud.google.com/compute/docs/disks/local-ssd#performance).</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>Immutable. Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public long? NumLocalSsds { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMasterConfigImageRef
{
    /// <summary>Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.  Allowed value: The `selfLink` field of a `ComputeImage` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The Compute Engine config settings for the master instance in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMasterConfig
{
    /// <summary>Immutable. Optional. The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1DataprocClusterSpecConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Immutable. Optional. Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta1DataprocClusterSpecConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1DataprocClusterSpecConfigMasterConfigImageRef? ImageRef { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.</summary>
    [JsonPropertyName("numInstances")]
    public long? NumInstances { get; set; }

    /// <summary>Immutable. Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMetastoreConfigDataprocMetastoreServiceRef
{
    /// <summary>Required. Resource name of an existing Dataproc Metastore service. Example: * `projects/[project_id]/locations/[dataproc_region]/services/[service-name]`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] DataprocMetastoreService not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Metastore configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigMetastoreConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("dataprocMetastoreServiceRef")]
    public V1beta1DataprocClusterSpecConfigMetastoreConfigDataprocMetastoreServiceRef DataprocMetastoreServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>Immutable. The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public long? AcceleratorCount { get; set; }

    /// <summary>Immutable. Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Immutable. Optional. Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Immutable. Optional. Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public long? BootDiskSizeGb { get; set; }

    /// <summary>Immutable. Optional. Type of the boot disk (default is "pd-standard"). Valid values: "pd-balanced" (Persistent Disk Balanced Solid State Drive), "pd-ssd" (Persistent Disk Solid State Drive), or "pd-standard" (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Immutable. Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See [local SSD performance](https://cloud.google.com/compute/docs/disks/local-ssd#performance).</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>Immutable. Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public long? NumLocalSsds { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigImageRef
{
    /// <summary>Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.  Allowed value: The `selfLink` field of a `ComputeImage` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecondaryWorkerConfig
{
    /// <summary>Immutable. Optional. The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Immutable. Optional. Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1DataprocClusterSpecConfigSecondaryWorkerConfigImageRef? ImageRef { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.</summary>
    [JsonPropertyName("numInstances")]
    public long? NumInstances { get; set; }

    /// <summary>Immutable. Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Immutable. Optional. Identity related configuration, including service account based secure multi-tenancy user mappings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecurityConfigIdentityConfig
{
    /// <summary>Immutable. Required. Map of user to service account.</summary>
    [JsonPropertyName("userServiceAccountMapping")]
    public IDictionary<string, string> UserServiceAccountMapping { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecurityConfigKerberosConfigKmsKeyRef
{
    /// <summary>Optional. The uri of the KMS key used to encrypt various sensitive files.  Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Kerberos related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecurityConfigKerberosConfig
{
    /// <summary>Immutable. Optional. The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>Immutable. Optional. The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>Immutable. Optional. The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Immutable. Optional. Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1DataprocClusterSpecConfigSecurityConfigKerberosConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Immutable. Optional. The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>Immutable. Optional. The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public long? TgtLifetimeHours { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>Immutable. Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary>Immutable. Optional. Security settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSecurityConfig
{
    /// <summary>Immutable. Optional. Identity related configuration, including service account based secure multi-tenancy user mappings.</summary>
    [JsonPropertyName("identityConfig")]
    public V1beta1DataprocClusterSpecConfigSecurityConfigIdentityConfig? IdentityConfig { get; set; }

    /// <summary>Immutable. Optional. Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta1DataprocClusterSpecConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>Immutable. Optional. The config settings for software inside the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigSoftwareConfig
{
    /// <summary>Immutable. Optional. The version of software inside the cluster. It must be one of the supported [Dataproc Versions](https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#supported_dataproc_versions), such as "1.2" (including a subminor version, such as "1.2.29"), or the ["preview" version](https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#other_versions). If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>Immutable. Optional. The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>Immutable. Optional. The properties to set on daemon config files. Property keys are specified in `prefix:property` format, for example `core:hadoop.tmp.dir`. The following are supported prefixes and their mappings: * capacity-scheduler: `capacity-scheduler.xml` * core: `core-site.xml` * distcp: `distcp-default.xml` * hdfs: `hdfs-site.xml` * hive: `hive-site.xml` * mapred: `mapred-site.xml` * pig: `pig.properties` * spark: `spark-defaults.conf` * yarn: `yarn-site.xml` For more information, see [Cluster properties](https://cloud.google.com/dataproc/docs/concepts/cluster-properties).</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigStagingBucketRef
{
    /// <summary>Optional. A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see [Dataproc staging bucket](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)). **This field requires a Cloud Storage bucket name, not a URI to a Cloud Storage bucket.**  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigTempBucketRef
{
    /// <summary>Optional. A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket. **This field requires a Cloud Storage bucket name, not a URI to a Cloud Storage bucket.**  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigWorkerConfigAccelerators
{
    /// <summary>Immutable. The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public long? AcceleratorCount { get; set; }

    /// <summary>Immutable. Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Immutable. Optional. Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigWorkerConfigDiskConfig
{
    /// <summary>Immutable. Optional. Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public long? BootDiskSizeGb { get; set; }

    /// <summary>Immutable. Optional. Type of the boot disk (default is "pd-standard"). Valid values: "pd-balanced" (Persistent Disk Balanced Solid State Drive), "pd-ssd" (Persistent Disk Solid State Drive), or "pd-standard" (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Immutable. Optional. Interface type of local SSDs (default is "scsi"). Valid values: "scsi" (Small Computer System Interface), "nvme" (Non-Volatile Memory Express). See [local SSD performance](https://cloud.google.com/compute/docs/disks/local-ssd#performance).</summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>Immutable. Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public long? NumLocalSsds { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigWorkerConfigImageRef
{
    /// <summary>Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.  Allowed value: The `selfLink` field of a `ComputeImage` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The Compute Engine config settings for worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfigWorkerConfig
{
    /// <summary>Immutable. Optional. The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1DataprocClusterSpecConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Immutable. Optional. Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta1DataprocClusterSpecConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("imageRef")]
    public V1beta1DataprocClusterSpecConfigWorkerConfigImageRef? ImageRef { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.</summary>
    [JsonPropertyName("numInstances")]
    public long? NumInstances { get; set; }

    /// <summary>Immutable. Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Immutable. The cluster config. Note that Dataproc may set default values, and values may change when clusters are updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecConfig
{
    /// <summary>Immutable. Optional. Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta1DataprocClusterSpecConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>Immutable. Optional. The config for Dataproc metrics.</summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public V1beta1DataprocClusterSpecConfigDataprocMetricConfig? DataprocMetricConfig { get; set; }

    /// <summary>Immutable. Optional. Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1DataprocClusterSpecConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Immutable. Optional. Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta1DataprocClusterSpecConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>Immutable. Optional. The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta1DataprocClusterSpecConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>Immutable. Optional. Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node's `role` metadata to run an executable on a master or worker node, as shown below using `curl` (you can also use `wget`): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if [[ "${ROLE}" == 'Master' ]]; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta1DataprocClusterSpecConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Immutable. Optional. Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta1DataprocClusterSpecConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine config settings for the master instance in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public V1beta1DataprocClusterSpecConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>Immutable. Optional. Metastore configuration.</summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta1DataprocClusterSpecConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta1DataprocClusterSpecConfigSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>Immutable. Optional. Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta1DataprocClusterSpecConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>Immutable. Optional. The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta1DataprocClusterSpecConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("stagingBucketRef")]
    public V1beta1DataprocClusterSpecConfigStagingBucketRef? StagingBucketRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("tempBucketRef")]
    public V1beta1DataprocClusterSpecConfigTempBucketRef? TempBucketRef { get; set; }

    /// <summary>Immutable. Optional. The Compute Engine config settings for worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta1DataprocClusterSpecConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecProjectRef
{
    /// <summary>Required. The Google Cloud Platform project ID that the cluster belongs to.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfigDataprocMetastoreServiceRef
{
    /// <summary>Required. Resource name of an existing Dataproc Metastore service. Example: * `projects/[project_id]/locations/[dataproc_region]/services/[service-name]`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] DataprocMetastoreService not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The Hive Metastore configuration for this workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("dataprocMetastoreServiceRef")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfigDataprocMetastoreServiceRef DataprocMetastoreServiceRef { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>Optional. Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload. Example: * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`  Allowed value: The `selfLink` field of a `DataprocCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }
}

/// <summary>Immutable. Optional. Configuration of auxiliary services used by this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>Immutable. Optional. The Hive Metastore configuration for this workload.</summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>Immutable. Optional. The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigGkeClusterTargetRef
{
    /// <summary>Optional. A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster (the GKE cluster can be zonal or regional). Format: 'projects/{project}/locations/{location}/clusters/{cluster_id}'  Allowed value: The `selfLink` field of a `ContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The autoscaler configuration for this node pool. The autoscaler is enabled only when a valid configuration is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>Immutable. The maximum number of nodes in the node pool. Must be &gt;= min_node_count, and must be &gt; 0. **Note:** Quota must be sufficient to scale up the cluster.</summary>
    [JsonPropertyName("maxNodeCount")]
    public long? MaxNodeCount { get; set; }

    /// <summary>Immutable. The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public long? MinNodeCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfigAccelerators
{
    /// <summary>Immutable. The number of accelerator cards exposed to an instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public long? AcceleratorCount { get; set; }

    /// <summary>Immutable. The accelerator type resource namename (see GPUs on Compute Engine).</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Immutable. Size of partitions to create on the GPU. Valid values are described in the NVIDIA [mig user guide](https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning).</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }
}

/// <summary>Immutable. Optional. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfigEphemeralStorageConfig
{
    /// <summary>Immutable. Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD is 375 GB in size. If zero, it means to disable using local SSDs as ephemeral storage.</summary>
    [JsonPropertyName("localSsdCount")]
    public long? LocalSsdCount { get; set; }
}

/// <summary>Immutable. Optional. The node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>Immutable. Optional. A list of [hardware accelerators](https://cloud.google.com/compute/docs/gpus) to attach to each node.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Immutable. Optional. The [Customer Managed Encryption Key (CMEK)] (https://cloud.google.com/kubernetes-engine/docs/how-to/using-cmek) used to encrypt the boot disk attached to each node in the node pool. Specify the key using the following format: `projects/KEY_PROJECT_ID/locations/LOCATION/keyRings/RING_NAME/cryptoKeys/KEY_NAME`.</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Immutable. Optional. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
    [JsonPropertyName("ephemeralStorageConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfigEphemeralStorageConfig? EphemeralStorageConfig { get; set; }

    /// <summary>Immutable. Optional. The number of local SSD disks to attach to the node, which is limited by the maximum number of disks allowable per zone (see [Adding Local SSDs](https://cloud.google.com/compute/docs/disks/local-ssd)).</summary>
    [JsonPropertyName("localSsdCount")]
    public long? LocalSsdCount { get; set; }

    /// <summary>Immutable. Optional. The name of a Compute Engine [machine type](https://cloud.google.com/compute/docs/machine-types).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. Optional. [Minimum CPU platform](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform) to be used by this instance. The instance may be scheduled on the specified or a newer CPU platform. Specify the friendly names of CPU platforms, such as "Intel Haswell"` or Intel Sandy Bridge".</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Optional. Whether the nodes are created as legacy [preemptible VM instances] (https://cloud.google.com/compute/docs/instances/preemptible). Also see Spot VMs, preemptible VM instances without a maximum lifetime. Legacy and Spot preemptible nodes cannot be used in a node pool with the `CONTROLLER` [role] (/dataproc/docs/reference/rest/v1/projects.regions.clusters#role) or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Immutable. Optional. Whether the nodes are created as [Spot VM instances] (https://cloud.google.com/compute/docs/instances/spot). Spot VMs are the latest update to legacy preemptible VMs. Spot VMs do not have a maximum lifetime. Legacy and Spot preemptible nodes cannot be used in a node pool with the `CONTROLLER` [role](/dataproc/docs/reference/rest/v1/projects.regions.clusters#role) or in the DEFAULT node pool if the CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>Immutable. Input only. The configuration for the GKE node pool. If specified, Dataproc attempts to create a node pool with the specified shape. If one with the same name already exists, it is verified against all specified fields. If a field differs, the virtual cluster creation will fail. If omitted, any node pool with the specified name is used. If a node pool with the specified name does not exist, Dataproc create a node pool with default values. This is an input only field. It will not be returned by the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>Immutable. Optional. The autoscaler configuration for this node pool. The autoscaler is enabled only when a valid configuration is present.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling? Autoscaling { get; set; }

    /// <summary>Immutable. Optional. The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig? Config { get; set; }

    /// <summary>Immutable. Optional. The list of Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) where node pool nodes associated with a Dataproc on GKE virtual cluster will be located. **Note:** All node pools associated with a virtual cluster must be located in the same region as the virtual cluster, and they must be located in the same zone within that region. If a location is not specified during node pool creation, Dataproc on GKE will choose the zone.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolRef
{
    /// <summary>Required. The target GKE node pool. Format: 'projects/{project}/locations/{location}/clusters/{cluster}/nodePools/{node_pool}'  Allowed value: The `selfLink` field of a `ContainerNodePool` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>Immutable. Input only. The configuration for the GKE node pool. If specified, Dataproc attempts to create a node pool with the specified shape. If one with the same name already exists, it is verified against all specified fields. If a field differs, the virtual cluster creation will fail. If omitted, any node pool with the specified name is used. If a node pool with the specified name does not exist, Dataproc create a node pool with default values. This is an input only field. It will not be returned by the API.</summary>
    [JsonPropertyName("nodePoolConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig? NodePoolConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("nodePoolRef")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolRef NodePoolRef { get; set; }

    /// <summary>Immutable. Required. The roles associated with the GKE node pool.</summary>
    [JsonPropertyName("roles")]
    public IList<string> Roles { get; set; }
}

/// <summary>Immutable. Required. The configuration for running the Dataproc cluster on GKE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("gkeClusterTargetRef")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigGkeClusterTargetRef? GkeClusterTargetRef { get; set; }

    /// <summary>Immutable. Optional. GKE node pools where workloads will be scheduled. At least one node pool must be assigned the `DEFAULT` GkeNodePoolTarget.Role. If a `GkeNodePoolTarget` is not specified, Dataproc constructs a `DEFAULT` `GkeNodePoolTarget`. Each role can be given to only one `GkeNodePoolTarget`. All node pools must have the same location settings.</summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}

/// <summary>Immutable. Optional. The software configuration for this Dataproc cluster running on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>Immutable. The components that should be installed in this Dataproc cluster. The key must be a string from the KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.</summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>Immutable. The properties to set on daemon config files. Property keys are specified in `prefix:property` format, for example `spark:spark.kubernetes.container.image`. The following are supported prefixes and their mappings: * spark: `spark-defaults.conf` For more information, see [Cluster properties](https://cloud.google.com/dataproc/docs/concepts/cluster-properties).</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>Immutable. Required. The configuration for running the Dataproc cluster on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>Immutable. Required. The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig GkeClusterConfig { get; set; }

    /// <summary>Immutable. Optional. A namespace within the Kubernetes cluster to deploy into. If this namespace does not exist, it is created. If it exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it. If not specified, the name of the Dataproc Cluster is used.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>Immutable. Optional. The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig? KubernetesSoftwareConfig { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfigStagingBucketRef
{
    /// <summary>Optional. A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see [Dataproc staging and temp buckets](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)). **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The virtual cluster config is used when creating a Dataproc cluster that does not directly control the underlying compute resources, for example, when creating a [Dataproc-on-GKE cluster](https://cloud.google.com/dataproc/docs/guides/dpgke/dataproc-gke). Dataproc may set default values, and values may change when clusters are updated. Exactly one of config or virtual_cluster_config must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpecVirtualClusterConfig
{
    /// <summary>Immutable. Optional. Configuration of auxiliary services used by this cluster.</summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigAuxiliaryServicesConfig? AuxiliaryServicesConfig { get; set; }

    /// <summary>Immutable. Required. The configuration for running the Dataproc cluster on Kubernetes.</summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigKubernetesClusterConfig KubernetesClusterConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("stagingBucketRef")]
    public V1beta1DataprocClusterSpecVirtualClusterConfigStagingBucketRef? StagingBucketRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterSpec
{
    /// <summary>Immutable. The cluster config. Note that Dataproc may set default values, and values may change when clusters are updated.</summary>
    [JsonPropertyName("config")]
    public V1beta1DataprocClusterSpecConfig? Config { get; set; }

    /// <summary>Immutable. The location for the resource, usually a GCP region.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DataprocClusterSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Optional. The virtual cluster config is used when creating a Dataproc cluster that does not directly control the underlying compute resources, for example, when creating a [Dataproc-on-GKE cluster](https://cloud.google.com/dataproc/docs/guides/dpgke/dataproc-gke). Dataproc may set default values, and values may change when clusters are updated. Exactly one of config or virtual_cluster_config must be specified.</summary>
    [JsonPropertyName("virtualClusterConfig")]
    public V1beta1DataprocClusterSpecVirtualClusterConfig? VirtualClusterConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConditions
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
public partial class V1beta1DataprocClusterStatusConfigEndpointConfig
{
    /// <summary>Output only. The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.</summary>
    [JsonPropertyName("httpPorts")]
    public IDictionary<string, string>? HttpPorts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigLifecycleConfig
{
    /// <summary>Output only. The time when cluster became idle (most recent job finished) and became eligible for deletion due to idleness (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("idleStartTime")]
    public string? IdleStartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigMasterConfigInstanceReferences
{
    /// <summary>The unique identifier of the Compute Engine instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

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

/// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigMasterConfigManagedGroupConfig
{
    /// <summary>Output only. The name of the Instance Group Manager for this group.</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The name of the Instance Template used for the Managed Instance Group.</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigMasterConfig
{
    /// <summary>Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. List of references to Compute Engine instances.</summary>
    [JsonPropertyName("instanceReferences")]
    public IList<V1beta1DataprocClusterStatusConfigMasterConfigInstanceReferences>? InstanceReferences { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public V1beta1DataprocClusterStatusConfigMasterConfigManagedGroupConfig? ManagedGroupConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigSecondaryWorkerConfigInstanceReferences
{
    /// <summary>The unique identifier of the Compute Engine instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

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

/// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigSecondaryWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The name of the Instance Group Manager for this group.</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The name of the Instance Template used for the Managed Instance Group.</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigSecondaryWorkerConfig
{
    /// <summary>Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. List of references to Compute Engine instances.</summary>
    [JsonPropertyName("instanceReferences")]
    public IList<V1beta1DataprocClusterStatusConfigSecondaryWorkerConfigInstanceReferences>? InstanceReferences { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public V1beta1DataprocClusterStatusConfigSecondaryWorkerConfigManagedGroupConfig? ManagedGroupConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigWorkerConfigInstanceReferences
{
    /// <summary>The unique identifier of the Compute Engine instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

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

/// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The name of the Instance Group Manager for this group.</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The name of the Instance Template used for the Managed Instance Group.</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfigWorkerConfig
{
    /// <summary>Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. List of references to Compute Engine instances.</summary>
    [JsonPropertyName("instanceReferences")]
    public IList<V1beta1DataprocClusterStatusConfigWorkerConfigInstanceReferences>? InstanceReferences { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public V1beta1DataprocClusterStatusConfigWorkerConfigManagedGroupConfig? ManagedGroupConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusConfig
{
    /// <summary></summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta1DataprocClusterStatusConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta1DataprocClusterStatusConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("masterConfig")]
    public V1beta1DataprocClusterStatusConfigMasterConfig? MasterConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta1DataprocClusterStatusConfigSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerConfig")]
    public V1beta1DataprocClusterStatusConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>Output only. Contains cluster daemon metrics such as HDFS and YARN stats. **Beta Feature**: This report is available for testing purposes only. It may be changed before final release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusMetrics
{
    /// <summary>The HDFS metrics.</summary>
    [JsonPropertyName("hdfsMetrics")]
    public IDictionary<string, string>? HdfsMetrics { get; set; }

    /// <summary>The YARN metrics.</summary>
    [JsonPropertyName("yarnMetrics")]
    public IDictionary<string, string>? YarnMetrics { get; set; }
}

/// <summary>Output only. Cluster status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusStatus
{
    /// <summary>Optional. Output only. Details of cluster's state.</summary>
    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

    /// <summary>Output only. The cluster's state. Possible values: UNKNOWN, CREATING, RUNNING, ERROR, DELETING, UPDATING, STOPPING, STOPPED, STARTING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Time when this state was entered (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }

    /// <summary>Output only. Additional state information that includes status reported by the agent. Possible values: UNSPECIFIED, UNHEALTHY, STALE_STATUS</summary>
    [JsonPropertyName("substate")]
    public string? Substate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatusStatusHistory
{
    /// <summary>Optional. Output only. Details of cluster's state.</summary>
    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

    /// <summary>Output only. The cluster's state. Possible values: UNKNOWN, CREATING, RUNNING, ERROR, DELETING, UPDATING, STOPPING, STOPPED, STARTING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Time when this state was entered (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }

    /// <summary>Output only. Additional state information that includes status reported by the agent. Possible values: UNSPECIFIED, UNHEALTHY, STALE_STATUS</summary>
    [JsonPropertyName("substate")]
    public string? Substate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocClusterStatus
{
    /// <summary>Output only. A cluster UUID (Unique Universal Identifier). Dataproc generates this value when it creates the cluster.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataprocClusterStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("config")]
    public V1beta1DataprocClusterStatusConfig? Config { get; set; }

    /// <summary>Output only. Contains cluster daemon metrics such as HDFS and YARN stats. **Beta Feature**: This report is available for testing purposes only. It may be changed before final release.</summary>
    [JsonPropertyName("metrics")]
    public V1beta1DataprocClusterStatusMetrics? Metrics { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Cluster status.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataprocClusterStatusStatus? Status { get; set; }

    /// <summary>Output only. The previous cluster status.</summary>
    [JsonPropertyName("statusHistory")]
    public IList<V1beta1DataprocClusterStatusStatusHistory>? StatusHistory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataprocCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataprocClusterSpec>, IStatus<V1beta1DataprocClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataprocCluster";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocclusters";
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
    public V1beta1DataprocClusterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DataprocClusterStatus? Status { get; set; }
}